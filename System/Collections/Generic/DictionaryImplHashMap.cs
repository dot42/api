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
    internal class DictionaryImplHashMap<TKey, TValue> : IDictionaryImpl<TKey, TValue>, IDictionary
    {
        internal readonly HashMap<TKey, TValue> map;

        /// <summary>
        /// Default ctor
        /// </summary>
        public DictionaryImplHashMap()
        {
            map = new HashMap<TKey, TValue>(); 
        }

        /// <summary>
        /// Creates an Dictionary with the given capacity
        /// </summary>
        public DictionaryImplHashMap(int capacity)
        {
            map = new HashMap<TKey, TValue>(capacity); 
        }


        /// <summary>
        /// Default ctor
        /// </summary>
        public DictionaryImplHashMap(DictionaryImplHashMap<TKey, TValue> source)
        {
            map = new HashMap<TKey, TValue>(source.map);
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public DictionaryImplHashMap(IEqualityComparer<TKey> comparer)
        {
            throw new NotImplementedException("System.Collections.Generic.Dictionary<,>.ctor(IEqualityComparer<TKey> comparer)");
        }

        /// <summary>
        /// Gets the number of elements
        /// </summary>
        public int Count { get { return map.Size(); } }

        public bool IsSynchronized { get { return false; } }
        public object SyncRoot { get { return map; } }

        public void CopyTo(Array array, int index)
        {
            Dot42.Collections.Collections.CopyTo(this, array, index);
        }
        
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
                if (map.ContainsKey(key))
                    return map.Get(key);
                throw new KeyNotFoundException();
            }
            set { map.Put(key, value); }
        }

        /// <summary>
        /// Add the given key and value to the dictionary.
        /// </summary>
        public void Add(TKey key, TValue value)
        {
            map.Put(key, value);
        }

        bool IDictionary<TKey, TValue>.Remove(TKey key)
        {
            bool ret = map.ContainsKey(key);
            Remove(key);
            return ret;
        }

        /// <summary>
        /// Removes the given key from the dictionary.
        /// </summary>
        public void Remove(TKey key)
        {
            map.Remove(key);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            map.Put(item.Key, item.Value);
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
            Dot42.Collections.Collections.CopyTo(this, array, index);
       }

        ICollection<TValue> IDictionary<TKey, TValue>.Values
        {
            get { return Values; } }

        /// <summary>
        /// Does this dictionary contain an element with given key?
        /// </summary>
        public bool ContainsKey(TKey key)
        {
            return map.ContainsKey(key);
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
            value = map.Get(key);
            return value != null || map.ContainsKey(key);
        }

        /// <summary>
        /// Gets the comparer used to compare keys.
        /// </summary>
        public IEqualityComparer<TKey> Comparer
        {
            get { throw new NotImplementedException("System.Collections.Generic.Dictionary<,>.Comparer"); }
        }

        /// <summary>
        /// Gets an enummerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var entry in new IterableWrapper<IMap_IEntry<TKey, TValue>>(map.EntrySet()))
            {
                yield return new KeyValuePair<TKey, TValue>(entry.Key, entry.Value);
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

        object IDictionary.this[object key] { get { return map.Get(key); } set { this[(TKey)key] = (TValue)value; } }


        ICollection IDictionary.Keys { get { return Keys; } }
        ICollection IDictionary.Values { get { return Values; } }

        void IDictionary.Remove(object key)
        {
            map.Remove(key);
        }
        #endregion

        /// <summary>
        /// Gets the keys of the collection.
        /// </summary>
        public KeyCollection Keys
        {
            get { return new KeyCollection(this); }
        }

        ICollection<TKey> IDictionary<TKey, TValue>.Keys
        {
            get { return Keys; } }

        /// <summary>
        /// Gets the values of the collection.
        /// </summary>
        public ValueCollection Values
        {
            get { return new ValueCollection(this); }
        }

        public sealed class KeyCollection: ICollection<TKey>, ICollection, IJavaCollectionWrapper<TKey>
        {
            private readonly Java.Util.ICollection<TKey> keys;

            /// <summary>
            /// Default ctor
            /// </summary>
            public KeyCollection(DictionaryImplHashMap<TKey, TValue> dictionary)
            {
                keys = dictionary.map.KeySet();
            }

            /// <summary>
            /// Gets an enummerator to enumerate over all elements in this sequence.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<TKey> GetEnumerator()
            {
                return new IteratorWrapper<TKey>(keys);
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
                keys.Add(item);
            }

            public void Clear()
            {
                keys.Clear();
            }

            public bool Contains(TKey item)
            {
                return keys.Contains(item);
            }

            public bool Remove(TKey item)
            {
                return keys.Remove(item);
            }

            public void CopyTo(TKey[] array, int index)
            {
                Dot42.Collections.Collections.CopyTo(keys, array, index);
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
                Dot42.Collections.Collections.CopyTo(keys, array, index);
            }

            public Java.Util.ICollection<TKey> Collection { get { return keys; } }
        }

        public sealed class ValueCollection : ICollection<TValue>, ICollection, IJavaCollectionWrapper<TValue>
        {
            private readonly Java.Util.ICollection<TValue> values;

            /// <summary>
            /// Default ctor
            /// </summary>
            public ValueCollection(DictionaryImplHashMap<TKey, TValue> dictionary)
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
                Dot42.Collections.Collections.CopyTo(values, array, index);
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
                Dot42.Collections.Collections.CopyTo(values, array, index);
            }

            public Java.Util.ICollection<TValue> Collection { get { return values; } }
        }

        internal class HashMapIterator : IteratorWrapperWithSelector<IMap_IEntry<TKey, TValue>, DictionaryEntry>, IDictionaryEnumerator
        {
            public HashMapIterator(IIterable<IMap_IEntry<TKey, TValue>> iterator)
                : base(iterator, Transform)
            {

            }

            private static DictionaryEntry Transform(IMap_IEntry<TKey, TValue> obj)
            {
                return new DictionaryEntry(obj.Key, obj.Value);
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
        }
    }
}

