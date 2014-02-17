// Copyright (C) 2014 dot42
//
// Original filename: ObfuscateAssemblyAttribute.cs
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
    /// Instructs the obfuscator to use their standard obfuscation rules for the appropriate assembly type. 
    /// </summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    [Ignore]
    public sealed class ObfuscateAssemblyAttribute : Attribute
    {
        private readonly bool assemblyIsPrivate;
        private bool stripAfterObfuscation = true;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="assemblyIsPrivate">True if the assembly is private and can be fully obfuscated (including public members), false otherwise.</param>
        public ObfuscateAssemblyAttribute(bool assemblyIsPrivate)
        {
            this.assemblyIsPrivate = assemblyIsPrivate;
        }

        /// <summary>
        /// Gets a Boolean value indicating whether the assembly was marked private. 
        /// </summary>
        public bool AssemblyIsPrivate
        {
            get { return assemblyIsPrivate; }
        }

        /// <summary>
        /// Gets or sets a Boolean value indicating whether the obfuscator should remove this attribute after processing. 
        /// </summary>
        public bool StripAfterObfuscation
        {
            get { return stripAfterObfuscation; }
            set { stripAfterObfuscation = value; }
        }
    }
}

