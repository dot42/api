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
using Java.Io;

namespace System.Collections.Generic
{
    internal interface IDictionaryImpl<TKey, TValue> : IDictionary<TKey, TValue>
    {
        bool ContainsValue(TValue value);
    }


    // since we want both support the lightweight java-forwarding 
    // and the full c# compatibility, this is a thin proxy around
    // both types, depending on the called constructor.
    public class Dictionary<TKey, TValue> : IDictionary<TKey,TValue>
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
                dict = new DictionaryImplHashMap<TKey, TValue>((DictionaryImplHashMap<TKey, TValue>)source.dict);
            dict = new DictionaryImplCSharp<TKey, TValue>(source.dict, source.Comparer);
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public Dictionary(IEqualityComparer<TKey> comparer)
        {
            Comparer = comparer;

            if (comparer == null)
                dict = new DictionaryImplHashMap<TKey, TValue>();
            if(comparer == EqualityComparer<TKey>.Default)
                dict = new DictionaryImplHashMap<TKey, TValue>();

            // have to use the CSharp-Dictionary.
            dict = new DictionaryImplCSharp<TKey, TValue>();
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

        public bool IsReadOnly
        {
            get { return dict.IsReadOnly; } }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            dict.Add(item);
        }

        public void Clear()
        {
            dict.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return dict.Contains(item);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return dict.Remove(item);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
        {
            dict.CopyTo(array, index);
        }

        public TValue this[TKey key] { get { return dict[key]; } set { dict[key] = value; } }

        public ICollection<TKey> Keys
        {
            get { return dict.Keys; } }

        public ICollection<TValue> Values
        {
            get { return dict.Values; } }

        public bool ContainsKey(TKey key)
        {
            return dict.ContainsKey(key);
        }

        public void Add(TKey key, TValue value)
        {
            dict.Add(key, value);
        }

        public bool Remove(TKey key)
        {
            return dict.Remove(key);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return dict.TryGetValue(key, out value);
        }
    }
}

