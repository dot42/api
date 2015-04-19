using System.Collections.Concurrent;
using System.Threading.Tasks;
using Java.Util.Concurrent;
using Java.Util.Concurrent.Atomic;

namespace System.Threading
{
    public class SemaphoreSlim : IDisposable
    {
        private readonly Semaphore _sem;
        private readonly AtomicBoolean _wasDisposed = new AtomicBoolean();
        private volatile ConcurrentLinkedQueue<AsyncWaiter> _asyncWaiters;

        public SemaphoreSlim(int initialCount)
        {
            _sem = new Semaphore(initialCount);
        }

        public Task WaitAsync(CancellationToken token)
        {
            return WaitAsync(-1, token);
        }

        public Task<bool> WaitAsync(TimeSpan duration, CancellationToken token)
        {
            return WaitAsync((int) duration.TotalMilliseconds, token);
        }

        public Task<bool> WaitAsync(Int32 duration, CancellationToken token)
        {
            CheckDisposed();

            if (_sem.TryAcquire())
                return Task.FromResult(true);

            if(duration == 0)
                return Task.FromResult(false);
            
            if (_asyncWaiters == null)
            {
                lock (this)
                {
                    if (_asyncWaiters == null)
                        _asyncWaiters = new ConcurrentLinkedQueue<AsyncWaiter>();
                }
            }

            AsyncWaiter waiter = new AsyncWaiter();
            TaskCompletionSource<bool> task = new TaskCompletionSource<bool>();
            
            waiter.Task = task;

            if (token != CancellationToken.None)
            {
                waiter.CancelRegistration = token.Register(task.SetCanceled);
            }

            if (duration != -1)
            {
                waiter.CancelDelay = new CancellationTokenSource();
                waiter.Delay = Task.Delay(duration, waiter.CancelDelay.Token);
            }
            
            _asyncWaiters.Add(waiter);

            if (_wasDisposed.Get())
            {
                // we were disposed after our CheckDisposed test above. 
                // Clean up.
                if (_asyncWaiters.Remove(waiter))
                {
                    // cleanup.
                    IsStillWaiting(waiter);
                }
            }

            return task.Task;
        }

        public Task WaitAsync()
        {
            return WaitAsync(-1, CancellationToken.None);
        }

        public void Wait()
        {
            Wait(-1, CancellationToken.None);
        }

        public void Wait(CancellationToken token)
        {
            Wait(-1, token);
        }

        public bool Wait(TimeSpan timeSpan, CancellationToken token)
        {
            return Wait((Int32)timeSpan.TotalMilliseconds, token);
        }

        public bool Wait(Int32 milliseconds)
        {
            return Wait(milliseconds, CancellationToken.None);
        }

        public bool Wait(Int32 milliseconds,  CancellationToken token)
        {
            CheckDisposed();

            if (milliseconds == -1 && token == CancellationToken.None)
            {
                _sem.AcquireUninterruptibly();
                return true;
            }
            if (token == CancellationToken.None)
            {
                var ret = _sem.TryAcquire(milliseconds, TimeUnit.MILLISECONDS);
                CheckDisposed();
                return ret;
            }

            var thread = Thread.CurrentThread;
            
            try
            {
                using (token.Register(thread.Interrupt))
                {
                    var ret = _sem.TryAcquire(milliseconds, TimeUnit.MILLISECONDS);
                    CheckDisposed();
                    return ret;
                }
            }
            catch (Java.Lang.InterruptedException ex)
            {
                throw new OperationCanceledException("operation cancelled", ex, token);
            }
        }

        public void Release(int count)
        {
            if (count == 0) return;

            if (_asyncWaiters != null)
            {
                AsyncWaiter asyncWaiter;
                while (count > 0 && (asyncWaiter = _asyncWaiters.Poll()) != null)
                {
                    if (!IsStillWaiting(asyncWaiter))
                        continue;

                    asyncWaiter.Task.SetResult(true);
                    count -= 1;
                }
            }

            if (count == 0) return;

            _sem.Release(count);
        }

        public void Release()
        {
            if (_asyncWaiters != null)
            {
                AsyncWaiter asyncWaiter;
                while ((asyncWaiter = _asyncWaiters.Poll()) != null)
                {
                    if (!IsStillWaiting(asyncWaiter))
                        continue;

                    asyncWaiter.Task.SetResult(true);
                    return;
                }
            }

            _sem.Release();
        }

        public void Dispose()
        {
            _wasDisposed.Set(true);
            _sem.Release(Int32.MaxValue);

            AsyncWaiter asyncWaiter;
            while (_asyncWaiters != null && (asyncWaiter = _asyncWaiters.Poll()) != null)
                IsStillWaiting(asyncWaiter);
        }

        private bool IsStillWaiting(AsyncWaiter asyncWaiter)
        {
            asyncWaiter.CancelRegistration.Dispose();

            if (asyncWaiter.Delay != null)
            {
                asyncWaiter.CancelDelay.Cancel();
                asyncWaiter.Delay.Dispose();
            }

            if (_wasDisposed.Get())
                asyncWaiter.Task.TrySetException(new ObjectDisposedException(GetType().Name));

            return !asyncWaiter.Task.Task.IsCompleted;
        }

        private void CheckDisposed()
        {
            if (_wasDisposed.Get())
                throw new ObjectDisposedException(GetType().Name);
        }

        private class AsyncWaiter
        {
            public TaskCompletionSource<bool> Task;
            public CancellationTokenRegistration CancelRegistration;
            public CancellationTokenSource CancelDelay;
            public Task Delay;
        }
    }
}
