using System;
using System.Diagnostics;
using System.Threading;
using Android.Util;
using Java.IO;
using Java.Lang;
using Java.Util.Concurrent;
using Java.Util.Regex;
using JetBrains.Annotations;
using Exception = System.Exception;

namespace Dot42.Internal.Threading
{
    internal class ThreadPoolImpl 
    {
        private readonly ThreadPoolExecutor _threadPool;
        private IScheduledFuture<object> _checkIncreaseThreadCount;
        private readonly int _minPoolSize;

        public ThreadPoolExecutor Executor { get { return _threadPool; } }

        internal ThreadPoolImpl() : this(0, 0)
        {
        }

        internal ThreadPoolImpl(int minPoolSize, int maxPoolSize)
        {
            // TODO: check is these defaults make any size

            // minimum 4
            _minPoolSize = minPoolSize > 0 ? minPoolSize : Math.Max(4, GetNumCores() - 1);

            // CLR has max 250 threads per core...

            if (maxPoolSize <= 0)
            {
                // min-max 20; 
                var maxThreadsMultiplier = 4;
                maxPoolSize = (_minPoolSize + 1) * maxThreadsMultiplier;
            }

            if (maxPoolSize < minPoolSize)
                maxPoolSize = minPoolSize;

            var queue = new RunnableQueue(this);
            _threadPool = new ThreadPoolExecutor(_minPoolSize, maxPoolSize, 60L, TimeUnit.SECONDS, queue);

            // there could be some logic to automatic reduce the number of threads again if they are
            // not needed. For now, we have the MemoryPressure approach.
            // TODO: MemoryPressure should automatically be called when Android signals memory pressure,
            //       probalby best from Dot42.Internal.Application.
        }

        public void MemoryPressure()
        {
            _threadPool.CorePoolSize = _minPoolSize;
        }

        private void CheckThreadCount()
        {
            VerboseLog("{0:000}|CheckThreadCount: CoreSize: {1}; maxSize: {2} queuelen: {3}; active {4}; pool size: {5}",
                    Thread.CurrentThread.Id, _threadPool.CorePoolSize, _threadPool.MaximumPoolSize, _threadPool.Queue.Size(), _threadPool.ActiveCount, _threadPool.PoolSize);

            _checkIncreaseThreadCount = null;

            if (_threadPool.Queue.IsEmpty || _threadPool.CorePoolSize >= _threadPool.MaximumPoolSize)
                return;

            VerboseLog("{0:000}|increasing core threadpool size from {1}; maxSize: {2} queuelen: {3}; active {4}; pool size: {5}",
                    Thread.CurrentThread.Id, _threadPool.CorePoolSize, _threadPool.MaximumPoolSize, _threadPool.Queue.Size(), _threadPool.ActiveCount, _threadPool.PoolSize);

            _threadPool.CorePoolSize += 1;

            ScheduleCheckThreadCount();
        }

        private void ScheduleCheckThreadCount()
        {
            VerboseLog("{0:000}|ScheduleCheckThreadCount: CoreSize: {1} maxSize: {2} queuelen: {3}; active {4}; pool size: {5}; futureDelay: {7}s; future: {6};",
                Thread.CurrentThread.Id, _threadPool.CorePoolSize, _threadPool.MaximumPoolSize, _threadPool.Queue.Size(), _threadPool.ActiveCount, _threadPool.PoolSize,
                                        _checkIncreaseThreadCount, _checkIncreaseThreadCount!=null?_checkIncreaseThreadCount.GetDelay(TimeUnit.SECONDS).ToString(): "-");

            // since ActiveCount might not be accurate, perform the check with a margin.
            if (_threadPool.ActiveCount < _threadPool.CorePoolSize - 1
             || _threadPool.CorePoolSize >= _threadPool.MaximumPoolSize)
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

        [Conditional("DEBUG")]
        [StringFormatMethod("format")]
        private static void VerboseLog(string format, params object[] args)
        {
            //Log.Verbose("dot42.threading", format, args);
        }
    }
}
