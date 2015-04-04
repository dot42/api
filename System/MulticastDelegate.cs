// Copyright (C) 2014 dot42
//
// Original filename: MulticastDelegate.cs
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

using System.Collections.Generic;
using Dot42;

namespace System
{
    partial class MulticastDelegate
    {
        [Include]
	    protected MulticastDelegate next;

        /// <summary>
        /// Add the given delegate to the end of my invocation list.
        /// </summary>
        protected override sealed void Add(Delegate other)
        {
            MulticastDelegate parent = this;
            while (parent.next != null)
            {
                parent = parent.next;
            }
            parent.next = (MulticastDelegate) other;
        }

        /// <summary>
        /// Remove the given delegate from my invocation list.
        /// </summary>
        protected override sealed Delegate Remove(Delegate other)
        {
            if (this.Equals(other))
            {
                // Front of the list
                var result = next;
                next = null;
                return result;
            }

            MulticastDelegate parent = this;
            while ((parent != null) && (!other.Equals(parent.next)))
            {
                parent = parent.next;
            }

            if (parent != null)
            {
                MulticastDelegate otherx = parent.next;
                parent.next = otherx.next;
                otherx.next = null;
            }

            return this;
        }

        public override Delegate[] GetInvocationList()
        {
            List<Delegate> ret = new List<Delegate> {this};

            MulticastDelegate parent = this;
            while (parent.next != null)
            {
                parent = parent.next;

                // TODO: check if this unfolding is neccessary.
                var parentsList = parent.GetInvocationList();
                
                for(int i = 0; i < parentsList.Length; ++i)
                    ret.Add(parentsList[i]);
            }
            return ret.ToArray();
        }
    }
}
