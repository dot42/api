//#define HASH_MAP_PERFORMANCE

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Java.Util;

namespace Dot42.Collections.Specialized
{
    // ideas based upon http://java-performance.info/implementing-world-fastest-java-int-to-int-hash-map/
    // but heavily extended.
    [SuppressMessage("dot42", "StaticFieldInGenericType")]
    [SuppressMessage("dot42", "StaticConstructorUsesGenericParameter")]
    internal abstract class OpenHashMapBase<K, V> : IOpenHashMap<K, V>, IEnumerable<KeyValuePair<K, V>>
    {
        public const int DefaultSize = 16;

        public const float DefaultFillFactor = 0.275f;
        public const float DefaultFillFactor2 = 0.75f;
        public const int DefaultFillFactor2Threshold = 400;

        protected const int EntrySize = 2;
        protected const int EntryShift = 1;
        
        protected const object FreeKey = null;

        private class Removed { } // mainly for the debugger.
    
        protected static readonly object RemovedKey = new Removed();

        internal protected abstract V Put(K key, V v, bool onlyIfAbsent);
        public abstract V Get(K key);
        public abstract bool Contains(K key);
        public abstract bool TryGetValue(K key, out V value);
        public abstract bool Remove(K key);

        public abstract IOpenHashMap<K, V> Clone(int newSize);

        internal class Value<V>
        {
            public V Val;
            public bool Found;
        }
        /// <summary>
        /// Keys and values
        ///  </summary>
        protected object[] m_data;

        /// <summary>
        /// Value for the null key (if inserted into a map)
        /// </summary>
        protected object m_nullValue;
        protected bool m_hasNull;

        /// <summary>
        /// Fill factor, must be between (0 and 1) 
        /// </summary>
        private readonly float m_fillFactor;
        private readonly float m_fillFactor2;
        private readonly int m_fillFactor2Threshold;

        /// <summary>
        /// We will resize a map once it reaches this size
        /// </summary>
        protected int m_threshold;
        /// <summary>
        /// Current map size </summary>
        protected int m_size;
        /// <summary>
        /// Mask to calculate the original position 
        /// </summary>
        protected int m_mask;
        /// <summary>
        /// Mask to wrap the actual array pointer
        ///  </summary>
        protected int m_mask2;

#if HASH_MAP_PERFORMANCE
        protected int m_totalGets;
        protected int m_totalAccesses;

        public float AverageComparisonsPerGet { get { return (float)m_totalAccesses/m_totalGets; } }
#endif
        protected OpenHashMapBase(int size, float fillFactor, int fillFactorThreshhold, float fillFactor2)
        {
            if (fillFactor <= 0 || fillFactor >= 1 || fillFactor2 <= 0 || fillFactor2 >= 1)
            {
                throw new ArgumentException("FillFactor must be in (0, 1)");
            }
            if (size <= 0)
            {
                throw new ArgumentException("Size must be positive!");
            }

            if (size < DefaultSize)
                size = DefaultSize;
            
            m_fillFactor = fillFactor;
            m_fillFactor2 = fillFactor2;
            m_fillFactor2Threshold = fillFactorThreshhold;

            InitializeEmpty(size);
        }

        /// <summary>
        /// Clones the hash map.
        /// </summary>
        protected OpenHashMapBase(OpenHashMapBase<K,V> other, int newSize)
        {
            m_fillFactor = other.m_fillFactor;
            m_fillFactor2 = other.m_fillFactor2;
            m_fillFactor2Threshold = other.m_fillFactor2Threshold;

#if HASH_MAP_PERFORMANCE
            m_totalAccesses = other.m_totalAccesses;
            m_totalGets = other.m_totalGets;
#endif

            if (newSize < 0)
            {
                InitializeEmpty(DefaultSize);
                return;
            }

            if (newSize < other.m_size)
                newSize = other.m_size;

            if (newSize < DefaultSize)
                newSize = DefaultSize;

            m_mask      = other.m_mask;
            m_mask2     = other.m_mask2;
            m_threshold = other.m_threshold;

            m_hasNull   = other.m_hasNull;
            m_nullValue = other.m_nullValue;

            int newCapacity = Tools.ArraySize(newSize, FillFactorForSize(newSize));

            if (2 * newCapacity == other.m_data.Length)
            {
                m_data = Arrays.CopyOf(other.m_data, other.m_data.Length);
                m_size = other.m_size;    
            }
            else
            {
                Rehash(newCapacity, other);
            }
        }

