using System;
using System.Threading;
using Java.IO;
using Java.Lang;
using Java.Util.Concurrent;
using Java.Util.Regex;
using Exception = System.Exception;

namespace Dot42.Internal.Threading
{
    internal class ThreadPoolImpl 
    {
        private readonly ThreadPoolExecutor _threadPool;
        private IScheduledFuture<object> _checkIncreaseThreadCount;
        private readonly int _minPoolSize;

        public ThreadPoolExecutor Executor { get { return _threadPool; } }

        internal ThreadPoolImpl() : this(0)
        {
        }

        internal ThreadPoolImpl(int maxThreadsMultiplier)
        {
            _minPoolSize = Math.Max(5, GetNumCores() - 1);

            // CLR has max 250 threads per core...

            if (maxThreadsMultiplier <= 0)
                maxThreadsMultiplier = 20;
            
            var maxPoolSize = _minPoolSize * maxThreadsMultiplier;

            var queue = new RunnableQueue(this);
            _threadPool = new ThreadPoolExecutor(_minPoolSize, maxPoolSize, 60L, TimeUnit.SECONDS, queue);

            // there could be some logic to automatic reduce the number of  threads again if they are
            // not needed. For now, we have the MemoryPressure method.
            // TODO: MemoryPressure should automatically be called when Android signals memory pressure,
            //       probalby best from Dot42.Internal.Application.
        }

        public void MemoryPressure()
        {
            _threadPool.CorePoolSize = _minPoolSize;
        }

        private void CheckThreadCount()
        {
            _checkIncreaseThreadCount = null;

            if (_threadPool.Queue.IsEmpty || _threadPool.CorePoolSize >= _threadPool.MaximumPoolSize)
                return;
            
            _threadPool.CorePoolSize += 1;
        }

        private void ScheduleCheckThreadCount()
        {
            if (_threadPool.CorePoolSize >= _threadPool.MaximumPoolSize)
                return;

            if (_checkIncreaseThreadCount == null)
            {
                var future = TaskMonitorService.GetService().Delay(30000L, CheckThreadCount);
                var prevFuture = Interlocked.CompareExchange(ref _checkIncreaseThreadCount, future, null);

                if (prevFuture != null)
                    future.Cancel(false);
            }
        }

        private sealed class RunnableQueue : LinkedBlockingQueue<IRunnable>
        {
            private readonly ThreadPoolImpl _threadPoolImpl;

            public RunnableQueue(ThreadPoolImpl threadPoolImpl)
            {
                _threadPoolImpl = threadPoolImpl;
            }

            public override bool Offer(IRunnable e)
            {
                _threadPoolImpl.ScheduleCheckThreadCount();
                return base.Offer(e);
            }
        }

        internal static int GetNumCores()
        {
            try
            {
                //Get directory containing CPU info
                var dir = new File("/sys/devices/system/cpu/");

                //Filter to only list the devices we care about
                var files = dir.ListFiles(new CpuFilter());

                //Return the number of cores (virtual CPU devices)
                return files.Length;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        private class CpuFilter : IFileFilter
        {
            public bool Accept(File pathname)
            {
                // Check if filename is "cpu", followed by a digit number
                return Pattern.Matches("cpu[0-9]+", pathname.Name);
            }
        }

        public void QueueUserWorkItem(WaitCallback callBack)
        {
            _threadPool.Execute(()=>callBack(null));
        }

        public void QueueUserWorkItem(WaitCallback callBack, object state)
        {
            _threadPool.Execute(() => callBack(state));
        }

        public void QueueUserWorkItem(Action action)
        {
            _threadPool.Execute(action);
        }

        public void QueueUserWorkItem(IRunnable runnable)
        {
            _threadPool.Execute(runnable);
        }

    }
}
