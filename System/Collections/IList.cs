// Copyright (C) 2014 dot42
//
// Original filename: IList.cs
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
namespace System.Collections
{
    public interface IList : ICollection
    {
        /// <summary>
        /// Does this list have a fixed size?
        /// </summary>
        bool IsFixedSize { get; }

        /// <summary>
        /// Is this list read-only.
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Gets/sets an item in this list at the given index.
        /// </summary>
        object this[int index] { get; set; }

        /// <summary>
        /// Add ths given element to the end of this list.
        /// </summary>
        /// <returns>The index at which the element was added or -1 if the element was not added.</returns>
        int Add(object element);

        /// <summary>
        /// Remove all elements
        /// </summary>
        void Clear();

        /// <summary>
        /// Is the given element contained in this list?
        /// </summary>
        bool Contains(object element);

        /// <summary>
        /// Gets the index of the given element in this list.
        /// </summary>
        /// <returns>-1 is the element was not found</returns>
        int IndexOf(object element);

        /// <summary>
        /// Insert the given element at the given index into this list.
        /// </summary>
        void Insert(int index, object element);

        /// <summary>
        /// Removes the first occurrance of the given element from this list.
        /// </summary>
        /// <param name="element"></param>
        void Remove(object element);

        /// <summary>
        /// Removes the element at the given index from this list.
        /// </summary>
        /// <param name="index">0-based index of the element to remove.</param>
        void RemoveAt(int index);
    }
}

