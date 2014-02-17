// Copyright (C) 2014 dot42
//
// Original filename: XmlChoiceIdentifierAttribute.cs
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
    /// Specifies that the member can be further detected by using an enumeration.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Parameter|AttributeTargets.ReturnValue, AllowMultiple = false)]
    public class XmlChoiceIdentifierAttribute : Attribute
    {
        private string memberName;

        /// <summary>
        /// Default ctor
        /// </summary>
        public XmlChoiceIdentifierAttribute()
        {            
        }

        /// <summary>
        /// Member name ctor
        /// </summary>
        public XmlChoiceIdentifierAttribute(string memberName)
        {
            this.memberName = memberName;
        }

        /// <summary>
        /// Gets/sets the name of the XML attribute.
        /// </summary>
        public string MemberName
        {
            get { return memberName ?? string.Empty; }
            set { memberName = value; }
        }
    }
}

