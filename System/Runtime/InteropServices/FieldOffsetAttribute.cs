// Copyright (C) 2014 dot42
//
// Original filename: FieldOffsetAttribute.cs
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
    //     Indicates the physical position of fields within the managed and unmanaged
    //     representation of a class or structure.
    [ComVisible(true)]
    [AttributeUsage(AttributeTargets.Field, Inherited = false)]
    public sealed class FieldOffsetAttribute : Attribute
    {
        // Summary:
        //     Initializes a new instance of the System.Runtime.InteropServices.FieldOffsetAttribute
        //     class with the offset in the structure to the beginning of the field.
        //
        // Parameters:
        //   offset:
        //     The offset in bytes from the beginning of the structure to the beginning
        //     of the field.
        public FieldOffsetAttribute(int offset)
        {
            Value = offset;
        }

        // Summary:
        //     Gets the offset from the beginning of the structure to the beginning of the
        //     field.
        //
        // Returns:
        //     The offset from the beginning of the structure to the beginning of the field.
        public int Value { get; private set; }
    }
}

