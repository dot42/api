// Copyright (C) 2014 dot42
//
// Original filename: XNode.cs
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

namespace System.Xml.Linq
{
	public abstract class XNode : XObject
	{
	    internal XNode next;

        /// <summary>
        /// Gets the next sibling of this node.
        /// </summary>
	    public XNode NextNode
	    {
            get { return ((parent != null) && (parent.content != this)) ? next : null; }
	    }

        /// <summary>
        /// Gets the previous sibling of this node.
        /// </summary>
        public XNode PreviousNode
        {
            get
            {
                if (parent == null)
                    return null;
                return ((parent != null) && (parent.content != this)) ? next : null;
            }
        }

        /// <summary>
        /// Returns a collection of the ancestor elements of this node.
        /// </summary>
        /// <remarks>
        /// This method does not return itself in the results.
        /// The nodes in the returned collection are in reverse document order.
        /// This method uses deferred execution.
        /// </remarks>
        public IEnumerable<XElement> Ancestors()
        {
            XElement parent = Parent;
            while(parent != null)
            {
                yield return parent;

                parent = parent.Parent;
            }
        }

        /// <summary>
        /// Returns a filtered collection of the ancestor elements of this node. 
        /// Only elements that have a matching XName are included in the collection.
        /// </summary>
        /// <remarks>
        /// This method does not return itself in the results.
        /// The nodes in the returned collection are in reverse document order.
        /// This method uses deferred execution.
        /// </remarks>
        public IEnumerable<XElement> Ancestors(XName name)
        {
            XElement parent = Parent;
            while (parent != null)
            {
                if(parent.name == name)
                    yield return parent;

                parent = parent.Parent;
            }
        }

        /// <summary>
        /// Removes this node from its parent.
        /// </summary>
        public void Remove()
        {
            if (Parent == null) throw new InvalidOperationException("Parent is null");

            Parent.Remove(this, false);
        }

        /// <summary>
        /// Create a clone of this node.
        /// </summary>
	    internal abstract XNode Clone();

        /// <summary>
        /// Convert to XML representation.
        /// </summary>
        public override string ToString()
        {
            return ToXml(SaveOptions.None);
        }

        /// <summary>
        /// Convert to XML representation.
        /// </summary>
        public string ToString(SaveOptions options)
        {
            return ToXml(options);
        }

        /// <summary>
        /// Append string content to the given buffer.
        /// </summary>
        internal virtual void AppendTextTo(Java.Lang.StringBuffer buffer)
        {
            // Override me
        }
	}
}

