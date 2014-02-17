// Copyright (C) 2014 dot42
//
// Original filename: ConfiguredTaskAwaitable_T.cs
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
//
// ConfiguredTaskAwaitable_T.cs
//
// Authors:
//	Marek Safar  <marek.safar@gmail.com>
//
// Copyright (C) 2011 Xamarin, Inc (http://www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Threading.Tasks;
using System.Runtime.ExceptionServices;

using Dot42.Internal;
using Dot42.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	public struct ConfiguredTaskAwaitable<TResult>
	{
        public struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, IAsyncSetThisSetter
		{
			readonly Task<TResult> task;
			readonly bool continueOnSourceContext;
		    readonly InstanceReference instanceReference;
            private IAsyncSetThis thisSetter;

            internal ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnSourceContext, InstanceReference instanceReference)
			{
				this.task = task;
				this.continueOnSourceContext = continueOnSourceContext;
                this.instanceReference = instanceReference;
                this.thisSetter = null;
			}

			public bool IsCompleted {
				get {
					return task.IsCompleted;
				}
			}

			public TResult GetResult ()
			{
				if (task.Status != TaskStatus.RanToCompletion)
					ExceptionDispatchInfo.Capture (TaskAwaiter.HandleUnexpectedTaskResult (task)).Throw ();

				return task.Result;
			}

            public void OnCompleted(Action continuation)
			{
				if (continuation == null)
					throw new ArgumentNullException ("continuation");

                TaskAwaiter.HandleOnCompleted(task, continuation, continueOnSourceContext, instanceReference, thisSetter);
			}

            public void UnsafeOnCompleted(Action continuation)
			{
				if (continuation == null)
					throw new ArgumentNullException ("continuation");

                TaskAwaiter.HandleOnCompleted(task, continuation, continueOnSourceContext, instanceReference, thisSetter);
			}

            void IAsyncSetThisSetter.SetThisSetter(IAsyncSetThis thisSetter)
            {
                this.thisSetter = thisSetter;
            }
		}
		
		readonly ConfiguredTaskAwaiter awaiter;

        internal ConfiguredTaskAwaitable(Task<TResult> task, bool continueOnSourceContext, InstanceReference instanceReference)
		{
            awaiter = new ConfiguredTaskAwaiter(task, continueOnSourceContext, instanceReference);
		}
		
		public ConfiguredTaskAwaiter GetAwaiter()
		{
			return awaiter;
		}
	}
}


