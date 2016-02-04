// Copyright (C) 2014 dot42
//
// Original filename: SortedList.cs
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
using Dot42;
using Dot42.Collections;
using Java.Util;

namespace System.Collections
{
    public class SortedList : IEnumerable
    {
        internal readonly ISortedMap<object, object> map;

        /// <summary>
        /// Default ctor
        /// </summary>
        public SortedList()
        {
            map = new TreeMap<object, object>();
        }

        /// <summary>
        /// Gets the number of elements
        /// </summary>
        public int Count
        {
            get { return map.Size(); }
        }

        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object this[object key]
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
        /// Gets the value at the specified index of a SortedList object.
        /// </summary>
        public object GetByIndex(int index)
        {
            var objects = map.Values().ToArray();
            if (index < 0 || index >= objects.Length) throw new ArgumentOutOfRangeException("index");
            return objects[index];
        }

        /// <summary>
        /// Add the given key and value to the sorted list.
        /// </summary>
        public void Add(object key, object value)
        {
            map.Put(key, value);
        }

        /// <summary>
        /// Removes the given key from the sorted list.
        /// </summary>
        public void Remove(object key)
        {
            map.Remove(key);
        }

        /// <summary>
        /// Remove all entries
        /// </summary>
        public void Clear()
        {
            map.Clear();
        }

        /// <summary>
        /// Does this sorted list contain an element with given key?
        /// </summary>
        public bool ContainsKey(object key)
        {
            return map.ContainsKey(key);
        }

        /// <summary>
        /// Does this sorted list contain an element with given key?
        /// </summary>
        public bool ContainsValue(object value)
        {
            return map.ContainsValue(value);
        }

        /// <summary>
        /// Try to get a value from this dictionary.
        /// </summary>
        public bool TryGetValue(object key, out object value)
        {
            if (map.ContainsKey(key))
            {
                value = map.Get(key);
                return true;
            }
            value = null;
            return false;
        }

        /// <summary>
        /// Gets the comparer used to compare keys.
        /// </summary>
        public IEqualityComparer Comparer
        {
            get { throw new NotImplementedException("System.Collections.SortedList.Comparer"); }
        }

        /// <summary>
        /// Gets an enummerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            foreach (var entry in new IterableWrapper<IMap_IEntry<object, object>>(map.EntrySet()))
            {
                yield return new KeyValuePair<object, object>(entry.Key, entry.Value);
            }
        }

        /// <summary>
        /// Gets the values of the collection.
        /// </summary>
        public IEnumerable Keys
        {
            get { return new JavaCollection(map.KeySet()); }
        }

        /// <summary>
        /// Gets the values of the collection.
        /// </summary>
        public IEnumerable Values
        {
            get { return new JavaCollection(map.Values()); }
        }

        public sealed class JavaCollection : IEnumerable
        {
            private readonly Java.Util.ICollection<object> values;

            /// <summary>
            /// Default ctor
            /// </summary>
            public JavaCollection(Java.Util.ICollection<object> values)
            {
                this.values = values;
            }

            /// <summary>
            /// Gets an enummerator to enumerate over all elements in this sequence.
            /// </summary>
            /// <returns></returns>
            public IEnumerator GetEnumerator()
            {
                return new IteratorWrapper<object>(values);
            }
        }
    }
}

