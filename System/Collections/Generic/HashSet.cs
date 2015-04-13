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

using Dot42.Collections;
using Java.Lang;

namespace System.Collections.Generic
{
	public class HashSet<T> : ICollection<T>, ISet<T>, ICollection, IJavaCollectionWrapper<T>
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
            if(comparer != null && comparer != EqualityComparer<T>.Default)
                throw new NotImplementedException("comparer not supported");

            hset = new Java.Util.HashSet<T>();
        }

        ///// <summary>
        ///// Default ctor
        ///// </summary>
        public HashSet(IEnumerable<T> source, IEqualityComparer<T> comparer)
        {
            if (comparer != null && comparer != EqualityComparer<T>.Default)
                throw new NotImplementedException("comparer not supported");

            var wrap = source as IJavaCollectionWrapper<T>;
            if (wrap != null)
                hset = new Java.Util.HashSet<T>(wrap.Collection);
            else
            {
                hset = new Java.Util.HashSet<T>();
                foreach (var item in source)
                    hset.Add(item);
            }
        }

	    public int Count { get { return hset.Size(); } }
	    public bool IsSynchronized { get { return false; } }
	    public object SyncRoot { get { return hset; } }
	    public void CopyTo(Array array, int index)
	    {
            Dot42.Collections.Collections.CopyTo(hset, array, index);
	    }

	    public bool IsReadOnly { get; private set; }

	    /// <summary>
        /// Add the given item to this set.
        /// </summary>
        public bool Add(T item)
        {
            return hset.Add(item);
        }

	    void ICollection<T>.Add(T item)
	    {
	        Add(item);
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

	    public void CopyTo(T[] array, int index)
	    {
            Dot42.Collections.Collections.CopyTo(hset, array, index);
	    }

        public void UnionWith(IEnumerable<T> other)
        {
            var wrap = other as IJavaCollectionWrapper<T>;
            if (wrap != null)
                hset.AddAll(wrap.Collection);
            else
                foreach (var e in other)
                    hset.Add(e);
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            var wrap = other as IJavaCollectionWrapper<T>;
            if (wrap != null)
                hset.RetainAll((Java.Util.ICollection<object>)wrap.Collection);
            else
            {
                var remove = new Java.Util.HashSet<T>(hset);
                foreach (var e in other)
                    remove.Remove(e);
                hset.RemoveAll((Java.Util.ICollection<object>)remove);
            }
        }

	    public IEnumerator<T> GetEnumerator()
	    {
	        return new Enumerator<T>(hset);
	    }

	    IEnumerator IEnumerable.GetEnumerator()
	    {
	        return GetEnumerator();
	    }

        public class Enumerator<T> : IteratorWrapper<T>
        {
            public Enumerator(IIterable<T> iterable)
                : base(iterable)
            {
            }
        }

        Java.Util.ICollection<T> IJavaCollectionWrapper<T>.Collection { get { return hset; } }
	}
}

