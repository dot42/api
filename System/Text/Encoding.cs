// Copyright (C) 2014 dot42
//
// Original filename: Encoding.cs
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
    /// Represents a character encoding.
    /// </summary>
	public abstract class Encoding
    {
        private sealed class ForwardingDecoder : Decoder
        {
            private readonly Encoding encoding;

            public ForwardingDecoder(Encoding enc)
            {
                encoding = enc;
            }

            public override int GetCharCount(byte[] bytes, int index, int count)
            {
                return encoding.GetCharCount(bytes, index, count);
            }
            public override int GetChars(byte[] bytes, int byteIndex,
                                         int byteCount, char[] chars,
                                         int charIndex)
            {
                return encoding.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
            }

        } 

        private sealed class ForwardingEncoder : Encoder
        {
            private readonly Encoding encoding;

            public ForwardingEncoder(Encoding enc)
            {
                encoding = enc;
            }

            public override int GetByteCount(char[] chars, int index, int count, bool flush)
            {
                return encoding.GetByteCount(chars, index, count);
            }
            public override int GetBytes(char[] chars, int charIndex,
                                         int charCount, byte[] bytes,
                                         int byteCount, bool flush)
            {
                return encoding.GetBytes(chars, charIndex, charCount, bytes, byteCount);
            }

        } 

        private static volatile ASCIIEncoding ascii;
        private static volatile UnicodeEncoding unicode;
        private static volatile UnicodeEncoding bigEndianUnicode;
        private static volatile UTF8Encoding utf8;
        private static volatile UTF32Encoding utf32;
        private static volatile UTF32Encoding bigEndianUtf32;

        internal readonly Charset charSet;

        /// <summary>
        /// Default ctor
        /// </summary>
        internal Encoding(Charset charSet)
        {
            this.charSet = charSet;
        }

        /// <summary>
        /// Gets the default encoding
        /// </summary>
        public static Encoding Default
        {
            get { return utf8; }
        }

        public static Encoding GetEncoding(int codePage)
        {
            switch (codePage)
            {
                case 0: //default
                    //return Encoding.Default;
                    return UTF8;

                case 1200:
                    return Unicode;
                case 1201:
                    return BigEndianUnicode;

                case 1252:
                case 20127:
                    return ASCII;

                case 12000:
                    return UTF32;
                case 12001:
                    return BigEndianUTF32;

                //case 65000:
                //    return UTF7;

                case 65001:
                    return UTF8;

            }

            throw new NotSupportedException("CodePage is not supported");
        }

        public static Encoding GetEncoding(string name)
        {
            name = name.ToLower();
            switch (name)
            {
                case "utf-16":
                case "utf-16le":
                    return Unicode;
                case "utf-16be":
                case "unicodeFFFE":
                    return BigEndianUnicode;

                case "windows-1252":
                case "us-ascii":
                    return ASCII;

                default: //additional switch, because C# compiler crashes with the case statements in a single switch
                    switch (name)
                    {
                        case "utf-32":
                        case "utf-32le":
                            return UTF32;
                        case "utf-32be":
                            return BigEndianUTF32;

                            //case "utf-7":
                            //    return UTF7;

                        case "utf-8":
                            return UTF8;
                    }
                    break;

            }

            throw new ArgumentException("Encoding is not supported");
        }

        /// <summary>
        /// Get a decoder.
        /// </summary>
        public virtual Decoder GetDecoder()
        {
            return new ForwardingDecoder(this);
        }

        /// <summary>
        /// Get an encoder.
        /// </summary>
        public virtual Encoder GetEncoder()
        {
            return new ForwardingEncoder(this);
        }

        /// <summary>
        /// Can this encoding be used by browser clients to display content?
        /// </summary>
        public virtual bool IsBrowserDisplay
        {
            get { return false; }        
        }

        /// <summary>
        /// Can this encoding be used by browser clients to save content?
        /// </summary>
        public virtual bool IsBrowserSave
        {
            get { return false; }
        }

        /// <summary>
        /// Can this encoding be used by mail and news clients to display content?
        /// </summary>
        public virtual bool IsMailNewsDisplay
        {
            get { return false; }
        }

        /// <summary>
        /// Can this encoding be used by mail and news clients to save content?
        /// </summary>
        public virtual bool IsMailNewsSave
        {
            get { return false; }
        }

        /// <summary>
        /// Does this encoding use single-byte code points?
        /// </summary>
        public virtual bool IsSingleByte
        {
            get { return false; }
        }

        /// <summary>
        /// Is this encoding readonly.
        /// </summary>
        public bool IsReadOnly
        {
            get { return true; }
        }

        /// <summary>
        /// Gets byte sequence that identifies used encoding.
        /// </summary>
        public virtual byte[] GetPreamble()
        {
            return new byte[0];
        }

        /// <summary>
        /// Gets the maximum number of bytes needed to encode the given number of characters.
        /// </summary>
        public virtual int GetMaxByteCount(int charCount)
        {
            if (charCount < 0)
                throw new ArgumentOutOfRangeException("charCount");
            return Math.Round(charSet.NewEncoder().MaxBytesPerChar() * charCount);
        }

        /// <summary>
        /// Gets the maximum number of characters needed to decode the given number of bytes.
        /// </summary>
        public virtual int GetMaxCharCount(int byteCount)
        {
            if (byteCount < 0)
                throw new ArgumentOutOfRangeException("byteCount");
            return Math.Round(charSet.NewDecoder().MaxCharsPerByte() * byteCount);
        }

        /// <summary>
        /// Gets the number of bytes needed to encode the given character range.
        /// </summary>
        public virtual int GetByteCount(char[] chars)
        {
            if (chars == null)
                throw new ArgumentNullException("chars");
            return GetByteCount(chars, 0, chars.Length);
        }

        /// <summary>
        /// Gets the number of bytes needed to encode the given character range.
        /// </summary>
        public virtual int GetByteCount(char[] chars, int charIndex, int charCount)
        {
            if (chars == null)
                throw new ArgumentNullException("chars");
            if (charIndex < 0)
                throw new ArgumentOutOfRangeException("charIndex");
            if (charCount < 0)
                throw new ArgumentOutOfRangeException("charCount");
            if (charIndex + charCount > chars.Length)
                throw new ArgumentOutOfRangeException("length");
            var buffer = CharBuffer.Wrap(chars, charIndex, charCount);
            return Encode(buffer).Remaining();
        }

        /// <summary>
        /// Gets the number of bytes needed to encode the given character range.
        /// </summary>
        public virtual int GetByteCount(string value)
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value");
            var buffer = CharBuffer.Wrap(value);
            return Encode(buffer).Remaining();
        }

        /// <summary>
        /// Encodes a part of a string into a byte array.
        /// </summary>
        public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            if (ReferenceEquals(s, null))
                throw new ArgumentNullException();
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            if (charIndex < 0)
                throw new ArgumentOutOfRangeException("charIndex");
            if (byteIndex < 0)
                throw new ArgumentOutOfRangeException("byteIndex");
            if (charCount < 0)
                throw new ArgumentOutOfRangeException("charCount");
            if (charIndex + charCount > s.Length)
                throw new ArgumentOutOfRangeException("length");
            var buffer = CharBuffer.Wrap(s, charIndex, charIndex + charCount);
            var encoded = Encode(buffer);
            var length = encoded.Remaining();
            if (byteIndex + length > bytes.Length)
                throw new ArgumentException("bytes length");
            encoded.Get(bytes, byteIndex, length);
            return length;
        }

        /// <summary>
        /// Encodes a part of a string into a byte array.
        /// </summary>
        public virtual byte[] GetBytes(string s)
        {
            if (ReferenceEquals(s, null))
                throw new ArgumentNullException();
            var buffer = CharBuffer.Wrap(s);
            var encoded = Encode(buffer);
            var length = encoded.Remaining();
            var bytes = new byte[length];
            encoded.Get(bytes, 0, length);
            return bytes;
        }

        /// <summary>
        /// Encodes a sequence of characters into a byte array.
        /// </summary>
        public virtual int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            if (chars == null)
                throw new ArgumentNullException("chars");
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            if (charIndex < 0)
                throw new ArgumentOutOfRangeException("charIndex");
            if (byteIndex < 0)
                throw new ArgumentOutOfRangeException("byteIndex");
            if (charCount < 0)
                throw new ArgumentOutOfRangeException("charCount");
            if (charIndex + charCount > chars.Length)
                throw new ArgumentOutOfRangeException("chars length");
            var buffer = CharBuffer.Wrap(chars, charIndex, charCount);
            var encoded = Encode(buffer);
            var length = encoded.Remaining();
            if (byteIndex + length > bytes.Length)
                throw new ArgumentException("bytes length");
            encoded.Get(bytes, byteIndex, length);
            return length;
        }

        /// <summary>
        /// Encodes a sequence of characters into a byte array.
        /// </summary>
        public virtual byte[] GetBytes(char[] chars)
        {
            if (chars == null)
                throw new ArgumentNullException("chars");
            return GetBytes(chars, 0, chars.Length);
        }

        /// <summary>
        /// Encodes a sequence of characters into a byte array.
        /// </summary>
        public virtual byte[] GetBytes(char[] chars, int charIndex, int charCount)
        {
            if (chars == null)
                throw new ArgumentNullException("chars");
            if (charIndex < 0)
                throw new ArgumentOutOfRangeException("charIndex");
            if (charCount < 0)
                throw new ArgumentOutOfRangeException("charCount");
            if (charIndex + charCount > chars.Length)
                throw new ArgumentOutOfRangeException("chars length");
            var buffer = CharBuffer.Wrap(chars, charIndex, charCount);
            var encoded = Encode(buffer);
            var length = encoded.Remaining();
            var bytes = new byte[length];
            encoded.Get(bytes, 0, length);
            return bytes;
        }

        /// <summary>
        /// Gets the number of character needed to decode the given byte range.
        /// </summary>
        public virtual int GetCharCount(byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            return GetCharCount(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Gets the number of character needed to decode the given byte range.
        /// </summary>
        public virtual int GetCharCount(byte[] bytes, int index, int count)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (index + count > bytes.Length)
                throw new ArgumentOutOfRangeException("length");
            var buffer = ByteBuffer.Wrap(bytes, index, count);
            var decoded = Decode(buffer);
            return decoded.Remaining();
        }

        /// <summary>
        /// Decodes a sequence of bytes into a character array.
        /// </summary>
        public virtual char[] GetChars(byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            return GetChars(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Decodes a sequence of bytes into a character array.
        /// </summary>
        public virtual char[] GetChars(byte[] bytes, int index, int count)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (index + count > bytes.Length)
                throw new ArgumentOutOfRangeException("length");
            var buffer = ByteBuffer.Wrap(bytes, index, count);
            var decoded = Decode(buffer);
            var length = decoded.Remaining();
            var chars = new char[length];
            decoded.Get(chars, 0, length);
            return chars;
        }

        /// <summary>
        /// Decodes a sequence of bytes into a character array.
        /// </summary>
        public virtual int GetChars(byte[] bytes, int index, int count, char[] chars, int charIndex)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            if (chars == null)
                throw new ArgumentNullException("chars");
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");
            if (charIndex < 0)
                throw new ArgumentOutOfRangeException("charIndex");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (index + count > bytes.Length)
                throw new ArgumentOutOfRangeException("bytes length");
            var buffer = ByteBuffer.Wrap(bytes, index, count);
            var decoded = Decode(buffer);
            var length = decoded.Remaining();
            if (charIndex + length > chars.Length)
                throw new ArgumentOutOfRangeException("chars length" + string.Format("[count={0} charIndex={1} length={2} chars.Length={3} charSet={4} GetMaxCharCount={5}]", count, charIndex, length, chars.Length, this.charSet.Name(), GetMaxCharCount(count)));
            decoded.Get(chars, charIndex, length);
            return length;
        }

        /// <summary>
        /// Decodes a sequence of bytes into a string array.
        /// </summary>
        public virtual string GetString(byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            return GetString(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Decodes a sequence of bytes into a string array.
        /// </summary>
        public virtual string GetString(byte[] bytes, int index, int count)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (index + count > bytes.Length)
                throw new ArgumentOutOfRangeException("bytes length");
            var buffer = ByteBuffer.Wrap(bytes, index, count);
            var decoded = Decode(buffer);
            return decoded.ToString();
        }

        /// <summary>
        /// Encode the given source using the character set.
        /// </summary>
        protected virtual ByteBuffer Encode(CharBuffer source)
        {
            var replaceWith = new[] {(byte)'?'};
            var encoder =
                charSet.NewEncoder()
                       .OnMalformedInput(CodingErrorAction.REPLACE)
                       .OnUnmappableCharacter(CodingErrorAction.REPLACE)
                       .ReplaceWith(replaceWith);
            return encoder.Encode(source);
        }

        /// <summary>
        /// Decode the given source using the character set.
        /// </summary>
        protected virtual CharBuffer Decode(ByteBuffer source)
        {
            const string replaceWith = "?";
            var encoder =
                charSet.NewDecoder()
                       .OnMalformedInput(CodingErrorAction.REPLACE)
                       .OnUnmappableCharacter(CodingErrorAction.REPLACE)
                       .ReplaceWith(replaceWith);
            return encoder.Decode(source);
        }

        /// <summary>
        /// Gets an encoding for the ASCII (7-bit) character set.
        /// </summary>
        public static Encoding ASCII
        {
            get { return ascii ?? (ascii = new ASCIIEncoding()); }
        }

        /// <summary>
        /// Gets an encoding for the UTF-16 character set.
        /// </summary>
        public static Encoding Unicode
        {
            get { return unicode ?? (unicode = new UnicodeEncoding()); }
        }

        /// <summary>
        /// Gets an encoding for the UTF-16 character set with big endian byte order.
        /// </summary>
        public static Encoding BigEndianUnicode
        {
            get { return bigEndianUnicode ?? (bigEndianUnicode = new UnicodeEncoding(true, true)); }
        }

        /// <summary>
        /// Gets an encoding for the UTF-8 character set.
        /// </summary>
        public static Encoding UTF8
        {
            get { return utf8 ?? (utf8 = new UTF8Encoding()); }
        }

        /// <summary>
        /// Gets an encoding for the UTF-32 character set.
        /// </summary>
        public static Encoding UTF32
        {
            get { return utf32 ?? (utf32 = new UTF32Encoding()); }
        }

        /// <summary>
        /// Gets an encoding for the UTF-32 character set.
        /// </summary>
        public static Encoding BigEndianUTF32
        {
            get { return bigEndianUtf32 ?? (bigEndianUtf32 = new UTF32Encoding(true, true)); }
        }
    }
}

