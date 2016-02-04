using System.Threading;
using Dot42;

namespace Java.Util.Concurrent.Atomic
{
    [Include(TypeCondition=typeof(Interlocked), ApplyToMembers=true)]
    public partial class AtomicLongFieldUpdater<T>
    {
        public long CompareExchange(T obj, long value, long comparand)
        {
            while (true)
            {
                if (CompareAndSet(obj, comparand, value))
                    return comparand;

                // Note that previousVal might not be the same as the one CompareAndSet 
                // compared to. As long as they differ, this is unobservable to the 
                // caller: no action has been taken; CompareAndSet could
                // have been called at the same time as 'Get' with the same result.
                long previousVal = Get(obj);
                if (previousVal != comparand)
                    return previousVal;
            }
        }
    }

    [Include(TypeCondition = typeof(Interlocked), ApplyToMembers = true)]
    public partial class AtomicIntegerFieldUpdater<T>
    {
        public int CompareExchange(T obj, int value, int comparand)
        {
            while (true)
            {
                
                if (CompareAndSet(obj, comparand, value))
                    return comparand;

                // Note that previousVal might not be the same as the one CompareAndSet 
                // compared to. As long as they differ, this is unobservable to the 
                // caller: no action has been taken; CompareAndSet could
                // have been called at the same time as 'Get' with the same result.
                int previousVal = Get(obj);
                if (previousVal != comparand)
                    return previousVal;
            }
        }
    }

    [Include(TypeCondition = typeof(Interlocked), ApplyToMembers = true)]
    public partial class AtomicReferenceFieldUpdater<T, V>
    {
        public V CompareExchange(T obj, V value, V comparand)
        {
            while (true)
            {
                
                if (CompareAndSet(obj, comparand, value))
                    return comparand;

                // Note that previousVal might not be the same as the one CompareAndSet 
                // compared to. As long as they differ, this is unobservable to the 
                // caller: no action has been taken; CompareAndSet could
                // have been called at the same time as 'Get' with the same result.
                V previousVal = Get(obj);
                if(!ReferenceEquals(previousVal, comparand))
                    return previousVal;
            }
        }
    }
}
