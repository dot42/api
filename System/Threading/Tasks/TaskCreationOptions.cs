// Copyright (C) 2014 dot42
//
// Original filename: TaskCreationOptions.cs
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
    public enum TaskCreationOptions
    {
        /// <summary>
        /// Specifies that the default behavior should be used.
        /// </summary>
        None = 0x0,

        /// <summary>
        /// A hint to a TaskScheduler to schedule a task in as fair a manner as possible, meaning that tasks scheduled sooner will be more likely to be run sooner, 
        /// and tasks scheduled later will be more likely to be run later.
        /// </summary>
        PreferFairness = 0x1,

        /// <summary>
        /// Specifies that a task will be a long-running, coarse-grained operation involving fewer, larger components than fine-grained systems. 
        /// It provides a hint to the TaskScheduler that oversubscription may be warranted. 
        /// Oversubscription lets you create more threads than the available number of hardware threads.
        /// </summary>
        LongRunning = 0x2,

        /// <summary>
        /// Specifies that a task is attached to a parent in the task hierarchy. For more information, see Nested Tasks and Child Tasks.
        /// </summary>
        AttachedToParent = 0x4,

        /// <summary>
        /// Specifies that an InvalidOperationException will be thrown if an attempt is made to attach a child task to the created task.
        /// </summary>
        DenyChildAttach = 0x8,

        /// <summary>
        /// Prevents the ambient scheduler from being seen as the current scheduler in the created task. 
        /// This means that operations like StartNew or ContinueWith that are performed in the created task will see Default as the current scheduler.
        /// </summary>
        HideScheduler = 0x10
    }
}

