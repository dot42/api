// Copyright (C) 2014 dot42
//
// Original filename: Thread.cs
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

namespace System.Threading
{
    [ApiEnhancementIgnoreMethods(".ctor")] // Handled differently
    partial class Thread
	{
        /// <summary>
        /// Create a new thread which will start with the given delegate.
        /// </summary>
        public Thread(ThreadStart run)
            : this(new ThreadStartRunnable(run))
        {            
        }

        /// <summary>
        /// Gets a unique identifier for this thread.
        /// </summary>
	    public int ManagedThreadId
	    {
            get { return (int) this.GetId(); }
	    }

        /// <summary>
        /// Causes the thread which sent this message to sleep for the given interval of time (given in milliseconds). The precision is not guaranteed - the 
        /// Thread may sleep more or less than requested.
        /// </summary>
        public static void Sleep(int millisecondsTimeout)
        {
            Sleep((long) millisecondsTimeout);
        }

        [Obsolete("check if the implementation works actually as expected")]
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public static void MemoryBarrier()
        {
            // hopefully doesn't get optimized away...
        }
	}
}

