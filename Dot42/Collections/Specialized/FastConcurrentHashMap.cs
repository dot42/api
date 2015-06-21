using System.Collections.Generic;
using System.Threading;

namespace Dot42.Collections.Specialized
{
    /// <summary>
    /// To accomplish concurrency this map will clone the underlying map on each write operation.
    /// <para>
    /// This can yield a performance benefit in multithreaded situations when the number of 'Get' 
    /// operation largely outperforms the number of 'Put' or 'Remove' calls.
    /// </para>
    /// </summary>
    internal class FastConcurrentHashMap<TKey, TVal> /*: IFastHashMap<TKey, TVal>*/
    {
        // We don't work with the IFastHashMap interface, because that adds another one or two 
        // stub calls on each invocation. For usage with the FastWeakReferenceHashMap we probably 
        // need to create another ImmutableHashMap implementation.

        // Note: The implicit volatile on this field, mandatorily introduced 
        //       by the use of Interlocked.CompareExchange, makes get operations
        //       on this map ca. 20 times slower as would be without 'volatile'.
        //       With javas memory model guarantees there seems to be no way of
        //       getting this field non-volatile, without introducing unrecoverable
        //       race conditions.

        /// <summary>
        /// only reads to this field are permitted.
        /// </summary>
        internal OpenHashMapBase<TKey, TVal> BaseMap;

        public FastConcurrentHashMap(OpenHashMapBase<TKey, TVal> baseMap)
        {
            BaseMap = baseMap;
        }

        public FastConcurrentHashMap()
        {
            BaseMap = new OpenHashMap<TKey, TVal>();
        }

        public FastConcurrentHashMap(IEqualityComparer<TKey> comparer)
        {
            BaseMap = new OpenEqualityComparerHashMap<TKey, TVal>(comparer);
        }

        public int Size
        {
            [Inline]
            get { return BaseMap.Size; }
        }

        [Inline]
        public TVal Get(TKey key)
        {
            return (TVal)BaseMap.Get(key);
        }

        public TVal Put(TKey key, TVal value)
        {
            while (true)
            {
                var current = BaseMap;
                var clone = CloneMap(current, current.Size + 1);
                var ret = clone.Put(key, value, false);

                if (Interlocked.CompareExchange(ref BaseMap, clone, current) != current)
                    continue;

                return ret;
            }
        }

        public TVal PutIfAbsent(TKey key, TVal value)
        {
            while (true)
            {
                var current = BaseMap;
                var clone = CloneMap(current,current.Size + 1);

                var ret = clone.Put(key, value, true);

                if (ret == null /*default(TVal)*/)
                    if (Interlocked.CompareExchange(ref BaseMap, clone, current) != current)
                        continue;

                return ret;
            }
        }

        public bool Remove(TKey key)
        {
            while (true)
            {
                var current = BaseMap;
                var clone = CloneMap(current, current.Size);
                var ret = clone.Remove(key);

                if(Interlocked.CompareExchange(ref BaseMap, clone, current) != current)
                    continue;

                return ret;
            }
        }

        public void Clear()
        {
            var clone = CloneMap(BaseMap, -1);

            while (true)
            {
                var current = BaseMap;
                if (Interlocked.CompareExchange(ref BaseMap, clone, current) != current)
                    continue;
                return;
            }
        }
        
        [Inline]
        private static OpenHashMapBase<TKey, TVal> CloneMap(OpenHashMapBase<TKey, TVal> map, int newSize)
        {
            return (OpenHashMapBase<TKey, TVal>)map.Clone(newSize);
        }
    }
}
