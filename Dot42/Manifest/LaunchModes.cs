// Copyright (C) 2014 dot42
//
// Original filename: LaunchModes.cs
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
namespace Dot42.Manifest
{
	public enum LaunchModes
	{
        /// <summary>
        /// Default behavior.
        /// </summary>
        Standard,

        /// <summary>
        /// If an instance of the activity already exists at the top of the target task, the system routes the intent to that activity, 
        /// rather than creating a new one.
        /// </summary>
        SingleTop,

        /// <summary>
        /// If an instance of the activity already exists, the system will route the intent to that instance.
        /// Otherwise, the system creates the activity at the root of a new task and routes the intent to it.
        /// </summary>
        SingleTask,

        /// <summary>
        /// The same as <see cref="SingleTask"/>, except that the system will not launch any other activities in the task holding the instance.
        /// </summary>
        SingleInstance
	}
}

