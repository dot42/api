// Copyright (C) 2014 dot42
//
// Original filename: Decoder.cs
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
    public abstract class Decoder
    {
        // Constructor.
        protected Decoder()
        {
        }

        /// <summary>
        /// Get the number of characters needed to decode a buffer.
        /// </summary>
        public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush)
        {
            if (flush)
                Reset();
            return GetCharCount(bytes, index, count);
        }

        /// <summary>
        ///  Get the number of characters needed to decode a buffer.
        /// </summary> 
        public abstract int GetCharCount(byte[] bytes, int index, int count);

        /// <summary>
        ///  Get the characters that result from decoding a buffer.
        /// </summary>
        public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount,
                                     char[] chars, int charIndex);

        
        public virtual int GetChars(
            byte[] bytes, int byteIndex, int byteCount,
            char[] chars, int charIndex, bool flush)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            if (byteIndex < 0)
                throw new ArgumentOutOfRangeException("byteIndex");
            if (byteCount < 0 || bytes.Length < byteIndex + byteCount)
                throw new ArgumentOutOfRangeException("byteCount");

            if (chars == null)
                throw new ArgumentNullException("chars");
            if (charIndex < 0 || chars.Length < charIndex)
                throw new ArgumentOutOfRangeException("charIndex");

            if (flush)
                Reset();
            return GetChars(bytes, byteIndex, byteCount, chars, charIndex);
        }

        public virtual void Reset()
        {  
        }

        public virtual void Convert(
            byte[] bytes, int byteIndex, int byteCount,
            char[] chars, int charIndex, int charCount, bool flush,
            out int bytesUsed, out int charsUsed, out bool completed)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            if (byteIndex < 0)
                throw new ArgumentOutOfRangeException("byteIndex");
            if (byteCount < 0 || bytes.Length < byteIndex + byteCount)
                throw new ArgumentOutOfRangeException("byteCount");

            if (chars == null)
                throw new ArgumentNullException("chars");
            if (charIndex < 0)
                throw new ArgumentOutOfRangeException("charIndex");
            if (charCount < 0 || chars.Length < charIndex + charCount)
                throw new ArgumentOutOfRangeException("charCount");

            bytesUsed = byteCount;
            while (true)
            {
                charsUsed = GetCharCount(bytes, byteIndex, bytesUsed, flush);
                if (charsUsed <= charCount)
                    break;
                flush = false;
                bytesUsed >>= 1;
            }
            completed = bytesUsed == byteCount;
            charsUsed = GetChars(bytes, byteIndex, bytesUsed, chars, charIndex, flush);
        }

    }
}

