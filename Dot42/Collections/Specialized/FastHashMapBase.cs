using System;
using System.Diagnostics.CodeAnalysis;
using Java.Util;

namespace Dot42.Collections.Specialized
{
    // based upon http://java-performance.info/implementing-world-fastest-java-int-to-int-hash-map/
    [SuppressMessage("dot42", "StaticFieldInGenericType")]
    public abstract class FastHashMapBase<K, V> : IFastHashMap<K, V>
    {
        public const float DefaultFillFactor = 0.75f;
        public const int DefaultSize = 16;
        
        protected static readonly object FreeKey = new object();
        protected static readonly object RemovedKey = new object();
        
        protected abstract V Put(K key, V v, bool onlyIfAbsent);
        public abstract V Get(K key);
        public abstract V Remove(K key);
        public abstract IFastHashMap<K, V> Clone(int newSize);

        /// <summary>
        /// Keys and values </summary>
        protected object[] m_data;

        /// <summary>
        /// Value for the null key (if inserted into a map) </summary>
        protected object m_nullValue;
        private bool m_hasNull;

        /// <summary>
        /// Fill factor, must be between (0 and 1) </summary>
        private readonly float m_fillFactor;
        /// <summary>
        /// We will resize a map once it reaches this size </summary>
        protected int m_threshold;
        /// <summary>
        /// Current map size </summary>
        protected int m_size;
        /// <summary>
        /// Mask to calculate the original position </summary>
        protected int m_mask;
        /// <summary>
        /// Mask to wrap the actual array pointer </summary>
        protected int m_mask2;

        public FastHashMapBase(int size = DefaultSize, float fillFactor = DefaultFillFactor)
        {
            if (fillFactor <= 0 || fillFactor >= 1)
            {
                throw new ArgumentException("FillFactor must be in (0, 1)");
            }
            if (size <= 0)
            {
                throw new ArgumentException("Size must be positive!");
            }

            if (size < DefaultSize)
                size = DefaultSize;

            int capacity = Tools.ArraySize(size, fillFactor);
            m_mask = capacity - 1;
            m_mask2 = capacity * 2 - 1;
            m_fillFactor = fillFactor;

            m_data = new object[capacity * 2];
            Arrays.Fill(m_data, FreeKey);

            m_threshold = (int)(capacity * fillFactor);
        }

        /// <summary>
        /// Clones the hash map.
        /// </summary>
        protected FastHashMapBase(FastHashMapBase<K,V> other, int newSize = -1)
        {
            if (newSize < other.m_size)
                newSize = other.m_size;

            if (newSize < DefaultSize)
                newSize = DefaultSize;

            m_mask = other.m_mask;
            m_mask2 = other.m_mask2;
            m_fillFactor = other.m_fillFactor;
            m_threshold = other.m_threshold;

            int newCapacity = 2 * Tools.ArraySize(newSize, m_fillFactor);

            if (newCapacity == other.m_data.Length)
            {
                m_data = Arrays.CopyOf(other.m_data, other.m_data.Length);
            }
            else
            {
                m_data = other.m_data;
                Rehash(newCapacity);
            }
        }

        public int Size { get { return m_size; } }

        public V Put(K key, V value)
        {
            return Put(key, value, false);
        }

        public V PutIfAbsent(K key, V value)
        {
            return Put(key, value, true);
        }

        protected void Rehash(int newCapacity)
        {
            m_threshold = (int)(newCapacity / 2 * m_fillFactor);
            m_mask = newCapacity / 2 - 1;
            m_mask2 = newCapacity - 1;

            int oldCapacity = m_data.Length;
            object[] oldData = m_data;

            m_data = new object[newCapacity];
            Arrays.Fill(m_data, FreeKey);

            m_size = m_hasNull ? 1 : 0;

            for (int i = 0; i < oldCapacity; i += 2)
            {
                object oldKey = oldData[i];
                if (oldKey != FreeKey && oldKey != RemovedKey)
                {
                    Put((K)oldKey, (V)oldData[i + 1]);
                }
            }
        }

        protected V RemoveNullKey()
        {
            if (m_hasNull)
            {
                object ret = m_nullValue;
                m_nullValue = null;
                m_hasNull = false;
                --m_size;
                return (V)ret;
            }
            else
            {
                return default(V);
            }
        }

        protected V InsertNullKey(V value)
        {
            if (m_hasNull)
            {
                object ret = m_nullValue;
                m_nullValue = value;
                return (V)ret;
            }
            else
            {
                m_nullValue = value;
                ++m_size;
                return default(V);
            }
        }
    }
}
