// based upon http://java-performance.info/implementing-world-fastest-java-int-to-int-hash-map/

namespace Dot42.Collections.Specialized
{
    /// <summary>
    /// Similar to IntIntMap, but using interleaving long[]
    /// </summary>
    internal sealed class LongIntMap 
    {
        private const long FreeKey = 0L;
        public const int NoValue = int.MinValue;

        /// <summary>
        /// Keys and values </summary>
        private long[] m_data;

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

        public LongIntMap(int size, float fillFactor)
        {
            if (fillFactor <= 0 || fillFactor >= 1)
            {
                throw new System.ArgumentException("FillFactor must be in (0, 1)");
            }
            if (size <= 0)
            {
                throw new System.ArgumentException("Size must be positive!");
            }
            int capacity = Tools.ArraySize(size, fillFactor);
            m_mask = capacity - 1;
            m_mask2 = capacity * 2 - 1;
            m_fillFactor = fillFactor;

            m_data = new long[capacity * 2];
            m_threshold = (int)(capacity * fillFactor);
        }

        public int Get(long key)
        {
            int ptr = (Tools.PhiMix(key) & m_mask) << 1;

            if (key == FreeKey)
            {
                return m_hasFreeKey ? m_freeValue : NoValue;
            }

            long k = m_data[ptr];

            if (k == FreeKey)
            {
                return NoValue; //end of chain already
            }
            if (k == key) //we check FREE prior to this call
            {
                return (int)m_data[ptr + 1];
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
                    return (int)m_data[ptr + 1];
                }
            }
        }

        public int Put(long key, int value)
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
            long k = m_data[ptr];
            if (k == FreeKey) //end of chain already
            {
                m_data[ptr] = key;
                m_data[ptr + 1] = (long)value;
                if (m_size >= m_threshold)
                {
                    Rehash(m_data.Length * 2); //size is set inside
                }
                else
                {
                    ++m_size;
                }
                return NoValue;
            }
            else if (k == key) //we check FREE prior to this call
            {
                int ret = (int)m_data[ptr + 1];
                m_data[ptr + 1] = (long)value;
                return ret;
            }

            while (true)
            {
                ptr = (ptr + 2) & m_mask2; //that's next index calculation
                k = m_data[ptr];
                if (k == FreeKey)
                {
                    m_data[ptr] = key;
                    m_data[ptr + 1] = (long)value;
                    if (m_size >= m_threshold)
                    {
                        Rehash(m_data.Length * 2); //size is set inside
                    }
                    else
                    {
                        ++m_size;
                    }
                    return NoValue;
                }
                else if (k == key)
                {
                    int ret = (int)m_data[ptr + 1];
                    m_data[ptr + 1] = (long)value;
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
            long k = m_data[ptr];
            if (k == key) //we check FREE prior to this call
            {
                int res = (int)m_data[ptr + 1];
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
                    int res = (int)m_data[ptr + 1];
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
            long k;
            long[] data = this.m_data;
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


        public int Size { get { return m_size; } }

        private void Rehash(int newCapacity)
        {
            m_threshold = (int)(newCapacity / 2 * m_fillFactor);
            m_mask = newCapacity / 2 - 1;
            m_mask2 = newCapacity - 1;

            int oldCapacity = m_data.Length;
            long[] oldData = m_data;

            m_data = new long[newCapacity];
            m_size = m_hasFreeKey ? 1 : 0;

            for (int i = 0; i < oldCapacity; i += 2)
            {
                long oldKey = oldData[i];
                if (oldKey != FreeKey)
                {
                    Put(oldKey, (int)oldData[i + 1]);
                }
            }
        }

        //    private int getStartIdx( final int key )
        //    {
        //        return ( Tools.phiMix( key ) & m_mask) << 1;
        //    }
    }


}