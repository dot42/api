// Copyright (C) 2014 dot42
//
// Original filename: XText.cs
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
using Org.Xmlpull.V1;

namespace System.Xml.Linq
{
    /// <summary>
    /// XML text
    /// </summary>
	public class XText : XNode
    {
        private string value;

        /// <summary>
        /// Initialize from string.
        /// </summary>
        public XText(string value)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            this.value = value;
        }

        /// <summary>
        /// Copy ctor
        /// </summary>
        public XText(XText source)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            value = source.value;
        }

        /// <summary>
	    /// Gets the type of this node.
	    /// </summary>
	    public override XmlNodeType NodeType
        {
            get { return XmlNodeType.Text; }
        }

        /// <summary>
        /// Gets/sets the value of this text node.
        /// </summary>
        public string Value
        {
            get { return value; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                var anyHandlers = NotifyChanging(this, XObjectChangeEventArgs.Value);
                this.value = value;
                if (anyHandlers)
                {
                    NotifyChanged(this, XObjectChangeEventArgs.Value);
                }
            }
        }

        /// <summary>
        /// Create a clone of this node.
        /// </summary>
        internal override XNode Clone()
        {
            return new XText(this);
        }

        /// <summary>
        /// Serialize this object to the given serializer.
        /// </summary>
        public override void WriteTo(IXmlSerializer serializer)
        {
            serializer.Text(value);
        }

        /// <summary>
        /// Append string content to the given buffer.
        /// </summary>
        internal override void AppendTextTo(Java.Lang.StringBuffer buffer)
        {
            buffer.Append(value);
        }
    }
}

