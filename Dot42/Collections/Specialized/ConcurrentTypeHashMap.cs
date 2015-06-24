using System;

namespace Dot42.Collections.Specialized
{
    /// <summary>
    /// This class map a 'Type' to some other value.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    internal class ConcurrentTypeHashMap<TValue> : FastConcurrentHashMap<Type,TValue>
    {
        public ConcurrentTypeHashMap() : base(true)
        {
        }
    }
}
