
using Dot42.Internal.Threading;
using Java.Lang;

namespace System.Threading
{
    public delegate void WaitCallback(Object state);

    public static class ThreadPool
    {
        private static readonly Lazy<ThreadPoolImpl> ThreadPoolImpl = new Lazy<ThreadPoolImpl>(()=>new ThreadPoolImpl());
        
        internal static ThreadPoolImpl Default { get { return ThreadPoolImpl.Value; } }

        public static void QueueUserWorkItem(WaitCallback callBack)
        {
            ThreadPoolImpl.Value.QueueUserWorkItem(callBack);
        }

        public static void QueueUserWorkItem(WaitCallback callBack, object state)
        {
            ThreadPoolImpl.Value.QueueUserWorkItem(callBack, state);
        }

        public static void QueueUserWorkItem(Action action)
        {
            ThreadPoolImpl.Value.QueueUserWorkItem(action);
        }

        public static void QueueUserWorkItem(IRunnable runnable)
        {
            ThreadPoolImpl.Value.QueueUserWorkItem(runnable);
        }

        public static void MemoryPressure()
        {
            if (!ThreadPoolImpl.IsValueCreated)
                return;
            ThreadPoolImpl.Value.MemoryPressure();
        }
    }
}
