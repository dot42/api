// Copyright (C) 2014 dot42
//
// Original filename: UTF32Encoding.cs
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
using Java.Nio;
using Java.Nio.Charset;

namespace System.Text
{
    /// <summary>
    /// UTF-32 encoding.
    /// </summary>
	public class UTF32Encoding : Encoding
    {
        private static readonly byte[] BigEndianPreamble = new[] { (byte)0x00, (byte)0x00, (byte)0xFE, (byte)0xFF };
        private static readonly byte[] LittleEndianPreamble = new[] { (byte)0xFE, (byte)0xFF, (byte)0x00, (byte)0x00 };

        private readonly bool bigEndian;
        private readonly bool byteOrderMark;
        private readonly bool throwOnInvalidBytes;

        /// <summary>
        /// Default ctor
        /// </summary>
        public UTF32Encoding()
            : this(false, true, false)
        {
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public UTF32Encoding(bool bigEndian, bool byteOrderMark)
            : this(bigEndian, byteOrderMark, false)
        {
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public UTF32Encoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes)
            : base(Charset.ForName(GetCharsetName(bigEndian, byteOrderMark)))
        {
            this.bigEndian = bigEndian;
            this.byteOrderMark = byteOrderMark;
            this.throwOnInvalidBytes = throwOnInvalidBytes;
        }

        /// <summary>
        /// Gets byte sequence that identifies used encoding.
        /// </summary>
        public override byte[] GetPreamble()
        {
            if (!byteOrderMark)
                return new byte[0];
            return bigEndian ? BigEndianPreamble : LittleEndianPreamble;
        }

        /// <summary>
        /// Encode the given source using the character set.
        /// </summary>
        protected override ByteBuffer Encode(CharBuffer source)
        {
            if (throwOnInvalidBytes)
                return charSet.NewEncoder().OnMalformedInput(CodingErrorAction.REPORT).OnUnmappableCharacter(CodingErrorAction.REPORT)
                           .Encode(source);
            return base.Encode(source);
        }

        /// <summary>
        /// Decode the given source using the character set.
        /// </summary>
        protected override CharBuffer Decode(ByteBuffer source)
        {
            if (throwOnInvalidBytes)
                return
                    charSet.NewDecoder()
                           .OnMalformedInput(CodingErrorAction.REPORT)
                           .OnUnmappableCharacter(CodingErrorAction.REPORT)
                           .Decode(source);
            return base.Decode(source);
        }

        /// <summary>
        /// Create the correct java Charset name for the given settings.
        /// </summary>
        private static string GetCharsetName(bool bigEndian, bool byteOrderMark)
        {
            if (bigEndian)
            {
                return byteOrderMark ? "UTF-32BE" : "UTF-32";
            }
            return "UTF-32LE";
        }
    }
}

