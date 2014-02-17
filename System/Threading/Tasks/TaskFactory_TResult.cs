// Copyright (C) 2014 dot42
//
// Original filename: TaskFactory_TResult.cs
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
    //[HostProtectionAttribute(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public class TaskFactory<TResult> 
	{
        private readonly TaskFactory innerTaskFactory;

        public TaskFactory()
            : this(CancellationToken.None)
        {
        }

        public TaskFactory(TaskScheduler scheduler)
            : this(CancellationToken.None, TaskCreationOptions.None, TaskContinuationOptions.None, scheduler)
        {
        }

        public TaskFactory(CancellationToken cancellationToken)
            : this(cancellationToken, TaskCreationOptions.None, TaskContinuationOptions.None, null)
        {
        }

        public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions)
            : this(CancellationToken.None, creationOptions, continuationOptions, null)
        {
        }

        public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
            TaskFactory.CheckContinuationOptions(continuationOptions);

            this.innerTaskFactory = new TaskFactory(cancellationToken, creationOptions, continuationOptions, scheduler);
        }

        /// <summary>
        /// Gets the default cancellation token for this task factory.
        /// </summary>
        public CancellationToken CancellationToken
        {
            get
            {
                return innerTaskFactory.CancellationToken;
            }
        }

        /// <summary>
        /// Gets the default task continuation options for this task factory.
        /// </summary>
        public TaskContinuationOptions ContinuationOptions
        {
            get
            {
                return innerTaskFactory.ContinuationOptions;
            }
        }

        /// <summary>
        /// Gets the default task creation options for this task factory.
        /// </summary>
        public TaskCreationOptions CreationOptions
        {
            get
            {
                return innerTaskFactory.CreationOptions;
            }
        }

        /// <summary>
        /// Gets the default task scheduler for this task factory.
        /// </summary>
        public TaskScheduler Scheduler
        {
            get
            {
                return innerTaskFactory.Scheduler;
            }
        }

        #region StartNew for Task<TResult>
        public Task<TResult> StartNew(Func<TResult> function)
        {
            return StartNew(function, CancellationToken, CreationOptions, GetScheduler());
        }

        public Task<TResult> StartNew(Func<TResult> function, TaskCreationOptions creationOptions)
        {
            return StartNew(function, CancellationToken, creationOptions, GetScheduler());
        }

        public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken)
        {
            return StartNew(function, cancellationToken, CreationOptions, GetScheduler());
        }

        public Task<TResult> StartNew(Func<TResult> function,
                                       CancellationToken cancellationToken,
                                       TaskCreationOptions creationOptions,
                                       TaskScheduler scheduler)
        {
            return StartNew((o) => function(), null, cancellationToken, creationOptions, scheduler);
        }

        public Task<TResult> StartNew(Func<object, TResult> function, object state)
        {
            return StartNew(function, state, CancellationToken, CreationOptions, GetScheduler());
        }

        public Task<TResult> StartNew(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
        {
            return StartNew(function, state, CancellationToken, creationOptions, GetScheduler());
        }

        public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken)
        {
            return StartNew(function, state, cancellationToken, CreationOptions, GetScheduler());
        }

        public Task<TResult> StartNew(Func<object, TResult> function, object state,
                                       CancellationToken cancellationToken,
                                       TaskCreationOptions creationOptions,
                                       TaskScheduler scheduler)
        {
            return innerTaskFactory.StartNew<TResult>(function, state, cancellationToken, creationOptions, scheduler);
        }
        #endregion

        private TaskScheduler GetScheduler()
        {
            return innerTaskFactory.GetScheduler();
        }


	}
}

