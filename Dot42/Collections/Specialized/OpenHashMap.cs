// based upon http://java-performance.info/implementing-world-fastest-java-int-to-int-hash-map/
//#define HASH_MAP_PERFORMANCE

namespace Dot42.Collections.Specialized
{
    /// <summary>
    /// Object-2-object map based on IntIntMap4a
    /// </summary>
    internal class OpenHashMap<K, V> : OpenHashMapBase<K, V>
    {
        public OpenHashMap(int size = DefaultSize)
                : base(size, DefaultFillFactor, DefaultFillFactor2Threshold,  DefaultFillFactor2)
        {
        }

        internal OpenHashMap(int size, float fillFactor, int fillFactorThreshhold, float fillFactor2)
            : base(size, fillFactor, fillFactorThreshhold, fillFactor2)
        {
        }

        public OpenHashMap(int size, float fillFactor)
            : base(size, fillFactor, 0, fillFactor)
        {
        }


        private OpenHashMap(OpenHashMap<K, V> other, int newSize)
            : base(other, newSize)
        {
        }

        // TODO: shrink map when elements are removed.
        #region Copied Code // As we are aiming for high speed, we copy/paste this part of the code.
        // the variable parts are then inlined by the compiler.

        public override V Get(K key)
        {
#if DUMP_PERFORMANCE
            if (m_totalGets != 0)
            {
                Log.Info("dot42", "fast hash map<{6},{7}>@{0} get performance: {1}/{2}={3:F1}: size {4} capacity {5}", GetHashCode(), m_totalAccesses, m_totalGets, (float)m_totalAccesses / m_totalGets, m_size, m_data.Length/2, typeof(K).JavaGetName(), typeof(V).JavaGetName());
            }
#endif
#if DUMP_PERFORMANCE || HASH_MAP_PERFORMANCE
            ++m_totalGets;
            ++m_totalAccesses;
#endif
            if (key == null)
            {
                return (V)m_nullValue; // we null it on remove, so safe not to check a flag here
            }

            int ptr = (GetHashCode(key) & m_mask) << EntryShift;
            var data = m_data;

            while (true)
            {
                var k = data[ptr];
                if (k == FreeKey)
                {
                    return default(V); //end of chain already
                }
                if (AreEqual(k, key)) // we implicit check RemovedKey here
                {
                    return (V)data[ptr + 1];
                }

#if DUMP_PERFORMANCE || HASH_MAP_PERFORMANCE
                ++m_totalAccesses;
#endif
                ptr = (ptr + EntrySize) & m_mask2; //that's next index
            }
        }

        public override bool TryGetValue(K key, out V value)
        {
#if DUMP_PERFORMANCE
            if (m_totalGets != 0)
            {
                Log.Info("dot42", "fast hash map<{6},{7}>@{0} get performance: {1}/{2}={3:F1}: size {4} capacity {5}", GetHashCode(), m_totalAccesses, m_totalGets, (float)m_totalAccesses / m_totalGets, m_size, m_data.Length/2, typeof(K).JavaGetName(), typeof(V).JavaGetName());
            }
#endif
#if DUMP_PERFORMANCE || HASH_MAP_PERFORMANCE
            ++m_totalGets;
            ++m_totalAccesses;
#endif
            if (key == null)
            {
                value = (V)m_nullValue;
                return m_hasNull;
            }

            int ptr = (GetHashCode(key) & m_mask) << EntryShift;
            var data = m_data;

            while (true)
            {

                var k = data[ptr];
                if (k == FreeKey)
                {
                    value = default(V); //end of chain already
                    return false;
                }
                if (AreEqual(k, key)) // we implicit check RemovedKey here
                {
                    value = (V)data[ptr + 1];
                    return true;
                }

#if DUMP_PERFORMANCE || HASH_MAP_PERFORMANCE
                ++m_totalGets;
                ++m_totalAccesses;
#endif
                ptr = (ptr + EntrySize) & m_mask2; //that's next index
            }
        }

