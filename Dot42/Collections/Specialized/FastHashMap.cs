// based upon http://java-performance.info/implementing-world-fastest-java-int-to-int-hash-map/


namespace Dot42.Collections.Specialized
{
    /// <summary>
    /// Object-2-object map based on IntIntMap4a
    /// </summary>
    public class FastHashMap<K, V> : FastHashMapBase<K, V>
    {
        public FastHashMap(int size = DefaultSize, float fillFactor = DefaultFillFactor)
                : base(size, fillFactor)
        {
        }

        private FastHashMap(FastHashMap<K, V> other, int newSize)
            : base(other, newSize)
        {
        }

        public override V Get(K key)
        {
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
            if (AreEqual(k, key)) //we check FREE and REMOVED prior to this call
            {
                return (V)m_data[ptr + 1];
            }

            while (true)
            {
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

        protected override V Put(K key, V value, bool onlyIfAbsent)
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
                    Rehash(m_data.Length * 2); //size is set inside
                }
                else
                {
                    ++m_size;
                }
                return default(V);
            }
            if (AreEqual(k, key)) //we check FREE and REMOVED prior to this call
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
                        Rehash(m_data.Length * 2); //size is set inside
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

            object k = m_data[ptr];
            if (k == FreeKey)
            {
                return default(V); //end of chain already
            }
            // equals
            if (AreEqual(k, key)) //we check FREE and REMOVED prior to this call
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
            while (true)
            {
                ptr = (ptr + 2) & m_mask2; //that's next index calculation
                k = m_data[ptr];
                if (k == FreeKey)
                {
                    return default(V);
                }
                // equals
                if (AreEqual(k, key))
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
            }
        }

        [Inline]
        private int GetHashCode(K key)
        {
            return key.GetHashCode();
        }

        [Inline]
        private bool AreEqual(object key1, object key2)
        {
            return key1.Equals(key2);
        }

        public override IFastHashMap<K, V> Clone(int newSize)
        {
            return new FastHashMap<K, V>(this, newSize);
        }
    }

}