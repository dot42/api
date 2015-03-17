using System.Threading.Tasks;
using Java.Util.Concurrent;

namespace System.Threading
{
    public class SemaphoreSlim /*: IDisposable*/
    {
        private readonly Semaphore _sem;

        public SemaphoreSlim(int initialCount)
        {
            _sem = new Semaphore(initialCount);
        }


        //public void Dispose()
        //{
        //    sem.
        //}

        public Task WaitAsync(CancellationToken token)
        {
            return Task.Run(() => Wait(token), token);
        }

        public Task WaitAsync(TimeSpan duration, CancellationToken token)
        {
            return Task.Run(() => Wait(duration, token), token);
        }

        public Task WaitAsync(Int32 duration, CancellationToken token)
        {
            return Task.Run(() => Wait(duration, token), token);
        }

        public Task WaitAsync()
        {
            return Task.Run(Wait);
        }

        public void Wait()
        {
            _sem.AcquireUninterruptibly();
        }

        public void Wait(CancellationToken token)
        {
            var thread = Thread.GetCurrentThread();
            try
            {
                using (token.Register(thread.Interrupt))
                    _sem.Acquire();            
            }
            catch (Java.Lang.InterruptedException ex)
            {
                throw new OperationCanceledException(ex.Message, ex, token);
            }
        }

        public bool Wait(Int32 milliseconds,  CancellationToken token)
        {
            var thread = Thread.GetCurrentThread();
            try
            {
                using (token.Register(thread.Interrupt))
                    return _sem.TryAcquire(milliseconds, TimeUnit.MILLISECONDS);
            }
            catch (Java.Lang.InterruptedException ex)
            {
                throw new OperationCanceledException("operation canceled", ex, token);
            }
        }

        public bool Wait(TimeSpan timeSpan, CancellationToken token)
        {
            return Wait((Int32)timeSpan.TotalMilliseconds, token);
        }

        public bool Wait(Int32 milliseconds)
        {
            return Wait(milliseconds, default(CancellationToken));
        }

        public void Release(int count)
        {
            _sem.Release(count);
        }

        public void Release()
        {
            _sem.Release();
        }
    }
}
