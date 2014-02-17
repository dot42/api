// Copyright (C) 2014 dot42
//
// Original filename: AttributeTargets.cs
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
using System.Runtime.InteropServices;

namespace System
{
    [Flags, ComVisible(true)]
    [Serializable]
    public enum AttributeTargets
    {
        /// <summary>Attribute can be applied to an assembly.</summary>
        Assembly = 1,
        /// <summary>Attribute can be applied to a module.</summary>
        Module = 2,
        /// <summary>Attribute can be applied to a class.</summary>
        Class = 4,
        /// <summary>Attribute can be applied to a structure; that is, a value type.</summary>
        Struct = 8,
        /// <summary>Attribute can be applied to an enumeration.</summary>
        Enum = 16,
        /// <summary>Attribute can be applied to a constructor.</summary>
        Constructor = 32,
        /// <summary>Attribute can be applied to a method.</summary>
        Method = 64,
        /// <summary>Attribute can be applied to a property.</summary>
        Property = 128,
        /// <summary>Attribute can be applied to a field.</summary>
        Field = 256,
        /// <summary>Attribute can be applied to an event.</summary>
        Event = 512,
        /// <summary>Attribute can be applied to an interface.</summary>
        Interface = 1024,
        /// <summary>Attribute can be applied to a parameter.</summary>
        Parameter = 2048,
        /// <summary>Attribute can be applied to a delegate.</summary>
        Delegate = 4096,
        /// <summary>Attribute can be applied to a return value.</summary>
        ReturnValue = 8192,
        /// <summary>Attribute can be applied to a generic parameter.</summary>
        GenericParameter = 16384,
        /// <summary>Attribute can be applied to any application element.</summary>
        All = 32767
    }
}

