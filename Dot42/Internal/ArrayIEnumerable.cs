// Copyright (C) 2014 dot42
//
// Original filename: ArrayIEnumerable.cs
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
using Java.Lang;

namespace Dot42.Internal
{
    /// <summary>
    /// Make an array compatible with <see cref="IEnumerable{T}"/>.
    /// </summary>
    [Include(TypeCondition = typeof(IEnumerable))]
    [Include(TypeCondition = typeof(IEnumerable<>))]
	internal class ArrayIEnumerable<T> : IEnumerable<T>
	{
        private readonly T[] array;

        /// <summary>
        /// Default ctor
        /// </summary>
        public ArrayIEnumerable(T[] array)
        {
            if (array == null)
                throw new ArgumentNullException("array");
            this.array = array;
        }

        /// <summary>
        /// Gets an enumerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        [Include(TypeCondition = typeof(IEnumerable))]
        [Include(TypeCondition = typeof(IEnumerable<>))]
        public IEnumerator<T> GetEnumerator()
        {
            return new ArrayIEnumerator<T>(array);
        }

        /// <summary>
        /// Gets an enumerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        [Include(TypeCondition = typeof(IEnumerable))]
        [Include(TypeCondition = typeof(IEnumerable<>))]
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
	}
}

