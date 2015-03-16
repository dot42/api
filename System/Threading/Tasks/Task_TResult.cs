// Copyright (C) 2014 dot42
//
// Original filename: Task_TResult.cs
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
using System.Runtime.CompilerServices;

using System.Diagnostics;
using Android.App;

using Dot42.Threading.Tasks;
using Java.Util;

namespace System.Threading.Tasks
{
	public class Task<TResult> : Task
	{
        private readonly static HashMap<Type, TaskFactory<TResult>> defaultFactory = new HashMap<Type, TaskFactory<TResult>>();

        /// <summary>
        /// Provides access to factory methods for creating Task&lt;TResult&gt; instances.
        /// </summary>
        public static TaskFactory<TResult> Factory
        {
            get
            {
                if (!defaultFactory.ContainsKey(typeof (TResult)))
                {
                    defaultFactory.Put(typeof (TResult), new TaskFactory<TResult>());
                }
                return defaultFactory.Get(typeof(TResult));
            }
        }

        TResult value;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public TResult Result
        {
            get
            {
                if (!IsCompleted)
                    Wait();
                if (IsCanceled)
                    throw new AggregateException(new TaskCanceledException(this));
                if (Exception != null)
                    throw Exception;
                return value;
            }
            internal set
            {
                this.value = value;
            }
        }

        #region Constructors

        public Task(Func<TResult> function)
            : this(function, TaskCreationOptions.None)
        {

        }

        public Task(Func<TResult> function, CancellationToken cancellationToken)
            : this(function, cancellationToken, TaskCreationOptions.None)
        {

        }

        public Task(Func<TResult> function, TaskCreationOptions creationOptions)
            : this(function, CancellationToken.None, creationOptions)
        {

        }

        public Task(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
            : base(TaskActionInvoker.Create(function), null, cancellationToken, creationOptions)
        {
            if (function == null)
                throw new ArgumentNullException("function");
        }

        public Task(Func<object, TResult> function, object state)
            : this(function, state, TaskCreationOptions.None)
        {

        }

        public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken)
            : this(function, state, cancellationToken, TaskCreationOptions.None)
        {

        }

        public Task(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
            : this(function, state, CancellationToken.None, creationOptions)
        {

        }

        public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
            : base(TaskActionInvoker.Create(function), state, cancellationToken, creationOptions)
        {
            if (function == null)
                throw new ArgumentNullException("function");
        }

        internal Task(TaskActionInvoker invoker, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, Task parent, Task contAncestor = null, bool ignoreCancellation = false)
            : base(invoker, state, cancellationToken, creationOptions, parent, contAncestor, ignoreCancellation)
        {
        }

        internal Task(TResult result)
           :base(TaskActionInvoker.Empty, null, default (CancellationToken), TaskCreationOptions.None)
        {
            TrySetResult(result);
        }


        #endregion

        internal bool TrySetResult(TResult result)
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

            Status = TaskStatus.Running;

            this.value = result;
            //Thread.MemoryBarrier();

            Finish();

            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="continueOnCapturedContext"></param>
        /// <returns></returns>
        public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
        {
            return new ConfiguredTaskAwaitable<TResult>(this, continueOnCapturedContext, null);
        }

        public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(Activity activity)
        {
            return ConfigureAwait(new InstanceReference(activity));
        }

#if ANDROID_11P
        public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(Fragment fragment)
        {
            return ConfigureAwait(new InstanceReference(fragment));
        }
#endif

        public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(InstanceReference instanceReference)
        {
            return new ConfiguredTaskAwaitable<TResult>(this, true, instanceReference);
        }

        /// <summary>
        /// Gets an awaiter used to await this Task.
        /// </summary>
        /// <remarks>
        /// This method is intended for compiler user rather than use directly in code.
        /// </remarks>
        public new TaskAwaiter<TResult> GetAwaiter()
        {
            return new TaskAwaiter<TResult>(this);
        }


    }
}

