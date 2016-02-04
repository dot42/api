using System;
using System.Threading;
using Java.Lang.Ref;

namespace Dot42.Internal
{
    /// <summary>
    /// suitable for a cache that gets automagically exempted under memory pressure.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LazyAndWeak<T> where T : class
    {
        private readonly Func<T> _initializor;
        private SoftReference<T> _instance;

        public T Value
        {
            get
            {
                SoftReference<T> reference = _instance;
                T value = null;

                if (reference != null) 
                    value = reference.Get();

                if (value == null)
                {
                    value = _initializor();
                    var newReference = new SoftReference<T>(value);

                    while (true)
                    {
                        var oldReference = Interlocked.CompareExchange(ref _instance, newReference, reference);

                        if (oldReference == reference)
                            // we set our value.
                            break;

                        // someone else was faster.
                        T otherValue = oldReference.Get();
                        if (otherValue != null)
                        {
                            value = otherValue;
                            newReference.Clear();
                            break;
                        }

                        // the others value has already been collected. try again.
                        reference = oldReference;
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
