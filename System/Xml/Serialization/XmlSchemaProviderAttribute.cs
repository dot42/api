// Copyright (C) 2014 dot42
//
// Original filename: XmlSchemaProviderAttribute.cs
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
    /// When applied to a type, stores the name of a static method of the type that returns an XML schema and a XmlQualifiedName 
    /// (or XmlSchemaType for anonymous types) that controls the serialization of the type.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Interface)]
    public class XmlSchemaProviderAttribute : Attribute
    {
        private string elementName;

        /// <summary>
        /// Method name ctor
        /// </summary>
        public XmlSchemaProviderAttribute(string elementName)
        {
            this.elementName = elementName;
        }

        /// <summary>
        /// Gets/sets whether the target class is a wildcard, or that the schema for the class has contains only an xs:any element.
        /// </summary>
        public bool IsAny { get; set; }

        /// <summary>
        /// Gets the name of the static method that supplies the type's XML schema and the name of its XML Schema data type.
        /// </summary>
        public string MethodName
        {
            get { return elementName ?? string.Empty; }
            set { elementName = value; }
        }
    }
}

