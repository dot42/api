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

using System;
using Java.Util;

namespace Dot42.Collections.Specialized
{

    /// <summary>
    /// This is a Open Hash Map, specialized for Int to Int mapping. 
    /// <para/> 
    /// While you are welcome to use this map for performance critical
    /// parts of your application, please note that the API of this 
    /// class is considered beta and might change between releases.
    /// </summary>
    // Same as IntIntMap4, but using interleaving int[] instead of long[]
    public sealed class IntIntMap 
    {
        private const int FreeKey = 0;
        public const int NoValue = int.MinValue;

        public const int DefaultSize = 16;
        public const float DefaultFillFactor = 0.55f;

        /// <summary>
        /// Keys and values </summary>
        private int[] m_data;

        /// <summary>
        /// Do we have 'free' key in the map? </summary>
        private bool m_hasFreeKey;
        /// <summary>
        /// Value of 'free' key </summary>
        private int m_freeValue;

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
        private int m_mask2;

        public IntIntMap(int size = DefaultSize, float fillFactor = DefaultFillFactor)
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

        public IntIntMap(IntIntMap other, int newSize = 0)
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

            m_hasFreeKey = other.m_hasFreeKey;
            m_freeValue = other.m_freeValue;

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

        /// <summary>
        /// Get the value associated with 'key'
        /// </summary>
        /// <param name="key"></param>
        /// <returns>the value, or 'NoValue' of not found.</returns>
        public int Get(int key)
        {
            int ptr = (Tools.PhiMix(key) & m_mask) << 1;

            if (key == FreeKey)
            {
                return m_hasFreeKey ? m_freeValue : NoValue;
            }

            int k = m_data[ptr];

            if (k == FreeKey)
            {
                return NoValue; //end of chain already
            }
            if (k == key) //we check FREE prior to this call
            {
                return m_data[ptr + 1];
            }

            while (true)
            {
                ptr = (ptr + 2) & m_mask2; //that's next index
                k = m_data[ptr];
                if (k == FreeKey)
                {
                    return NoValue;
                }
                if (k == key)
                {
                    return m_data[ptr + 1];
                }
            }
        }

        public int Put(int key, int value)
        {
            if (key == FreeKey)
            {
                int ret = m_freeValue;
                if (!m_hasFreeKey)
                {
                    ++m_size;
                }
                m_hasFreeKey = true;
                m_freeValue = value;
                return ret;
            }

            int ptr = (Tools.PhiMix(key) & m_mask) << 1;
            int k = m_data[ptr];
            if (k == FreeKey) //end of chain already
            {
                m_data[ptr] = key;
                m_data[ptr + 1] = value;
                if (m_size >= m_threshold)
                {
                    Rehash(m_data.Length * 2, this); //size is set inside
                }
                else
                {
                    ++m_size;
                }
                return NoValue;
            }
            else if (k == key) //we check FREE prior to this call
            {
                int ret = m_data[ptr + 1];
                m_data[ptr + 1] = value;
                return ret;
            }

            while (true)
            {
                ptr = (ptr + 2) & m_mask2; //that's next index calculation
                k = m_data[ptr];
                if (k == FreeKey)
                {
                    m_data[ptr] = key;
                    m_data[ptr + 1] = value;
                    if (m_size >= m_threshold)
                    {
                        Rehash(m_data.Length * 2, this); //size is set inside
                    }
                    else
                    {
                        ++m_size;
                    }
                    return NoValue;
                }
                else if (k == key)
                {
                    int ret = m_data[ptr + 1];
                    m_data[ptr + 1] = value;
                    return ret;
                }
            }
        }

        public int Remove(int key)
        {
            if (key == FreeKey)
            {
                if (!m_hasFreeKey)
                {
                    return NoValue;
                }
                m_hasFreeKey = false;
                --m_size;
                return m_freeValue; //value is not cleaned
            }

            int ptr = (Tools.PhiMix(key) & m_mask) << 1;
            int k = m_data[ptr];
            if (k == key) //we check FREE prior to this call
            {
                int res = m_data[ptr + 1];
                ShiftKeys(ptr);
                --m_size;
                return res;
            }
            else if (k == FreeKey)
            {
                return NoValue; //end of chain already
            }
            while (true)
            {
                ptr = (ptr + 2) & m_mask2; //that's next index calculation
                k = m_data[ptr];
                if (k == key)
                {
                    int res = m_data[ptr + 1];
                    ShiftKeys(ptr);
                    --m_size;
                    return res;
                }
                else if (k == FreeKey)
                {
                    return NoValue;
                }
            }
        }

        private int ShiftKeys(int pos)
        {
            // Shift entries with the same hash.
            int last, slot;
            int k;
            int[] data = this.m_data;
            while (true)
            {
                pos = ((last = pos) + 2) & m_mask2;
                while (true)
                {
                    if ((k = data[pos]) == FreeKey)
                    {
                        data[last] = FreeKey;
                        return last;
                    }
                    slot = (Tools.PhiMix(k) & m_mask) << 1; //calculate the starting slot for the current key
                    if (last <= pos ? last >= slot || slot > pos : last >= slot && slot > pos)
                    {
                        break;
                    }
                    pos = (pos + 2) & m_mask2; //go to the next entry
                }
                data[last] = k;
                data[last + 1] = data[pos + 1];
            }
        }
        
        private void Rehash(int newCapacity, IntIntMap source)
        {
            m_threshold = (int)(newCapacity * m_fillFactor);
            m_mask = newCapacity - 1;
            m_mask2 = newCapacity * 2 - 1;

            int[] sourceData = source.m_data;
            int oldLength    = sourceData.Length;

            m_data = new int[newCapacity * 2];
            m_size = m_hasFreeKey ? 1 : 0;

            for (int i = 0; i < oldLength; i += 2)
            {
                int oldKey = sourceData[i];
                if (oldKey != FreeKey)
                {
                    Put(oldKey, sourceData[i + 1]);
                }
            }
        }

        private void InitializeEmpty(int size)
        {
            int capacity = Tools.ArraySize(size, m_fillFactor);
            m_threshold = (int)(capacity * m_fillFactor);
            m_mask = capacity - 1;
            m_mask2 = capacity * 2 - 1;
            m_hasFreeKey = false;
            m_freeValue = 0;

            m_data = new int[capacity * 2];
        }

        // We could intead provide a specialized IIntEnumerator
        public int[] Keys
        {
            get
            {
                int[] ret = new int[Size];
                int idx = 0;

                if (m_hasFreeKey)
                    ret[idx++] = m_freeValue;

                var data = m_data;
                var length = data.Length;

                for (int i = 0; i < length; ++i)
                {
                    int key = data[i];
                    if(key != FreeKey)
                        ret[idx++] = key;
                }
                return ret;
            }
        }
    }


}