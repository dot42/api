using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Java.Lang.Ref;
using Java.Util;

namespace Dot42.Collections.Specialized
{
    /// <summary>
    /// used as base class for OpenWeakReferenceHashMap/OpenSoftReferenceHashMap
    /// Not used at the moment.
    /// </summary>
    internal abstract class OpenReferenceHashMapBase<K, V> : IOpenHashMap<K, V>
    {
        public const float DefaultFillFactor = 0.55f;
        public const int DefaultSize = 16;

        [SuppressMessage("dot42", "StaticFieldInGenericType")]
        protected static readonly object FreeKey = new object();
        [SuppressMessage("dot42", "StaticFieldInGenericType")]
        protected static readonly object RemovedKey = new object();

        protected ReferenceQueue<K> m_queue = new ReferenceQueue<K>();

        public abstract IOpenHashMap<K, V> Clone(int newSize);
        protected abstract Reference<K> CreateReference(K key);

        /// <summary>
        /// Keys and values </summary>
        protected object[] m_data;

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

        private bool _containsStaleEntries;
        public bool ContainsStaleEntries { get { return _containsStaleEntries; } }

        public OpenReferenceHashMapBase(int size, float fillFactor = DefaultFillFactor)
        {
            if (fillFactor <= 0 || fillFactor >= 1)
            {
                throw new ArgumentException("FillFactor must be in (0, 1)");
            }
            if (size <= 0)
            {
                throw new ArgumentException("Size must be positive!");
            }

            m_fillFactor = fillFactor;
            InitializeEmpty(size);
        }

        /// <summary>
        /// Clones the hash map.
        /// </summary>
        protected OpenReferenceHashMapBase(OpenReferenceHashMapBase<K, V> other, int newSize)
        {
            m_fillFactor = other.m_fillFactor;

            if (newSize < 0)
            {
                InitializeEmpty(DefaultSize);
                return;
            }

            if (newSize < other.m_size)
                newSize = other.m_size;

            if (newSize < DefaultSize)
                newSize = DefaultSize;

            m_mask = other.m_mask;
            m_mask2 = other.m_mask2;
            m_threshold = other.m_threshold;

            // we need new references, to keep our referencequeue up to date.
            m_data = other.m_data;
            int newCapacity = Tools.ArraySize(newSize, other.m_fillFactor) * 2;
            Rehash(newCapacity);
        }

        public int Size { get { return m_size; } }

        private void InitializeEmpty(int size)
        {
            int capacity = Tools.ArraySize(size, m_fillFactor);
            m_mask = capacity - 1;
            m_mask2 = capacity * 2 - 1;


            m_data = new object[capacity * 2];
            Arrays.Fill(m_data, FreeKey);

            m_threshold = (int)(capacity * m_fillFactor);
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

            m_queue = new ReferenceQueue<K>();

            m_size = 0;

            for (int i = 0; i < oldCapacity; i += 2)
            {
                object oldKey = oldData[i];
                if (oldKey != FreeKey && oldKey != RemovedKey)
                {
                    var reference = (Reference<K>)oldKey;
                    object kk;
                    if ((kk = reference.Get()) != null && !reference.IsEnqueued)
                        Put((K)kk, (V)oldData[i + 1]);
                }
            }
        }

        public V Get(K key)
        {
            if (key == null)
                throw new ArgumentNullException("key");

            // hashcode
            int ptr = (GetHashCode(key) & m_mask) << 1;
            object k = m_data[ptr];

            if (k == FreeKey)
            {
                return default(V); //end of chain already
            }

            k = ExtractKey(k);
            
            // equals
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

                k = ExtractKey(k);

                // equals
                if (AreEqual(k, key))
                {
                    return (V)m_data[ptr + 1];
                }
            }
        }

        public V PutIfAbsent(K key, V value)
        {
            return Put(key, value, true);
        }

        public V Put(K key, V value)
        {
            return Put(key,value,false);
        }

