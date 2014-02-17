// Copyright (C) 2014 dot42
//
// Original filename: DebuggableAttribute.cs
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
    /// Modifies code generation for runtime just-in-time (JIT) debugging. This class cannot be inherited.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = false)]
    public sealed class DebuggableAttribute : Attribute
	{
        private readonly DebuggingModes mode;

        [Flags, ComVisible(true)]
        public enum DebuggingModes
        {
            /// <summary>In the .NET Framework version 2.0, JIT tracking information is always generated, and this flag has the same effect as <see cref="F:System.Diagnostics.DebuggableAttribute.DebuggingModes.Default" /> with the exception of the <see cref="P:System.Diagnostics.DebuggableAttribute.IsJITTrackingEnabled" /> property being false, which has no meaning in version 2.0.</summary>
            None = 0,
            /// <summary>Instructs the just-in-time (JIT) compiler to use its default behavior, which includes enabling optimizations, disabling Edit and Continue support, and using symbol store sequence points if present. In the .NET Framework version 2.0, JIT tracking information, the Microsoft intermediate language (MSIL) offset to the native-code offset within a method, is always generated.</summary>
            Default = 1,
            /// <summary>Disable optimizations performed by the compiler to make your output file smaller, faster, and more efficient. Optimizations result in code rearrangement in the output file, which can make debugging difficult. Typically optimization should be disabled while debugging. </summary>
            DisableOptimizations = 256,
            /// <summary>Use the implicit MSIL sequence points, not the program database (PDB) sequence points. The symbolic information normally includes at least one Microsoft intermediate language (MSIL) offset for each source line. When the just-in-time (JIT) compiler is about to compile a method, it asks the profiling services for a list of MSIL offsets that should be preserved. These MSIL offsets are called sequence points.</summary>
            IgnoreSymbolStoreSequencePoints = 2,
            /// <summary>Enable edit and continue. Edit and continue enables you to make changes to your source code while your program is in break mode. The ability to edit and continue is compiler dependent. </summary>
            EnableEditAndContinue = 4
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public DebuggableAttribute(DebuggingModes mode)
        {
            this.mode = mode;
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public DebuggableAttribute(bool isJITTrackingEnabled, bool  isJITOptimizerDisabled)
        {
            mode = DebuggingModes.None;
            if (isJITTrackingEnabled)
            {
                mode |= DebuggingModes.Default;
            }
            if (isJITOptimizerDisabled)
            {
                mode |= DebuggingModes.DisableOptimizations;
            }
        }

        /// <summary>
        /// Gets the debugging modes for the attribute.
        /// </summary>
        public DebuggingModes DebuggingFlags { get { return mode; } }

        /// <summary>Gets a value that indicates whether the runtime optimizer is disabled.</summary>
        /// <returns>true if the runtime optimizer is disabled; otherwise, false.</returns>
        /// <filterpriority>2</filterpriority>
        public bool IsJITOptimizerDisabled
        {
            get { return (mode & DebuggingModes.DisableOptimizations) == DebuggingModes.DisableOptimizations; }
        }

        // System.Diagnostics.DebuggableAttribute
        /// <summary>Gets a value that indicates whether the runtime will track information during code generation for the debugger.</summary>
        /// <returns>true if the runtime will track information during code generation for the debugger; otherwise, false.</returns>
        /// <filterpriority>2</filterpriority>
        public bool IsJITTrackingEnabled
        {
            get { return (mode & DebuggingModes.Default) == DebuggingModes.Default; }
        }
	}
}

