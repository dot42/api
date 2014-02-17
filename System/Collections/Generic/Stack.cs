// Copyright (C) 2014 dot42
//
// Original filename: Stack.cs
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
using System.Linq;
using Java.Util;

namespace System.Collections.Generic
{
	public class Stack<T>
	{
	    private readonly ArrayList<T> list;

	    /// <summary>
	    /// Ctor
	    /// </summary>
	    public Stack()
	    {  
            list = new ArrayList<T>();
	    }

        /// <summary>
        /// Ctor
        /// </summary>
        public Stack(int initialCapacity)
        {
            list = new ArrayList<T>(initialCapacity); 
        }

        /// <summary>
        /// The number of elements contained in the Stack.
        /// </summary>
	    public virtual int Count
	    {
	        get { return list.Count; }
	    }

        /// <summary>
        /// Clears the stack
        /// </summary>
        public virtual void Clear()
        {
            list.Clear();
        }

        /// <summary>
        /// Get the object at the top of the Stack without removing it.
        /// </summary>
        public virtual T Peek()
        {
            return list[list.Count - 1];
        }

        /// <summary>
        /// Get the object at the top of the Stack and removes it.
        /// </summary>
        public virtual T Pop()
        {
            return list.Remove(list.Count - 1);
        }

        /// <summary>
        /// Set the object on the top of the stack (may be null)
        /// </summary>
        /// <param name="obj"></param>
	    public virtual void Push(T obj)
        {
            list.Add(obj);
        }

        /// <summary>
        /// Copies the Stack to a new array.
        /// </summary>
        public virtual T[] ToArray()
        {
            return list.ToList().ToArray();
        }
	}
}

