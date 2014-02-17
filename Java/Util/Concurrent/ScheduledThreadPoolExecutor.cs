// Copyright (C) 2014 dot42
//
// Original filename: ScheduledThreadPoolExecutor.cs
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

namespace Java.Util.Concurrent
{
    [ApiEnhancementIgnoreMethods("Execute", "Submit")]
	partial class ScheduledThreadPoolExecutor
	{
        /// <summary>
        /// Creates and executes a one-shot action that becomes enabled after the given delay.
        /// </summary>
        /// <java-name>
        /// schedule
        /// </java-name>
        [Dot42.DexImport("schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sched" +
"uledFuture;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sched" +
"uledFuture<*>;", IgnoreFromJava = true)]
        public global::Java.Util.Concurrent.IScheduledFuture<object> Schedule(global::System.Action runnable, long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) 
        {
            return default(global::Java.Util.Concurrent.IScheduledFuture<object>);
        }
    
        /// <summary>
        /// Creates and executes a periodic action that becomes enabled first after the given initial delay, and subsequently with the given period; that is executions will commence after initialDelay then initialDelay+period, then initialDelay + 2 * period, and so on. If any execution of the task encounters an exception, subsequent executions are suppressed. Otherwise, the task will only terminate via cancellation or termination of the executor. If any execution of this task takes longer than its period, then subsequent executions may start late, but will not concurrently execute.
        /// </summary>
        /// <java-name>
        /// scheduleAtFixedRate
        /// </java-name>
        [Dot42.DexImport("scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
"duledFuture;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
"duledFuture<*>;", IgnoreFromJava = true)]
        public global::Java.Util.Concurrent.IScheduledFuture<object> ScheduleAtFixedRate(global::System.Action command, long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */
        {
            return default(global::Java.Util.Concurrent.IScheduledFuture<object>);
        }

        /// <summary>
        /// Creates and executes a periodic action that becomes enabled first after the given initial delay, and subsequently with the given delay between the termination of one execution and the commencement of the next. If any execution of the task encounters an exception, subsequent executions are suppressed. Otherwise, the task will only terminate via cancellation or termination of the executor.
        /// </summary>
        /// <java-name>
        /// scheduleWithFixedDelay
        /// </java-name>
        [Dot42.DexImport("scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
"duledFuture;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Sche" +
"duledFuture<*>;", IgnoreFromJava = true)]
        public global::Java.Util.Concurrent.IScheduledFuture<object> ScheduleWithFixedDelay(global::System.Action command, long initialDelay, long delay, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */
        {
            return default(global::Java.Util.Concurrent.IScheduledFuture<object>);
        }
    }
}

