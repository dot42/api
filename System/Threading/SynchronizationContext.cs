// Copyright (C) 2014 dot42
//
// Original filename: SynchronizationContext.cs
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
using System.Runtime.ConstrainedExecution;
using Android.App;
using Dot42;
using Java.Lang;

using Dot42.Internal;
using Dot42.Threading.Tasks;


namespace System.Threading 
{
	public class SynchronizationContext
	{
        internal class MySendOrPostRunner: IRunnable
        {
            private SendOrPostCallback d;
            private object state;

            public MySendOrPostRunner(SendOrPostCallback d, object state)
            {
                this.d = d;
                this.state = state;
            }

            public void Run()
            {
                d(state);
            }
        }

		bool notification_required;

		//[ThreadStatic]
        static readonly Java.Lang.ThreadLocal<SynchronizationContext> currentContext = new Java.Lang.ThreadLocal<SynchronizationContext>();
		
		public SynchronizationContext ()
		{
		}

		internal SynchronizationContext (SynchronizationContext context)
		{
            currentContext.Set(context);
		}
		
		public static SynchronizationContext Current
        {
			get 
            {
				return currentContext.Get();
			}
		}

		public virtual SynchronizationContext CreateCopy ()
		{
			return new SynchronizationContext (this);
		}

		public bool IsWaitNotificationRequired ()
		{
			return notification_required;
		}

		public virtual void OperationCompleted ()
		{
		}

		public virtual void OperationStarted ()
		{
		}
		
		public virtual void Post (SendOrPostCallback d, object state)
		{
            ThreadPool.QueueUserWorkItem(new MySendOrPostRunner(d, state));
		}
		
		public virtual void Send (SendOrPostCallback d, object state)
		{
			d (state);
		}
		
		public static void SetSynchronizationContext (SynchronizationContext syncContext)
		{
            currentContext.Set(syncContext);
		}

        public static void SetSynchronizationContext(Activity activity)
        {
            SetSynchronizationContext(new InstanceReference(activity));
        }

#if ANDROID_11P
        public static void SetSynchronizationContext(Fragment fragment)
        {
            SetSynchronizationContext(new InstanceReference(fragment));
        }
#endif

        public static void SetSynchronizationContext(InstanceReference instanceReference)
        {
            if (!(Current is InstanceSynchronizationContext))
            {
                SetSynchronizationContext(new InstanceSynchronizationContext());
            }

            InstanceSynchronizationContext.RegisterActivity(instanceReference);
        }

        [NotImplemented]
	    protected void SetWaitNotificationRequired ()
		{
			notification_required = true;
            throw new NotImplementedException("System.Threading.SynchronizationContect.SetWaitNotificationRequired");
		}

		[CLSCompliant (false)][NotImplemented]
		public virtual int Wait (IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			return WaitHelper (waitHandles, waitAll, millisecondsTimeout);
		}

		[CLSCompliant (false)]
		[ReliabilityContract (Consistency.WillNotCorruptState, Cer.MayFail)]
		protected static int WaitHelper (IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
            throw new NotImplementedException("System.Threading.SynchronizationContect.WaitHelper");
		}
	}
}

