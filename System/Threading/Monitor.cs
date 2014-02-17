// Copyright (C) 2014 dot42
//
// Original filename: Monitor.cs
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
	public static class Monitor
	{
	    /// <summary>
	    /// Acquire an exclusive lock on the given object.
	    /// </summary>
	    [DexNative]
        public static extern void Enter(object obj);

	    /// <summary>
	    /// Release an exclusive lock on the given object.
	    /// </summary>
        [DexNative]
        public static extern void Exit(object obj);

	    /// <summary>
	    /// Indicates whether the current thread has a monitor lock on the specified object.
	    /// </summary>
        [DexImport("holdsLock", "(Ljava/lang/Object;)Z")]
        public static bool IsEntered(object obj)
	    {
	        return default(bool);
	    }

	    /// <summary>
        /// Causes a thread which is waiting on this object's monitor (by means of calling one of the wait() methods) to be woken up.
        /// </summary>
        public static void Pulse(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException();
            obj.Notify();
        }

        /// <summary>
        /// Causes all threads which are waiting on this object's monitor (by means of calling one of the wait() methods) to be woken up.
        /// </summary>
        public static void PulseAll(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException();
            obj.NotifyAll();
        }

        /// <summary>
        /// Causes the calling thread to wait until another thread calls the notify() or notifyAll() method of this object.
        /// </summary>
        public static void Wait(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException();
            obj.JavaWait();            
        }

        /// <summary>
        /// Causes the calling thread to wait until another thread calls the notify() or notifyAll() method of this object or until the specified timeout expires. 
        /// This method can only be invoked by a thread which owns this object's monitor; see notify() on how a thread can become the owner of a monitor.
        /// </summary>
        /// <returns>True if the lock was reacquired before the specified time elapsed; 
        /// false if the lock was reacquired after the specified time elapsed. The method does not return until the lock is reacquired.</returns>
        public static bool Wait(object obj, int millisecondsTimeout)
        {
            if (obj == null)
                throw new ArgumentNullException();
            var start = Java.Lang.System.CurrentTimeMillis();
            obj.JavaWait(millisecondsTimeout);
            var end = Java.Lang.System.CurrentTimeMillis();
            var elapsed = end - start;
            return (elapsed < millisecondsTimeout);
        }

        /// <summary>
        /// Causes the calling thread to wait until another thread calls the notify() or notifyAll() method of this object or until the specified timeout expires. 
        /// This method can only be invoked by a thread which owns this object's monitor; see notify() on how a thread can become the owner of a monitor.
        /// </summary>
        public static bool Wait(object obj, TimeSpan timeout)
        {
            return Wait(obj, (int) timeout.TotalMilliseconds);
        }
    }
}

