// Copyright (C) 2014 dot42
//
// Original filename: XContainer.cs
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
using Dot42;

namespace System.Xml.Linq
{
	public abstract class XContainer : XNode
	{
	    internal object content;

        /// <summary>
        /// Default ctor
        /// </summary>
        internal XContainer()
        {            
        }

        /// <summary>
        /// Clone ctor
        /// </summary>
        internal XContainer(XContainer source)
        {
            content = source.content as string;
            if ((content == null) && (source.content is XNode))
            {
                foreach (var node in source.Nodes())
                {
                    Add(node.Clone(), false);
                }
            }
        }

        /// <summary>
        /// Gets the first node of this container.
        /// </summary>
	    public XNode FirstNode
	    {
	        get
	        {
	            var last = LastNode;
	            return (last != null) ? last.next : null;
	        }
	    }

        /// <summary>
        /// Gets the last node of this container.
        /// </summary>
        public XNode LastNode 
        {
            get
            {
                if (content == null)
                    return null;
                var node = content as XNode;
                if (node != null)
                    return node;
                var text = content as string;
                if (text != null)
                {
                    if (text.Length == 0)
                        return null;
                    var textNode = new XText(text) { parent = this };
                    textNode.next = textNode;
                    content = textNode;
                }
                return (XNode) content;
            }
        }

        /// <summary>
        /// Add given content as children of this container.
        /// </summary>
        public void Add(object value)
        {
            Add(value, true);
        }

        /// <summary>
        /// Add given content as children of this container.
        /// </summary>
        public void Add(params object[] value)
        {
            if (value == null)
                return;
            for (var i = 0; i < value.Length; i++)
            {
                Add(value[i], true);
            }
        }

        /// <summary>
        /// Remove all child nodes from this container.
        /// </summary>
        public void RemoveNodes()
        {
            RemoveNodes(true);
        }

        /// <summary>
        /// Remove all child nodes from this container.
        /// </summary>
        internal void RemoveNodes(bool notify)
        {
            if (content is string)
            {
                notify = notify && (this is XElement);
                var hasHandlers = notify && NotifyChanging(this, XObjectChangeEventArgs.Value);
                content = null;
                if (hasHandlers)
                    NotifyChanged(this, XObjectChangeEventArgs.Value);
                return;
            }

            while (content != null)
            {
                var node = content as XNode;
                if (node != null)
                {
                    Remove(node.next, notify);
                }
            }
        }

        /// <summary>
        /// Remove the given node from it's parent
        /// </summary>
        internal void Remove(XNode node, bool notify)
        {
            if (node.parent != this)
            {
                throw new InvalidOperationException("Invalid parent");
            }

            var hasHandlers = NotifyChanging(this, XObjectChangeEventArgs.Remove);

            var iterator = content as XNode;
            if ((iterator == node) && (node.next == node))
            {
                // Last remaining node
                content = null;
            }
            else
            {
                XNode next;
                while ((next = iterator.next) != node)
                {
                    iterator = next;
                }
                if (content == node)
                {
                    content = iterator;
                }
                iterator.next = node.next;
            }
            node.parent = null;
            node.next = null;

            if (hasHandlers)
            {
                NotifyChanged(this, XObjectChangeEventArgs.Remove);
            }
        }

        /// <summary>
        /// Return a collection of child nodes in document order.
        /// </summary>
        public IEnumerable<XNode> Nodes()
        {
            var x = LastNode;
            if (x != null)
            {
                do
                {
                    x = x.next;
                    yield return x;
                } while ((x.parent == this) && (content != x));
            }
        }

        /// <summary>
        /// Return a collection of child elements in document order.
        /// </summary>
        public IEnumerable<XElement> Elements()
        {
            foreach (var node in Nodes())
            {
                var element = node as XElement;
                if (element != null)
                    yield return element;
            }
        }

        /// <summary>
        /// Return a collection of child elements with given name in document order.
        /// </summary>
        public IEnumerable<XElement> Elements(XName name)
        {
            if (ReferenceEquals(name, null))
                yield break;            
            foreach (var node in Nodes())
            {
                var element = node as XElement;
                if ((element != null) && (element.name == name))
                    yield return element;
            }
        }

        /// <summary>
        /// Get the first child elements with given name in document order.
        /// </summary>
        public XElement Element(XName name)
        {
            foreach (var node in Nodes())
            {
                var element = node as XElement;
                if ((element != null) && (element.name == name))
                    return element;
            }
            return null;
        }

