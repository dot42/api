// Copyright (C) 2014 dot42
//
// Original filename: JavaListWrapper.cs
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

namespace Java.Util
{
    public class JavaListWrapper<T> : JavaCollectionWrapper<T>, System.Collections.Generic.IList<T>, System.Collections.IList, IJavaCollectionWrapper<T>
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        public JavaListWrapper(IList<T> list)
            : base(list)
        {
        }

        /// <summary>
        /// Does this list have a fixed size?
        /// </summary>
        public bool IsFixedSize
        {
            get { return false; }
        }

        /// <summary>
        /// Add ths given element to the end of this list.
        /// </summary>
        /// <returns>The index at which the element was added or -1 if the element was not added.</returns>
        int System.Collections.IList.Add(object item)
        {
            return Add((T) item);
        }

        /// <summary>
        /// Removes the first occurrance of the given element from this list.
        /// </summary>
        /// <param name="element"></param>
        void System.Collections.IList.Remove(object item)
        {
            List.Remove((T) item);
        }

        /// <summary>
        /// Removes the element at the given index from this list.
        /// </summary>
        /// <param name="index">0-based index of the element to remove.</param>
        public void RemoveAt(int index)
        {
            List.Remove(index);
        }

        /// <summary>
        /// Insert the given element at the given index into this list.
        /// </summary>
        void System.Collections.IList.Insert(int index, object element)
        {
            List.Add(index, (T)element);
        }

        /// <summary>
        /// Gets/sets an item in this list at the given index.
        /// </summary>
        object System.Collections.IList.this[int index]
        {
            get { return List.Get(index); }
            set { List.Set(index, (T) value); }
        }

        /// <summary>
        /// Add ths given element to the end of this list.
        /// </summary>
        /// <returns>The index at which the element was added or -1 if the element was not added.</returns>
        public int Add(T item)
        {
            var list = List;
            list.Add(item);
            return list.IndexOf(item);
        }

        /// <summary>
        /// Removes the first occurrance of the given element from this list.
        /// </summary>
        public void Remove(T item)
        {
            List.Remove(item);
        }

        /// <summary>
        /// Insert the given element at the given index into this list.
        /// </summary>
        public void Insert(int index, T element)
        {
            List.Add(index, element);
        }

        /// <summary>
        /// Is the given element contained in this list?
        /// </summary>
        bool System.Collections.IList.Contains(object element)
        {
            return base.Contains((T) element);
        }

        /// <summary>
        /// Gets the index of the given element in this list.
        /// </summary>
        /// <returns>-1 is the element was not found</returns>
        int System.Collections.IList.IndexOf(object element)
        {
            return List.IndexOf(element);
        }

        /// <summary>
        /// Gets the index of the given element in this list.
        /// </summary>
        /// <returns>-1 is the element was not found</returns>
        public int IndexOf(T element)
        {
            return List.IndexOf(element);
        }

        /// <summary>
        /// Is the given element contained in this list?
        /// </summary>
        bool System.Collections.Generic.ICollection<T>.Contains(T element)
        {
            return base.Contains(element);
        }

        /// <summary>
        /// Gets/sets an item in this list at the given index.
        /// </summary>
        T System.Collections.Generic.IList<T>.this[int index]
        {
            get { return List.Get(index); }
            set { List.Set(index, value); }
        }

        /// <summary>
        /// Gets the wapped list.
        /// </summary>
        protected Java.Util.IList<T> List { get { return (IList<T>) base.Collection; } }
    }
}

