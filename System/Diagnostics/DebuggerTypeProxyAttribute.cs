// Copyright (C) 2014 dot42
//
// Original filename: DebuggerTypeProxyAttribute.cs
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

namespace System.Diagnostics
{
    /// <summary>
    /// Specifies the display proxy for a type.
    /// </summary>
    [ComVisible(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    [Ignore("Not used by Dot42 debugger.")]
	public sealed class DebuggerTypeProxyAttribute : Attribute
	{
        private readonly string typeName;
        private Type target;

        /// <summary>
        /// Default ctor
        /// </summary>
        public DebuggerTypeProxyAttribute(string typeName)
        {
            this.typeName = typeName;
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public DebuggerTypeProxyAttribute(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            this.typeName = type.AssemblyQualifiedName;
        }

        /// <summary>
        /// Gets the type name of the proxy type.
        /// </summary>
        /// <returns>The type name of the proxy type.</returns>
        /// <filterpriority>2</filterpriority>
        public string ProxyTypeName
        {
            get { return typeName; }
        }

        /// <summary>
        /// Gets or sets the name of the target type.
        /// </summary>
        public string TargetTypeName { get; set; }

        /// <summary>
        /// Gets or sets the target type for the attribute.
        /// </summary>
        public Type Target
        {
            get { return target; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                TargetTypeName = value.AssemblyQualifiedName;
                target = value;
            }
        }
	}
}

