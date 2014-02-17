// Copyright (C) 2014 dot42
//
// Original filename: TaskCompletionQueue.cs
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
// TaskCompletionQueue.cs
//
// Authors:
//    Jérémie Laval <jeremie dot laval at xamarin dot com>
//
// Copyright 2011 Xamarin Inc (http://www.xamarin.com).
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//


using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Concurrent;
using Java.Util.Concurrent;

namespace System.Threading.Tasks
{
	internal class TaskCompletionQueue<TCompletion> where TCompletion : class
	{
		TCompletion single;
        ConcurrentLinkedQueue<TCompletion> completed; 

		public void Add (TCompletion continuation)
		{
		    if (single == null)
		    {
		        single = continuation;
		        return;
		    }

            if (completed == null)
            {
                completed = new ConcurrentLinkedQueue<TCompletion>();
            }

		    completed.Add (continuation);
		}

		public bool Remove (TCompletion continuation)
		{
			TCompletion temp = single;
			if (temp != null && temp == continuation)
			{
			    single = null;
			    return true;
			}
				
			if (completed != null) return completed.Remove (continuation);
			return false;
		}

		public bool HasElements {
			get {
				return single != null || (completed != null && completed.Count != 0);
			}
		}

		public bool TryGetNextCompletion (out TCompletion continuation)
		{
			continuation = null;

		    if (single != null)
		    {
		        continuation = single;
		        single = null;
		    }
		    else
		    {
                if (completed != null)
                {
                    continuation = completed.Poll();
                }
		    }

		    return continuation != null;
		}
	}
}


