// Copyright (C) 2014 dot42
//
// Original filename: AssemblyNameFlags.cs
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
namespace System.Reflection
{
	public enum AssemblyNameFlags
	{
        /// <summary>
        /// Specifies that no flags are in effect.
        /// </summary>
        None = 0,

        /// <summary>
        /// Specifies that a public key is formed from the full public key rather than the public key token.
        /// </summary>
        PublicKey = 1,

        /// <summary>
        /// Specifies that just-in-time (JIT) compiler optimization is disabled for the assembly. This is the exact opposite of the meaning that is suggested by the member name.
        /// </summary>
        EnableJITcompileOptimizer = 0x4000,

        /// <summary>
        /// Specifies that just-in-time (JIT) compiler tracking is enabled for the assembly.
        /// </summary>
        EnableJITcompileTracking = 0x8000,

        /// <summary>
        /// Specifies that the assembly can be retargeted at runtime to an assembly from a different publisher.
        /// </summary>
        Retargetable = 0x100
	}
}

