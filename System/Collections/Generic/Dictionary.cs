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

using System.Linq;
using Dot42;

namespace System.Collections.Generic
{
    internal interface IDictionaryImpl<TKey, TValue> : IDictionary<TKey, TValue>
    {
        bool ContainsValue(TValue value);

        bool IsSynchronized { get; }
        object SyncRoot { get; }
        void CopyTo(Array array, int index);

    }
    
    // since we want both support the lightweight java-forwarding 
    // and the full c# IComparer<T> functionality, this is a thin 
    // wrapper around two different implementations.
    //
    // Note that this redirection could also be handled at the compiler
    // to remove one level of indirection at runtime.
    public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary, ICollection
    {
        internal readonly IDictionaryImpl<TKey, TValue> dict;
        public IEqualityComparer<TKey> Comparer { get; private set; }
        /// <summary>
        /// Default ctor
        /// </summary>
        public Dictionary()
        {
            dict = new DictionaryImplHashMap<TKey, TValue>();
        }

        /// <summary>
        /// Creates an Dictionary with the given capacity
        /// </summary>
        public Dictionary(int capacity)
        {
            dict = new DictionaryImplHashMap<TKey, TValue>(capacity);
        }


        /// <summary>
        /// Default ctor
        /// </summary>
        public Dictionary(Dictionary<TKey, TValue> source)
        {
            if (source.dict is DictionaryImplHashMap<TKey, TValue>)
            {
                dict = new DictionaryImplHashMap<TKey, TValue>((DictionaryImplHashMap<TKey, TValue>) source.dict);
                return;
            }
            if (source.dict is DictionaryImplHashMapWithComparerWrapper<TKey, TValue>)
            {
                dict = new DictionaryImplHashMapWithComparerWrapper<TKey, TValue>(
                             (DictionaryImplHashMapWithComparerWrapper<TKey, TValue>) source.dict);
                return;
            }
            if (source.Comparer == null || source.Comparer == EqualityComparer<TKey>.Default)
            {
                dict = new DictionaryImplHashMap<TKey, TValue>(source.Count);
            }
            else
            {
                dict = new DictionaryImplHashMapWithComparerWrapper<TKey, TValue>(source.Comparer);
            }

            foreach (var elem in source)
                dict.Add(elem);
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public Dictionary(IEqualityComparer<TKey> comparer)
        {
            Comparer = comparer;

            if (comparer == null || comparer == EqualityComparer<TKey>.Default)
                dict = new DictionaryImplHashMap<TKey, TValue>();
            else
            {
                // have to use the key-wrapping dictionary.
                dict = new DictionaryImplHashMapWithComparerWrapper<TKey, TValue>(comparer);
            }
        }

        
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return dict.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) dict).GetEnumerator();
        }

        public bool ContainsValue(TValue value)
        {
            return dict.ContainsValue(value);
        }

        public int Count
        {
            get { return dict.Count; } }

        public bool IsSynchronized { get { return dict.IsSynchronized; } }
        public object SyncRoot { get { return dict.SyncRoot; } }

        public void CopyTo(Array array, int index)
        {
            dict.CopyTo(array, index);
        }


        public bool IsReadOnly
        {
            get { return dict.IsReadOnly; } 
        }


        public void Add(KeyValuePair<TKey, TValue> item)
        {
            ThrowHelper.ThrowIfArgumentNullException(item, "item");
            ThrowIfKeyExists(item.Key);
            dict.Add(item);
        }

        public void Clear()
        {
            dict.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            ThrowHelper.ThrowIfArgumentNullException(item, "item");
            ThrowHelper.ThrowIfArgumentNullException(item.Key, "item.Key");

            return dict.Contains(item);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            ThrowHelper.ThrowIfArgumentNullException(item, "item");
            ThrowHelper.ThrowIfArgumentNullException(item.Key, "item.Key");

            return dict.Remove(item);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
        {
            dict.CopyTo(array, index);
        }

        public TValue this[TKey key]
        {
            get
            {
                ThrowHelper.ThrowIfArgumentNullException(key, "key");
                return dict[key];
            }
            set
            {
                ThrowHelper.ThrowIfArgumentNullException(key, "key");
                dict[key] = value;
            }
        }


        public bool ContainsKey(TKey key)
        {
            ThrowHelper.ThrowIfArgumentNullException(key, "key");
            return dict.ContainsKey(key);
        }

        public void Add(TKey key, TValue value)
        {
            ThrowHelper.ThrowIfArgumentNullException(key, "key");
            ThrowIfKeyExists(key);

            dict.Add(key, value);
        }

        public bool Remove(TKey key)
        {
            ThrowHelper.ThrowIfArgumentNullException(key, "key");
            return dict.Remove(key);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            ThrowHelper.ThrowIfArgumentNullException(key, "key");
            return dict.TryGetValue(key, out value);
        }

        [Inline]
        private void ThrowIfKeyExists(TKey key)
        {
            if (dict.ContainsKey(key))
                ThrowHelper.ThrowArgumentException("duplicate key: " + key, "key");
        }

        #region IDictionary explicit implementation

        public ICollection<TKey> Keys
        {
            get { return dict.Keys; }
        }

        public ICollection<TValue> Values
        {
            get { return dict.Values; }
        }

        ICollection IDictionary.Values
        {
            get { return ((IDictionary)dict).Values; }
        }

        ICollection IDictionary.Keys
        {
            get { return ((IDictionary)dict).Keys; }
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
             return ((IDictionary)dict).GetEnumerator();
        }

        bool IDictionary.Contains(object key)
        {
            ThrowHelper.ThrowIfArgumentNullException(key, "key");
            if (!(key is TKey)) return false;
            return ContainsKey((TKey)key);
        }

        void IDictionary.Remove(object key)
        {
            ThrowHelper.ThrowIfArgumentNullException(key, "key");
            if (!(key is TKey)) return;
            Remove((TKey)key);
        }

        void IDictionary.Add(object key, object value)
        {
            ThrowHelper.ThrowIfArgumentNullException(key, "key");
            ThrowIfWrongKeyType(key);
            ThrowIfWrongValueType(value);

            Add((TKey)key, (TValue)value);
        }

        bool IDictionary.IsFixedSize { get { return false; } }

        object IDictionary.this[object key]
        {
            get
            {
                ThrowHelper.ThrowIfArgumentNullException(key, "key");
                if (!(key is TKey)) return null;
                TValue val;

                if (!TryGetValue((TKey) key, out val))
                    return null;

                return val;
            }
            set
            {
                ThrowHelper.ThrowIfArgumentNullException(key, "key");
                ThrowIfWrongKeyType(key);
                ThrowIfWrongValueType(value);
                this[(TKey)key] = (TValue)value;
            }
        }

        private void ThrowIfWrongKeyType(object key)
        {
            if (!(key is TKey))
            {
                throw new ArgumentException(string.Format("can not store key type {0} in {1}", key.GetType(), TypeName));
            }
        }
        private void ThrowIfWrongValueType(object value)
        {
            var type = typeof(TValue);
            var isValueType = type.IsValueType;

            if(isValueType && value == null)
                ThrowHelper.ThrowArgumentNullException("value");
            
            if (!isValueType && value == null)
                return;
            if (value != null && !(typeof (TValue).IsAssignableFrom(value.GetType())))
            {
                throw new ArgumentException(string.Format("can not store value type {0} in {1}", value.GetType(), TypeName));
            }
        }

        private string TypeName
        {
            get
            {
                string dictType = string.Format("{0}<{1},{2}>", GetType().FullName, typeof (TKey), typeof (TValue));
                return dictType;
            }
        }

        #endregion 

    }
}

