// Copyright (C) 2014 dot42
//
// Original filename: InternalsVisibleToAttribute.cs
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
using Dot42;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Specifies that types that are ordinarily visible only within the current assembly are visible to a specified assembly.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
    [Ignore]
    public sealed class InternalsVisibleToAttribute : Attribute
	{
        private readonly string assemblyName;

        public InternalsVisibleToAttribute(string assemblyName)
        {
            this.assemblyName = assemblyName;
        }

        public string AssemblyName
        {
            get { return assemblyName; }
        }

        /// <summary>
        /// This property is not implemented.
        /// </summary>
        public bool AllInternalsVisible { get; set; }
	}
}

