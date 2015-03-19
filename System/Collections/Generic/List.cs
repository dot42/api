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
using System.Collections.ObjectModel;
using System.Linq;
using Dot42;
using Dot42.Collections;
using Java.Lang;
using Java.Util;

namespace System.Collections.Generic
{
	public class List<T> : IList<T>, IList
	{
	    private readonly ArrayList<T> list;

        /// <summary>
        /// Default ctor
        /// </summary>
        public List()
        {
            list = new ArrayList<T>();
        } 

        /// <summary>
        /// Copy ctor
        /// </summary>
        public List(IEnumerable<T> source)
        {
            var colSource = source as Java.Util.ICollection<T>;
            if (colSource != null)
            {
                list = new ArrayList<T>(colSource);
            }
            else
            {
                list = new ArrayList<T>();
                foreach (var item in source)
                {
                    list.Add(item);
                }
            }
        }

        /// <summary>
        /// Copy ctor
        /// </summary>
        public List(IIterable<T> source)
        {
            var colSource = source as Java.Util.ICollection<T>;
            if (colSource != null)
            {
                list = new ArrayList<T>(colSource);
            }
            else
            {
                list = new ArrayList<T>();
                foreach (var item in source.AsEnumerable())
                {
                    list.Add(item);
                }
            }
        } 

        /// <summary>
        /// Initialize a new list with initial capacity
        /// </summary>
        public List(int capacity)
        {
            list = new ArrayList<T>(capacity);
        }

	    /// <summary>
	    /// Gets an enummerator to enumerate over all elements in this sequence.
	    /// </summary>
	    /// <returns></returns>
	    public IEnumerator<T> GetEnumerator()
	    {
	        return new Enumerator<T>(list);
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
	        get { return list.Size(); }
	    }

	    /// <summary>
	    /// Is this collection thread safe.
	    /// </summary>
	    public bool IsSynchronized
	    {
	        get { return false; }
	    }

	    /// <summary>
	    /// Gets the object used to synchronize access to this collection.
	    /// </summary>
	    public object SyncRoot
	    {
	        get { return list; }
	    }

	    /// <summary>
	    /// Copy all my elements to the given array starting at the given index.
	    /// </summary>
	    /// <param name="array">Array to copy my elements into.</param>
	    /// <param name="index">Position in <see cref="array"/> where the first element will be copied to.</param>
	    public void CopyTo(Array array, int index)
	    {
	        Dot42.Collections.Collections.CopyTo(list, array, index);
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
	        get { return list.Get(index); }
	        set { list.Set(index, value); }
	    }

	    /// <summary>
	    /// Gets/sets an item in this list at the given index.
	    /// </summary>
	    object IList.this[int index]
	    {
            get { return list.Get(index); }
            set { list.Set(index, (T) value); }
        }

	    /// <summary>
	    /// Add ths given element to the end of this list.
	    /// </summary>
	    /// <returns>The index at which the element was added or -1 if the element was not added.</returns>
	    public int Add(object element)
	    {
	        var rc = list.Size();
	        list.Add((T) element);
	        return rc;
	    }

	    /// <summary>
	    /// Add the given item to this collection.
	    /// </summary>
	    public void Add(T item)
	    {
	        list.Add(item);
	    }

	    void ICollection<T>.Add(T element)
	    {
            list.Add(element);
        }

        /// <summary>
        /// Adds the elements of the specified collection to the end of this List.
        /// </summary>
        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var element in collection)
            {
                 list.Add(element);
            }
        }

	    /// <summary>
	    /// Is the given element contained in this list?
	    /// </summary>
	    public bool Contains(T element)
	    {
	        return list.Contains(element);
	    }

	    bool ICollection<T>.Remove(T item)
	    {
            return list.Remove((object)item);
	    }

	    /// <summary>
	    /// Removes the first occurrance of the given element from this list.
	    /// </summary>
	    public bool Remove(T element)
	    {
	        return list.Remove((object)element);
	    }

	    public int IndexOf(T element)
	    {
	        return list.IndexOf(element);
	    }

	    public void Insert(int index, T element)
	    {
	        list.Add(index, element);
	    }

	    public void Clear()
	    {
	        list.Clear();
	    }

	    public void CopyTo(T[] array, int index)
	    {
	        Dot42.Collections.Collections.CopyTo(list, array, index);
	    }

	    public bool Contains(object element)
	    {
	        return list.Contains(element);
	    }

	    public int IndexOf(object element)
	    {
            return list.IndexOf(element);
        }

	    public void Insert(int index, object element)
	    {
	        list.Add(index, (T) element);
	    }

	    public void Remove(object element)
	    {
	        list.Remove(element);
	    }

	    public void RemoveAt(int index)
	    {
	        list.Remove(index);
	    }

        public void RemoveAll(Predicate<T> predicate)
        {
            for (int i = list.Count - 1; i >= 0; ++i)
            {
                if (predicate(list.Get(i)))
                    list.Remove(i);
            }
        }

        /// <summary>
        /// Copy all elements into a new array.
        /// </summary>
        public T[] ToArray()
        {
            var result = new T[list.Count];
            return list.ToArray(result);
        }

        public int FindIndex(Predicate<T> predicate)
        {
            for (int i = 0; i < list.Count; ++i)
                if (predicate(list.Get(i)))
                    return i;
            return -1;
        }

        /// <summary>
        /// Return this list as readonly.
        /// </summary>
        /// <returns></returns>
        public ReadOnlyCollection<T> AsReadOnly()
        {
            return new ReadOnlyCollection<T>(this);
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

