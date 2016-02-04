using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace System
{
    [SuppressMessage("dot42", "StaticConstructorUsesGenericParameter")]
    public class Lazy<T> where T: class 
    {
        private readonly Func<T> _initializor;
        private T _instance;

        public Lazy(Func<T> initializor)
        {
            _initializor = initializor;
        }

        public T Value
        {
            get
            {
                T foo = _instance;
                if (foo != null) return foo;

                Interlocked.CompareExchange(ref _instance, _initializor(), null);
                return _instance;
            }
        }

        public bool IsValueCreated
        {
            get
            {
                return _instance != null;    
            }
        }

    }
}
