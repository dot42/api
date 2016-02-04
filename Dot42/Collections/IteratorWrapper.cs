// Copyright (C) 2014 dot42
//
// Original filename: IteratorWrapper.cs
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
using System.Collections;
using System.Collections.Generic;
using Java.Util;
using Java.Lang;

namespace Dot42.Collections
{
    /// <summary>
    /// Wraps an <see cref="IIterator{E}"/> such that is can be used as <see cref="System.Collections.Generic.IEnumerator{T}"/>.
    /// </summary>
	public class IteratorWrapper<T> : IEnumerator<T>
	{
        private readonly IIterable<T> iterable;
	    private IIterator<T> iterator;
	    private T current;

        /// <summary>
        /// Default ctor
        /// </summary>
        public IteratorWrapper(IIterable<T> iterable)
        {
            this.iterable = iterable;
            Reset();
        }

        /// <summary>
        /// Cleanup
        /// </summary>
	    public void Dispose()
	    {
	    }

	    /// <summary>
	    /// Move to the next element.
	    /// </summary>
	    /// <returns>True on success.</returns>
	    public bool MoveNext()
	    {
            if (!iterator.HasNext)
                return false;
	        
            current = iterator.Next();
	        if (Null.IsNull(current)) current = default(T);
	        
            return true;
	    }

	    /// <summary>
	    /// Move to initial position (before first element).
	    /// </summary>
	    public void Reset()
	    {
            iterator = iterable.Iterator();
	    }

	    /// <summary>
	    /// Gets the current element in the sequence.
	    /// </summary>
	    public T Current
	    {
	        get { return current; }
	    }

	    /// <summary>
	    /// Gets the current element in the sequence.
	    /// </summary>
	    object IEnumerator.Current
	    {
	        get { return Current; }
	    }
	}
}

