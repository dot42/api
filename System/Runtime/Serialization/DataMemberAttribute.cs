// Copyright (C) 2014 dot42
//
// Original filename: DataMemberAttribute.cs
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
    //     When applied to the member of a type, specifies that the member is part of
    //     a data contract and is serializable by the System.Runtime.Serialization.DataContractSerializer.
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public sealed class DataMemberAttribute : Attribute
    {
        // Summary:
        //     Initializes a new instance of the System.Runtime.Serialization.DataMemberAttribute
        //     class.
        public DataMemberAttribute()
        {}

        // Summary:
        //     Gets or sets a value that specifies whether to serialize the default value
        //     for a field or property being serialized.
        //
        // Returns:
        //     true if the default value for a member should be generated in the serialization
        //     stream; otherwise, false. The default is true.
        public bool EmitDefaultValue { get; set; }
        //
        // Summary:
        //     Gets or sets a value that instructs the serialization engine that the member
        //     must be present when reading or deserializing.
        //
        // Returns:
        //     true, if the member is required; otherwise, false.
        //
        // Exceptions:
        //   System.Runtime.Serialization.SerializationException:
        //     the member is not present.
        public bool IsRequired { get; set; }
        //
        // Summary:
        //     Gets or sets a data member name.
        //
        // Returns:
        //     The name of the data member. The default is the name of the target that the
        //     attribute is applied to.
        public string Name { get; set; }
        //
        // Summary:
        //     Gets or sets the order of serialization and deserialization of a member.
        //
        // Returns:
        //     The numeric order of serialization or deserialization.
        public int Order { get; set; }
    }
}
