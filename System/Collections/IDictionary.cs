// Copyright (C) 2014 dot42
//
// Original filename: IDictionary.cs
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
    /// <summary>
    /// Non generic collection of key-value pairs.
    /// </summary>
    public interface IDictionary : ICollection
    {
        /// <summary>
        /// Does this dictionary have a fixed size?
        /// </summary>
        bool IsFixedSize { get; }

        /// <summary>
        /// Is this dictionary read-only?
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Gets/sets an item with the given specified key.
        /// </summary>
        /// <value>The element with the specified key, or null if the key does not exist.</value>
        object this[object key] { get; set; }

        /// <summary>
        /// Gets the keys of this dictionary.
        /// </summary>
        ICollection Keys { get; }

        /// <summary>
        /// Gets the values of this dictionary.
        /// </summary>
        ICollection Values { get; }

       /// <summary>
        /// Adds an element with the provided key and value.
       /// </summary>
        void Add(object key, object value);

        /// <summary>
        /// Removes all elements.
        /// </summary>
        void Clear();

        /// <summary>
        /// Check if the key is in the collection
        /// </summary>
        bool Contains(object key);

        /// <summary>
        /// Returns an IDictionaryEnumerator.
        /// </summary>
        /// <returns></returns>
        IDictionaryEnumerator GetEnumerator();

        /// <summary>
        /// Removes the element with the specified key.
        /// </summary>
        void Remove(object key);
    }
}

