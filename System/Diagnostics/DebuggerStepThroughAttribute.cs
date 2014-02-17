// Copyright (C) 2014 dot42
//
// Original filename: DebuggerStepThroughAttribute.cs
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
    /// <summary>
    /// Instructs the debugger to step through the code instead of stepping into the code. This class cannot be inherited.
    /// </summary>
    [SerializableAttribute]
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
    [ComVisible(true)]
	public sealed class DebuggerStepThroughAttribute : Attribute
	{
	}
}

