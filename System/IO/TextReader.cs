// Copyright (C) 2014 dot42
//
// Original filename: TextReader.cs
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
using Java.Lang;

namespace System.IO
{
    /// <summary>
    /// Reader representing a sequence of characters.
    /// </summary>
	public abstract class TextReader : IDisposable
	{
        /// <summary>
        /// Reader that provides no data.
        /// </summary>
        public static readonly TextReader Null = new NullReader();

        /// <summary>
        /// Close this read and release all resources.
        /// </summary>
        public virtual void Close()
        {
            Dispose(true);
        }

        /// <summary>
        /// Release all resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Release unmanaged resources and optionally managed resources.
        /// </summary>
        /// <param name="disposing">If true, release managed resources also.</param>
        protected virtual void Dispose(bool disposing)
        {
            // Override me
        }

        /// <summary>
        /// Gets the next character without changing the state of this reader.
        /// </summary>
        /// <returns>The next character or -1 if no more characters are available.</returns>
        public virtual int Peek()
        {
            return -1;
        }

        /// <summary>
        /// Reads the next character from this reader.
        /// </summary>
        /// <returns>The next character or -1 if no more characters are available.</returns>
        public virtual int Read()
        {
            return -1;
        }

        /// <summary>
        /// Reads a maximum of <paramref name="count"/> characters from this reader and store them in <paramref name="buffer"/>.
        /// </summary>
        /// <returns>The number of characters read.</returns>
        public virtual int Read(char[] buffer, int index, int count)
        {
            if (buffer == null)
                throw new ArgumentNullException("buffer");
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (index +count > buffer.Length)
                throw new ArgumentException("length");
            var readCount = 0;
            while (readCount < count)
            {
                var ch = Read();
                if (ch < 0)
                    return readCount;
                buffer[index++] = (char) ch;
                readCount++;
            }
            return readCount;
        }

        /// <summary>
        /// Read a line of characters from this reader.
        /// </summary>
        /// <returns></returns>
        public virtual string ReadLine()
        {
            var buffer = new StringBuffer();
            int ch;
            while (true)
            {
                ch = Read();
                if (ch < 0)
                {
                    if (buffer.Length() == 0)
                        return null;
                    return buffer.ToString();
                }
                if ((ch == (int)'\n') || (ch == (int)'\r'))
                {
                    break;
                }
                buffer.Append((char) ch);
            }
            if ((ch == 13) && (Peek() == 10))
            {
                Read(); // Skip
            }
            return buffer.ToString();
        }

        /// <summary>
        /// Read the remainder of the reader and return it as string.
        /// </summary>
        public virtual string ReadToEnd()
        {
            var tmp = new char[4096];
            var buffer = new StringBuffer();
            int len;
            while ((len = Read(tmp, 0, tmp.Length)) > 0)
            {
                buffer.Append(tmp, 0, len);
            }
            return buffer.ToString();
        }

        private sealed class NullReader : TextReader
        {
            /// <summary>
            /// Read a line of characters from this reader.
            /// </summary>
            /// <returns></returns>
            public override string ReadLine()
            {
                return null;
            }

            /// <summary>
            /// Read the remainder of the reader and return it as string.
            /// </summary>
            public override string ReadToEnd()
            {
                return "";
            }
        }
    }
}