        [Inline]
        private float FillFactorForSize(int size)
        {
            return m_fillFactor2Threshold <= 0 || size < m_fillFactor2Threshold 
                    ? m_fillFactor 
                    : m_fillFactor2;
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

        private void InitializeEmpty(int size)
        {
            var fillFactor = FillFactorForSize(size);
            int capacity = Tools.ArraySize(size, fillFactor);
            m_threshold = (int)(capacity * fillFactor);
            m_mask      = capacity - 1;
            m_mask2     = capacity * 2 - 1;
            m_hasNull   = false;
            m_nullValue = null;

            m_data = new object[capacity * 2];
            //Arrays.Fill(m_data, FreeKey); // not needed any more, since FreeKey is null
        }

        protected virtual void Rehash(int newCapacity, OpenHashMapBase<K, V> source)
        {
            var fillFactor = FillFactorForSize(m_size);
            m_threshold = (int)(newCapacity * fillFactor);
            m_mask      = newCapacity  - 1;
            m_mask2     = newCapacity * 2 - 1;

            object[] sourceData = source.m_data;

            m_data = new object[newCapacity * 2];
            m_size = m_hasNull ? 1 : 0;
            //Arrays.Fill(m_data, FreeKey); // not needed any more, since FreeKey is null

            int oldLength = sourceData.Length;
            for (int i = 0; i < oldLength; i += 2)
            {
                object oldKey = sourceData[i];
                if (oldKey != FreeKey && oldKey != RemovedKey)
                {
                    Put((K)oldKey, (V)sourceData[i + 1], false);
                }
            }
        }

        protected /*V*/ bool RemoveNullKey()
        {
            if (m_hasNull)
            {
                //object ret = m_nullValue;
                m_nullValue = null;
                m_hasNull = false;
                --m_size;
                return true /*(V)ret*/;
            }
             
            return /*default(V)*/ false;
        }

        protected V InsertNullKey(V value)
        {
            if (m_hasNull)
            {
                object ret = m_nullValue;
                m_nullValue = value;
                return (V)ret;
            }

            m_nullValue = value;
            ++m_size;
            return default(V);
        }

        public void Clear()
        {
            InitializeEmpty(DefaultSize);
        }

        public bool ContainsValue(V value)
        {
            var data = m_data;
            var length = data.Length;
            for (int i = 0; i < length; ++i)
            {
                var k = data[i];
                if (k == FreeKey || k == RemovedKey)
                    continue;
                var val = data[i + 1];
                if (Equals(value, val))
                    return true;
            }
            return false;
        }


        #region IEnumerator

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }

        private abstract class EnumeratorBase
        {
            private const int InitialPosition = -2;
            protected const int NullPosition = -1;

            protected readonly OpenHashMapBase<K, V> m_map;
            protected int  m_position;
            protected bool m_isOnNull = false;

            protected EnumeratorBase(OpenHashMapBase<K, V> map)
            {
                m_map = map;
                m_position = InitialPosition;  
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (m_position < 0)
                {
                    if (m_position == InitialPosition && m_map.m_hasNull)
                    {
                        m_position = NullPosition;
                        return true;
                    }
                    m_position = InitialPosition;
                }
                
                var data = m_map.m_data;
                var length = data.Length;

                m_position += EntrySize;

                while (m_position < length)
                {
                    object key = data[m_position];

                    if (key != FreeKey && key != RemovedKey)
                        return true;

                    m_position += EntrySize;
                }

                return false;
            }

            public void Reset()
            {
                m_position = InitialPosition;
                m_isOnNull = false;
            }
        }

        private class Enumerator : EnumeratorBase, IEnumerator<KeyValuePair<K, V>>, IDictionaryEnumerator
        {
            public Enumerator(OpenHashMapBase<K, V> map) : base(map)
            {
            }

            object IEnumerator.Current { get { return Current; } }

            public KeyValuePair<K, V> Current
            {
                get
                {
                    var data = m_map.m_data;
                    var position = m_position;

                    if (position < 0 || position >= data.Length)
                    {
                        if (position == NullPosition)
                        {
                            return new KeyValuePair<K, V>(default(K), (V)m_map.m_nullValue);    
                        }

                        throw new InvalidOperationException();
                    }

                    return new KeyValuePair<K, V>((K)data[position], (V)data[position + 1]);
                }
            }

            // historical interface. we don't care for the last performance kick.
            public DictionaryEntry Entry { get { var cur = Current; return new DictionaryEntry(cur.Key, cur.Value);} } 
            public object Key   { get { return Current.Key; } }
            public object Value { get { return Current.Value; } }
        }
        #endregion

