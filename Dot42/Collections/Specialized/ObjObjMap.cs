// http://java-performance.info/implementing-world-fastest-java-int-to-int-hash-map/
// This is free and unencumbered software released into the public domain.
// 
// Anyone is free to copy, modify, publish, use, compile, sell, or
// distribute this software, either in source code form or as a compiled
// binary, for any purpose, commercial or non-commercial, and by any
// means.
// 
// In jurisdictions that recognize copyright laws, the author or authors
// of this software dedicate any and all copyright interest in the
// software to the public domain. We make this dedication for the benefit
// of the public at large and to the detriment of our heirs and
// successors. We intend this dedication to be an overt act of
// relinquishment in perpetuity of all present and future rights to this
// software under copyright law.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
// OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// 
// For more information, please refer to <http://unlicense.org> 

using Java.Util;

namespace Dot42.Collections.Specialized
{
    /// <summary>
    /// Object-2-object map based on IntIntMap4a
    /// </summary>
    public class ObjObjMap<K, V> 
    {
        private static readonly object FREE_KEY = new object();
        private static readonly object REMOVED_KEY = new object();

        /// <summary>
        /// Keys and values </summary>
        private object[] m_data;

        /// <summary>
        /// Value for the null key (if inserted into a map) </summary>
        private object m_nullValue;
        private bool m_hasNull;

        /// <summary>
        /// Fill factor, must be between (0 and 1) </summary>
        private readonly float m_fillFactor;
        /// <summary>
        /// We will resize a map once it reaches this size </summary>
        private int m_threshold;
        /// <summary>
        /// Current map size </summary>
        private int m_size;
        /// <summary>
        /// Mask to calculate the original position </summary>
        private int m_mask;
        /// <summary>
        /// Mask to wrap the actual array pointer </summary>
        private int m_mask2;

        public ObjObjMap(int size, float fillFactor)
        {
            if (fillFactor <= 0 || fillFactor >= 1)
            {
                throw new System.ArgumentException("FillFactor must be in (0, 1)");
            }
            if (size <= 0)
            {
                throw new System.ArgumentException("Size must be positive!");
            }

            int capacity = Specialized.Tools.ArraySize(size, fillFactor);
            m_mask = capacity - 1;
            m_mask2 = capacity * 2 - 1;
            m_fillFactor = fillFactor;

            m_data = new object[capacity * 2];
            Arrays.Fill(m_data, FREE_KEY);

            m_threshold = (int)(capacity * fillFactor);
        }

        public V Get(K key)
        {
            if (key == null)
            {
                return (V)m_nullValue; //we null it on remove, so safe not to check a flag here
            }

            int ptr = (key.GetHashCode() & m_mask) << 1;
            object k = m_data[ptr];

            if (k == FREE_KEY)
            {
                return default(V); //end of chain already
            }
            if (k.Equals(key)) //we check FREE and REMOVED prior to this call
            {
                return (V)m_data[ptr + 1];
            }
            while (true)
            {
                ptr = (ptr + 2) & m_mask2; //that's next index
                k = m_data[ptr];
                if (k == FREE_KEY)
                {
                    return default(V);
                }
                if (k.Equals(key))
                {
                    return (V)m_data[ptr + 1];
                }
            }
        }

        public V Put(K key, V value)
        {
            if (key == null)
            {
                return InsertNullKey(value);
            }

            int ptr = GetStartIndex(key) << 1;
            object k = m_data[ptr];

            if (k == FREE_KEY) //end of chain already
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
            else if (k.Equals(key)) //we check FREE and REMOVED prior to this call
            {
                object ret = m_data[ptr + 1];
                m_data[ptr + 1] = value;
                return (V)ret;
            }

            int firstRemoved = -1;
            if (k == REMOVED_KEY)
            {
                firstRemoved = ptr; //we may find a key later
            }

            while (true)
            {
                ptr = (ptr + 2) & m_mask2; //that's next index calculation
                k = m_data[ptr];
                if (k == FREE_KEY)
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
                else if (k.Equals(key))
                {
                    object ret = m_data[ptr + 1];
                    m_data[ptr + 1] = value;
                    return (V)ret;
                }
                else if (k == REMOVED_KEY)
                {
                    if (firstRemoved == -1)
                    {
                        firstRemoved = ptr;
                    }
                }
            }
        }

        public V Remove(K key)
        {
            if (key == null)
            {
                return RemoveNullKey();
            }

            int ptr = GetStartIndex(key) << 1;
            object k = m_data[ptr];
            if (k == FREE_KEY)
            {
                return default(V); //end of chain already
            }
            else if (k.Equals(key)) //we check FREE and REMOVED prior to this call
            {
                --m_size;
                if (m_data[(ptr + 2) & m_mask2] == FREE_KEY)
                {
                    m_data[ptr] = FREE_KEY;
                }
                else
                {
                    m_data[ptr] = REMOVED_KEY;
                }

                V ret = (V)m_data[ptr + 1];
                m_data[ptr + 1] = null;
                return ret;
            }
            while (true)
            {
                ptr = (ptr + 2) & m_mask2; //that's next index calculation
                k = m_data[ptr];
                if (k == FREE_KEY)
                {
                    return default(V);
                }
                else if (k.Equals(key))
                {
                    --m_size;
                    if (m_data[(ptr + 2) & m_mask2] == FREE_KEY)
                    {
                        m_data[ptr] = FREE_KEY;
                    }
                    else
                    {
                        m_data[ptr] = REMOVED_KEY;
                    }

                    V ret = (V)m_data[ptr + 1];
                    m_data[ptr + 1] = null;
                    return ret;
                }
            }
        }

        private V InsertNullKey(V value)
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

        private V RemoveNullKey()
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

        public int Size { get { return m_size; } }

        private void Rehash(int newCapacity)
        {
            m_threshold = (int)(newCapacity / 2 * m_fillFactor);
            m_mask = newCapacity / 2 - 1;
            m_mask2 = newCapacity - 1;

            int oldCapacity = m_data.Length;
            object[] oldData = m_data;

            m_data = new object[newCapacity];
            Arrays.Fill(m_data, FREE_KEY);

            m_size = m_hasNull ? 1 : 0;

            for (int i = 0; i < oldCapacity; i += 2)
            {
                object oldKey = oldData[i];
                if (oldKey != FREE_KEY && oldKey != REMOVED_KEY)
                {
                    Put((K)oldKey, (V)oldData[i + 1]);
                }
            }
        }

        public virtual int GetStartIndex(object key)
        {
            //key is not null here
            return key.GetHashCode() & m_mask;
        }
    }

}