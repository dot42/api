//
// TaskContinuation.cs
//
// Authors:
//    Jérémie Laval <jeremie dot laval at xamarin dot com>
//    Marek Safar  <marek.safar@gmail.com>
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

using System.Collections.Generic;
using System.Linq;
using Dot42;
using Java.Util.Concurrent;

using Dot42.Internal;
using Dot42.Threading.Tasks;

namespace System.Threading.Tasks
{
    interface IWaitable
    {
        bool Wait(int millisecondsTimeout, CancellationToken cancellationToken);
    }

	interface IContinuation
	{
        void Execute(Task completedTask);
	}

	class TaskContinuation : IContinuation
	{
		readonly Task task;
		readonly TaskContinuationOptions continuationOptions;

		public TaskContinuation (Task task, TaskContinuationOptions continuationOptions)
		{
			this.task = task;
			this.continuationOptions = continuationOptions;
		}

		bool ContinuationStatusCheck (TaskContinuationOptions kind)
		{
			if (kind == TaskContinuationOptions.None)
				return true;

			int kindCode = (int) kind;
			//var status = task.ContinuationAncestor.Status;
		    var status = task.Status;

			if (kindCode >= ((int) TaskContinuationOptions.NotOnRanToCompletion)) {
				// Remove other options
				kind &= ~(TaskContinuationOptions.PreferFairness
						  | TaskContinuationOptions.LongRunning
						  | TaskContinuationOptions.AttachedToParent
						  | TaskContinuationOptions.ExecuteSynchronously);

				if (status == TaskStatus.Canceled) {
					if (kind == TaskContinuationOptions.NotOnCanceled)
						return false;
					if (kind == TaskContinuationOptions.OnlyOnFaulted)
						return false;
					if (kind == TaskContinuationOptions.OnlyOnRanToCompletion)
						return false;
				} else if (status == TaskStatus.Faulted) {
					if (kind == TaskContinuationOptions.NotOnFaulted)
						return false;
					if (kind == TaskContinuationOptions.OnlyOnCanceled)
						return false;
					if (kind == TaskContinuationOptions.OnlyOnRanToCompletion)
						return false;
				} else if (status == TaskStatus.RanToCompletion) {
					if (kind == TaskContinuationOptions.NotOnRanToCompletion)
						return false;
					if (kind == TaskContinuationOptions.OnlyOnFaulted)
						return false;
					if (kind == TaskContinuationOptions.OnlyOnCanceled)
						return false;
				}
			}

			return true;
		}

        public void Execute(Task completedTask)
		{
			if (!ContinuationStatusCheck (continuationOptions)) {
				task.CancelReal ();
				task.Dispose ();
				return;
			}

			// The task may have been canceled externally
			if (task.IsCompleted)
				return;

			if ((continuationOptions & TaskContinuationOptions.ExecuteSynchronously) != 0)
				task.RunSynchronouslyCore (task.scheduler);
			else
				task.Schedule ();
		}
	}

	class ActionContinuation : IContinuation
	{
		readonly Action action;

		public ActionContinuation (Action action)
		{
			this.action = action;
		}

        public void Execute(Task completedTask)
		{
			action ();
		}
	}

	class SynchronizationContextContinuation : IContinuation
	{
		readonly Action action;
		readonly SynchronizationContext ctx;
        readonly InstanceReference instanceReference;
        readonly IAsyncSetThis thisSetter;

        public SynchronizationContextContinuation(Action action, SynchronizationContext ctx, InstanceReference instanceReference, IAsyncSetThis thisSetter)
		{
			this.action = action;
			this.ctx = ctx;
            this.instanceReference = instanceReference;
            this.thisSetter = thisSetter;
		}

        public void Execute(Task completedTask)
        {
            var activityCtx = ctx as InstanceSynchronizationContext;
            if (activityCtx != null && instanceReference != null)
            {
                var newInstance = InstanceSynchronizationContext.GetRegisteredActivity(instanceReference);
                if (newInstance == null)
                    return; //no need to handle remaining code (including the ctx.Post)

                if (thisSetter != null && newInstance != instanceReference.Instance)
                {
                    thisSetter.SetThis(newInstance);
                }
            }

			ctx.Post (l => ((Action) l) (), action);
		}
	}

    
	sealed class WhenAllContinuation : IContinuation
	{
        readonly TaskCompletionSource<object> owner;
	    private int counter;
	    private bool canceled;
        private ConcurrentLinkedQueue<Exception> exceptions = null;

