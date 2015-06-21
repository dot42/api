using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Java.Util;

namespace Dot42.Collections.Specialized
{
    // based upon http://java-performance.info/implementing-world-fastest-java-int-to-int-hash-map/
    [SuppressMessage("dot42", "StaticFieldInGenericType")]
    internal abstract class OpenHashMapBase<K, V> : IOpenHashMap<K, V>, IEnumerable<KeyValuePair<K, V>>
    {
        public const float DefaultFillFactor = 0.275f;
        public const int DefaultSize = 16;
        
        protected const object FreeKey = null;
        protected static readonly object RemovedKey = new object();

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
        /// Fill factor, must be between (0 and 1) </summary>
        protected readonly float m_fillFactor;
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

        protected OpenHashMapBase(int size = DefaultSize, float fillFactor = DefaultFillFactor)
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
            m_fillFactor = fillFactor;
            InitializeEmpty(size);
        }

        /// <summary>
        /// Clones the hash map.
        /// </summary>
        protected OpenHashMapBase(OpenHashMapBase<K,V> other, int newSize)
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

            m_mask      = other.m_mask;
            m_mask2     = other.m_mask2;
            m_threshold = other.m_threshold;

            m_hasNull   = other.m_hasNull;
            m_nullValue = other.m_nullValue;

            int newCapacity = Tools.ArraySize(newSize, m_fillFactor);

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
            int capacity = Tools.ArraySize(size, m_fillFactor);
            m_threshold = (int)(capacity * m_fillFactor);
            m_mask      = capacity - 1;
            m_mask2     = capacity * 2 - 1;
            m_hasNull   = false;
            m_nullValue = null;

            m_data = new object[capacity * 2];
            //Arrays.Fill(m_data, FreeKey); // not needed any more, since FreeKey is null
        }

        protected virtual void Rehash(int newCapacity, OpenHashMapBase<K, V> source)
        {
            m_threshold = (int)(newCapacity * m_fillFactor);
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
            protected readonly OpenHashMapBase<K, V> m_map;
            protected int m_position;
            protected bool m_nullReturned = false;

            protected EnumeratorBase(OpenHashMapBase<K, V> map)
            {
                m_map = map;
                m_position = -2;  
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (m_position < 0)
                {
                    m_position += 2;
                    if (m_map.m_hasNull)
                        return true;
                }

                var data = m_map.m_data;
                var length = data.Length;

                while (m_position < length)
                {
                    object key = data[m_position];
                    if (key != FreeKey && key != RemovedKey)
                        break;
                    m_position += 2;
                }

                return m_position < length;
            }

            public void Reset()
            {
                m_position = -2;
                m_nullReturned = false;
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
                    if(m_position < 0 || m_position >= data.Length)
                        throw new InvalidOperationException();

                    if (m_position == 0 && !m_nullReturned && m_map.m_hasNull)
                    {
                        m_nullReturned = true;
                        return new KeyValuePair<K, V>(default(K), (V)m_map.m_nullValue);
                    }
                    return new KeyValuePair<K, V>((K)data[m_position], (V)data[m_position + 1]);
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
                        if (m_position < 0 || m_position >= data.Length)
                            throw new InvalidOperationException();

                        if (m_position == 0 && !m_nullReturned && m_map.m_hasNull)
                        {
                            m_nullReturned = true;
                            return default(K);
                        }
                        return (K)data[m_position];
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
                        if (m_position < 0 || m_position >= data.Length)
                            throw new InvalidOperationException();

                        if (m_position == 0 && !m_nullReturned && m_map.m_hasNull)
                        {
                            m_nullReturned = true;
                            return (V)m_map.m_nullValue;
                        }
                        return (V)data[m_position + 1];
                    }
                }
            }
        }

        #endregion
    }
}
