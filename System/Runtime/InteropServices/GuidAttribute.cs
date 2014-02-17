// Copyright (C) 2014 dot42
//
// Original filename: GuidAttribute.cs
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
namespace System.Runtime.InteropServices
{
    // Summary:
    //     Supplies an explicit System.Guid when an automatic GUID is undesirable.
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
    [ComVisible(true)]
    public sealed class GuidAttribute : Attribute
    {
        // Summary:
        //     Initializes a new instance of the System.Runtime.InteropServices.GuidAttribute
        //     class with the specified GUID.
        //
        // Parameters:
        //   guid:
        //     The System.Guid to be assigned.
        public GuidAttribute(string guid)
        {
            Value = guid;
        }

        // Summary:
        //     Gets the System.Guid of the class.
        //
        // Returns:
        //     The System.Guid of the class.
        public string Value { get; private set; }
    }
}
