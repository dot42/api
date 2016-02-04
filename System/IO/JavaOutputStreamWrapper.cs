// Copyright (C) 2014 dot42
//
// Original filename: JavaOutputStreamWrapper.cs
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
using JOutputStream = Java.IO.OutputStream;

namespace System.IO
{
    /// <summary>
    /// Wrapper for java OutputStream.
    /// </summary>
	public class JavaOutputStreamWrapper : Stream
    {
        private readonly JOutputStream stream;
        private long position;

        /// <summary>
        /// Default ctor
        /// </summary>
        public JavaOutputStreamWrapper(JOutputStream stream)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");
            this.stream = stream;
        }

        /// <summary>
        /// Release unmanaged resources.
        /// </summary>
        /// <param name="disposing">If set, also release managed resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            { 
                try{ stream.Close(); }
                catch {}
            }
        }

        /// <summary>
        /// Is reading from this stream supported?
        /// </summary>
        public override bool CanRead
        {
            get { return false; }
        }

        /// <summary>
        /// Is writing to this stream supported?
        /// </summary>
        public override bool CanWrite
        {
            get { return true; }
        }

        /// <summary>
        /// Is seeking supported?
        /// </summary>
        public override bool CanSeek
        {
            get { return false; }
        }

        /// <summary>
        /// Gets the length of this sequence in bytes.
        /// </summary>
        public override long Length
        {
            get { throw new NotSupportedException(); }
        }

        /// <summary>
        /// Gets/sets the position within this stream.
        /// </summary>
        public override long Position
        {
            get { return position; }
            set { throw new NotSupportedException(); }
        }

        /// <summary>
        /// Ensure that any buffered data is written to the underlying device.
        /// </summary>
        public override void Flush()
        {
            stream.Flush();
        }

        /// <summary>
        /// Read a sequence of bytes from this stream and advance the position of this stream.
        /// </summary>
        /// <param name="buffer">Destination</param>
        /// <param name="offset">Offset within the buffer</param>
        /// <param name="count">Number of bytes to read.</param>
        /// <returns>The total number of bytes read or 0 if the end of the stream has been reached.</returns>
        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Set the position of this stream.
        /// </summary>
        /// <param name="offset">Byte offset relative to origin.</param>
        /// <param name="origin">Reference point.</param>
        /// <returns>New position of the stream.</returns>
        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Sets the length of the current stream.
        /// </summary>
        /// <param name="value">The new length of the stream.</param>
        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Write a sequence of bytes to this stream and advance the position of this stream.
        /// </summary>
        /// <param name="buffer">Destination</param>
        /// <param name="offset">Offset within the buffer</param>
        /// <param name="count">Number of bytes to write.</param>
        public override void Write(byte[] buffer, int offset, int count)
        {
            stream.Write(buffer, offset, count);
            position += count;
        }
	}
}

