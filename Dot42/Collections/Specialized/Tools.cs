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

namespace Dot42.Collections.Specialized
{

    /// <summary>
    /// Common methods
    /// </summary>
    internal class Tools
    {

        /// <summary>
        /// Taken from FastUtil implementation </summary>

        /// <summary>
        /// Return the least power of two greater than or equal to the specified value.
        /// 
        /// <para>Note that this function will return 1 when the argument is 0.
        /// 
        /// </para>
        /// </summary>
        /// <param name="x"> a long integer smaller than or equal to 2<sup>62</sup>. </param>
        /// <returns> the least power of two greater than or equal to the specified value. </returns>
        public static long NextPowerOfTwo(long x)
        {
            if (x == 0)
            {
                return 1;
            }
            x--;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return (x | x >> 32) + 1;
        }

        /// <summary>
        /// Returns the least power of two smaller than or equal to 2<sup>30</sup> and larger than or equal to <code>Math.ceil( expected / f )</code>.
        /// </summary>
        /// <param name="expected"> the expected number of elements in a hash table. </param>
        /// <param name="f"> the load factor. </param>
        /// <returns> the minimum possible size for a backing array. </returns>
        /// <exception cref="IllegalArgumentException"> if the necessary size is larger than 2<sup>30</sup>. </exception>
        public static int ArraySize(int expected, float f)
        {
            long s = Math.Max(2, NextPowerOfTwo((long)Math.Ceiling(expected / f)));
            if (s > (1 << 30))
            {
                throw new System.ArgumentException("Too large (" + expected + " expected elements with load factor " + f + ")");
            }
            return (int)s;
        }

        //taken from FastUtil
        internal const int INT_PHI = unchecked((int)0x9E3779B9);

        [Inline]
        public static int PhiMix(int x)
        {
            int h = x * INT_PHI;
            return h ^ (h >> 16);
        }

        [Inline]
        public static int PhiMix(long x)
        {
            int h = ((int)x ^ (int)(x >> 32)) * INT_PHI;
            return h ^ (h >> 16);
        }
    }
}