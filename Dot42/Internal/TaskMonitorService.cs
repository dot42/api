// Copyright (C) 2014 dot42
//
// Original filename: TaskMonitorService.cs
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
using System.Threading.Tasks;
using Java.Lang;
using Java.Util.Concurrent;

namespace Dot42.Internal
{
	internal class TaskMonitorService
	{
	    private readonly ScheduledThreadPoolExecutor executor;
	    private static readonly Lazy<TaskMonitorService> service = new Lazy<TaskMonitorService>(()=>new TaskMonitorService());

        /// <summary>
        /// Default ctor
        /// </summary>
        private TaskMonitorService()
        {
            executor = new ScheduledThreadPoolExecutor(1);
        }

        /// <summary>
        /// Gets the single instance.
        /// </summary>
        internal static TaskMonitorService GetService()
        {
            return service.Value;
        }

        /// <summary>
        /// Finish the given task completion source after a given delay.
        /// </summary>
        internal IScheduledFuture<object> Delay(long millis, TaskCompletionSource<object> source)
        {
            var runnable = new DelayRunner(source);
            return executor.Schedule(runnable, millis, TimeUnit.MILLISECONDS);
        }

        internal IScheduledFuture<object> Delay(long millis, IRunnable runnable)
        {
            return executor.Schedule(runnable, millis, TimeUnit.MILLISECONDS);
        }

        internal IScheduledFuture<object> Delay(long millis, Action runnable)
        {
            return executor.Schedule(runnable, millis, TimeUnit.MILLISECONDS);
        }

        /// <summary>
        /// try to remove a IRunnable task if present, otherwise ignore.
        /// </summary>
        /// <param name="runnable"></param>
        internal void Remove(IRunnable runnable)
        {
            try
            {
                executor.Remove(runnable);
            }
            catch
            {
                //ignore
            }
        }

        /// <summary>
        /// Helper for <see cref="Delay"/>.
        /// </summary>
        private class DelayRunner : IRunnable
        {
            private readonly TaskCompletionSource<object> source;

            public DelayRunner(TaskCompletionSource<object> source)
            {
                this.source = source;
            }

            public void Run()
            {
                source.SetResult(null);
            }
        }
	}
}

