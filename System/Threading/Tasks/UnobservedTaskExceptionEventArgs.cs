// Copyright (C) 2014 dot42
//
// Original filename: UnobservedTaskExceptionEventArgs.cs
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
    /// <summary>
    /// Provides data for the event that is raised when a faulted Task's exception goes unobserved.
    /// </summary>
	public class UnobservedTaskExceptionEventArgs : EventArgs
	{
	    private readonly AggregateException exception;
	    private bool observed;

        /// <summary>
        /// Default ctor
        /// </summary>
	    public UnobservedTaskExceptionEventArgs(AggregateException exception)
        {
            this.exception = exception;
        }

        /// <summary>
        /// Gets the unobserved exception
        /// </summary>
        public AggregateException Exception { get { return exception; } }

        /// <summary>
        /// Gets whether this exception has been marked as "observed."
        /// </summary>
        public bool Observed { get { return observed; } }

        /// <summary>
        /// Marks the Exception as "observed," thus preventing it from triggering exception escalation policy which, by default, terminates the process.
        /// </summary>
        public void SetObserved()
        {
            observed = true;
        }
	}
}

