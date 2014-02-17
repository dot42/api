// Copyright (C) 2014 dot42
//
// Original filename: Instrumentation.cs
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
namespace Android.App
{
	partial class Instrumentation
	{
        /// <summary>
        /// <para>Execute a call on the application's main thread, blocking until it is complete. Useful for doing things that are not thread-safe, such as looking at or modifying the view hierarchy.</para><para></para>        
        /// </summary>
        /// <java-name>
        /// runOnMainSync
        /// </java-name>
        [Dot42.DexImport("runOnMainSync", "(Ljava/lang/Runnable;)V", AccessFlags = 1, IgnoreFromJava = true)]
        public void RunOnMainSync(global::System.Action runner) /* MethodBuilder.Create */
        {
        }

        /// <summary>
        /// <para>Schedule a callback for when the application's main thread goes idle (has no more events to process).</para><para></para>        
        /// </summary>
        /// <java-name>
        /// waitForIdle
        /// </java-name>
        [Dot42.DexImport("waitForIdle", "(Ljava/lang/Runnable;)V", AccessFlags = 1, IgnoreFromJava = true)]
        public void WaitForIdle(global::System.Action recipient) 
        {
        }
    }
}

