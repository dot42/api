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
using Java.Util.Concurrent;

using Dot42.Internal;
using Dot42.Threading.Tasks;
using Java.Util.Concurrent.Atomic;

namespace System.Threading.Tasks
{
    interface IWaitable
    {
        bool Wait(int millisecondsTimeout, CancellationToken cancellationToken);
    }

	interface IContinuation
	{
        void Execute();
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

        public void Execute()
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

        public void Execute()
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

        public void Execute()
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
        readonly TaskCompletionSource<VoidTaskResult> owner;
		readonly IList<Task> tasks;
	    private readonly AtomicInteger counter;

		public WhenAllContinuation (TaskCompletionSource<VoidTaskResult> owner, IList<Task> tasks)
		{
			this.owner = owner;
			this.counter = new AtomicInteger(tasks.Count);
			this.tasks = tasks;

            foreach (var t in tasks)
                t.ContinueWith(this);
		}

		public void Execute ()
		{
			if (counter.DecrementAndGet() != 0)
				return;

			bool canceled = false;
			List<Exception> exceptions = null;
			foreach (var task in tasks) {
				if (task.IsFaulted) {
					if (exceptions == null)
						exceptions = new List<Exception> ();

					exceptions.AddRange (task.Exception.InnerExceptions);
					continue;
				}

				if (task.IsCanceled) 
                {
					canceled = true;
				}

                task.RemoveContinuation(this);
			}

			if (exceptions != null) 
            {
				owner.SetException (exceptions);
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
        readonly IList<Task> tasks;

        public WhenAnyContinuation(TaskCompletionSource<Task> owner, IList<Task> tasks)
        {
            this.owner = owner;
            this.tasks = tasks;
            foreach (var t in tasks)
                t.ContinueWith(this);
        }

        public void Execute()
        {
            bool hasResult = false;
            foreach (var task in tasks)
            {
                if(!hasResult && task.IsCompleted)
                {
                    owner.SetResult(task);
                    hasResult = true;
                }
                task.RemoveContinuation(this);
            }
        }
    }

    /*
	sealed class WhenAllContinuation<TResult> : IContinuation
	{
		readonly Task<TResult[]> owner;
		readonly IList<Task<TResult>> tasks;
		int counter;

		public WhenAllContinuation (Task<TResult[]> owner, IList<Task<TResult>> tasks)
		{
			this.owner = owner;
			this.counter = tasks.Count;
			this.tasks = tasks;
		}

		public void Execute ()
		{
			if (Interlocked.Decrement (ref counter) != 0)
				return;

			bool canceled = false;
			List<Exception> exceptions = null;
			TResult[] results = null;
			for (int i = 0; i < tasks.Count; ++i) {
				var task = tasks [i];
				if (task.IsFaulted) {
					if (exceptions == null)
						exceptions = new List<Exception> ();

					exceptions.AddRange (task.Exception.InnerExceptions);
					continue;
				}

				if (task.IsCanceled) {
					canceled = true;
					continue;
				}

				if (results == null) {
					if (canceled || exceptions != null)
						continue;

					results = new TResult[tasks.Count];
				}

				results[i] = task.Result;
			}

			if (exceptions != null) {
				owner.TrySetException (new AggregateException (exceptions));
				return;
			}

			if (canceled) {
				owner.CancelReal ();
				return;
			}

			owner.TrySetResult (results);
		}
	}
    */

    /*
	sealed class WhenAnyContinuation<T> : IContinuation where T : Task
	{
		readonly Task<T> owner;
		readonly IList<T> tasks;
		AtomicBooleanValue executed;

		public WhenAnyContinuation (Task<T> owner, IList<T> tasks)
		{
			this.owner = owner;
			this.tasks = tasks;
			executed = new AtomicBooleanValue ();
		}

		public void Execute ()
		{
			if (!executed.TryRelaxedSet ())
				return;

			bool owner_notified = false;
			for (int i = 0; i < tasks.Count; ++i) {
				var task = tasks[i];
				if (!task.IsCompleted) {
					task.RemoveContinuation (this);
					continue;
				}

				if (owner_notified)
					continue;

				owner.TrySetResult (task);
				owner_notified = true;
			}
		}
	}
    */

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

        public void Execute()
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

        public void Execute()
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


