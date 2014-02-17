// Copyright (C) 2014 dot42
//
// Original filename: XmlTypeAttribute.cs
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
    /// Controls the XML schema that is generated when the attribute target is serialized by the XmlSerializer.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Interface)]
    public class XmlTypeAttribute : Attribute
    {
        private string typeName;

        /// <summary>
        /// Default ctor
        /// </summary>
        public XmlTypeAttribute()
        {            
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public XmlTypeAttribute(string typeName)
        {
            TypeName = typeName;
        }

        /// <summary>
        /// Gets/sets whether the resulting schema type is an XSD anonymous type.
        /// </summary>
        public bool AnonymousType { get; set; }

        /// <summary>
        /// Gets/sets whether to include the type in XML schema documents.
        /// </summary>
        public bool IncludeInSchema { get; set; }

        /// <summary>
        /// Gets/sets the namespace of the XML type.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets/sets the name of the XML type.
        /// </summary>
        public string TypeName
        {
            get { return typeName ?? string.Empty; }
            set { typeName = value; }
        }
    }
}

