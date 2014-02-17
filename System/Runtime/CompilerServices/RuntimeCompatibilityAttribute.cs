// Copyright (C) 2014 dot42
//
// Original filename: RuntimeCompatibilityAttribute.cs
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
    /// Specifies whether to wrap exceptions that do not derive from the Exception class with a RuntimeWrappedException object. This class cannot be inherited.
    /// </summary>
    [SerializableAttribute]
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
    [Ignore]
    public sealed class RuntimeCompatibilityAttribute : Attribute
	{
        /// <summary>
        /// Gets or sets a value that indicates whether to wrap exceptions that do not derive from the Exception class with a RuntimeWrappedException object.
        /// </summary>
        public bool WrapNonExceptionThrows { get; set; }
	}
}

