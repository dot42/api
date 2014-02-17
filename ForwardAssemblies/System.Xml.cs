// Copyright (C) 2014 dot42
//
// Original filename: System.Xml.cs
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
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: Dot42.FrameworkLibrary]
[assembly: AssemblyFlags(AssemblyNameFlags.Retargetable)]

[assembly: TypeForwardedTo(typeof(System.Xml.XmlConvert))]
[assembly: TypeForwardedTo(typeof(System.Xml.XmlNodeType))]

[assembly: TypeForwardedTo(typeof(System.Xml.Schema.XmlSchemaForm))]

[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlAnyAttributeAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlAnyElementAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlArrayAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlArrayItemAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlAttributeAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlChoiceIdentifierAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlElementAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlEnumAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlIgnoreAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlIncludeAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlNamespaceDeclarationsAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlRootAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlSchemaProviderAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlSerializerAssemblyAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlSerializerVersionAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlTextAttribute))]
[assembly: TypeForwardedTo(typeof(System.Xml.Serialization.XmlTypeAttribute))]

