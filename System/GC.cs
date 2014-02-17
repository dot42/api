// Copyright (C) 2014 dot42
//
// Original filename: GC.cs
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
using JSystem = Java.Lang.System;
using JRuntime = Java.Lang.Runtime;

namespace System
{
    /// <summary>
    /// Controls the garbage collector.
    /// </summary>
	public static class GC
	{
        /// <summary>
        /// Force a run of the garbase collector.
        /// </summary>
        public static void Collect()
        {
            JSystem.Gc();
        }

        /// <summary>
        /// Instruct the system not to call the finalizer of the given object.
        /// </summary>
        /// <remarks>Not implemented</remarks>
        public static void SuppressFinalize(object value)
        {
            if (value == null)
                throw new ArgumentNullException("value");
        }

        /// <summary>
        /// Retrieves the number of bytes currently allocated. 
        /// </summary>
        public static long GetTotalMemory(bool forceFullCollection)
        {
            //we cannot force, but provide hints
            if (forceFullCollection)
            {
                JSystem.RunFinalization();
                JSystem.Gc();
            }
            return JRuntime.GetRuntime().TotalMemory();
        }

	}
}