		public WhenAllContinuation (TaskCompletionSource<object> owner, IList<Task> tasks)
		{
			this.owner = owner;
            
            tasks = tasks.Distinct().ToList();
			counter = tasks.Count;
			
            foreach (var t in tasks)
                t.ContinueWith(this);
		}

        public void Execute(Task completedTask)
        {
            completedTask.RemoveContinuation(this);

            if (completedTask.IsFaulted)
            {
                if (exceptions == null)
                    Interlocked.CompareExchange(ref exceptions, new ConcurrentLinkedQueue<Exception>(), null);
                exceptions.Add(completedTask.Exception);
            }
            else if (completedTask.IsCanceled)
            {
                canceled = true;
            }

            bool isComplete = Interlocked.Decrement(ref counter) == 0;

            if (!isComplete)
                return;

			if (exceptions != null) 
            {
				owner.SetException(exceptions.AsEnumerable());
				return;
			}

			if (canceled) 
            {
				owner.SetCanceled();
				return;
			}

			owner.SetResult(null);
		}
	}

    sealed class WhenAnyContinuation : IContinuation
    {
        readonly TaskCompletionSource<Task> owner;
        private int hasResult;
        private IList<Task> tasks;
        public WhenAnyContinuation(TaskCompletionSource<Task> owner, IList<Task> tasks)
        {
            this.owner = owner;
            this.tasks = tasks;

            foreach (var t in tasks)
                t.ContinueWith(this);
        }

        public void Execute(Task completedTask)
        {
            if (Interlocked.CompareExchange(ref hasResult, 1, 0) != 0)
                return;

            foreach (var t in tasks)
                t.RemoveContinuation(this);
            tasks = null;

            owner.SetResult(completedTask);
        }
    }

    sealed class ManualResetContinuation : IContinuation, IDisposable, IWaitable
	{
        Semaphore evt;

		public ManualResetContinuation ()
		{
            this.evt = new Semaphore(0);
		}

        public Semaphore Event
        {
			get 
            {
				return evt;
			}
		}

		public void Dispose ()
		{
		    lock (this)
		    {
		        evt = null;
		    }
		}

        public void Execute(Task completedTask)
        {
            lock (this)
            {
                if( evt != null) evt.Release();
            }
        }

        public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
        {
            bool result;

            cancellationToken.Register(Cancel);
            if (millisecondsTimeout != Timeout.Infinite)
            {
                result = Event.TryAcquire(millisecondsTimeout, TimeUnit.MILLISECONDS);
            }
            else
            {
                Event.Acquire();
                result = true;
            }
            cancellationToken.ThrowIfCancellationRequested();

            return result;
        }

        private void Cancel()
        {
            lock (this)
            {
                if (evt != null)
                {
                    evt.Release();
                }
            }
        }
	}

	sealed class CountdownContinuation : IContinuation, IDisposable, IWaitable
	{
        CountDownLatch evt;

		public CountdownContinuation (int initialCount)
		{
            this.evt = new CountDownLatch(initialCount);
		}

        public CountDownLatch Event
        {
			get 
            {
				return evt;
			}
		}

		public void Dispose ()
		{
		    lock (this)
		    {
		        evt = null;
		    }
		}

        public void Execute(Task completedTask)
		{
            lock (this)
            {
                if(evt != null) evt.CountDown();
            }
		}

        public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
        {
            bool result;

            cancellationToken.Register(Cancel);
            if (millisecondsTimeout != Timeout.Infinite)
            {
                result = Event.Await(millisecondsTimeout, TimeUnit.MILLISECONDS);
            }
            else
            {
                Event.Await();
                result = true;
            }
            cancellationToken.ThrowIfCancellationRequested();

            return result;
        }

        private void Cancel()
        {
            lock (this)
            {
                if (evt != null)
                {
                    for (var i = 0; i < evt.Count; i++)
                    {
                        evt.CountDown();
                    }
                }
            }
        }
	}
}


