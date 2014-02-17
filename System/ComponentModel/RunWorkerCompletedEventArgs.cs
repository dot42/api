// Copyright (C) 2014 dot42
//
// Original filename: RunWorkerCompletedEventArgs.cs
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
	public class RunWorkerCompletedEventArgs : EventArgs
	{
	    public RunWorkerCompletedEventArgs(object result, Exception error, bool cancelled)
	    {
	        Result = result;
	        Error = error;
	        Cancelled = cancelled;
	    }

        public object Result { get; private set; }
        public Exception Error { get; private set; }
        public bool Cancelled { get; private set; }
    }
}

