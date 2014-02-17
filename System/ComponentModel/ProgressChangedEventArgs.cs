// Copyright (C) 2014 dot42
//
// Original filename: ProgressChangedEventArgs.cs
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
namespace System.ComponentModel
{
	public class ProgressChangedEventArgs : EventArgs
	{
        /// <summary>
        /// Default ctor
        /// </summary>
        public ProgressChangedEventArgs(int progressPercentage, object userState)
        {
            ProgressPercentage = progressPercentage;
            UserState = userState;
        }

	    /// <summary>
        /// Gets the task progress percentage.
        /// </summary>
        public int ProgressPercentage { get; private set; }

        /// <summary>
        /// Gets a unique user state.
        /// </summary>
	    public object UserState { get; private set; }
	}
}

