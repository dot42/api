// Copyright (C) 2014 dot42
//
// Original filename: IterableWrapper.cs
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

namespace Dot42.Collections
{
    /// <summary>
    /// Make <see cref="IIterable{T}"/> compatible with <see cref="IEnumerable{T}"/>.
    /// </summary>
	public class IterableWrapper<T> : IEnumerable<T>
	{
        private readonly IIterable<T> iterable;

        /// <summary>
        /// Default ctor
        /// </summary>
	    public IterableWrapper(IIterable<T> iterable)
        {
            if (iterable == null)
                throw new ArgumentNullException("iterable");
            this.iterable = iterable;
        }

        /// <summary>
        /// Gets an enumerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new IteratorWrapper<T>(iterable);
        }

        /// <summary>
        /// Gets an enumerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
	}
}

