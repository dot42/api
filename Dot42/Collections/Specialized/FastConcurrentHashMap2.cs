using System;
using Java.Util;

namespace Dot42.Collections.Specialized
{
    // This implementation yields a little bit less performance than FastConcurrentHashMap.

    ///// <summary>
    ///// This concurrent Map is optimized for situations where read accesses by far outperform 
    ///// write accesses, as it is typical for e.g. caching maps.
    ///// <para>
    ///// Write accesses will always use a lock. Read operations will only use a lock if values
    ///// were recently written to the map, and the request is for one of the recently written 
    ///// values or a non-existent value.
    ///// </para>
    ///// <para>
    ///// If no values are written, request for existing values will result in exactly one volatile
    ///// field access. Requests for non-existing values will result in two volatile field accesses.
    ///// </para>
    ///// </summary>
    //internal class FastConcurrentHashMap2<TKey, TVal> /*: IFastHashMap<TKey, TVal>*/
    //{
    //    // We don't work with the IFastHashMap interface, because that adds another one or two 
    //    // stub calls on each invocation. For usage with the FastWeakReferenceHashMap we probably 
    //    // need to create another implementation.

    //    private const int CopyWriteMapAfterThreshold = 10;

    //    private volatile HashMap<TKey, TVal> _readMap;

    //    private volatile HashMap<TKey, TVal> _writeMap;
    //    private int _writeMapAccessCounter;
    //    private readonly object _sync = new object();

    //    internal FastConcurrentHashMap2()
    //    {
    //        _readMap = new HashMap<TKey, TVal>();
    //    }

    //    public int Size
    //    {
    //        [Inline]
    //        get { return _readMap.Size(); }
    //    }

    //    public TVal Get(TKey key)
    //    {
    //        // Try the fast path.
    //        var ret = _readMap.Get(key);

    //        if (ret != null)
    //            return ret;

    //        // This second volatile field access is not strictly required for a caching map,
    //        // that will 'PutIfAbsent' or 'Put' if we return null anyway. For those types it
    //        // would suffice if we always return null, or make the write map non-volatile.
    //        // As a caching map will on the other hand hopefully most of the time have 
    //        // cache-hits, this volatile access should not hurt too much.
    //        if (_writeMap == null)
    //            return default(TVal);

    //        // walk the slow path.
    //        lock (_sync)
    //        {
    //            ++_writeMapAccessCounter;

    //            var map = _writeMap;

    //            if (++_writeMapAccessCounter > CopyWriteMapAfterThreshold)
    //            {
    //                // Set the read map after a number of servings from the write map.
    //                _readMap = map;
    //                _writeMap = null;
    //                _writeMapAccessCounter = 0;
    //            }

    //            return map.Get(key);
    //        }
    //    }

    //    public TVal Put(TKey key, TVal value)
    //    {
    //        if(value == null)
    //            throw new ArgumentNullException();

    //        lock (_sync)
    //        {
    //            _writeMapAccessCounter = Math.Max(_writeMapAccessCounter - 1, 0);

    //            var map = _writeMap;
    //            if (map == null)
    //            {
    //                var baseMap = _readMap;
    //                map = CloneMap(baseMap, 0);
    //                _writeMap = map;
    //            }

    //            return map.Put(key, value);
    //        }
    //    }

    //    public TVal PutIfAbsent(TKey key, TVal value)
    //    {
    //        if (value == null)
    //            throw new ArgumentNullException();

    //        lock (_sync)
    //        {
    //            _writeMapAccessCounter = Math.Max(_writeMapAccessCounter - 1, 0);

    //            var map = _writeMap;
    //            if (map == null)
    //            {
    //                var baseMap = _readMap;
    //                map = CloneMap(baseMap, 0);
    //                _writeMap = map;
    //            }

    //            if (map.ContainsKey(key))
    //                return map.Get(key);
    //            map.Put(key, value);
    //            return default(TVal);
    //        }
    //    }

    //    public bool Remove(TKey key)
    //    {
    //        lock (_sync)
    //        {
    //            var map = _writeMap;

    //            if (map != null)
    //            {
    //                if (!_writeMap.ContainsKey(key))
    //                    return false;
    //                _writeMap.Remove(key);
    //                _readMap = _writeMap;
    //                _writeMap = null;
    //                _writeMapAccessCounter = 0;
    //                return true;
    //            }

    //            map = _readMap;
    //            if (!_readMap.ContainsKey(key))
    //                return false;
    //            map = CloneMap(map, 0);
    //            map.Remove(key);
    //            _readMap = map;
    //            return true;
    //        }
    //    }

    //    public void Clear()
    //    {
    //        var empty = CloneMap(_readMap, -1);

    //        lock (_sync)
    //        {
    //            _readMap = empty;
    //            _writeMap = null;
    //            _writeMapAccessCounter = 0;
    //        }
    //    }
        
    //    [Inline]
    //    private static HashMap<TKey,TVal> CloneMap(HashMap<TKey, TVal> map, int newSize)
    //    {
    //        return new HashMap<TKey, TVal>(map);
    //    }
    //}
}
