// Copyright (C) 2014 dot42
//
// Original filename: EventWaitHandle.cs
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
using System.IO;

namespace System.Threading
{
	public class EventWaitHandle : WaitHandle
	{
	    private Java.Util.Concurrent.Semaphore semaphore;

		static bool IsManualReset (EventResetMode mode)
		{
			if ((mode < EventResetMode.AutoReset) || (mode > EventResetMode.ManualReset))
				throw new ArgumentException ("mode");
			return (mode == EventResetMode.ManualReset);
		}
		
		public EventWaitHandle (bool initialState, EventResetMode mode)
		{
			bool created;
			bool manual = IsManualReset (mode);
            semaphore = CreateSemaphore(manual, initialState, null, out created);
		}
		
        /*
		public EventWaitHandle (bool initialState, EventResetMode mode,string name)
		{
			bool created;
			bool manual = IsManualReset (mode);
            semaphore = CreateSemaphore(manual, initialState, name, out created);
		}
		
		public EventWaitHandle (bool initialState, EventResetMode mode, string name, out bool createdNew)
		{
			bool manual = IsManualReset (mode);
            semaphore = CreateSemaphore(manual, initialState, name, out createdNew);
		}
        */

        private Java.Util.Concurrent.Semaphore CreateSemaphore(bool manual, bool initialState, string name, out bool createdNew)
        {
            if (!manual) throw new NotImplementedException("System.Threading.EventResetMode.AutoReset is not implemented");

            var result = new Java.Util.Concurrent.Semaphore(1);
            if (initialState) result.Acquire();

            createdNew = true;

            return result;
        }

        /// <summary>
        /// Sets the state of the event to nonsignaled, causing threads to block.
        /// </summary>
        /// <returns>true if the operation succeeds; otherwise, false.</returns>
		public bool Reset ()
		{
			/* This needs locking since another thread could dispose is currenty */
			lock (this) {
				CheckDisposed ();

			    semaphore.Acquire();
			    return true;
			}
		}
		
        /// <summary>
        /// Sets the state of the event to signaled, allowing one or more waiting threads to proceed.
        /// </summary>
        /// <returns>true if the operation succeeds; otherwise, false.</returns>
		public bool Set ()
		{
			lock (this) {
				CheckDisposed ();
                
                semaphore.Release();
			    return true;
			}
		}
	}
}

