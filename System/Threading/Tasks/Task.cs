// Copyright (C) 2014 dot42
//
// Original filename: Task.cs
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
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Android.App;
using Android.Util;
using Java.Util.Concurrent;
using Java.Util.Concurrent.Atomic;

using Dot42.Internal;
using Dot42.Threading.Tasks;

namespace System.Threading.Tasks
{
    //[HostProtectionAttribute(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public class Task : IAsyncResult, IDisposable
	{
        private static readonly AtomicInteger lastId = new AtomicInteger(1);
        private static readonly TaskFactory defaultFactory = new TaskFactory();

        // With this attribute each thread has its own value so that it's correct for our Schedule code and for Parent property.
        //[ThreadStatic]
        private static readonly	Java.Lang.ThreadLocal<Task> current = new Java.Lang.ThreadLocal<Task>();

        private readonly int id;
        private readonly TaskCreationOptions creationOptions;
        private TaskStatus status;
	    private object state;
	    private TaskActionInvoker invoker;
        internal AtomicBoolean executing = new AtomicBoolean(false);

	    private readonly TaskCompletionQueue<IContinuation> continuations = new TaskCompletionQueue<IContinuation>();

	    private readonly CancellationToken cancellationToken;
        private CancellationTokenRegistration? cancellationTokenRegistration;

	    internal TaskScheduler scheduler;

        private TaskExceptionSlot exSlot;

        private const TaskCreationOptions MaxTaskCreationOptions = TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent;
        internal const TaskCreationOptions WorkerTaskNotSupportedOptions = TaskCreationOptions.LongRunning | TaskCreationOptions.PreferFairness;

        #region Constuctors

        public Task(Action action)
            : this(action, TaskCreationOptions.None)
        {

        }

        public Task(Action action, TaskCreationOptions creationOptions)
            : this(action, CancellationToken.None, creationOptions)
        {

        }

        public Task(Action action, CancellationToken cancellationToken)
            : this(action, cancellationToken, TaskCreationOptions.None)
        {

        }

        public Task(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
            : this(TaskActionInvoker.Create(action), null, cancellationToken, creationOptions, current.Get())
        {
            if (action == null)
                throw new ArgumentNullException("action");
            if (creationOptions > MaxTaskCreationOptions || creationOptions < TaskCreationOptions.None)
                throw new ArgumentOutOfRangeException("creationOptions");
        }

        public Task(Action<object> action, object state)
            : this(action, state, TaskCreationOptions.None)
        {
        }

        public Task(Action<object> action, object state, TaskCreationOptions creationOptions)
            : this(action, state, CancellationToken.None, creationOptions)
        {
        }

        public Task(Action<object> action, object state, CancellationToken cancellationToken)
            : this(action, state, cancellationToken, TaskCreationOptions.None)
        {
        }

        public Task(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
            : this(TaskActionInvoker.Create(action), state, cancellationToken, creationOptions, current.Get())
        {
            if (action == null)
                throw new ArgumentNullException("action");
            if (creationOptions > MaxTaskCreationOptions || creationOptions < TaskCreationOptions.None)
                throw new ArgumentOutOfRangeException("creationOptions");
        }

	    internal Task(TaskActionInvoker invoker, object state, CancellationToken cancellationToken,
	                  TaskCreationOptions creationOptions, Task parent = null, Task contAncestor = null, bool ignoreCancellation = false)
	    {
	        if (SynchronizationContext.Current == null) SynchronizationContext.SetSynchronizationContext(new AndroidSynchronizationContext());

            this.invoker = invoker;
            this.creationOptions = creationOptions;
            this.state = state;
	        this.id = lastId.GetAndIncrement();
            this.cancellationToken = cancellationToken;
            //this.parent = parent = parent == null ? current : parent;
           // this.contAncestor = contAncestor;
            this.status = cancellationToken.IsCancellationRequested && !ignoreCancellation ? TaskStatus.Canceled : TaskStatus.Created;

            // Process creationOptions

            //if (parent != null && HasFlag(creationOptions, TaskCreationOptions.AttachedToParent))
            //    parent.AddChild();

            if (cancellationToken.CanBeCanceled && !ignoreCancellation)
                cancellationTokenRegistration = cancellationToken.Register(l => ((Task)l).CancelReal(), this);
        }

        //static bool HasFlag(TaskCreationOptions opt, TaskCreationOptions member)
        //{
        //    return (opt & member) == member;
        //}

	    #endregion

        #region Properties

        internal CancellationToken CancellationToken
        {
            get
            {
                return cancellationToken;
            }
        }

        /// <summary>
        /// Gets the state object supplied when the Task was created, or null if none was supplied.
        /// </summary>
        public object AsyncState
        {
            get { throw new NotImplementedException("System.Threading.Tasks.Task.AsyncState"); }
        }

        /// <summary>
        /// Gets a WaitHandle that can be used to wait for the task to complete.
        /// </summary>
        WaitHandle IAsyncResult.AsyncWaitHandle
        {
            get { throw new NotImplementedException("System.Threading.Tasks.Task.IAsyncResult.AsyncWaitHandle"); }
        }

        /// <summary>
        /// Gets an indication of whether the operation completed synchronously.
        /// </summary>
        bool IAsyncResult.CompletedSynchronously
        {
            get { throw new NotImplementedException("System.Threading.Tasks.Task.IAsyncResult.CompletedSynchronously"); }
        }

	    /// <summary>
	    /// Gets the TaskCreationOptions used to create this task.
	    /// </summary>
	    public TaskCreationOptions CreationOptions
	    {
	        get { return creationOptions; }
	    }

        // <summary>
        // Returns the unique ID of the currently executing Task.
        // </summary>
        public static int? CurrentId
        {
            get
            {
                Task t = current.Get();
                return t == null ? (int?)null : t.Id;
            }
        }

	    /// <summary>
	    /// Gets the AggregateException that caused the Task to end prematurely. 
	    /// If the Task completed successfully or has not yet thrown any exceptions, this will return null.
	    /// </summary>
	    public AggregateException Exception
	    {
            get { return exSlot != null ?  exSlot.Exception : null; }
	    }

	    /// <summary>
	    /// Provides access to factory methods for creating Task and Task&lt;TResult&gt; instances.
	    /// </summary>
	    public static TaskFactory Factory
	    {
            get { return defaultFactory; }
	    }

	    /// <summary>
	    /// Gets a unique ID for this Task instance.
	    /// </summary>
	    public int Id
	    {
	        get { return id; }
	    }
        
        /// <summary>
        /// Gets whether this Task instance has completed execution due to being canceled.
        /// </summary>
	    public bool IsCanceled
	    {
            get { return status == TaskStatus.Canceled; }
	    }

        /// <summary>
        /// Gets whether this Task has completed.
        /// </summary>
        public bool IsCompleted
        {
            get { return status == TaskStatus.RanToCompletion || status == TaskStatus.Faulted || status == TaskStatus.Canceled; }
        }

        /// <summary>
        /// Gets whether the Task completed due to an unhandled exception.
        /// </summary>
	    public bool IsFaulted
	    {
            get { return status == TaskStatus.Faulted; }
	    }

	    /// <summary>
	    /// Gets the TaskStatus of this task.
	    /// </summary>
        public TaskStatus Status
        {
            get { return status; }
            internal set { status = value; }
        }


        TaskExceptionSlot ExceptionSlot
        {
            get
            {
                if (exSlot != null)
                    return exSlot;
                
                lock (this)
                {
                    if (exSlot == null)
                        exSlot = new TaskExceptionSlot(this);
                    return exSlot;
                }
            }
        }

        #endregion

        #region Methods

        #region Start
        public void Start()
        {
            Start(TaskScheduler.Current);
        }

        public void Start(TaskScheduler scheduler)
        {
            if (scheduler == null)
                throw new ArgumentNullException("scheduler");

            if (status >= TaskStatus.WaitingToRun)
                throw new InvalidOperationException("The Task is not in a valid state to be started.");

            //if (IsContinuation)
            //    throw new InvalidOperationException("Start may not be called on a continuation task");

            SetupScheduler(scheduler);
            Schedule();
        }

        internal void SetupScheduler(TaskScheduler scheduler)
        {
            this.scheduler = scheduler;
            status = TaskStatus.WaitingForActivation;
        }

        public void RunSynchronously()
        {
            RunSynchronously(TaskScheduler.Current);
        }

        public void RunSynchronously(TaskScheduler scheduler)
        {
            if (scheduler == null)
                throw new ArgumentNullException("scheduler");

            if (Status > TaskStatus.WaitingForActivation)
                throw new InvalidOperationException("The task is not in a valid state to be started");

            //if (IsContinuation)
            //    throw new InvalidOperationException("RunSynchronously may not be called on a continuation task");

            RunSynchronouslyCore(scheduler);
        }

        internal void RunSynchronouslyCore(TaskScheduler scheduler)
        {
            SetupScheduler(scheduler);
            var saveStatus = status;
            Status = TaskStatus.WaitingToRun;

            try
            {
                if (scheduler.RunInline(this, false))
                    return;
            }
            catch (Exception inner)
            {
                throw new TaskSchedulerException(inner);
            }

            Status = saveStatus;
            Start(scheduler);
            Wait();
        }

        internal void Schedule()
        {
            status = TaskStatus.WaitingToRun;
            scheduler.QueueTask(this);
        }

        void ThreadStart()
        {
            /* Allow scheduler to break fairness of deque ordering without
             * breaking its semantic (the task can be executed twice but the
             * second time it will return immediately
             */
            if (executing.GetAndSet(true))
                return;

            // Disable CancellationToken direct cancellation
            if (cancellationTokenRegistration != null)
            {
                cancellationTokenRegistration.Value.Dispose();
                cancellationTokenRegistration = null;
            }

            // If Task are ran inline on the same thread we might trash these values
            var saveCurrent = current.Get();
            var saveScheduler = TaskScheduler.Current;

            current.Set(this);
#if NET_4_5
			TaskScheduler.Current = HasFlag (creationOptions, TaskCreationOptions.HideScheduler) ? TaskScheduler.Default : scheduler;
#else
            TaskScheduler.Current = scheduler;
#endif

            if (!cancellationToken.IsCancellationRequested)
            {
                status = TaskStatus.Running;

                try
                {
                    InnerInvoke();
                }
                catch (OperationCanceledException oce)
                {
                    if (cancellationToken != CancellationToken.None && oce.CancellationToken == cancellationToken)
                        CancelReal();
                    else
                        HandleGenericException(oce);
                }
                catch (Exception e)
                {
                    HandleGenericException(e);
                }
            }
            else
            {
                CancelReal();
            }

            if (saveCurrent != null)
                current.Set(saveCurrent);
            if (saveScheduler != null)
                TaskScheduler.Current = saveScheduler;
            Finish();
        }

        internal bool TrySetCanceled()
        {
            if (IsCompleted)
                return false;

            //if (!executing.TryRelaxedSet())
            //{
            //    var sw = new SpinWait();
            //    while (!IsCompleted)
            //        sw.SpinOnce();

            //    return false;
            //}

            CancelReal();
            return true;
        }

        internal bool TrySetException(AggregateException aggregate)
        {
            if (IsCompleted)
                return false;

            //if (!executing.TryRelaxedSet())
            //{
            //    var sw = new SpinWait();
            //    while (!IsCompleted)
            //        sw.SpinOnce();

            //    return false;
            //}

            HandleGenericException(aggregate);
            return true;
        }

        internal bool TrySetExceptionObserved()
        {
            if (exSlot != null)
            {
                exSlot.Observed = true;
                return true;
            }
            return false;
        }

        internal void Execute()
        {
            ThreadStart();
        }

        internal void CancelReal()
        {
            Status = TaskStatus.Canceled;

            ProcessCompleteDelegates();
        }

        void HandleGenericException(Exception e)
        {
            HandleGenericException(new AggregateException(e));
        }

        void HandleGenericException(AggregateException e)
        {
            ExceptionSlot.Exception = e;
            //Thread.MemoryBarrier();
            Status = TaskStatus.Faulted;

            ProcessCompleteDelegates();
        }

        void InnerInvoke()
        {
            //if (IsContinuation)
            //{
            //    invoker.Invoke(contAncestor, state, this);
            //}
            //else
            //{
                invoker.Invoke(this, state, this);
            //}
        }

        internal void Finish()
        {
            /*
            // If there was children created and they all finished, we set the countdown
            if (childTasks != null)
            {
                if (childTasks.Signal())
                    ProcessChildExceptions(true);
            }
            */
             
            // Don't override Canceled or Faulted
            if (status == TaskStatus.Running)
            {
                //if (childTasks == null || childTasks.IsSet)
                    Status = TaskStatus.RanToCompletion;
                //else
                //    Status = TaskStatus.WaitingForChildrenToComplete;
            }

            /*
            // Tell parent that we are finished
            if (parent != null && HasFlag(creationOptions, TaskCreationOptions.AttachedToParent) &&
#if NET_4_5
			    !HasFlag (parent.CreationOptions, TaskCreationOptions.DenyChildAttach) &&
#endif
 status != TaskStatus.WaitingForChildrenToComplete)
            {
                parent.ChildCompleted(this.Exception);
            }
            */

            // Completions are already processed when task is canceled or faulted
            if (status == TaskStatus.RanToCompletion)
                ProcessCompleteDelegates();

            // Reset the current thingies
            if (current.Get() == this)
                current.Set(null);
            if (TaskScheduler.Current == scheduler)
                TaskScheduler.Current = null;

            if (cancellationTokenRegistration.HasValue)
                cancellationTokenRegistration.Value.Dispose();
        }

        void ProcessCompleteDelegates()
        {
            if (continuations.HasElements)
            {
                IContinuation continuation;
                while (continuations.TryGetNextCompletion(out continuation))
                {
                    //TODO: remove line below if case 828 has been solved
                    if (continuation == null) break;
                    
                    continuation.Execute();
                }
            }
        }

        #endregion

        public void Wait()
        {
            Wait(Timeout.Infinite, CancellationToken.None);
        }

        public void Wait(CancellationToken cancellationToken)
        {
            Wait(Timeout.Infinite, cancellationToken);
        }

        public bool Wait(TimeSpan timeout)
        {
            return Wait(CheckTimeout(timeout), CancellationToken.None);
        }

        public bool Wait(int millisecondsTimeout)

        {
            return Wait(millisecondsTimeout, CancellationToken.None);
        }

        public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
        {
            if (millisecondsTimeout < -1)
                throw new ArgumentOutOfRangeException("millisecondsTimeout");

            bool result = WaitCore(millisecondsTimeout, cancellationToken);

            if (IsCanceled)
                throw new AggregateException(new TaskCanceledException(this));

            var exception = Exception;
            if (exception != null)
                throw exception;

            return result;
        }

        internal bool WaitCore(int millisecondsTimeout, CancellationToken cancellationToken)
        {
            if (IsCompleted)
                return true;

            // If the task is ready to be run and we were supposed to wait on it indefinitely without cancellation, just run it
            if (Status == TaskStatus.WaitingToRun && millisecondsTimeout == Timeout.Infinite && scheduler != null && !cancellationToken.CanBeCanceled)
                scheduler.RunInline(this, true);

            bool result = true;

            if (!IsCompleted)
            {
                var continuation = new ManualResetContinuation();
                try
                {
                    ContinueWith(continuation);

                    result = continuation.Wait(millisecondsTimeout, cancellationToken); 
                }
                finally
                {
                    if (!result)
                        RemoveContinuation(continuation);
                    continuation.Dispose();
                }
            }

            return result;
        }

        public static void WaitAll(params Task[] tasks)
        {
            WaitAll(tasks, Timeout.Infinite, CancellationToken.None);
        }

        public static void WaitAll(Task[] tasks, CancellationToken cancellationToken)
        {
            WaitAll(tasks, Timeout.Infinite, cancellationToken);
        }

        public static bool WaitAll(Task[] tasks, TimeSpan timeout)
        {
            return WaitAll(tasks, CheckTimeout(timeout), CancellationToken.None);
        }

        public static bool WaitAll(Task[] tasks, int millisecondsTimeout)
        {
            return WaitAll(tasks, millisecondsTimeout, CancellationToken.None);
        }

        public static bool WaitAll(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
        {
            if (tasks == null)
                throw new ArgumentNullException("tasks");

            bool result = true;
            foreach (var t in tasks)
            {
                if (t == null)
                    throw new ArgumentException("tasks", "the tasks argument contains a null element");

                result &= t.Status == TaskStatus.RanToCompletion;
            }

            if (!result)
            {
                var continuation = new CountdownContinuation(tasks.Length);
                try
                {
                    foreach (var t in tasks)
                        t.ContinueWith(continuation);

                    result = continuation.Wait(millisecondsTimeout, cancellationToken);
                }
                finally
                {
                    List<Exception> exceptions = null;

                    foreach (var t in tasks)
                    {
                        if (result)
                        {
                            if (t.Status == TaskStatus.RanToCompletion)
                                continue;
                            if (exceptions == null)
                                exceptions = new List<Exception>();
                            if (t.Exception != null)
                                exceptions.AddRange(t.Exception.InnerExceptions);
                            else
                                exceptions.Add(new TaskCanceledException(t));
                        }
                        else
                        {
                            t.RemoveContinuation(continuation);
                        }
                    }

                    continuation.Dispose();

                    if (exceptions != null)
                        throw new AggregateException(exceptions);
                }
            }

            return result;
        }

        public static int WaitAny(params Task[] tasks)
        {
            return WaitAny(tasks, Timeout.Infinite, CancellationToken.None);
        }

        public static int WaitAny(Task[] tasks, TimeSpan timeout)
        {
            return WaitAny(tasks, CheckTimeout(timeout));
        }

        public static int WaitAny(Task[] tasks, int millisecondsTimeout)
        {
            return WaitAny(tasks, millisecondsTimeout, CancellationToken.None);
        }

        public static int WaitAny(Task[] tasks, CancellationToken cancellationToken)
        {
            return WaitAny(tasks, Timeout.Infinite, cancellationToken);
        }

        public static int WaitAny(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
        {
            if (tasks == null)
                throw new ArgumentNullException("tasks");
            if (millisecondsTimeout < -1)
                throw new ArgumentOutOfRangeException("millisecondsTimeout");
            CheckForNullTasks(tasks);

            if (tasks.Length > 0)
            {
                var continuation = new ManualResetContinuation();
                bool result = false;
                try
                {
                    for (int i = 0; i < tasks.Length; i++)
                    {
                        var t = tasks[i];
                        if (t.IsCompleted)
                            return i;
                        t.ContinueWith(continuation);
                    }

                    result = continuation.Wait(millisecondsTimeout, cancellationToken);
                    if (!result) return -1;
                }
                finally
                {
                    if (!result)
                        foreach (var t in tasks)
                            t.RemoveContinuation(continuation);
                    continuation.Dispose();
                }
            }

            int firstFinished = -1;
            for (int i = 0; i < tasks.Length; i++)
            {
                var t = tasks[i];
                if (t.IsCompleted)
                {
                    firstFinished = i;
                    break;
                }
            }

            return firstFinished;
        }

        public static Task Run(Action action)
        {
            return Run(action, CancellationToken.None);
        }

        public static Task Run(Action action, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
                return TaskConstants.Canceled;

            return Task.Factory.StartNew(action, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
        }

        public static Task<TResult> Run<TResult>(Func<TResult> function)
        {
            return Run(function, CancellationToken.None);
        }

        public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
                return TaskConstants<TResult>.Canceled;

            return Task.Factory.StartNew(function, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
        }

        internal void ContinueWith(IContinuation continuation)
        {
            if (IsCompleted)
            {
                continuation.Execute();
                return;
            }

            continuations.Add(continuation);

            // Retry in case completion was achieved but event adding was too late
            if (IsCompleted && continuations.Remove(continuation))
                continuation.Execute();
        }

        internal void RemoveContinuation(IContinuation continuation)
        {
            continuations.Remove(continuation);
        }

        private static int CheckTimeout(TimeSpan timeout)
        {
            try
            {
                return checked((int)timeout.TotalMilliseconds);
            }
            catch (System.OverflowException)
            {
                throw new ArgumentOutOfRangeException("timeout");
            }
        }

        private static void CheckForNullTasks(Task[] tasks)
        {
            foreach (var t in tasks)
                if (t == null)
                    throw new ArgumentException("tasks", "the tasks argument contains a null element");
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!IsCompleted)
                throw new InvalidOperationException("A task may only be disposed if it is in a completion state");

            // Set action to null so that the GC can collect the delegate and thus
            // any big object references that the user might have captured in a anonymous method
            if (disposing)
            {
                invoker = null;
                state = null;
                if (cancellationTokenRegistration != null)
                    cancellationTokenRegistration.Value.Dispose();
            }
        }

        public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
        {
            return new ConfiguredTaskAwaitable(this, continueOnCapturedContext, null);
        }

        public ConfiguredTaskAwaitable ConfigureAwait(Activity activity)
        {
            return ConfigureAwait(new InstanceReference(activity));
        }

#if ANDROID_11P
        public ConfiguredTaskAwaitable ConfigureAwait(Fragment fragment)
        {
            return ConfigureAwait(new InstanceReference(fragment));
        }
#endif

        public ConfiguredTaskAwaitable ConfigureAwait(InstanceReference instanceReference)
        {
            return new ConfiguredTaskAwaitable(this, true, instanceReference);
        }

        /// <summary>
        /// Gets an awaiter used to await this Task.
        /// </summary>
        /// <remarks>
        /// This method is intended for compiler user rather than use directly in code.
        /// </remarks>
        public TaskAwaiter GetAwaiter()
        {
            return new TaskAwaiter(this);
        }

        public static Task Delay (int millisecondsDelay)
		{
			return Delay (millisecondsDelay, CancellationToken.None);
		}

		public static Task Delay (TimeSpan delay)
		{
			return Delay (CheckTimeout (delay), CancellationToken.None);
		}

		public static Task Delay (TimeSpan delay, CancellationToken cancellationToken)
		{
			return Delay (CheckTimeout (delay), cancellationToken);
		}

	    public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
	    {
            var source = new TaskCompletionSource<object>();
            var delayed = TaskMonitorService.GetService().Delay((long)millisecondsDelay, source);
            if (cancellationToken != CancellationToken.None)
            {
                cancellationToken.Register(() =>
                    {
                        delayed.Cancel(false);
                        source.SetCanceled();
                    });
            }
             
            return source.Task;
	    }

        #endregion
    }
}

