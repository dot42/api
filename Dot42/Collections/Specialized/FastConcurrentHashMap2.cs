using System.Threading;
using Java.Util;

namespace Dot42.Collections.Specialized
{
    /// <summary>
    /// To accomplish concurrency this map will clone the underlying map on each write operation.
    /// <para/>
    /// This class is very similar to the FastConcurrentHashMap. The performance characteristics 
    /// described there hold here as well. The underlying map is a Java.Util.HashMap. This implementation
    /// map has a worse write performance compared tp FastConcurrentHashMap, but read performance
    /// is comparable or even better (except when FastConcurrentHashMap is used with 
    /// OpenReferenceEqualityHashMap which is the fastest combination).
    /// </summary>
    internal class FastConcurrentHashMap2<TKey, TVal> 
    {
        private IMap<TKey, TVal> _baseMap;

        public FastConcurrentHashMap2()
        {
            _baseMap = new HashMap<TKey, TVal>();
        }

        public int Size
        {
            [Inline]
            get { return _baseMap.Size(); }
        }

        [Inline]
        public TVal Get(TKey key)
        {
            return _baseMap.Get(key);
        }

        public TVal Put(TKey key, TVal value)
        {
            while (true)
            {
                var current = _baseMap;
                var clone = CloneMap(current, current.Size() + 1);
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
                var clone = CloneMap(current,current.Size() + 1);

                TVal ret = default(TVal);
                if(!clone.ContainsKey(key))
                    ret = clone.Put(key, value);

                if (ret == null)
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
                var clone = CloneMap(current, current.Size());
                var ret = clone.Remove(key);

                if(Interlocked.CompareExchange(ref _baseMap, clone, current) != current)
                    continue;

                return ret;
            }
        }

        public void Clear()
        {
            var clone = CloneMap(_baseMap, -1);

            while (true)
            {
                var current = _baseMap;
                if (Interlocked.CompareExchange(ref _baseMap, clone, current) != current)
                    continue;
                return;
            }
        }
        
        [Inline]
        private IMap<TKey, TVal> CloneMap(IMap<TKey, TVal> map, int newSize)
        {
            if (newSize < 0)
            {
                return new HashMap<TKey, TVal>();
            }
            return new HashMap<TKey, TVal>(map);
        }
    }
}
