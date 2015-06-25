// Copyright (C) 2014 dot42
//
// Original filename: TaskScheduler.cs
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
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Dot42.Internal;
using Java.Util.Concurrent.Atomic;

namespace System.Threading.Tasks
{
    /// <summary>
    /// This class handles the low-level work of queuing tasks onto threads.
    /// </summary>
    [SuppressMessage("dot42", "InterlockedFallback", Justification="due to static events")]
	public abstract class TaskScheduler
	{
	    private readonly int id;
	    private static readonly AtomicInteger lastId = new AtomicInteger(1);

        static readonly TaskScheduler defaultScheduler = new ThreadPoolScheduler(false);
        static readonly TaskScheduler ioScheduler = new ThreadPoolScheduler(true);

        //[ThreadStatic]
        static readonly Java.Lang.ThreadLocal<TaskScheduler> currentScheduler = new Java.Lang.ThreadLocal<TaskScheduler>();

        /// <summary>
        /// Gets the default TaskScheduler instance that is provided by the .NET Framework.
        /// </summary>
        public static TaskScheduler Default
        {
            get
            {
                return defaultScheduler;
            }
        }

        /// <summary>
        /// Gets the scheduler used for IO operations.
        /// </summary>
        internal static TaskScheduler IO { get { return ioScheduler; } }

        /// <summary>
        /// Gets the TaskScheduler associated with the currently executing task.
        /// </summary>
        public static TaskScheduler Current
        {
            get
            {
                var current = currentScheduler.Get();
                if (current != null)
                    return current;

                return defaultScheduler;
            }
            internal set
            {
                currentScheduler.Set(value);
            }
        }

        /// <summary>
        /// Occurs when a faulted task's unobserved exception is about to trigger exception escalation policy, which, by default, would terminate the process.
        /// </summary>
        public static event EventHandler<UnobservedTaskExceptionEventArgs> UnobservedTaskException;

        /// <summary>
        /// Default ctor
        /// </summary>
        protected TaskScheduler()
        {
            id = lastId.GetAndIncrement();
        }

	    /// <summary>
	    /// Gets the unique ID for this scheduler.
	    /// </summary>
        public int Id { get { return id; } }

        /// <summary>
        /// Indicates the maximum concurrency level this TaskScheduler is able to support.
        /// </summary>
        public virtual int MaximumConcurrencyLevel { get { return int.MaxValue; } }

        /// <summary>
        /// For debugger support only, generates an enumerable of Task instances currently queued to the scheduler waiting to be executed.
        /// </summary>
        protected abstract IEnumerable<Task> GetScheduledTasks();

        /// <summary>
        /// Queues a Task to the scheduler.
        /// </summary>
        protected internal abstract void QueueTask(Task task);

        /// <summary>
        /// Attempts to dequeue a Task that was previously queued to this scheduler.
        /// </summary>
        protected internal virtual bool TryDequeue(Task task)
        {
            // Override me
            return false;
        }

        /// <summary>
        /// Attempts to execute the provided Task on this scheduler.
        /// </summary>
        protected bool TryExecuteTask(Task task)
        {
            if (task.IsCompleted)
                return false;

            if (task.Status == TaskStatus.WaitingToRun)
            {
                task.Execute();
                //if (task.WaitOnChildren())
                    task.Wait();

                return true;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the provided Task can be executed synchronously in this call, and if it can, executes it.
        /// </summary>
        protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

        /// <summary>
        /// Fire an UnobservedTaskException event.
        /// </summary>
        internal static void OnUnobservedTaskException(AggregateException ex)
        {
            var evt = UnobservedTaskException;
            if (evt != null)
            {
                evt(null, new UnobservedTaskExceptionEventArgs(ex));
            }
        }

        internal bool RunInline(Task task, bool taskWasPreviouslyQueued)
        {
            if (!TryExecuteTaskInline(task, taskWasPreviouslyQueued))
                return false;

            if (!task.IsCompleted)
                throw new InvalidOperationException("The TryExecuteTaskInline call to the underlying scheduler succeeded, but the task body was not invoked");

            return true;
        }

        internal static UnobservedTaskExceptionEventArgs FireUnobservedEvent(Task task, AggregateException e)
        {
            UnobservedTaskExceptionEventArgs args = new UnobservedTaskExceptionEventArgs(e);

            EventHandler<UnobservedTaskExceptionEventArgs> temp = UnobservedTaskException;
            if (temp == null)
                return args;

            temp(task, args);

            return args;
        }
	}
}

