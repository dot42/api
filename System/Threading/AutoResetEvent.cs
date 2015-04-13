namespace System.Threading
{
    // http://stackoverflow.com/questions/1091973/javas-equivalent-to-nets-autoresetevent
    // an alternative implementation using semaphores might be: https://code.google.com/p/cages/source/browse/trunk/Cages/src/org/wyki/concurrency/AutoResetEvent.java?r=11
    public class AutoResetEvent : WaitHandle
    {
        private readonly object _monitor = new object();

        private volatile bool _isOpen = false;

        public AutoResetEvent(bool open)
        {
            _isOpen = open;
        }

        public override bool WaitOne()
        {
            base.CheckDisposed();
            lock (_monitor)
            {
                while (!_isOpen)
                {
                    _monitor.JavaWait();
                    base.CheckDisposed();
                }
                _isOpen = false;
            }
            return true;
        }

        public bool WaitOne(TimeSpan timeout)
        {
            return WaitOne((long)timeout.TotalMilliseconds);
        }

        public bool WaitOne(long timeout)
        {
            base.CheckDisposed();

            lock (_monitor)
            {
                try
                {
                    long t = Java.Lang.System.CurrentTimeMillis();
                    while (!_isOpen)
                    {
                        _monitor.JavaWait(timeout);
                        base.CheckDisposed();
                        // Check for timeout
                        if (Java.Lang.System.CurrentTimeMillis() - t >= timeout)
                            break;
                    }

                    return _isOpen;
                }
                finally
                {
                    _isOpen = false;
                }
            }
        }

        public void Set()
        {
            lock (_monitor)
            {
                _isOpen = true;
                _monitor.JavaNotify();
            }
        }

        protected override void Dispose(bool explicitDisposing)
        {
            base.Dispose(explicitDisposing);

            if (explicitDisposing)
            {
                _monitor.JavaNotifyAll();   
            }
        }

        public void Reset()
        {
            _isOpen = false;
        }
    }
}