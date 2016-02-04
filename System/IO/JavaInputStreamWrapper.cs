// Copyright (C) 2014 dot42
//
// Original filename: JavaInputStreamWrapper.cs
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
    /// Stream wrapper for java InputStream.
    /// </summary>
	public class JavaInputStreamWrapper : Stream
	{
	    private readonly JInputStream stream;
        private long position;

        /// <summary>
        /// Default ctor
        /// </summary>
	    public JavaInputStreamWrapper(JInputStream stream)
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
	        get { return true; }
	    }

        /// <summary>
        /// Is writing to this stream supported?
        /// </summary>
        public override bool CanWrite
	    {
	        get { return false; }
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
	        get { throw new NotImplementedException("System.IO.JavaInputStreamWrapper.Length"); }
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
            while (true)
            {
                var rc = stream.Read(buffer, offset, count);
                if (rc < 0)
                    return 0; // End of stream
                if (rc > 0)
                {
                    position += rc;
                    return rc;
                }
            }
        }

        /// <summary>
        /// Set the position of this stream.
        /// </summary>
        /// <param name="offset">Byte offset relative to origin.</param>
        /// <param name="origin">Reference point.</param>
        /// <returns>New position of the stream.</returns>
        public override long Seek(long offset, SeekOrigin origin)
        {
            if (origin == SeekOrigin.Current)
	        {
	            stream.Skip(offset);
	            position += offset;
	            return position;
	        }
            // Other origins not supported
            throw new NotSupportedException();
        }

        /// <summary>
        /// Sets the length of the current stream.
        /// </summary>
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
	        throw new NotSupportedException();
	    }
	}
}

