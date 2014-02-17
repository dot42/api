// Copyright (C) 2014 dot42
//
// Original filename: XmlSerializerAssemblyAttribute.cs
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
    /// Applied to a Web service client proxy, enables you to specify an assembly that contains custom-made serializers.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Interface, AllowMultiple = false)]
    public class XmlSerializerAssemblyAttribute : Attribute
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        public XmlSerializerAssemblyAttribute()
        {
        }

        /// <summary>
        /// Assembly name ctor
        /// </summary>
        public XmlSerializerAssemblyAttribute(string assemblyName)
        {
            AssemblyName = assemblyName;
        }

        /// <summary>
        /// Assembly name + codebase ctor
        /// </summary>
        public XmlSerializerAssemblyAttribute(string assemblyName, string codeBase)
        {
            AssemblyName = assemblyName;
            CodeBase = codeBase;
        }

        /// <summary>
        /// Gets/sets the name of the assembly that contains serializers for a specific set of types.
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// Gets/sets the location of the assembly that contains the serializers.
        /// </summary>
        public string CodeBase { get; set; }
    }
}

