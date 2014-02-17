// Copyright (C) 2014 dot42
//
// Original filename: XmlEnumAttribute.cs
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
    /// Controls how the XmlSerializer serializes an enumeration member.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Field)]
    public class XmlEnumAttribute : Attribute
	{
        /// <summary>
        /// Default ctor
        /// </summary>
        public XmlEnumAttribute()
        {            
        }

        /// <summary>
        /// Name ctor
        /// </summary>
        public XmlEnumAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets/sets the value generated in an XML-document instance when the XmlSerializer serializes an enumeration, 
        /// or the value recognized when it deserializes the enumeration member.
        /// </summary>
        public string Name { get; set; }
	}
}

