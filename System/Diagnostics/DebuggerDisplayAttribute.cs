// Copyright (C) 2014 dot42
//
// Original filename: DebuggerDisplayAttribute.cs
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

namespace System.Diagnostics
{
    [ComVisible(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Delegate, AllowMultiple = true)]
	public sealed class DebuggerDisplayAttribute : Attribute
	{
        private readonly string value;

        /// <summary>
        /// Default ctor
        /// </summary>
        public DebuggerDisplayAttribute(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Gets the string to display in the value column of the debugger variable windows.
        /// </summary>
        public string Value
        {
            get { return value; }
        }

        /// <summary>
        /// Gets or sets the name to display in the debugger variable windows.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the attribute's target.
        /// </summary>
        public Type Target { get; set; }

        /// <summary>
        /// Gets or sets the type name of the attribute's target.
        /// </summary>
        public string TargetTypeName { get; set; }

        /// <summary>
        /// Gets or sets the string to display in the type column of the debugger variable windows.
        /// </summary>
        public string Type { get; set; }
	}
}

