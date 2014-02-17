// Copyright (C) 2014 dot42
//
// Original filename: EventResetMode.cs
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
namespace System.Threading
{
    /// <summary>
    /// Indicates whether an EventWaitHandle is reset automatically or manually after receiving a signal.
    /// </summary>
	public enum EventResetMode
	{
        /// <summary>
        /// When signaled, the EventWaitHandle resets automatically after releasing a single thread. 
        /// If no threads are waiting, the EventWaitHandle remains signaled until a thread blocks, and resets after releasing the thread. 
        /// </summary>
		AutoReset = 0,
        /// <summary>
        /// When signaled, the EventWaitHandle releases all waiting threads and remains signaled until it is manually reset. 
        /// </summary>
		ManualReset = 1,
	}
}

