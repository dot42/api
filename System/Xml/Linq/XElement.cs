// Copyright (C) 2014 dot42
//
// Original filename: XElement.cs
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
using Org.Xmlpull.V1;

namespace System.Xml.Linq
{
    /// <summary>
    /// XML element
    /// </summary>
	public class XElement : XContainer
    {
        internal XAttribute lastAttribute;
        internal XName name;

        /// <summary>
        /// Default ctor
        /// </summary>
        public XElement(XName name)
        {
            if (name == null)
                throw new ArgumentNullException("name");
            this.name = name;
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public XElement(XName name, object content)
            : this(name)
        {
            Add(content);
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public XElement(XName name, params object[] content)
            : this(name)
        {
            Add(content, false);
        }

        /// <summary>
        /// Copy ctor
        /// </summary>
        public XElement(XElement source)
            : base(source)
        {
            name = source.name;
            if (source.lastAttribute != null)
            {
                foreach (var attr in source.Attributes())
                {
                    Add(new XAttribute(attr), false);
                }
            }
        }

	    /// <summary>
	    /// Gets the type of this node.
	    /// </summary>
	    public override XmlNodeType NodeType
        {
            get { return XmlNodeType.Element; }
        }

        /// <summary>
        /// Gets/sets the name of this element.
        /// </summary>
        public XName Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                var hasHandlers = NotifyChanging(this, XObjectChangeEventArgs.Name);
                name = value;
                if (hasHandlers)
                    NotifyChanged(this, XObjectChangeEventArgs.Name);
            }
        }

        /// <summary>
        /// Gets/sets the concatenated text content of this element.
        /// </summary>
        public string Value
        {
            get
            {
                if (content == null)
                {
                    return "";
                }
                var text = content as string;
                if (text != null)
                    return text;
                var buffer = new Java.Lang.StringBuffer();
                AppendTextTo(buffer);
                return buffer.ToString();
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                RemoveNodes(true);
                Add(value, true);
            }
        }

        /// <summary>
        /// Does this element have at least one attribute?
        /// </summary>
        public bool HasAttributes
        {
            get { return (lastAttribute != null); }
        }

        /// <summary>
        /// Does this element have at least one child element?
        /// </summary>
        public bool HasElements
        {
            get
            {
                foreach (var node in Nodes())
                {
                    if (node is XElement)
                        return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Does this element have no content?
        /// </summary>
        public bool IsEmpty
        {
            get { return (content == null); }
        }

        /// <summary>
        /// Gets all attributes.
        /// </summary>
        public IEnumerable<XAttribute> Attributes()
        {
            var x = lastAttribute;
            if (x != null)
            {
                do
                {
                    x = x.next;
                    yield return x;
                } while ((x.parent == this) && (lastAttribute != x));
            }
        }

        /// <summary>
        /// Gets all attributes with given name.
        /// </summary>
        public IEnumerable<XAttribute> Attributes(XName name)
        {
            if (name == null)
                yield break;
            if (lastAttribute != null)
            {
                foreach (var attr in Attributes())
                {
                    if (attr.name == name)
                        yield return attr;
                }
            }
        }

        /// <summary>
        /// Gets the first attribute with given name.
        /// </summary>
        public XAttribute Attribute(XName name)
        {
            if (lastAttribute != null)
            {
                foreach (var attr in Attributes())
                {
                    if (attr.name == name)
                        return attr;
                }
            }
            return null;
        }

        /// <summary>
        /// Add the given attribute
        /// </summary>
        internal override void Add(XAttribute attribute, bool notify)
        {
            if (Attribute(attribute.name) != null)
                throw new InvalidOperationException("Duplicate attribute");
            if (attribute.parent != null)
            {
                attribute = new XAttribute(attribute);
            }
            Append(attribute, notify);
        }

        /// <summary>
        /// Append the given attribute
        /// </summary>
        internal void Append(XAttribute attribute, bool notify)
        {
            if (attribute.parent != null)
                throw new InvalidOperationException("Invalid parent");
            var hasHandlers = notify && NotifyChanging(attribute, XObjectChangeEventArgs.Add);

            // Now append

            attribute.parent = this;
            if (lastAttribute == null)
            {
                attribute.next = attribute;
            }
            else
            {
                attribute.next = lastAttribute.next;
                lastAttribute.next = attribute;
            }
            lastAttribute = attribute;

            // Notify if needed
            if (hasHandlers) NotifyChanged(attribute, XObjectChangeEventArgs.Add);
        }

        /// <summary>
        /// Remove the given attribute from my list.
        /// </summary>
        internal void Remove(XAttribute attribute)
        {
            if (attribute.parent != this)
            {
                throw new InvalidOperationException("Invalid parent");
            }

            var hasHandlers = NotifyChanging(this, XObjectChangeEventArgs.Remove);

            var iterator = lastAttribute;
            if ((iterator == attribute) && (attribute.next == attribute))
            {
                // Last remaining attribute
                lastAttribute = null;
            }
            else
            {
                XAttribute next;
                while ((next = iterator.next) != attribute)
                {
                    iterator = next;
                }
                if (lastAttribute == attribute)
                {
                    lastAttribute = iterator;
                }
                iterator.next = attribute.next;
            }
            attribute.parent = null;
            attribute.next = null;

            if (hasHandlers)
            {
                NotifyChanged(this, XObjectChangeEventArgs.Remove);
            }
        }

        /// <summary>
        /// Returns a collection of elements that contain this element, and all descendant elements of this element, in document order.
        /// </summary>
        public IEnumerable<XElement> DescendantsAndSelf()
        {
            yield return this;

            foreach (var decendant in Descendants())
            {
                yield return decendant;
            }
        }

        /// <summary>
        /// Returns a collection of elements that contain this element, and all descendant elements of this element, in document order.
        /// </summary>
        public IEnumerable<XElement> DescendantsAndSelf(XName name)
        {
            if(Name == name) yield return this;

            foreach (var decendant in Descendants(name))
            {
                yield return decendant;
            }
        }

        /// <summary>
        /// Returns a collection of nodes that contain this element, and all descendant nodes of this element, in document order.
        /// </summary>
        public IEnumerable<XNode> DescendantNodesAndSelf()
        {
            yield return this;

            foreach (var decendantNode in DescendantNodes())
            {
                yield return decendantNode;
            }
        }

        /// <summary>
        /// Create a clone of this node.
        /// </summary>
        internal override XNode Clone()
        {
            return new XElement(this);
        }

        /// <summary>
        /// Serialize this object to the given serializer.
        /// </summary>
        public override void WriteTo(IXmlSerializer serializer)
        {
            serializer.StartTag(name.NamespaceName, name.LocalName);

            if (HasAttributes)
            {
                foreach (var attr in Attributes())
                {
                    attr.WriteTo(serializer);
                }
            }

            if (content is string)
            {
                serializer.Text((string) content);
            }
            else if (content is XNode)
            {
                foreach (var node in Nodes())
                {
                    node.WriteTo(serializer);
                }
            }

            serializer.EndTag(name.NamespaceName, name.LocalName);
        }
    }
}

