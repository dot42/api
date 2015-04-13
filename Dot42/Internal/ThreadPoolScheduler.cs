// Copyright (C) 2014 dot42
//
// Original filename: ThreadPoolScheduler.cs
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
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Java.IO;
using Java.Lang;
using Java.Util.Concurrent;
using Java.Util.Regex;
using Exception = System.Exception;

namespace Dot42.Internal
{
    /// <summary>
    /// Task scheduler using the ThreadPoolExecutor.
    /// </summary>
    sealed class ThreadPoolScheduler : TaskScheduler
    {
        private static readonly int numCores = getNumCores();
        private readonly ThreadPoolExecutor threadPool;
        private readonly int lowMaxPoolSize;
        private readonly int highMaxPoolSize;

        /// <summary>
        /// Default ctor
        /// </summary>
        internal ThreadPoolScheduler(bool isIOScheduler)
        {
            lowMaxPoolSize = Math.Max(1, numCores - 1);
            highMaxPoolSize = isIOScheduler ? lowMaxPoolSize * 2 : lowMaxPoolSize * 3;
            var queue = new RunnableQueue();
            threadPool = new ThreadPoolExecutor(lowMaxPoolSize, lowMaxPoolSize, 60L, TimeUnit.SECONDS, queue);
            queue.Executor = threadPool;
        }

        private class CpuFilter : IFileFilter
        {
            public bool Accept(File pathname)
            {
                // Check if filename is "cpu", followed by a digit number
                return Pattern.Matches("cpu[0-9]+", pathname.Name);
            }
        }

        private static int getNumCores()
        {
            try
            {
                //Get directory containing CPU info
                var dir = new File("/sys/devices/system/cpu/");

                //Filter to only list the devices we care about
                var files = dir.ListFiles(new CpuFilter());

                //Return the number of cores (virtual CPU devices)
                return files.Length;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        /// <summary>
        /// Runnable for a specific task.
        /// </summary>
        private class TaskRunner : IRunnable
        {
            private readonly Task task;

            public TaskRunner(Task task)
            {
                this.task = task;
            }

            public void Run()
            {
                task.Execute();
            }
        }

        /// <summary>
        /// Queues a Task to the scheduler.
        /// </summary>
        protected internal override void QueueTask(Task task)
        {
            if ((task.CreationOptions & TaskCreationOptions.LongRunning) != 0)
            {
                var thread = new Thread(new TaskRunner(task)) { Name = "Task worker thread" };
                thread.Start();
            }
            else
            {
                threadPool.Execute(new TaskRunner(task));
            }
        }

        /// <summary>
        /// For debugger support only, generates an enumerable of Task instances currently queued to the scheduler waiting to be executed.
        /// </summary>
        protected override IEnumerable<Task> GetScheduledTasks()
        {
            throw new NotImplementedException("System.Threading.Tasks.ThreadPoolScheduler.GetScheduledTasks");
        }

        /// <summary>
        /// Attempts to dequeue a Task that was previously queued to this scheduler.
        /// </summary>
        protected internal override bool TryDequeue(Task task)
        {
            return false;
        }

        /// <summary>
        /// Determines whether the provided Task can be executed synchronously in this call, and if it can, executes it.
        /// </summary>
        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            if (taskWasPreviouslyQueued && !TryDequeue(task))
                return false;

            return TryExecuteTask(task);
        }

        private sealed class RunnableQueue : LinkedBlockingQueue<IRunnable>
        {
            internal ThreadPoolExecutor Executor;

            public override bool Offer(IRunnable e)
            {
                /*var x = Executor;
                if (x.GetActiveCount() < x.GetMaximumPoolSize())
                    return false;*/
                return base.Offer(e);
            }
        }
    }
}

