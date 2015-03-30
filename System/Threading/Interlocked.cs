using System.Runtime.CompilerServices;

namespace System.Threading
{
    /// <summary>
    /// This class is here mainly because Fody.PropertyChanged needs an implementation.
    /// 
    /// A proper implementation would let the dot42 compiler detect all accesses to 
    /// Interlocked, and on-the-fly replace all usages of interlocked fields with their 
    /// AtomicXXX counterparts.
    /// </summary>
    [Obsolete("please try not to use this class, since the implementation makes use of a lock, which of course defeats the whole purpose of a lighweight Interlocked. Use javas AtomicXXX instead. Please note that the compiler will make use of this class to implement events.")]
    internal static class Interlocked
    {
        // NOTE: all calls to this class are managed by the compiler,
        //       no explicit locking is needed here.

        public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
        {
            T ret = location1;
            if (location1 == comparand)
                location1 = value;
            return ret;
        }

        public static int Increment(ref Int32 obj) 
        {
                return obj++;
        }

        public static int Decrement(ref Int32 obj)
        {
            return obj--;
        }

        public static Int64 Increment(ref Int64 obj)
        {
            return obj++;
        }

        public static Int64 Decrement(ref Int64 obj)
        {
            return obj--;
        }
    }
}
