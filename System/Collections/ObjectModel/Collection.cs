// Copyright (C) 2014 dot42
//
// Original filename: List.cs
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
using Java.Lang;

namespace System.Collections.ObjectModel
{
	public class Collection<T> : ICollection<T>, IEnumerable<T>, IList<T>, IList, ICollection, IEnumerable
	{
	    private readonly List<T> list;

        protected IList<T> Items { get { return list; } }


        /// <summary>
        /// Default ctor
        /// </summary>
        public Collection()
        {
            list = new List<T>();
        } 

        /// <summary>
        /// Copy ctor
        /// </summary>
        public Collection(IEnumerable<T> source)
        {
            list = new List<T>(source);
        }

        /// <summary>
        /// Copy ctor
        /// </summary>
        public Collection(IIterable<T> source)
        {
            list = new List<T>(source);
        }

	    protected virtual void ClearItems()
	    {
	        list.Clear();
	    }

	    protected virtual void InsertItem(int index, T item)
	    {
	        list.Insert(index, item);
	    }

	    protected virtual void RemoveItem(int index)
	    {
	        list.RemoveAt(index);
	    }

	    protected virtual void SetItem(int index, T item)
	    {
	        list[index] = item;
	    }


        /// <summary>
        /// Initialize a new list with initial capacity
        /// </summary>
        public Collection(int capacity)
        {
            list = new List<T>(capacity);
        }

	    /// <summary>
	    /// Gets an enummerator to enumerate over all elements in this sequence.
	    /// </summary>
	    /// <returns></returns>
	    public IEnumerator<T> GetEnumerator()
	    {
	        return list.GetEnumerator();
	    }

        /// <summary>
        /// Gets an enummerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
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
	    /// Gets number of elements in this collection.
	    /// </summary>
	    public int Count
	    {
	        get { return list.Count; }
	    }

	    /// <summary>
	    /// Is this collection thread safe.
	    /// </summary>
	    public bool IsSynchronized
	    {
	        get { return list.IsSynchronized; }
	    }

	    /// <summary>
	    /// Gets the object used to synchronize access to this collection.
	    /// </summary>
	    public object SyncRoot
	    {
	        get { return list.SyncRoot; }
	    }

	    /// <summary>
	    /// Copy all my elements to the given array starting at the given index.
	    /// </summary>
	    /// <param name="array">Array to copy my elements into.</param>
	    /// <param name="index">Position in <see cref="array"/> where the first element will be copied to.</param>
	    public void CopyTo(Array array, int index)
	    {
            list.CopyTo(array, index);
	    }

	    /// <summary>
	    /// Does this list have a fixed size?
	    /// </summary>
	    public bool IsFixedSize
	    {
	        get { return false; }
	    }

	    /// <summary>
	    /// Is this list read-only.
	    /// </summary>
	    public bool IsReadOnly
	    {
	        get { return false; }
	    }

        /// <summary>
        /// Gets/sets an item in this list at the given index.
        /// </summary>
        public T this[int index]
        {
            get { return list[index]; }
            set { SetItem(index, value); }
        }

	    /// <summary>
	    /// Add the given item to this collection.
	    /// </summary>
	    public void Add(T item)
	    {
            InsertItem(list.Count, item);
	    }

	    /// <summary>
        /// Adds the elements of the specified collection to the end of this List.
        /// </summary>
        public void AddRange(IEnumerable<T> collection)
	    {
            foreach(var element in collection)
                InsertItem(list.Count, element);
	    }

	    /// <summary>
	    /// Is the given element contained in this list?
	    /// </summary>
	    public bool Contains(T element)
	    {
	        return list.Contains(element);
	    }

	    /// <summary>
	    /// Removes the first occurrance of the given element from this list.
	    /// </summary>
	    public bool Remove(T element)
	    {
	        int idx = IndexOf(element);
	        if (idx == -1) return false;
	        RemoveItem(idx);
	        return true;
	    }

        public int IndexOf(T element)
	    {
	        return list.IndexOf(element);
	    }

        public void RemoveAt(int index)
        {
            RemoveItem(index);
        }

	    public void Insert(int index, T element)
	    {
            InsertItem(index, element);
	    }

	    public void Clear()
	    {
            ClearItems();
	    }

	    public void CopyTo(T[] array, int index)
	    {
            list.CopyTo(array, index);
	    }

        /// <summary>
        /// Gets/sets an item in this list at the given index.
        /// </summary>
        object IList.this[int index]
        {
            get { return list[index]; }
            set { SetItem(index, (T)value); }
        }

        /// <summary>
        /// Add ths given element to the end of this list.
        /// </summary>
        /// <returns>The index at which the element was added or -1 if the element was not added.</returns>
        int IList.Add(object element)
        {
            int idx = list.Count;
            InsertItem(idx, (T)element);
            return idx;
        }

        bool IList.Contains(object element)
	    {
	        return list.Contains((T)element);
	    }

        int IList.IndexOf(object element)
	    {
            return list.IndexOf((T)element);
        }

        void IList.Insert(int index, object element)
	    {
            InsertItem(index, (T)element);
	    }

	    void IList.Remove(object element)
	    {
	        Remove((T) element);
	    }
       
        public class Enumerator<T> : IteratorWrapper<T>
        {
            public Enumerator(IIterable<T> iterable)
                : base(iterable)
            {
            }
        }
	}
}

