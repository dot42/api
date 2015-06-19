using System.Collections.Generic;
using System.Threading;

namespace Dot42.Collections.Specialized
{
    /// <summary>
    /// To accomplish concurrency this map will clone the underlying map on each write operation.
    /// <para>
    /// This can yield a performance benefits in multithreaded situations when the number of 'Get' 
    /// operation largely outperforms the number of 'Put' or 'Remove' calls.
    /// </para>
    /// </summary>
    internal class FastImmutableHashMap<TKey, TVal> : IFastHashMap<TKey, TVal>
    {
        private IFastHashMap<TKey, TVal> _baseMap;

        public FastImmutableHashMap(IFastHashMap<TKey, TVal> baseMap)
        {
            _baseMap = baseMap;
        }

        public FastImmutableHashMap()
        {
            _baseMap = new FastHashMap<TKey, TVal>();
        }

        public FastImmutableHashMap(IEqualityComparer<TKey> comparer)
        {
            _baseMap = new FastComparingHashMap<TKey, TVal>(comparer);
        }


        public int Size
        {
            get { return _baseMap.Size; }
        }

        public TVal Get(TKey key)
        {
            return _baseMap.Get(key);
        }

        public TVal Put(TKey key, TVal value)
        {
            while (true)
            {
                var current = _baseMap;
                var clone = current.Clone(current.Size + 1);
                var ret = clone.Put(key, value);

                if (Interlocked.CompareExchange(ref _baseMap, clone, current) != current)
                    continue;

                return ret;
            }
        }

        public TVal PutIfAbsent(TKey key, TVal value)
        {
            while (true)
            {
                var current = _baseMap;
                var clone = current.Clone(current.Size + 1);

                var ret = clone.PutIfAbsent(key, value);

                if (ret == null /*default(TVal)*/)
                    if (Interlocked.CompareExchange(ref _baseMap, clone, current) != current)
                        continue;

                return ret;
            }
        }

        public TVal Remove(TKey key)
        {
            while (true)
            {
                var current = _baseMap;
                var clone = current.Clone();
                var ret = clone.Remove(key);

                if(Interlocked.CompareExchange(ref _baseMap, clone, current) != current)
                    continue;

                return ret;
            }
        }


        public IFastHashMap<TKey, TVal> Clone(int newSize)
        {
            return new FastImmutableHashMap<TKey, TVal>(_baseMap.Clone(newSize));
        }
    }
}
