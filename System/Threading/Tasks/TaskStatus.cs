// Copyright (C) 2014 dot42
//
// Original filename: TaskStatus.cs
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
namespace System.Threading.Tasks
{
	public enum TaskStatus
	{
        /// <summary>
        /// The task has been initialized but has not yet been scheduled.
        /// </summary>
        Created,

        /// <summary>
        /// The task is waiting to be activated and scheduled internally by the .NET Framework infrastructure.
        /// </summary>
        WaitingForActivation,

        /// <summary>
        /// The task has been scheduled for execution but has not yet begun executing.
        /// </summary>
        WaitingToRun,

        /// <summary>
        /// The task is running but has not yet completed.
        /// </summary>
        Running,

        /// <summary>
        /// The task has finished executing and is implicitly waiting for attached child tasks to complete.
        /// </summary>
        WaitingForChildrenToComplete,

        /// <summary>
        /// The task completed execution successfully.
        /// </summary>
        RanToCompletion,

        /// <summary>
        /// The task acknowledged cancellation by throwing an OperationCanceledException with its own CancellationToken while the token was in signaled state, 
        /// or the task's CancellationToken was already signaled before the task started executing.
        /// </summary>
        Canceled,

        /// <summary>
        /// The task completed due to an unhandled exception.
        /// </summary>
        Faulted
	}
}

