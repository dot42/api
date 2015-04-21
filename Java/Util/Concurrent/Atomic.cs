using System.Threading;
using Dot42;

namespace Java.Util.Concurrent.Atomic
{
    [Include(TypeCondition=typeof(Interlocked), ApplyToMembers=true)]
    public partial class AtomicLongFieldUpdater<T>
    {
        public long CompareExchange(T obj, long value, long comparand)
        {
            long currentVal = Get(obj);
            if (CompareAndSet(obj, comparand, value))
                return comparand;
            // Note that currentVal might not be the same as the one CompareAndSet compared
            // to. This is unobservable to the caller though.
            return currentVal;
        }
    }

    [Include(TypeCondition = typeof(Interlocked), ApplyToMembers = true)]
    public partial class AtomicIntegerFieldUpdater<T>
    {
        public int CompareExchange(T obj, int value, int comparand)
        {
            int currentVal = Get(obj);
            if (CompareAndSet(obj, comparand, value))
                return comparand;
            // Note that currentVal might not be the same as the one CompareAndSet compared
            // to. This is unobservable to the caller though.
            return currentVal;
        }
    }

    [Include(TypeCondition = typeof(Interlocked), ApplyToMembers = true)]
    public partial class AtomicReferenceFieldUpdater<T, V>
    {
        public V CompareExchange(T obj, V value, V comparand)
        {
            V currentVal = Get(obj);
            if (CompareAndSet(obj, comparand, value))
                return comparand;
            // Note that currentVal might not be the same as the one CompareAndSet compared
            // to. This is unobservable to the caller though.
            return currentVal;
        }
    }
}
