// Copyright (C) 2014 dot42
//
// Original filename: TaskFactory.cs
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
using System.Linq;
using System.Text;

namespace System.Threading.Tasks
{
	public class TaskFactory
	{
        private readonly TaskScheduler scheduler;
        private TaskCreationOptions creationOptions;
        private TaskContinuationOptions continuationOptions;
        private CancellationToken cancellationToken;

	    /// <summary>
	    /// Creates a new TaskFactory
	    /// </summary>
	    public TaskFactory()
            : this(CancellationToken.None, TaskCreationOptions.None, TaskContinuationOptions.None, null)
        {

        }

        /// <summary>
        /// Creates a new TaskFactory
        /// </summary>
        public TaskFactory(CancellationToken cancellationToken)
            : this(cancellationToken, TaskCreationOptions.None, TaskContinuationOptions.None, null)
        {

        }

        /// <summary>
        /// Creates a new TaskFactory
        /// </summary>
        public TaskFactory(TaskScheduler scheduler)
            : this (CancellationToken.None, TaskCreationOptions.None, TaskContinuationOptions.None, scheduler)
        {

        }

        /// <summary>
        /// Creates a new TaskFactory
        /// </summary>
        public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions)
            : this (CancellationToken.None, creationOptions, continuationOptions, null)
        {

        }
        /// <summary>
        /// Creates a new TaskFactory
        /// </summary>
        public TaskFactory(CancellationToken cancellationToken,TaskCreationOptions creationOptions,TaskContinuationOptions continuationOptions,TaskScheduler scheduler)
	    {
            this.cancellationToken = cancellationToken;
            this.scheduler = scheduler;
            this.creationOptions = creationOptions;
            this.continuationOptions = continuationOptions;

            CheckContinuationOptions(continuationOptions);
	    }

        internal static void CheckContinuationOptions(TaskContinuationOptions continuationOptions)
        {
            if ((continuationOptions & (TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.NotOnRanToCompletion)) != 0)
                throw new ArgumentOutOfRangeException("continuationOptions");

            const TaskContinuationOptions long_running = TaskContinuationOptions.LongRunning | TaskContinuationOptions.ExecuteSynchronously;
            if ((continuationOptions & long_running) == long_running)
                throw new ArgumentOutOfRangeException("continuationOptions", "Synchronous continuations cannot be long running");
        }

        /// <summary>
        /// Gets the default cancellation token for this task factory.
        /// </summary>
        public CancellationToken CancellationToken
        {
            get
            {
                return cancellationToken;
            }
        }

        /// <summary>
        /// Gets the default task continuation options for this task factory.
        /// </summary>
        public TaskContinuationOptions ContinuationOptions
        {
            get
            {
                return continuationOptions;
            }
        }

        /// <summary>
        /// Gets the default task creation options for this task factory.
        /// </summary>
        public TaskCreationOptions CreationOptions
        {
            get
            {
                return creationOptions;
            }
        }

        /// <summary>
        /// Gets the default task scheduler for this task factory.
        /// </summary>
        public TaskScheduler Scheduler
        {
            get
            {
                return scheduler;
            }
        }

        #region StartNew for Task
        public Task StartNew(Action action)
        {
            return StartNew(action, cancellationToken, creationOptions, GetScheduler());
        }

        public Task StartNew(Action action, CancellationToken cancellationToken)
        {
            return StartNew(action, cancellationToken, creationOptions, GetScheduler());
        }

        public Task StartNew(Action action, TaskCreationOptions creationOptions)
        {
            return StartNew(action, cancellationToken, creationOptions, GetScheduler());
        }

        public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
            Task t = new Task(action, cancellationToken, creationOptions);
            if (!t.IsCompleted) t.Start(scheduler);

            return t;
        }

        public Task StartNew(Action<object> action, object state)
        {
            return StartNew(action, state, cancellationToken, creationOptions, GetScheduler());
        }

        public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken)
        {
            return StartNew(action, state, cancellationToken, creationOptions, GetScheduler());
        }

        public Task StartNew(Action<object> action, object state, TaskCreationOptions creationOptions)
        {
            return StartNew(action, state, cancellationToken, creationOptions, GetScheduler());
        }

        public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions,
                              TaskScheduler scheduler)
        {
            Task t = new Task(action, state, cancellationToken, creationOptions);
            if (!t.IsCompleted) t.Start(scheduler);

            return t;
        }
        #endregion

        #region StartNew for Task<TResult>
        public Task<TResult> StartNew<TResult>(Func<TResult> function)
        {
            return StartNew<TResult>(function, cancellationToken, creationOptions, GetScheduler());
        }

        public Task<TResult> StartNewIO<TResult>(Func<TResult> function)
        {
            return StartNew<TResult>(function, cancellationToken, creationOptions, TaskScheduler.IO);
        }

        public Task<TResult> StartNew<TResult>(Func<TResult> function, TaskCreationOptions creationOptions)
        {
            return StartNew<TResult>(function, cancellationToken, creationOptions, GetScheduler());

        }

        public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken)
        {
            return StartNew<TResult>(function, cancellationToken, creationOptions, GetScheduler());
        }

        public Task<TResult> StartNew<TResult>(Func<TResult> function,CancellationToken cancellationToken,TaskCreationOptions creationOptions,TaskScheduler scheduler)
        {
            var t = new Task<TResult>(function, cancellationToken, creationOptions);
            if (!t.IsCompleted) t.Start(scheduler);

            return t;
        }

        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state)
        {
            return StartNew<TResult>(function, state, cancellationToken, creationOptions, GetScheduler());
        }

        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken)
        {
            return StartNew<TResult>(function, state, cancellationToken, creationOptions, GetScheduler());
        }

        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
        {
            return StartNew<TResult>(function, state, cancellationToken, creationOptions, GetScheduler());
        }

        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state,CancellationToken cancellationToken,TaskCreationOptions creationOptions,TaskScheduler scheduler)
        {
            Task<TResult> t = new Task<TResult>(function, state, cancellationToken, creationOptions);
            if (!t.IsCompleted) t.Start(scheduler);

            return t;
        }
        #endregion

        internal TaskScheduler GetScheduler()
        {
            return scheduler ?? TaskScheduler.Current;
        }

	}
}

