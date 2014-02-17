// Copyright (C) 2014 dot42
//
// Original filename: ASCIIEncoding.cs
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
    /// US-ASCII encoding.
    /// </summary>
	public class ASCIIEncoding : Encoding
	{
        /// <summary>
        /// Default ctor
        /// </summary>
        public ASCIIEncoding()
            : base(Charset.ForName("US-ASCII"))
        {            
        }

        /// <summary>
        /// Does this encoding use single-byte code points?
        /// </summary>
        public override bool IsSingleByte
        {
            get { return true; }
        }

        /// <summary>
        /// Gets the number of bytes needed to encode the given character range.
        /// </summary>
        public override int GetByteCount(char[] chars)
        {
            return chars.Length;
        }

        /// <summary>
        /// Gets the number of bytes needed to encode the given character range.
        /// </summary>
        public override int GetByteCount(char[] chars, int charIndex, int charCount)
	    {
	        return charCount;
	    }

        /// <summary>
        /// Gets the number of bytes needed to encode the given character range.
        /// </summary>
        public override int GetByteCount(string value)
        {
            return value.Length;
        }

        /// <summary>
        /// Gets the number of character needed to decode the given byte range.
        /// </summary>
        public override int GetCharCount(byte[] bytes, int index, int count)
	    {
	        return count;
	    }
	}
}

