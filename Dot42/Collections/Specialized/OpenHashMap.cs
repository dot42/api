// based upon http://java-performance.info/implementing-world-fastest-java-int-to-int-hash-map/


namespace Dot42.Collections.Specialized
{
    /// <summary>
    /// Object-2-object map based on IntIntMap4a
    /// </summary>
    internal class OpenHashMap<K, V> : OpenHashMapBase<K, V>
    {
        public OpenHashMap(int size = DefaultSize, float fillFactor = DefaultFillFactor)
                : base(size, fillFactor)
        {
        }

        private OpenHashMap(OpenHashMap<K, V> other, int newSize)
            : base(other, newSize)
        {
        }

        #region Copied Code // As we are aiming for high speed, we copy/paste this part of the code.
        // the variable parts are then inlined by the compiler.

#if DUMP_PERFORMANCE
        protected int m_totalGets;
        protected int m_totalAccesses;
#endif

        public override V Get(K key)
        {
#if DUMP_PERFORMANCE
            if (m_totalGets != 0)
            {
                Log.Info("dot42", "fast hash map<{6},{7}>@{0} get performance: {1}/{2}={3:F1}: size {4} capacity {5}", GetHashCode(), m_totalAccesses, m_totalGets, (float)m_totalAccesses / m_totalGets, m_size, m_data.Length/2, typeof(K).JavaGetName(), typeof(V).JavaGetName());
            }

            ++m_totalGets;
            ++m_totalAccesses;
#endif

            if (key == null)
            {
                return (V)m_nullValue; //we null it on remove, so safe not to check a flag here
            }

            int ptr = (GetHashCode(key) & m_mask) << 1;
            object k = m_data[ptr];

            if (k == FreeKey)
            {
                return default(V); //end of chain already
            }
            if (AreEqual(k, key)) // we implicit check RemovedKey here
            {
                return (V)m_data[ptr + 1];
            }

            while (true)
            {
#if DUMP_PERFORMANCE
                ++m_totalAccesses;
#endif
                ptr = (ptr + 2) & m_mask2; //that's next index
                k = m_data[ptr];
                if (k == FreeKey)
                {
                    return default(V);
                }
                if (AreEqual(k, key))
                {
                    return (V)m_data[ptr + 1];
                }
            }
        }

        public override bool Contains(K key)
        {
#if DUMP_PERFORMANCE
            if (m_totalGets != 0)
            {
                Log.Info("dot42", "fast hash map<{6},{7}>@{0} contains performance: {1}/{2}={3:F1}: size {4} capacity {5}", GetHashCode(), m_totalAccesses, m_totalGets, (float)m_totalAccesses / m_totalGets, m_size, m_data.Length/2, typeof(K).JavaGetName(), typeof(V).JavaGetName());
            }

            ++m_totalGets;
            ++m_totalAccesses;
#endif

            if (key == null)
            {
                return m_hasNull; //we null it on remove, so safe not to check a flag here
            }

            int ptr = (GetHashCode(key) & m_mask) << 1;
            object k = m_data[ptr];

            if (k == FreeKey)
            {
                return false; //end of chain already
            }
            if (AreEqual(k, key)) // we implicit check RemovedKey here
            {
                return true;
            }

            while (true)
            {
#if DUMP_PERFORMANCE
                ++m_totalAccesses;
#endif
                ptr = (ptr + 2) & m_mask2; //that's next index
                k = m_data[ptr];
                if (k == FreeKey)
                {
                    return false;
                }
                if (AreEqual(k, key))
                {
                    return true;
                }
            }
        }

        protected internal override V Put(K key, V value, bool onlyIfAbsent)
        {
            if (key == null)
            {
                return InsertNullKey(value);
            }

            int ptr = (GetHashCode(key) & m_mask) << 1;
            object k = m_data[ptr];

            if (k == FreeKey) //end of chain already
            {
                m_data[ptr] = key;
                m_data[ptr + 1] = value;
                if (m_size >= m_threshold)
                {
                    Rehash(m_data.Length, this); //size is set inside
                }
                else
                {
                    ++m_size;
                }

                return default(V);
            }

            if (AreEqual(k, key)) // we implicit check RemovedKey here
            {
                object ret = m_data[ptr + 1];
                if (!onlyIfAbsent)
                    m_data[ptr + 1] = value;
                return (V)ret;
            }

            int firstRemoved = -1;
            if (k == RemovedKey)
            {
                firstRemoved = ptr; //we may find a key later
            }

            while (true)
            {
                ptr = (ptr + 2) & m_mask2; //that's next index calculation
                k = m_data[ptr];
                if (k == FreeKey)
                {
                    if (firstRemoved != -1)
                    {
                        ptr = firstRemoved;
                    }
                    m_data[ptr] = key;
                    m_data[ptr + 1] = value;
                    if (m_size >= m_threshold)
                    {
                        Rehash(m_data.Length, this); //size is set inside
                    }
                    else
                    {
                        ++m_size;
                    }
                    return default(V);
                }
                if (AreEqual(k, key))
                {
                    object ret = m_data[ptr + 1];

                    if (!onlyIfAbsent)
                        m_data[ptr + 1] = value;

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

        public override V Remove(K key)
        {
            if (key == null)
            {
                return RemoveNullKey();
            }

            // hashcode
            int ptr = (GetHashCode(key) & m_mask) << 1;

            while (true)
            {
                object k = m_data[ptr];

                if (k == FreeKey)
                {
                    return default(V); //end of chain already
                }

                if (AreEqual(k, key)) // we implicit check RemovedKey here
                {
                    --m_size;
                    if (m_data[(ptr + 2) & m_mask2] == FreeKey)
                    {
                        m_data[ptr] = FreeKey;
                    }
                    else
                    {
                        m_data[ptr] = RemovedKey;
                    }

                    V ret = (V)m_data[ptr + 1];
                    m_data[ptr + 1] = null;

                    return ret;
                }

                ptr = (ptr + 2) & m_mask2; //that's next index calculation
            }
        }
        #endregion

        [Inline]
        private int GetHashCode(K key)
        {
            var hashCode = key.GetHashCode();
            return hashCode ^ (hashCode >> 16); // spread
        }

        [Inline]
        private bool AreEqual(object key1, object key2)
        {
            return key1.Equals(key2);
        }

        public override IOpenHashMap<K, V> Clone(int newSize)
        {
            return new OpenHashMap<K, V>(this, newSize);
        }
    }

}