        private V Put(K key, V value, bool onlyIfAbsent)
        {
            if (key == null)
                throw new ArgumentNullException("key");

            // hashcode
            int ptr = (GetHashCode(key) & m_mask) << 1;
            object k = m_data[ptr];

            if (k == FreeKey) //end of chain already
            {
                m_data[ptr] = CreateReference(key);
                m_data[ptr + 1] = value;
                if (m_size >= m_threshold)
                {
                    Rehash(m_data.Length * 2); //size is set inside
                }
                else
                {
                    ++m_size;
                }

                if (_containsStaleEntries)
                    ExpungeStaleEntries();

                return default(V);
            }

            k = ExtractKey(k);

            // equals
            if (AreEqual(k, key)) //we check FREE and REMOVED prior to this call
            {
                object ret = m_data[ptr + 1];

                if (!onlyIfAbsent)
                    m_data[ptr + 1] = value;

                if (_containsStaleEntries)
                    ExpungeStaleEntries();

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
                    m_data[ptr] = CreateReference(key);
                    m_data[ptr + 1] = value;
                    if (m_size >= m_threshold)
                    {
                        Rehash(m_data.Length * 2); //size is set inside
                    }
                    else
                    {
                        ++m_size;
                    }

                    if (_containsStaleEntries)
                        ExpungeStaleEntries();

                    return default(V);
                }

                // equals
                k = ExtractKey(k);

                if (AreEqual(k, key))
                {
                    object ret = m_data[ptr + 1];

                    if (!onlyIfAbsent)
                        m_data[ptr + 1] = value;

                    if (_containsStaleEntries)
                        ExpungeStaleEntries();

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

        public bool Remove(K key)
        {
            if (_containsStaleEntries)
                ExpungeStaleEntries(); 
            
            if (key == null)
                throw new ArgumentNullException("key");

            // hashcode
            int ptr = (GetHashCode(key) & m_mask) << 1;
            
            while (true)
            {
                object k = m_data[ptr];

                if (k == FreeKey)
                {
                    //return default(V); //end of chain already
                    return false;
                }

                k = ExtractKey(k);

                // equals
                if (k == null || AreEqual(k, key)) //we check FREE and REMOVED prior to this call
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

                    //V ret = (V)m_data[ptr + 1];
                    m_data[ptr + 1] = null;

                    if(k != null)
                        return true /*ret*/;
                }

                ptr = (ptr + 2) & m_mask2; //that's next index calculation
            }
        }

        [Inline]
        private int GetHashCode(K key)
        {
            int hashCode = Java.Lang.System.IdentityHashCode(key);
            return hashCode ^ (hashCode >> 16); // spread
        }

        [Inline]
        private bool AreEqual(object key1, object key2)
        {
            return ReferenceEquals(key1, key2);
        }

        private void ExpungeStaleEntries()
        {
            _containsStaleEntries = false;
            object obj;
            while ((obj = m_queue.Poll()) != null)
            {
                Remove((K)obj);
            }
        }
        
        [Inline]
        private object ExtractKey(object k)
        {
            var reference = k as Reference<K>;
            var kk = reference == null ? (object)null : reference.Get(); // seems to be important to call the get method (?!)

            if (kk != null && !reference.IsEnqueued)
                return kk;

            _containsStaleEntries = true;
            return k;
        }

        [Conditional("DEBUG")]
        public void Dump()
        {
            Debug.WriteLine("dumping {0}", this);
            for (int i = 0; i < m_data.Length; i+=2)
            {
                var key = m_data[i];
                bool isFree = key == FreeKey;
                bool isRemoved = key == RemovedKey;
                bool isQueued = false;
                if (!isFree && !isRemoved)
                {
                    var r = (Reference<K>) key;
                    isQueued = r.IsEnqueued;
                    key = r.Get();

                }
                Debug.WriteLine("  {0}={1}", isFree ? "(empty)" : isRemoved ? "(rem)" : (isQueued?"q: " : "" + key), m_data[i + 1]);
            }
        }

    }
}
