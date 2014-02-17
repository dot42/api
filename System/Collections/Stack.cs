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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Java.Util;

namespace System.Collections
{
	public class Stack
	{
        Java.Util.ArrayList<object> list = new ArrayList<object>(); 

        /// <summary>
        /// Ctor
        /// </summary>
	    public Stack()
	    {  
	    }

        /// <summary>
        /// Ctor
        /// </summary>
        public Stack(int initialCapacity)
        {
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
        public virtual object Peek()
        {
            return list[list.Count - 1];
        }

        /// <summary>
        /// Get the object at the top of the Stack and removes it.
        /// </summary>
        public virtual object Pop()
        {
            return list.Remove(list.Count - 1);
        }

        /// <summary>
        /// Set the object on the top of the stack (may be null)
        /// </summary>
        /// <param name="obj"></param>
	    public virtual void Push(object obj)
        {
            list.Add(obj);
        }

        /// <summary>
        /// Copies the Stack to a new array.
        /// </summary>
        public virtual object[] ToArray()
        {
            return list.ToArray();
        }
	}
}

