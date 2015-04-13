// Copyright (C) 2014 dot42
//
// Original filename: JavaSetWrapper.cs
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
using System;
using System.Collections;
using System.Collections.Generic;
using Java.Util;

namespace Dot42.Collections
{
    /// <summary>
    /// Wraps <see cref="Java.Util.ISet{T}"/> such that is can be used as <see cref="System.Collections.Generic.ISet{T}"/>.
    /// </summary>
	public class JavaSetWrapper<T> : System.Collections.Generic.ISet<T>, IJavaCollectionWrapper<T>
    {
	    private readonly Java.Util.ISet<T> collection;

        /// <summary>
        /// Default ctor
        /// </summary>
	    public JavaSetWrapper(Java.Util.ISet<T> collection)
	    {
            if (collection == null)
                throw new ArgumentNullException("collection");
	        this.collection = collection;
	    }

        public void UnionWith(IEnumerable<T> other)
        {
            var wrap = other as IJavaCollectionWrapper<T>;
            if (wrap != null)
                collection.AddAll(wrap.Collection);
            else
                foreach (var e in other)
                    collection.Add(e);
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            var wrap = other as IJavaCollectionWrapper<T>;
            if (wrap != null)
                collection.RetainAll((Java.Util.ICollection<object>)wrap.Collection);
            else
            {
                var remove = new Java.Util.HashSet<T>(collection);
                foreach (var e in other)
                    remove.Remove(e);
                collection.RemoveAll((Java.Util.ICollection<object>)remove);
            }
        }


        /// <summary>
	    /// Gets an enummerator to enumerate over all elements in this sequence.
	    /// </summary>
	    /// <returns></returns>
	    public IEnumerator<T> GetEnumerator()
        {
            return new IteratorWrapper<T>(collection);
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
        public int Count { get { return collection.Size(); } }

        /// <summary>
        /// Is this collection unmodifiable?
        /// </summary>
        public bool IsReadOnly { get { return false; } }

        /// <summary>
        /// Add the given item to this collection.
        /// </summary>
        public void Add(T item)
        {
            collection.Add(item);
        }

	    /// <summary>
	    /// Remove all elements.
	    /// </summary>
	    public void Clear()
	    {
	        collection.Clear();
	    }

	    /// <summary>
        /// Does this collection contain the given element?
        /// </summary>
        public bool Contains(T item)
        {
            return collection.Contains(item);
        }

	    /// <summary>
	    /// Remove the given item from this collection.
	    /// </summary>
	    /// <returns>True if the item was removed, false otherwise.</returns>
	    public bool Remove(T item)
        {
            return collection.Remove(item);
        }

        /// <summary>
        /// Copy all my elements to the given array starting at the given index.
        /// </summary>
        /// <param name="array">Array to copy my elements into.</param>
        /// <param name="index">Position in <see cref="array"/> where the first element will be copied to.</param>
        public void CopyTo(T[] array, int index)
        {
            Dot42.Collections.Collections.CopyTo(collection, array, index);
        }

        /// <summary>
        /// Copy all my elements to the given array starting at the given index.
        /// </summary>
        /// <param name="array">Array to copy my elements into.</param>
        /// <param name="index">Position in <see cref="array"/> where the first element will be copied to.</param>
        public void CopyTo(Array array, int index)
        {
            Dot42.Collections.Collections.CopyTo(collection, array, index);
        }

	    /// <summary>
	    /// Gets the object used to synchronize access to this collection.
	    /// </summary>
	    public object SyncRoot { get { return collection; } }

	    /// <summary>
	    /// Is this collection thread safe.
	    /// </summary>
	    public bool IsSynchronized { get { return false; } }

        /// <summary>
        /// Gets the wapped collection.
        /// </summary>
        public Java.Util.ICollection<T> Collection { get { return collection; } }
    }
}

