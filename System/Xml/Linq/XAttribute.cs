// Copyright (C) 2014 dot42
//
// Original filename: XAttribute.cs
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
using Dot42;
using Java.Io;
using Org.Xmlpull.V1;

namespace System.Xml.Linq
{
	public class XAttribute : XObject
	{
	    internal XName name;
	    private string value;
	    internal XAttribute next;

        /// <summary>
        /// Default ctor
        /// </summary>
        public XAttribute(XName name, object value)
        {
            if (name == null)
                throw new ArgumentNullException("name");
            if (value == null)
                throw new ArgumentNullException("value");
            this.value = ConvertToString(value);
            Validate(name, this.value);
            this.name = name;
        }

        /// <summary>
        /// Copy ctor
        /// </summary>
        public XAttribute(XAttribute source)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            value = source.value;
            name = source.name;
        }

	    /// <summary>
	    /// Gets the type of this node.
	    /// </summary>
	    public override XmlNodeType NodeType
        {
            get { return XmlNodeType.Attribute; }
        }

        /// <summary>
        /// Gets the name of this attribute.
        /// </summary>
        public XName Name { get { return name; } }

        /// <summary>
        /// Gets/sets the value of this attribute.
        /// </summary>
	    public string Value
	    {
            get { return value; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                Validate(name, value);
                var hasHandlers = NotifyChanging(this, XObjectChangeEventArgs.Value);
                this.value = value;
                if (hasHandlers)
                {
                    NotifyChanged(this, XObjectChangeEventArgs.Value);
                }
            }
	    }

        /// <summary>
        /// Gets the next attribute of the parent element.
        /// </summary>
	    public XAttribute NextAttribute
	    {
	        get
	        {
	            if ((parent == null) || (((XElement) parent).lastAttribute == this))
	                return null;
	            return next;
	        }
	    }

        /// <summary>
        /// Gets the previous attribute of the parent element.
        /// </summary>
        public XAttribute PreviousAttribute
        {
            get
            {
                if (parent == null)
                    return null;
                var last = ((XElement) parent).lastAttribute;
                var x = last;
                while (x.next != this)
                {
                    x = x.next;
                }
                return (x == last) ? null : x;
            }
        }

        /// <summary>
        /// Remove this attribute from it's parent.
        /// </summary>
        public void Remove()
        {
            if (parent == null)
                throw new InvalidOperationException("Missing parent");
            ((XElement) parent).Remove(this);
        }

        /// <summary>
        /// Serialize this object to the given serializer.
        /// </summary>
        public override void WriteTo(IXmlSerializer serializer)
        {
            serializer.Attribute(name.NamespaceName, name.LocalName, value);
        }

        /// <summary>
        /// Validate the given attribute combination.
        /// </summary>
        [Todo]
        private static void Validate(XName name, string value)
        {
            // TODO
        }

        /// <summary>
        /// Convert to XML representation.
        /// </summary>
        public override string ToString()
        {
            return ToXml(SaveOptions.None);
        }
	}
}

