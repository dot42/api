// Copyright (C) 2014 dot42
//
// Original filename: TaskSchedulerException.cs
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
	public class TaskSchedulerException : Exception
	{
		const string exceptionDefaultMessage = "An exception was thrown by a TaskScheduler";
	  
		public TaskSchedulerException () : base (exceptionDefaultMessage)
		{
		}

		public TaskSchedulerException (string message) : base (message)
		{
		}

		public TaskSchedulerException (Exception innerException)
			: base (exceptionDefaultMessage, innerException)
		{
		}
	
		public TaskSchedulerException (string message, Exception innerException)
			: base (message, innerException)
		{
		}
	}
}


