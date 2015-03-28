using System;
using Java.Lang.Ref;
using Java.Util.Concurrent.Atomic;

namespace Dot42.Internal
{
    /// <summary>
    /// suitable for a cache that gets automagically exempted under memory pressure.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LazyAndWeak<T> where T : class
    {
        private readonly Func<T> _initializor;
        private readonly AtomicReference<SoftReference<T>> _instance = new AtomicReference<SoftReference<T>>();

        public T Value
        {
            get
            {
                SoftReference<T> @ref = _instance.Get();
                T value = null;

                if (@ref != null) value = @ref.Get();

                if (value == null)
                {
                    value = _initializor();
                    if (!_instance.CompareAndSet(null, new SoftReference<T>(value)))
                    {
                        // someone else was faster.
                        @ref = _instance.Get();
                        T otherValue = @ref.Get();
                        if (otherValue != null)
                            value = otherValue;
                        else
                        {
                            // already collected again. 
                            // just force our value.
                            _instance.Set(new SoftReference<T>(value));
                        }
                    }
                }

                return value;

            }
        }

        public LazyAndWeak(Func<T> initializor)
        {
            _initializor = initializor;
        }
    }
}