        public override bool Contains(K key)
        {
#if DUMP_PERFORMANCE
            if (m_totalGets != 0)
            {
                Log.Info("dot42", "fast hash map<{6},{7}>@{0} get performance: {1}/{2}={3:F1}: size {4} capacity {5}", GetHashCode(), m_totalAccesses, m_totalGets, (float)m_totalAccesses / m_totalGets, m_size, m_data.Length/2, typeof(K).JavaGetName(), typeof(V).JavaGetName());
            }
#endif
#if DUMP_PERFORMANCE || HASH_MAP_PERFORMANCE
            ++m_totalGets;
            ++m_totalAccesses;
#endif
            if (key == null)
            {
                return m_hasNull;
            }

            int ptr = (GetHashCode(key) & m_mask) << EntryShift;
            var data = m_data;

            while (true)
            {

                var k = data[ptr];
                if (k == FreeKey)
                {
                    return false;
                }
                if (AreEqual(k, key)) // we implicit check RemovedKey here
                {
                    return true;
                }

#if DUMP_PERFORMANCE || HASH_MAP_PERFORMANCE
                ++m_totalAccesses;
#endif
                ptr = (ptr + EntrySize) & m_mask2; //that's next index
            }
        }

        protected internal override V Put(K key, V value, bool onlyIfAbsent)
        {
            if (key == null)
            {
                return InsertNullKey(value);
            }

            int ptr = (GetHashCode(key) & m_mask) << EntryShift;
            var data = m_data;

            object k = data[ptr];

            if (k == FreeKey) //end of chain already
            {
                data[ptr] = key;
                data[ptr + 1] = value;
                if (m_size >= m_threshold)
                {
                    Rehash(data.Length, this); //size is set inside
                }
                else
                {
                    ++m_size;
                }

                return default(V);
            }

            if (AreEqual(k, key)) // we implicit check RemovedKey here
            {
                object ret = data[ptr + 1];
                if (!onlyIfAbsent)
                    data[ptr + 1] = value;
                return (V)ret;
            }

            int firstRemoved = -1;
            if (k == RemovedKey)
            {
                firstRemoved = ptr; //we may find a key later
            }

            while (true)
            {
                ptr = (ptr + EntrySize) & m_mask2; //that's next index calculation
                k = data[ptr];
                if (k == FreeKey)
                {
                    if (firstRemoved != -1)
                    {
                        ptr = firstRemoved;
                    }
                    data[ptr] = key;
                    data[ptr + 1] = value;
                    if (m_size >= m_threshold)
                    {
                        Rehash(data.Length, this); //size is set inside
                    }
                    else
                    {
                        ++m_size;
                    }
                    return default(V);
                }
                if (AreEqual(k, key))
                {
                    object ret = data[ptr + 1];

                    if (!onlyIfAbsent)
                        data[ptr + 1] = value;

                    return (V)ret;

                }
                if (k == RemovedKey)
                {
                    if (firstRemoved == -1)
                    {
                        firstRemoved = ptr;
                    }
                }
            }
        }

        public override /*V*/ bool Remove(K key)
        {
            if (key == null)
            {
                return RemoveNullKey();
            }

            // hashcode
            int ptr = (GetHashCode(key) & m_mask) << EntryShift;
            var data = m_data;

            while (true)
            {
                object k = data[ptr];

                if (k == FreeKey)
                {
                    return false; //default(V); //end of chain already
                }

                if (AreEqual(k, key)) // we implicit check RemovedKey here
                {
                    --m_size;
                    if (data[(ptr + EntrySize) & m_mask2] == FreeKey)
                    {
                        data[ptr] = FreeKey;
                    }
                    else
                    {
                        data[ptr] = RemovedKey;
                    }

                    //V ret = (V)m_data[ptr + 1];
                    data[ptr + 1] = null;

                    return true; //ret;
                }

                ptr = (ptr + EntrySize) & m_mask2; //that's next index calculation
            }
        }

        #endregion

        [Inline]
        private int GetHashCode(K key)
        {
            var hashCode = key.GetHashCode();
            //return hashCode * Tools.IntPhi;
            hashCode *= Tools.IntPhi;
            return hashCode ^ (hashCode >> 16); // spread
        }

        [Inline]
        private bool AreEqual(object key1, object key2)
        {
            return ReferenceEquals(key1, key2) || key1.Equals(key2);
        }

        public override IOpenHashMap<K, V> Clone(int newSize)
        {
            return new OpenHashMap<K, V>(this, newSize);
        }
    }

}