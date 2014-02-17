// Copyright (C) 2014 dot42
//
// Original filename: DataContractAttribute.cs
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
namespace System.Runtime.Serialization
{
    // Summary:
    //     Specifies that the type defines or implements a data contract and is serializable
    //     by a serializer, such as the System.Runtime.Serialization.DataContractSerializer.
    //     To make their type serializable, type authors must define a data contract
    //     for their type.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
    public sealed class DataContractAttribute : Attribute
    {
        // Summary:
        //     Initializes a new instance of the System.Runtime.Serialization.DataContractAttribute
        //     class.
        public DataContractAttribute()
        {}

        // Summary:
        //     Gets or sets a value that indicates whether to preserve object reference
        //     data.
        //
        // Returns:
        //     true to keep object reference data using standard XML; otherwise, false.
        //     The default is false.
        public bool IsReference { get; set; }
        //
        // Summary:
        //     Gets or sets the name of the data contract for the type.
        //
        // Returns:
        //     The local name of a data contract. The default is the name of the class that
        //     the attribute is applied to.
        public string Name { get; set; }
        //
        // Summary:
        //     Gets or sets the namespace for the data contract for the type.
        //
        // Returns:
        //     The namespace of the contract.
        public string Namespace { get; set; }
    }
}

