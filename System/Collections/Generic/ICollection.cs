// Copyright (C) 2014 dot42
//
// Original filename: ICollection.cs
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
    public interface ICollection<T> : ICollection, IEnumerable<T>
    {
        /// <summary>
        /// Gets the number of elements in the collection.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Is this collection unmodifiable?
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Add the given item to this collection.
        /// </summary>
        void Add(T item);

        /// <summary>
        /// Remove all elements.
        /// </summary>
        void Clear();

        /// <summary>
        /// Does this collection contain the given element?
        /// </summary>
        bool Contains(T item);

        /// <summary>
        /// Remove the given item from this collection.
        /// </summary>
        /// <returns>True if the item was removed, false otherwise.</returns>
        bool Remove(T item);

        /// <summary>
        /// Copy all my elements to the given array starting at the given index.
        /// </summary>
        /// <param name="array">Array to copy my elements into.</param>
        /// <param name="index">Position in <see cref="array"/> where the first element will be copied to.</param>
        void CopyTo(T[] array, int index);
    }
}