        /// <summary>
        /// Add given content as children of this container.
        /// </summary>
        internal void Add(object value, bool notify)
        {
            if (value == null)
                return;
            var node = value as XNode;
            if (node != null)
            {
                Add(node, notify);
                return;
            }
            var text = value as string;
            if (text != null)
            {
                Add(text, notify);
                return;
            }
            var attr = value as XAttribute;
            if (attr != null)
            {
                Add(attr, notify);
                return;
            }
            var array = value as object[];
            if (array != null)
            {
                for (var i = 0; i < array.Length; i++)
                {
                    Add(array[i], notify);
                }
                return;
            }
            var enumerable = value as IEnumerable;
            if (enumerable != null)
            {
                foreach (var x in enumerable)
                {
                    Add(x, notify);
                }
                return;
            }
            Add(ConvertToString(value), notify);
        }

        /// <summary>
        /// Add the given node
        /// </summary>
        internal void Add(XNode node, bool notify)
        {
            if ((node.parent != null) || (Root == node))
            {
                node = node.Clone();
            }
            ConvertText2Node();
            Append(node, notify);
        }

        /// <summary>
        /// Add the given node to the end of the list
        /// </summary>
        internal void Append(XNode node, bool notify)
        {
            if (node.parent != null)
            {
                throw new InvalidOperationException("Invalid parent");
            }
            var hasHandlers = notify && NotifyChanging(node, XObjectChangeEventArgs.Add);
            // Add now
            node.parent = this;
            if ((content == null) || (content is string))
            {
                node.next = node;
            }
            else
            {
                var last = (XNode) content;
                node.next = last.next;
                last.next = node;
            }
            content = node;
            // Notify if needed
            if (hasHandlers) NotifyChanged(node, XObjectChangeEventArgs.Add);
        }

        /// <summary>
        /// Convert any string content to XText.
        /// </summary>
        internal void ConvertText2Node()
        {
            var text = content as string;
            if ((text != null) && (text.Length > 0))
            {
                var node = new XText(text);
                node.next = node;
                node.parent = this;
                content = node;
            }
        }

        /// <summary>
        /// Add the given attribute
        /// </summary>
        internal virtual void Add(XAttribute attribute, bool notify)
        {
            // Override me
        }

        /// <summary>
        /// Add the given text
        /// </summary>
        [Todo]
        internal void Add(string text, bool notify)
        {
            if (text.Length > 0)
            {
                Add(new XText(text), notify);
            }
        }

        /// <summary>
        /// Returns a collection of the descendant elements for this document or element, in document order.
        /// </summary>
        /// <remarks>
        /// Note that this method will not return itself in the result.
        /// </remarks>
        public IEnumerable<XElement> Descendants()
        {
            var childElements = Elements().GetEnumerator();
            var hasNext = childElements.MoveNext();

            var stack = new Stack<IEnumerator<XElement>>();

            while (true)
            {
                if (hasNext)
                {
                    yield return childElements.Current;
                    stack.Push(childElements);

                    childElements = childElements.Current.Elements().GetEnumerator();
                    hasNext = childElements.MoveNext();
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        childElements = stack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Returns a collection of the descendant elements for this document or element, in document order.
        /// </summary>
        /// <remarks>
        /// Note that this method will not return itself in the result.
        /// </remarks>
        public IEnumerable<XElement> Descendants(XName name)
        {
            var childElements = Elements(name).GetEnumerator();
            var hasNext = childElements.MoveNext();

            var stack = new Stack<IEnumerator<XElement>>();

            while (true)
            {
                if (hasNext)
                {
                    yield return childElements.Current;
                    stack.Push(childElements);

                    childElements = childElements.Current.Elements(name).GetEnumerator();
                    hasNext = childElements.MoveNext();
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        childElements = stack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

	    /// <summary>
	    /// Returns a collection of the descendant nodes for this document or element, in document order.
	    /// </summary>
	    public IEnumerable<XNode> DescendantNodes()
	    {
	        foreach (XNode node in Nodes())
	        {
	            yield return node;
	            
                var container = node as XContainer;
	            if (container != null)
	                foreach (var d in container.DescendantNodes())
	                    yield return d;
	        }
	    }

	    /// <summary>
	    /// Append string content to the given buffer.
	    /// </summary>
	    internal override void AppendTextTo(Java.Lang.StringBuffer buffer)
        {
            var text = content as string;
            if (text != null)
            {
                buffer.Append(text);
            }
            else if (content is XNode)
            {
                foreach (var node in Nodes())
                {
                    node.AppendTextTo(buffer);
                }
            }
        }
    }
}

