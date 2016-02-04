// Copyright (C) 2014 dot42
//
// Original filename: InputStreamWrapper.cs
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
using JInputStream = Java.IO.InputStream;

namespace System.IO
{
    /// <summary>
    /// Java InputStream wrapper for Stream.
    /// </summary>
	internal class InputStreamWrapper : JInputStream
	{
	    private readonly Stream stream;

        public InputStreamWrapper(Stream stream)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (!stream.CanRead)
                throw new ArgumentException("Non-readable stream");
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
        /// <para>Reads a single byte from this stream and returns it as an integer in the range from 0 to 255. Returns -1 if the end of the stream has been reached. Blocks until one byte has been read, the end of the source stream is detected or an exception is thrown.</para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>the byte read or -1 if the end of stream has been reached. </para>
        /// </returns>
        public override int Read()
        {
            return stream.ReadByte();
        }

        /// <summary>
        /// <para>Reads at most <c> length </c> bytes from this stream and stores them in the byte array <c> b </c> starting at <c> offset </c> .</para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>the number of bytes actually read or -1 if the end of the stream has been reached. </para>
        /// </returns>
        public override int Read(byte[] buffer, int offset, int length)
        {
            var rc = stream.Read(buffer, offset, length);
            return (rc == 0) ? -1 : rc;
        }
	}
}

