// Copyright (C) 2014 dot42
//
// Original filename: MethodImplOptions.cs
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

namespace System.Runtime.CompilerServices
{
    /// <summary>Defines the details of how a method is implemented.</summary>
    [Flags, ComVisible(true)]
    [Serializable]
	public enum MethodImplOptions
	{
        /// <summary>Specifies that the method is implemented in unmanaged code.</summary>
        Unmanaged = 4,
        /// <summary>Specifies that the method is declared, but its implementation is provided elsewhere.</summary>
        ForwardRef = 16,
        /// <summary>Specifies that the method signature is exported exactly as declared.</summary>
        PreserveSig = 128,
        /// <summary>Specifies an internal call. An internal call is a call to a method that is implemented within the common language runtime itself.</summary>
        InternalCall = 4096,
        /// <summary>Specifies that the method can be executed by only one thread at a time.  Static methods lock on the type, whereas instance methods lock on the instance. Only one thread can execute in any of the instance functions, and only one thread can execute in any of a class's static functions.</summary>
        Synchronized = 32,
        /// <summary>Specifies that the method cannot be inlined.</summary>
        NoInlining = 8,
        AggressiveInlining = 256,
        /// <summary>Specifies that the method is not optimized by the just-in-time (JIT) compiler or by native code generation (see Ngen.exe) when debugging possible code generation problems.</summary>
        NoOptimization = 64
	}
}

