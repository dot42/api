// Copyright (C) 2014 dot42
//
// Original filename: Encoder.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
namespace System.Text
{
    public abstract class Encoder
    {
        protected Encoder()
        {
        }

        /// <summary>
        /// Get the number of bytes needed to encode a buffer.
        /// </summary>
        public abstract int GetByteCount(char[] chars, int index,
                                         int count, bool flush);

        /// <summary>
        /// Get the bytes that result from decoding a buffer.
        /// </summary>
        public abstract int GetBytes(char[] chars, int charIndex, int charCount,
                                     byte[] bytes, int byteIndex, bool flush);

        /// <summary>
        /// Resets the encoder.
        /// </summary>
        public virtual void Reset()
        {
        }

        /// <summary>
        /// Converts an array of characters to an encoded byte sequence and stores the result in an array of bytes.
        /// </summary>
        public virtual void Convert(
            char[] chars, int charIndex, int charCount,
            byte[] bytes, int byteIndex, int byteCount, bool flush,
            out int charsUsed, out int bytesUsed, out bool completed)
        {
            if (chars == null)
                throw new ArgumentNullException("chars");
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            if (charIndex < 0)
                throw new ArgumentOutOfRangeException("charIndex");
            if (charCount < 0 || chars.Length < charIndex + charCount)
                throw new ArgumentOutOfRangeException("charCount");
            if (byteIndex < 0)
                throw new ArgumentOutOfRangeException("byteIndex");
            if (byteCount < 0 || bytes.Length < byteIndex + byteCount)
                throw new ArgumentOutOfRangeException("byteCount");

            charsUsed = charCount;
            while (true)
            {
                bytesUsed = GetByteCount(chars, charIndex, charsUsed, flush);
                if (bytesUsed <= byteCount)
                    break;
                flush = false;
                charsUsed >>= 1;
            }
            completed = charsUsed == charCount;
            bytesUsed = GetBytes(chars, charIndex, charsUsed, bytes, byteIndex, flush);
        }
    }
}

