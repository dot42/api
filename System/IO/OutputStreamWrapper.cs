// Copyright (C) 2014 dot42
//
// Original filename: OutputStreamWrapper.cs
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
using JOutputStream = Java.Io.OutputStream;

namespace System.IO
{
    /// <summary>
    /// Java OutputStream wrapper for Stream.
    /// </summary>
	internal class OutputStreamWrapper : JOutputStream
	{
	    private readonly Stream stream;

        /// <summary>
        /// Default ctor
        /// </summary>
        public OutputStreamWrapper(Stream stream)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (!stream.CanWrite)
                throw new ArgumentException("Non-writable stream");
            this.stream = stream;
        }

        /// <summary>
        /// <para>Closes this stream. Concrete implementations of this class should free any resources during close. This implementation does nothing.</para><para></para>        
        /// </summary>
        public override void Close()
        {
            base.Close();
            stream.Close();
        }

        /// <summary>
        /// <para>Flushes this stream. Implementations of this method should ensure that any buffered data is written out. This implementation does nothing.</para><para></para>        
        /// </summary>
        public override void Flush()
        {
            stream.Flush();
        }

        /// <summary>
        /// <para>Writes a single byte to this stream. Only the least significant byte of the integer <c> oneByte </c> is written to the stream.</para><para></para>        
        /// </summary>
        public override void Write(int oneByte)
        {
            stream.WriteByte((byte) oneByte);
        }

        /// <summary>
        /// <para>Writes <c> count </c> bytes from the byte array <c> buffer </c> starting at position <c> offset </c> to this stream.</para><para></para>        
        /// </summary>
        public override void Write(byte[] buffer, int offset, int count)
        {
            stream.Write(buffer, offset, count);
        }
	}
}

