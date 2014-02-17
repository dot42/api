// Copyright (C) 2014 dot42
//
// Original filename: XmlAnyElementAttribute.cs
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
namespace System.Xml.Serialization
{
    /// <summary>
    /// Specifies that the member (a field that returns an array of XmlElement or XmlNode objects) contains objects that represent any XML 
    /// element that has no corresponding member in the object being serialized or deserialized.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
    public class XmlAnyElementAttribute : Attribute
    {
        private string name;
        private string @namespace;
        private int order;

        public XmlAnyElementAttribute()
        {
        }

        public XmlAnyElementAttribute(string name)
        {
            this.name = name;
        }

        public XmlAnyElementAttribute(string name, string ns)
        {
            this.name = name;
            @namespace = ns;
        }

        /// <summary>
        /// Gets/sets the XML element name.
        /// </summary>
        public string Name
        {
            get { return name ?? string.Empty; }
            set { name = value; }
        }

        /// <summary>
        /// Gets/sets the XML element namespace.
        /// </summary>
        public string Namespace
        {
            get { return @namespace; }
            set { @namespace = value; }
        }

        /// <summary>
        /// Gets/sets the explicit order in which elements are serialized/deserialized.
        /// </summary>
        public int Order
        {
            get { return order; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Negative values not allowed", "Order");
                order = value;
            }
        }
    }
}

