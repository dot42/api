namespace System.Threading
{
    public static class Interlocked
    {
        // NOTE: all calls to this class are managed by the compiler,
        //       no explicit locking is needed here.
        //       In almost all cases, these calls will be redirected 
        //       to their AtomicXXXFieldUpdater counterparts.

        public static T CompareExchange<T>(ref T location, T value, T comparand) where T : class
        {
            T ret = location;
            if (location == comparand)
                location = value;
            return ret;
        }

        public static object CompareExchange(ref object location, object value, object comparand)
        {
            object ret = location;
            if (location == comparand)
                location = value;
            return ret;
        }

        public static int CompareExchange(ref int location, int value, int comparand) 
        {
            int ret = location;
            if (location == comparand)
                location = value;
            return ret;
        }

        public static long CompareExchange(ref long location, long value, long comparand)
        {
            long ret = location;
            if (location == comparand)
                location = value;
            return ret;
        }

        [Obsolete("The integrity of this call will be achieved through locking. Consider using an AtomicFloat instead.")]
        public static float CompareExchange(ref float location, float value, float comparand)
        {
            float ret = location;
            if (location == comparand)
                location = value;
            return ret;
        }

        [Obsolete("The integrity of this call will be achieved through locking. Consider using an AtomicDouble instead.")]
        public static double CompareExchange(ref double location, double value, double comparand)
        {
            double ret = location;
            if (location == comparand)
                location = value;
            return ret;
        }

        public static T Exchange<T>(ref T location, T value) where T : class
        {
            T ret = location;
            location = value;
            return ret;
        }

        public static object Exchange(ref object location, object value)
        {
            object ret = location;
            location = value;
            return ret;
        }

        public static int Exchange(ref int location, int value)
        {
            int ret = location;
            location = value;
            return ret;
        }

        public static long Exchange(ref long location, long value)
        {
            long ret = location;
            location = value;
            return ret;
        }

        [Obsolete("The integrity of this call will be achieved through locking. Consider using an AtomicFloat instead.")]
        public static float Exchange(ref float location, float value)
        {
            float ret = location;
            location = value;
            return ret;
        }

        [Obsolete("The integrity of this call will be achieved through locking. Consider using an AtomicDouble instead.")]
        public static double Exchange(ref double location, double value)
        {
            double ret = location;
            location = value;
            return ret;
        }

        public static int Increment(ref int location1) 
        {
            return unchecked(++location1);
        }

        public static long Increment(ref long location1)
        {
            return unchecked(++location1);
        }

        public static int Decrement(ref int location1)
        {
            return unchecked(--location1);
        }

        public static long Decrement(ref long location1)
        {
            return unchecked(--location1);
        }

        public static int Add(ref int location1, int add)
        {
            return unchecked(location1 += add);
        }

        public static long Add(ref long location1, long add)
        {
            return unchecked(location1 += add);
        }

        public static long Read(ref long location1)
        {
            return location1;
        }
    }
}
