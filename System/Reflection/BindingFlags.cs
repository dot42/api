// Copyright (C) 2014 dot42
//
// Original filename: BindingFlags.cs
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

namespace System.Reflection
{
    /// <summary>
    /// How to search for members and types by reflection.
    /// </summary>
    [Serializable]
    [Flags]
    public enum BindingFlags
    {

        /// <summary>
        /// No binding flags
        /// </summary>
        Default = 0,

        /// <summary>
        /// Case should not be considered
        /// </summary>
        IgnoreCase = 0x00000001,

        /// <summary>
        /// Only members declared at top level should be considered
        /// </summary>
        DeclaredOnly = 0x00000002,

        /// <summary>
        /// Instance members are included
        /// </summary>
        Instance = 0x00000004,

        /// <summary>
        /// Static members are included
        /// </summary>
        Static = 0x00000008,

        /// <summary>
        /// Public members are included
        /// </summary>
        Public = 0x00000010,

        /// <summary>
        /// Non public members are included
        /// </summary>
        NonPublic = 0x00000020,

        /// <summary>
        /// Public and protected static members up the hierarchy are included.
        /// </summary>
        FlattenHierarchy = 0x00000040,

        /// <summary>
        /// A method is to be invoked. This must not be a constructor or type initializer.
        /// </summary>
        InvokeMethod = 0x00000100,

        /// <summary>
        /// Reflection should create an instance of the specified type.
        /// </summary>
        CreateInstance = 0x00000200,

        /// <summary>
        /// Value of specified field should be returned
        /// </summary>
        GetField = 0x00000400,

        /// <summary>
        /// Value of specified field should be set
        /// </summary>
        SetField = 0x00000800,

        /// <summary>
        /// Value of specified property should be returned
        /// </summary>
        GetProperty = 0x00001000,

        /// <summary>
        /// Value of specified property should be set
        /// </summary>
        SetProperty = 0x00002000,

        /// <summary>
        /// COM related. Not supported.
        /// </summary>
        PutDispProperty = 0x00004000,

        /// <summary>
        /// COM related. Not supported.
        /// </summary>
        PutRefDispProperty = 0x00008000,

        /// <summary>
        /// Types of specified arguments must be an exact match
        /// </summary>
        ExactBinding = 0x00010000,

        /// <summary>
        /// Not used.
        /// </summary>
        SuppressChangeType = 0x00020000,

        /// <summary>
        /// ?
        /// </summary>
        OptionalParamBinding = 0x00040000,

        /// <summary>
        /// COM related. Not supported.
        /// </summary>
        IgnoreReturn = 0x01000000
    }
}

