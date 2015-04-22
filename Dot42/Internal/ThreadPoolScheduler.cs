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
using Dot42.Internal.Threading;
using Java.Lang;

namespace Dot42.Internal
{
    /// <summary>
    /// Task scheduler using the ThreadPoolExecutor.
    /// </summary>
    sealed class ThreadPoolScheduler : TaskScheduler
    {
        private readonly ThreadPoolImpl _threadPool;

        /// <summary>
        /// Default ctor
        /// </summary>
        internal ThreadPoolScheduler(bool isIOScheduler)
        {
            // TODO: Think about why the IO scheduler in the original code would only ever
            //       have cores-1 threads. Does this makes sense? The current code mimics this
            //       behavoir. I'm not sure what the intention of the IO scheduler 
            //       is in the first place, but it seems to be only used in WebClient when 
            //       processing HTTP requests..
            
            if (!isIOScheduler)
                _threadPool = ThreadPool.Default;
            else
            {
                var numCores = ThreadPoolImpl.GetNumCores();
                var coreThreads = Math.Max(1, numCores - 1);
                _threadPool = new ThreadPoolImpl(coreThreads, coreThreads);    
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
                _threadPool.QueueUserWorkItem(new TaskRunner(task));
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
    }
}

