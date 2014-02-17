// Copyright (C) 2014 dot42
//
// Original filename: UTF8Encoding.cs
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
    /// UTF-8 encoding.
    /// </summary>
	public class UTF8Encoding : Encoding
	{
        private readonly bool byteOrderMark;
        private readonly bool throwOnInvalidBytes;
        private static readonly byte[] Preamble = new[] { (byte)0xEF, (byte)0xBB, (byte)0xBF };

        /// <summary>
        /// Default ctor
        /// </summary>
        public UTF8Encoding()
            : base(Charset.ForName("UTF-8"))
        {
            byteOrderMark = false;
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public UTF8Encoding(bool byteOrderMark)
            : base(Charset.ForName("UTF-8"))
        {
            this.byteOrderMark = byteOrderMark;
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public UTF8Encoding(bool byteOrderMark, bool throwOnInvalidBytes)
            : base(Charset.ForName("UTF-8"))
        {
            this.byteOrderMark = byteOrderMark;
            this.throwOnInvalidBytes = throwOnInvalidBytes;
        }

        /// <summary>
        /// Gets byte sequence that identifies used encoding.
        /// </summary>
        public override byte[] GetPreamble()
        {
            return (byteOrderMark) ? Preamble : new byte[0]; 
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
    }
}

