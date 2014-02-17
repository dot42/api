// Copyright (C) 2014 dot42
//
// Original filename: TaskContinuationOptions.cs
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
    [Flags]
    public enum TaskContinuationOptions
    {
        /// <summary>
        /// Default = "Continue on any, no task options, run asynchronously" Specifies that the default behavior should be used. 
        /// Continuations, by default, will be scheduled when the antecedent task completes, regardless of the task's final TaskStatus.
        /// </summary>
        None = 0x00000,

        /// <summary>
        /// A hint to a TaskScheduler to schedule a task in as fair a manner as possible, meaning that tasks scheduled sooner will be more likely to be run sooner,
        /// and tasks scheduled later will be more likely to be run later.
        /// </summary>
        PreferFairness = 0x00001,

        /// <summary>
        /// Specifies that a task will be a long-running, course-grained operation. It provides a hint to the TaskScheduler that oversubscription may be warranted.
        /// </summary>
        LongRunning = 0x00002,

        /// <summary>
        /// Specifies that a task is attached to a parent in the task hierarchy.
        /// </summary>
        AttachedToParent = 0x00004,

        /// <summary>
        /// Specifies that an InvalidOperationException will be thrown if an attempt is made to attach a child task to the created task.
        /// </summary>
        DenyChildAttach = 8,

        /// <summary>
        /// Prevents the ambient scheduler from being seen as the current scheduler in the created task. 
        /// This means that operations like StartNew or ContinueWith that are performed in the created task will see Default as the current scheduler.
        /// </summary>
        HideScheduler = 16,

        /// <summary>
        /// In the case of continuation cancellation, prevents completion of the continuation until the antecedent has completed.
        /// </summary>
        LazyCancellation = 32,

        /// <summary>
        /// Specifies that the continuation task should not be scheduled if its antecedent ran to completion. This option is not valid for multi-task continuations.
        /// </summary>
        NotOnRanToCompletion = 0x10000,

        /// <summary>
        /// Specifies that the continuation task should not be scheduled if its antecedent threw an unhandled exception. 
        /// This option is not valid for multi-task continuations.
        /// </summary>
        NotOnFaulted = 0x20000,

        /// <summary>
        /// Specifies that the continuation task should not be scheduled if its antecedent was canceled. 
        /// This option is not valid for multi-task continuations.
        /// </summary>
        NotOnCanceled = 0x40000,

        /// <summary>
        /// Specifies that the continuation task should be scheduled only if its antecedent ran to completion. 
        /// This option is not valid for multi-task continuations.
        /// </summary>
        OnlyOnRanToCompletion = 0x60000,

        /// <summary>
        /// Specifies that the continuation task should be scheduled only if its antecedent threw an unhandled exception. 
        /// This option is not valid for multi-task continuations.
        /// </summary>
        OnlyOnFaulted = 0x50000,

        /// <summary>
        /// Specifies that the continuation task should be scheduled only if its antecedent was canceled. 
        /// This option is not valid for multi-task continuations.
        /// </summary>
        OnlyOnCanceled = 0x30000,

        /// <summary>
        /// Specifies that the continuation task should be executed synchronously. 
        /// With this option specified, the continuation will be run on the same thread that causes the antecedent task to transition into its final state. 
        /// If the antecedent is already complete when the continuation is created, the continuation will run on the thread creating the continuation. 
        /// Only very short-running continuations should be executed synchronously.
        /// </summary>
        ExecuteSynchronously = 0x80000,
    }
}

