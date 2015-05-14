// Copyright (C) 2014 dot42
//
// Original filename: Dictionary.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Dot42.Collections;
using Java.Lang;
using Java.Util;

namespace System.Collections.Generic
{
    // TODO: find a shorter name
    internal class DictionaryImplHashMapWithComparerWrapper<TKey, TValue> : IDictionaryImpl<TKey, TValue>, IDictionary
    {
        internal readonly HashMap<KeyWrapper<TKey>, TValue> map;
        private readonly IEqualityComparer<TKey> comparer;
        
        /// <summary>
        /// Default ctor
        /// </summary>
        public DictionaryImplHashMapWithComparerWrapper(DictionaryImplHashMapWithComparerWrapper<TKey, TValue> source)
        {
            map = new HashMap<KeyWrapper<TKey>, TValue>(source.map);
            comparer = source.Comparer;
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public DictionaryImplHashMapWithComparerWrapper(IEqualityComparer<TKey> comparer)
        {
            map = new HashMap<KeyWrapper<TKey>, TValue>();
            this.comparer = comparer;
        }

        /// <summary>
        /// Gets the number of elements
        /// </summary>
        public int Count { get { return map.Size(); } }

        public bool IsReadOnly { get; private set; }

        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public TValue this[TKey key]
        {
            get
            {
                TValue ret;
                if(!TryGetValue(key, out ret))
                    throw new KeyNotFoundException();
                return ret;
            }
            set
            {
                var w = new KeyWrapper<TKey>(key, comparer);
                map.Put(w, value);
            }
        }

        /// <summary>
        /// Add the given key and value to the dictionary.
        /// </summary>
        public void Add(TKey key, TValue value)
        {
            var w = new KeyWrapper<TKey>(key, comparer);
            map.Put(w, value);
        }

        bool IDictionary<TKey, TValue>.Remove(TKey key)
        {
            var w = new KeyWrapper<TKey>(key, comparer);
            bool ret = map.ContainsKey(w);
            map.Remove(w);
            return ret;
        }

        /// <summary>
        /// Removes the given key from the dictionary.
        /// </summary>
        public void Remove(TKey key)
        {
            var w = new KeyWrapper<TKey>(key, comparer);
            map.Remove(w);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            var w = new KeyWrapper<TKey>(item.Key, comparer);
            map.Put(w, item.Value);
        }

        /// <summary>
        /// Remove all entries
        /// </summary>
        public void Clear()
        {
            map.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            TValue current;
            if (!TryGetValue(item.Key, out current))
                return false;
            return Equals(current, item.Value);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            if (!Contains(item))
                return false;
            Remove(item.Key);
            return true;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
        {
            throw new NotImplementedException("System.Collections.Generic.Dictionary<,>.CopyTo");
        }
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException("System.Collections.Generic.Dictionary<,>.CopyTo");
        }

        public bool IsSynchronized { get { return false; } }
        public object SyncRoot { get { return map; } }

        ICollection<TValue> IDictionary<TKey, TValue>.Values
        {
            get { return Values; }
        }

        /// <summary>
        /// Does this dictionary contain an element with given key?
        /// </summary>
        public bool ContainsKey(TKey key)
        {
            var w = new KeyWrapper<TKey>(key, comparer);
            return map.ContainsKey(w);
        }

        /// <summary>
        /// Does this dictionary contain an element with given key?
        /// </summary>
        public bool ContainsValue(TValue value)
        {
            return map.ContainsValue(value);
        }

        /// <summary>
        /// Try to get a value from this dictionary.
        /// </summary>
        public bool TryGetValue(TKey key, out TValue value)
        {
            var w = new KeyWrapper<TKey>(key, comparer);
         
            value = map.Get(w);
            return value != null || map.ContainsKey(w);
        }

        /// <summary>
        /// Gets the comparer used to compare keys.
        /// </summary>
        public IEqualityComparer<TKey> Comparer
        {
            get { return comparer; }
        }

        /// <summary>
        /// Gets an enummerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            var enumerable = new IterableWrapper<IMap_IEntry<KeyWrapper<TKey>, TValue>>(map.EntrySet());
            foreach (var entry in enumerable)
            {
                yield return new KeyValuePair<TKey, TValue>(entry.Key.Key, entry.Value);
            }
        }

        /// <summary>
        /// Gets an enummerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Gets the keys of the collection.
        /// </summary>
        public KeyCollection Keys
        {
            get { return new KeyCollection(this); }
        }

        ICollection<TKey> IDictionary<TKey, TValue>.Keys
        {
            get { return Keys; }
        }

        /// <summary>
        /// Gets the values of the collection.
        /// </summary>
        public ValueCollection Values
        {
            get { return new ValueCollection(this); }
        }

        #region IDictionary implementation

        bool IDictionary.IsFixedSize { get { return false; } }

        bool IDictionary.Contains(object key)
        {
            return map.ContainsKey(key);
        }

        void IDictionary.Add(object key, object value)
        {
            Add((TKey)key, (TValue)value);
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            return new HashMapIterator(map.EntrySet());
        }

        object IDictionary.this[object key] { get { return map.Get(key); } set { this[(TKey) key] = (TValue) value; } }


