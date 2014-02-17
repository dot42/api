// Copyright (C) 2014 dot42
//
// Original filename: AsyncSynchronizationContext.cs
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
using System;
using System.Threading;

using Java.Util.Concurrent;
using Java.Util.Concurrent.Atomic;

namespace Dot42.Test
{
	internal class AsyncSynchronizationContext : SynchronizationContext
    {
        private AtomicInteger _operationCount = new AtomicInteger();
		private readonly AsyncOperationQueue _operations = new AsyncOperationQueue();

		public override void Send(SendOrPostCallback d, object state)
		{
			throw new InvalidOperationException("Sending to this synchronization context is not supported");
		}

		public override void Post(SendOrPostCallback d, object state)
		{
			_operations.Enqueue(new AsyncOperation(d, state));
		}

		public override void OperationStarted()
		{
		    _operationCount.IncrementAndGet();

			base.OperationStarted();
		}

		public override void OperationCompleted()
		{
			if (_operationCount.DecrementAndGet() == 0)
				_operations.MarkAsComplete();

			base.OperationCompleted();
        }

		public void WaitForPendingOperationsToComplete()
		{
			_operations.InvokeAll();
		}

		private class AsyncOperationQueue
		{
			private bool _run = true;
            private readonly ConcurrentLinkedQueue<AsyncOperation> _operations = new ConcurrentLinkedQueue<AsyncOperation>();
		    private readonly Semaphore _operationsAvailable = new Semaphore(0);

			public void Enqueue(AsyncOperation asyncOperation)
			{
				_operations.Offer(asyncOperation);
			    _operationsAvailable.Release();
			}

			public void MarkAsComplete()
			{
				_run = false;
			    _operationsAvailable.Release();
			}

			public void InvokeAll()
			{
				while (_run)
				{
					InvokePendingOperations();
					_operationsAvailable.Acquire();
				}

				InvokePendingOperations();
			}

			private void InvokePendingOperations()
			{
				while (_operations.Count > 0)
				{
					AsyncOperation operation = _operations.Poll();
					operation.Invoke();
				}
			}
		}

		private class AsyncOperation
		{
			private readonly SendOrPostCallback _action;
			private readonly object _state;

			public AsyncOperation(SendOrPostCallback action, object state)
			{
				_action = action;
				_state = state;
			}

			public void Invoke()
			{
				_action(_state);
			}
		}
    }
}
