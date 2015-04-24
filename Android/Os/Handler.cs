// Copyright (C) 2014 dot42
//
// Original filename: Handler.cs
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
using System;
using Dot42.Internal.Threading;

namespace Android.OS
{
	partial class Handler
	{
        /// <summary>
        /// Delegate based handler.
        /// </summary>
        public Handler(Func<Message, bool> handler)
            : this(new HandlerFuncCallback(handler))
        {            
        }

        /// <summary>
        /// <para>Causes the Action r to be added to the message queue. The action will be run on the thread to which this handler is attached.</para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>Returns true if the Action was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. </para>
        /// </returns>
        /// <java-name>
        /// post
        /// </java-name>
        [Dot42.DexImport("post", "(Ljava/lang/Runnable;)Z", AccessFlags = 17, IgnoreFromJava = true)]
        public bool Post(global::System.Action r) 
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Causes the Action r to be added to the message queue, to be run at a specific time given by <b>uptimeMillis</b>. <b>The time-base is android.os.SystemClock#uptimeMillis.</b> The action will be run on the thread to which this handler is attached.</para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>Returns true if the Action was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. Note that a result of true does not mean the action will be processed  if the looper is quit before the delivery time of the message occurs then the message will be dropped. </para>
        /// </returns>
        /// <java-name>
        /// postAtTime
        /// </java-name>
        [Dot42.DexImport("postAtTime", "(Ljava/lang/Runnable;J)Z", AccessFlags = 17, IgnoreFromJava = true)]
        public bool PostAtTime(global::System.Action r, long uptimeMillis) 
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Causes the Action r to be added to the message queue, to be run at a specific time given by <b>uptimeMillis</b>. <b>The time-base is android.os.SystemClock#uptimeMillis.</b> The action will be run on the thread to which this handler is attached.</para><para><para>android.os.SystemClock::uptimeMillis </para></para>        
        /// </summary>
        /// <returns>
        /// <para>Returns true if the Action was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. Note that a result of true does not mean the action will be processed  if the looper is quit before the delivery time of the message occurs then the message will be dropped.</para>
        /// </returns>
        /// <java-name>
        /// postAtTime
        /// </java-name>
        [Dot42.DexImport("postAtTime", "(Ljava/lang/Runnable;Ljava/lang/Object;J)Z", AccessFlags = 17, IgnoreFromJava = true)]
        public bool PostAtTime(global::System.Action r, object token, long uptimeMillis) 
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Causes the Action r to be added to the message queue, to be run after the specified amount of time elapses. The action will be run on the thread to which this handler is attached.</para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>Returns true if the Action was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. Note that a result of true does not mean the Action will be processed  if the looper is quit before the delivery time of the message occurs then the message will be dropped. </para>
        /// </returns>
        /// <java-name>
        /// postDelayed
        /// </java-name>
        [Dot42.DexImport("postDelayed", "(Ljava/lang/Runnable;J)Z", AccessFlags = 17, IgnoreFromJava = true)]
        public bool PostDelayed(global::System.Action r, long delayMillis) 
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Posts a message to an object. Causes the Action r to executed on the next iteration through the message queue. The action will be run on the thread to which this handler is attached. <b>This method is only for use in very special circumstances  it can easily starve the message queue, cause ordering problems, or have other unexpected side-effects.</b></para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>Returns true if the message was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. </para>
        /// </returns>
        /// <java-name>
        /// postAtFrontOfQueue
        /// </java-name>
        [Dot42.DexImport("postAtFrontOfQueue", "(Ljava/lang/Runnable;)Z", AccessFlags = 17, IgnoreFromJava = true)]
        public bool PostAtFrontOfQueue(global::System.Action r) 
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Remove any pending posts of Action r that are in the message queue. </para>        
        /// </summary>
        /// <java-name>
        /// removeCallbacks
        /// </java-name>
        [Dot42.DexImport("removeCallbacks", "(Ljava/lang/Runnable;)V", AccessFlags = 17, IgnoreFromJava = true)]
        public void RemoveCallbacks(global::System.Action r) 
        {
        }

        /// <summary>
        /// <para>Remove any pending posts of Action <b>r</b> with Object <b>token</b> that are in the message queue. If <b>token</b> is null, all callbacks will be removed. </para>        
        /// </summary>
        /// <java-name>
        /// removeCallbacks
        /// </java-name>
        [Dot42.DexImport("removeCallbacks", "(Ljava/lang/Runnable;Ljava/lang/Object;)V", AccessFlags = 17, IgnoreFromJava = true)]
        public void RemoveCallbacks(global::System.Action r, object token) 
        {
        }
    }
}