        #region Key/Value Collections

        public System.Collections.Generic.ICollection<K> Keys { get { return new KeyCollection(this); } }
        public System.Collections.Generic.ICollection<V> Values { get { return new ValueCollection(this); } }

        public class KeyCollection : System.Collections.Generic.ICollection<K>, ICollection
        {
            private readonly OpenHashMapBase<K, V> m_map;

            public KeyCollection(OpenHashMapBase<K, V> map)
            {
                m_map = map;
            }

            /// <summary>
            /// Gets an enummerator to enumerate over all elements in this sequence.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<K> GetEnumerator()
            {
                return new Enumerator(m_map);
            }

            /// <summary>
            /// Gets an enummerator to enumerate over all elements in this sequence.
            /// </summary>
            /// <returns></returns>
            IEnumerator IEnumerable.GetEnumerator()
            {
                return new Enumerator(m_map);
            }

            public int Count { get { return m_map.Size; } }

            public bool IsReadOnly { get { return true; } }

            public void Add(K item)
            {
                m_map.Put(item, default(V));
            }

            public void Clear()
            {
                m_map.Clear();
            }

            public bool Contains(K item)
            {
                return m_map.Contains(item);
            }

            public bool Remove(K item)
            {
                return m_map.Remove(item);
            }

            public void CopyTo(K[] array, int index)
            {
                Dot42.Collections.Collections.CopyTo(this, array, index);
            }

            public bool IsSynchronized { get { return false; } }
            public object SyncRoot {get { throw new NotImplementedException("System.Collections.Generic.Dictionary<,>KeyCollection.SyncRoot"); } }

            public void CopyTo(Array array, int index)
            {
                Dot42.Collections.Collections.CopyTo(this, array, index);
            }

            private class Enumerator : EnumeratorBase, IEnumerator<K>
            {
                public Enumerator(OpenHashMapBase<K, V> map) : base(map)
                {
                }

                object IEnumerator.Current { get { return Current; } }

                public K Current
                {
                    get
                    {
                        var data = m_map.m_data;
                        var position = m_position;

                        if (position < 0 || position >= data.Length)
                        {
                            if (position == NullPosition)
                            {
                                return default(K);
                            }

                            throw new InvalidOperationException();
                        }

                        return (K)data[position];
                    }
                }
            }
        }

        public class ValueCollection : System.Collections.Generic.ICollection<V>, ICollection
        {
            private readonly OpenHashMapBase<K, V> m_map;

            public ValueCollection(OpenHashMapBase<K, V> map)
            {
                m_map = map;
            }

            /// <summary>
            /// Gets an enummerator to enumerate over all elements in this sequence.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<V> GetEnumerator()
            {
                return new Enumerator(m_map);
            }

            /// <summary>
            /// Gets an enummerator to enumerate over all elements in this sequence.
            /// </summary>
            /// <returns></returns>
            IEnumerator IEnumerable.GetEnumerator()
            {
                return new Enumerator(m_map);
            }

            public int Count { get { return m_map.Size; } }

            public bool IsReadOnly { get { return true; } }

            public void Add(V item)
            {
                throw new InvalidOperationException();
            }

            public void Clear()
            {
                m_map.Clear();
            }

            public bool Contains(V item)
            {
                return m_map.ContainsValue(item);
            }

            public bool Remove(V item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(V[] array, int index)
            {
                Dot42.Collections.Collections.CopyTo(this, array, index);
            }

            public bool IsSynchronized { get { return false; } }
            public object SyncRoot { get { throw new NotImplementedException("System.Collections.Generic.Dictionary<,>KeyCollection.SyncRoot"); } }

            public void CopyTo(Array array, int index)
            {
                Dot42.Collections.Collections.CopyTo(this, array, index);
            }

            private class Enumerator : EnumeratorBase, IEnumerator<V>
            {
                public Enumerator(OpenHashMapBase<K, V> map)
                    : base(map)
                {
                }

                object IEnumerator.Current { get { return Current; } }

                public V Current
                {
                    get
                    {
                        var data = m_map.m_data;
                        var position = m_position;

                        if (position < 0 || position >= data.Length)
                        {
                            if (position == NullPosition)
                            {
                                return (V)m_map.m_nullValue;
                            }

                            throw new InvalidOperationException();
                        }

                        return (V)data[position + 1];
                    }
                }
            }
        }

        #endregion
    }
}