        ICollection IDictionary.Keys { get { return Keys; } }
        ICollection IDictionary.Values { get { return Values; } }

        void IDictionary.Remove(object key)
        {
            map.Remove(key);
        }

        #endregion

        public sealed class KeyCollection : ICollection<TKey>, ICollection
        {
            
            private readonly Java.Util.ICollection<KeyWrapper<TKey>> keys;
            private IEqualityComparer<TKey> comparer;

            /// <summary>
            /// Default ctor
            /// </summary>
            public KeyCollection(DictionaryImplHashMapWithComparerWrapper<TKey, TValue> dictionary)
            {
                comparer = dictionary.Comparer;
                keys = dictionary.map.KeySet();
            }

            /// <summary>
            /// Gets an enummerator to enumerate over all elements in this sequence.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<TKey> GetEnumerator()
            {
                return new IteratorWrapperWithSelector<KeyWrapper<TKey>,TKey>(keys, k=>k.Key);
            }

            /// <summary>
            /// Gets an enummerator to enumerate over all elements in this sequence.
            /// </summary>
            /// <returns></returns>
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public int Count
            {
                get { return keys.Size(); }
            }

            public bool IsReadOnly
            {
                get { return true; }
            }

            public void Add(TKey item)
            {
                keys.Add(new KeyWrapper<TKey>(item, comparer));
            }

            public void Clear()
            {
                keys.Clear();
            }

            public bool Contains(TKey item)
            {
                return keys.Contains(new KeyWrapper<TKey>(item, comparer));
            }

            public bool Remove(TKey item)
            {
                return keys.Remove(new KeyWrapper<TKey>(item, comparer));
            }

            public void CopyTo(TKey[] array, int index)
            {
                var i = 0;
                foreach (var key in this)
                {
                    array[index + i++] = key;
                }
            }


            public bool IsSynchronized
            {
                get { return false; }
            }

            public object SyncRoot
            {
                get { throw new NotImplementedException("System.Collections.Generic.Dictionary<,>KeyCollection.SyncRoot"); }
            }

            public void CopyTo(Array array, int index)
            {
                throw new NotImplementedException("System.Collections.Generic.Dictionary<,>.KeyCollection.CopyTo");
            }
        }

        public sealed class ValueCollection : ICollection<TValue>, ICollection
        {
            private readonly Java.Util.ICollection<TValue> values;

            /// <summary>
            /// Default ctor
            /// </summary>
            public ValueCollection(DictionaryImplHashMapWithComparerWrapper<TKey, TValue> dictionary)
            {
                values = dictionary.map.Values();
            }

            /// <summary>
            /// Gets an enummerator to enumerate over all elements in this sequence.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<TValue> GetEnumerator()
            {
                return new IteratorWrapper<TValue>(values);
            }

            /// <summary>
            /// Gets an enummerator to enumerate over all elements in this sequence.
            /// </summary>
            /// <returns></returns>
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public int Count
            {
                get { return values.Size(); }
            }

            public bool IsReadOnly
            {
                get { return true; }
            }

            public void Add(TValue item)
            {
                values.Add(item);
            }

            public void Clear()
            {
                values.Clear();
            }

            public bool Contains(TValue item)
            {
                return values.Contains(item);
            }

            public bool Remove(TValue item)
            {
                return values.Remove(item);
            }

            public void CopyTo(TValue[] array, int index)
            {
                throw new NotImplementedException("System.Collections.Generic.Dictionary<,>.ValueCollection.CopyTo");
            }


            public bool IsSynchronized
            {
                get { return false; }
            }

            public object SyncRoot
            {
                get { throw new NotImplementedException("System.Collections.Generic.Dictionary<,>.ValueCollection.SyncRoot"); }
            }

            public void CopyTo(Array array, int index)
            {
                throw new NotImplementedException("System.Collections.Generic.Dictionary<,>.ValueCollection.CopyTo");
            }
        }

        internal class HashMapIterator: IteratorWrapperWithSelector<IMap_IEntry<KeyWrapper<TKey>, TValue>, DictionaryEntry>, IDictionaryEnumerator
        {
            public HashMapIterator(IIterable<IMap_IEntry<KeyWrapper<TKey>, TValue>> iterator)
                : base(iterator, Transform)
            {

            }

            public DictionaryEntry Entry
            {
                get { return base.Current; }
            }

            public object Key
            {
                get { return base.Current.Key; }
            }
            public object Value
            {
                get { return base.Current.Value; }
            }

            private static DictionaryEntry Transform(IMap_IEntry<KeyWrapper<TKey>, TValue> obj)
            {
                return new DictionaryEntry(obj.Key.Key, obj.Value);
            }
        }

        internal class KeyWrapper<T>
        {
            internal readonly T Key;
            private readonly IEqualityComparer<T> _comparer;

            public KeyWrapper(T key, IEqualityComparer<T> comparer)
            {
                Key = key;
                _comparer = comparer;
            }

            public override bool Equals(object @object)
            {
                if (ReferenceEquals(@object, null)) return false;
                return _comparer.Equals(Key, ((KeyWrapper<T>)@object).Key);
            }

            public override int GetHashCode()
            {
                return _comparer.GetHashCode(Key);
            }
        }
    }
}

