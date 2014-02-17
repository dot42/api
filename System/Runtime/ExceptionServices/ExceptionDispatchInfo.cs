// Copyright (C) 2014 dot42
//
// Original filename: ExceptionDispatchInfo.cs
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
using System.Diagnostics;

namespace System.Runtime.ExceptionServices
{
	public sealed class ExceptionDispatchInfo
	{
		readonly Exception exception;

		private ExceptionDispatchInfo (Exception source)
		{
			this.exception = source;
		}

		public Exception SourceException {
			get {
				return exception;
			}
		}

		public static ExceptionDispatchInfo Capture (Exception source)
		{
			if (source == null)
				throw new ArgumentNullException ("source");

			return new ExceptionDispatchInfo (source);
		}

		public void Throw ()
		{
            //the outer exception has the current stacktrace, the inner the original.
		    throw exception;
			//throw new Exception(exception);
		}
	}
}


