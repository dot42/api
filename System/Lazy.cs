using System;
using Java.Util.Concurrent.Atomic;

namespace System
{
    public class Lazy<T> where T: class 
    {
        private readonly Func<T> _initializor;
        private readonly AtomicReference<T> _instance = new AtomicReference<T>();

        public T Value
        {
            get
            {
                T foo = _instance.Get();
                if (foo != null) return foo;
                _instance.CompareAndSet(null, _initializor());
                return _instance.Get();
            }
        }

        public Lazy(Func<T> initializor)
        {
            _initializor = initializor;
        }
    }
}
