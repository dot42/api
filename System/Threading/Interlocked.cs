namespace System.Threading
{
    /// <summary>
    /// This class was mainly added to be used by PropertyChanged.Fody.
    /// It is kept internal, so that the C# compiler doesn't use it when
    /// producing event code.
    /// </summary>
    [Obsolete("please try not to use this class, since the implementation makes use of a global lock atm, which of course defeats the whole purpose of a lighweight Interlocked.")]
    internal static class Interlocked
    {
        private static readonly object _sync = new object();

        [Obsolete("please try not to use this class, since the implementation makes use of a global lock atm, which of course defeats the purpose of a lighweight Interlocked.")]
        public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
        {
            lock (_sync)
            {
                T ret = location1;
                if (location1 == comparand)
                    location1 = value;
                return ret;
            }
        }

        [Obsolete("please try not to use this class, since the implementation makes use of a global lock atm, which of course defeats the purpose of a lighweight Interlocked.")]
        public static int Increment(ref Int32 obj) 
        {
            lock (_sync)
            {
                return obj++;
            }
        }

        [Obsolete("please try not to use this class, since the implementation makes use of a global lock atm, which of course defeats the purpose of a lighweight Interlocked.")]
        public static int Decrement(ref Int32 obj)
        {
            lock (_sync)
            {
                return obj--;
            }
        }

        [Obsolete("please try not to use this class, since the implementation makes use of a global lock atm, which of course defeats the purpose of a lighweight Interlocked.")]
        public static Int64 Increment(ref Int64 obj)
        {
            lock (_sync)
            {
                return obj++;
            }
        }

        [Obsolete("please try not to use this class, since the implementation makes use of a global lock atm, which of course defeats the purpose of a lighweight Interlocked.")]
        public static Int64 Decrement(ref Int64 obj)
        {
            lock (_sync)
            {
                return obj--;
            }
        }

    }
}
