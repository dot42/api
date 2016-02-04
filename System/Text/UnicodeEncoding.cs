// Copyright (C) 2014 dot42
//
// Original filename: UnicodeEncoding.cs
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
using Java.Nio.Charset;

namespace System.Text
{
    /// <summary>
    /// UTF-16 encoding.
    /// </summary>
	public class UnicodeEncoding : Encoding
    {
        private static readonly byte[] BigEndianPreamble = new[] { (byte)0xFE, (byte)0xFF };
        private static readonly byte[] LittleEndianPreamble = new[] { (byte)0xFF, (byte)0xFE };

        private readonly bool bigEndian;
        private readonly bool byteOrderMark;

        /// <summary>
        /// Default ctor
        /// </summary>
        public UnicodeEncoding()
            : base(Charset.ForName("UTF-16LE"))
        {
            bigEndian = false;
            byteOrderMark = false;
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="bigEndian">If true, use big endian encoding: MSB first, otherwise little endian: LSB first.</param>
        /// <param name="byteOrderMark">If true, provide a byte order mark, false otherwise</param>
        public UnicodeEncoding(bool bigEndian, bool byteOrderMark)
            : base(Charset.ForName(GetCharsetName(bigEndian, byteOrderMark)))
        {
            this.bigEndian = bigEndian;
            this.byteOrderMark = byteOrderMark;
        }

        /// <summary>
        /// Can this encoding be used by browser clients to save content?
        /// </summary>
        public override bool IsBrowserSave
        {
            get { return true; }
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
        /// Create the correct java Charset name for the given settings.
        /// </summary>
        private static string GetCharsetName(bool bigEndian, bool byteOrderMark)
        {
            if (bigEndian)
            {
                return byteOrderMark ? "UTF-16BE" : "UTF-16";
            }
            return "UTF-16LE";
        }

        public override int GetMaxCharCount(int byteCount)
        {
            return Math.JavaRound(byteCount/2f);
        }
    }
}

