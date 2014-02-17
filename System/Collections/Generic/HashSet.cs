// Copyright (C) 2014 dot42
//
// Original filename: HashSet.cs
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
namespace System.Collections.Generic
{
	public class HashSet<T>
	{
	    private readonly Java.Util.HashSet<T> hset;

        /// <summary>
        /// Default ctor
        /// </summary>
        public HashSet()
        {
            hset = new Java.Util.HashSet<T>();
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public HashSet(IEnumerable<T> source)
        {
            hset = new Java.Util.HashSet<T>();
            foreach (var item in source)
            {
                hset.Add(item);
            }
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public HashSet(IEqualityComparer<T> comparer)
        {
            hset = new Java.Util.HashSet<T>();
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public HashSet(IEnumerable<T> source, IEqualityComparer<T> comparer)
        {
            hset = new Java.Util.HashSet<T>();
            foreach (var item in source)
            {
                hset.Add(item);
            }
        }

        /// <summary>
        /// Add the given item to this set.
        /// </summary>
        public bool Add(T item)
        {
            return hset.Add(item);
        }

        /// <summary>
        /// Remove all items
        /// </summary>
        public void Clear()
        {
            hset.Clear();
        }

        /// <summary>
        /// Does this set contain the given item?
        /// </summary>
        public bool Contains(T item)
        {
            return hset.Contains(item);
        }

        /// <summary>
        /// Remove the given item from this set.
        /// </summary>
        public bool Remove(T item)
        {
            return hset.Remove(item);
        }

	}
}

