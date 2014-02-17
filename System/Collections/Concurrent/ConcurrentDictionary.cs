// Copyright (C) 2014 dot42
//
// Original filename: ConcurrentDictionary.cs
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
using System.Collections.Generic;
using Dot42.Collections;
using Java.Util;
using Java.Util.Concurrent;

namespace System.Collections.Concurrent
{
    public class ConcurrentDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        internal readonly ConcurrentHashMap<TKey, TValue> map;

        /// <summary>
        /// Default ctor
        /// </summary>
        public ConcurrentDictionary()
        {
            map = new ConcurrentHashMap<TKey, TValue>(); 
        }

        /// <summary>
        /// Creates an Dictionary with the given capacity
        /// </summary>
        public ConcurrentDictionary(int capacity)
        {
            map = new ConcurrentHashMap<TKey, TValue>(capacity); 
        }


        /// <summary>
        /// Default ctor
        /// </summary>
        public ConcurrentDictionary(Java.Util.IMap<TKey, TValue> source)
        {
            map = new ConcurrentHashMap<TKey, TValue>(source);
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public ConcurrentDictionary(IEqualityComparer<TKey> comparer)
        {
            map = new ConcurrentHashMap<TKey, TValue>();
        }

        /// <summary>
        /// Gets the number of elements
        /// </summary>
        public int Count { get { return map.Size(); } }

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
        public bool TryAdd(TKey key, TValue value)
        {
            if (map.ContainsKey(key)) return false;
            map.Put(key, value);
            return true;
        }

        /// <summary>
        /// Removes the given key from the dictionary.
        /// </summary>
        public bool TryRemove(TKey key, out TValue value)
        {
            if (map.ContainsKey(key))
            {
                value = map.Remove(key);
                return true;

            }

            value = default(TValue);
            return false;
        }

        /// <summary>
        /// Remove all entries
        /// </summary>
        public void Clear()
        {
            map.Clear();
        }

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
            if (map.ContainsKey(key))
            {
                value = map.Get(key);
                return true;
            }
            value = default(TValue);
            return false;
        }

        /// <summary>
        /// Gets the comparer used to compare keys.
        /// </summary>
        public IEqualityComparer<TKey> Comparer
        {
            get { throw new NotImplementedException("System.Collections.Concurrent.ConcurrentDictionary.Comparer"); }
        }

        /// <summary>
        /// Gets an enummerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var entry in new IterableWrapper<IMap_IEntry<TKey, TValue>>(map.EntrySet()))
            {
                yield return new KeyValuePair<TKey, TValue>(entry.GetKey(), entry.GetValue());
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

        /*
        /// <summary>
        /// Gets the keys of the collection.
        /// </summary>
        public ICollection<TKey> Keys
        {
            get { return new KeyCollection(this); }
        }

        /// <summary>
        /// Gets the values of the collection.
        /// </summary>
        public ICollection<TValue> Values
        {
            get { return new ValueCollection(this); }
        }

        public sealed class KeyCollection : Java.Util.ICollection<TKey>
        {
            private readonly Java.Util.ICollection<TKey> keys;

            /// <summary>
            /// Default ctor
            /// </summary>
            public KeyCollection(Java.Util.Dictionary<TKey, TValue> dictionary)
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
                var i = 0;
                foreach (var key in this)
                {
                    array[index + i++] = key;
                }
            }


            public bool IsSynchronized
            {
                get { return true; }
            }

            public object SyncRoot
            {
                get { throw new NotImplementedException(); }
            }

            public void CopyTo(Array array, int index)
            {
                throw new NotImplementedException();
            }
        }

        public sealed class ValueCollection : Java.Util.ICollection<TValue>
        {
            private readonly Java.Util.ICollection<TValue> values;

            /// <summary>
            /// Default ctor
            /// </summary>
            public ValueCollection(Java.Util.Dictionary<TKey, TValue> dictionary)
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
                throw new NotImplementedException();
            }


            public bool IsSynchronized
            {
                get { return false; }
            }

            public object SyncRoot
            {
                get { throw new NotImplementedException(); }
            }

            public void CopyTo(Array array, int index)
            {
                throw new NotImplementedException();
            }
        }
        */
    }
}

