// Copyright (C) 2014 dot42
//
// Original filename: ObfuscationAttribute.cs
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
using Dot42;

namespace System.Reflection
{
    /// <summary>
    /// Instructs the obfuscator to take the specified actions for an assembly, type, or member. 
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
    [ComVisibleAttribute(true)]
    [Obfuscation]
    [Ignore]
    public sealed class ObfuscationAttribute : Attribute
    {
        private bool applyToMembers = true;
        private bool exclude = true;
        private string feature = "all";
        private bool stripAfterObfuscation = true;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public ObfuscationAttribute()
        {
        }

        /// <summary>
        /// Gets or sets a Boolean value indicating whether the obfuscator should remove this attribute after processing. 
        /// </summary>
        public bool StripAfterObfuscation
        {
            get { return stripAfterObfuscation; }
            set { stripAfterObfuscation = value; }
        }

        /// <summary>
        /// Gets or sets a string value that is recognized by the obfuscator, and which specifies processing options. 
        /// </summary>
        public string Feature
        {
            get { return feature; }
            set { feature = value; }
        }

        /// <summary>
        /// Gets or sets a Boolean value indicating whether the obfuscator should exclude the type or member from obfuscation. 
        /// </summary>
        public bool Exclude
        {
            get { return exclude; }
            set { exclude = value; }
        }

        /// <summary>
        /// Gets or sets a Boolean value indicating whether the attribute of a type is to apply to the members of the type. 
        /// </summary>
        public bool ApplyToMembers
        {
            get { return applyToMembers; }
            set { applyToMembers = value; }
        }
    }
}

