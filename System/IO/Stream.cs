// Copyright (C) 2014 dot42
//
// Original filename: Stream.cs
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
using Java.Io;
using JInputStream = Java.Io.InputStream;
using JOutputStream = Java.Io.OutputStream;

namespace System.IO
{
    /// <summary>
    /// Sequence of bytes.
    /// </summary>
	public abstract class Stream : IDisposable
    {
        private class NullStream : Stream
        {
            public override bool CanRead
            {
                get
                {
                    return true;
                }
            }

            public override bool CanSeek
            {
                get
                {
                    return true;
                }
            }

            public override bool CanWrite
            {
                get
                {
                    return true;
                }
            }

            public override long Length
            {
                get
                {
                    return 0;
                }
            }

            public override long Position
            {
                get
                {
                    return 0;
                }
                set
                {
                }
            }

            public override void Flush()
            {
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                return 0;
            }

            public override int ReadByte()
            {
                return -1;
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                return 0;
            }

            public override void SetLength(long value)
            {
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
            }

            public override void WriteByte(byte value)
            {
            }
        }

        private InputStreamWrapper inputStreamWrapper;
        private OutputStreamWrapper outputStreamWrapper;

        /// <summary>
        /// A Stream with no backing store.
        /// </summary>
        public static readonly Stream Null = new NullStream();

        /// <summary>
        /// Is reading from this stream supported?
        /// </summary>
        public abstract bool CanRead { get; }

        /// <summary>
        /// Is writing to this stream supported?
        /// </summary>
        public abstract bool CanWrite { get; }

        /// <summary>
        /// Is seeking supported?
        /// </summary>
        public abstract bool CanSeek { get; }

        /// <summary>
        /// Gets the length of this sequence in bytes.
        /// </summary>
        public abstract long Length { get; }

        /// <summary>
        /// Gets/sets the position within this stream.
        /// </summary>
        public abstract long Position { get; set; }

        public virtual bool CanTimeout { get { return false; } }
        public virtual int ReadTimeout { get { throw new InvalidOperationException(); } set { throw new InvalidOperationException(); } }
        public virtual int WriteTimeout { get { throw new InvalidOperationException(); } set { throw new InvalidOperationException(); } }
        
        /// <summary>
        /// Close this stream and any resources that it may hold.
        /// </summary>
        public virtual void Close()
        {
            Dispose(true);
        }

        /// <summary>
        /// Copy bytes from this stream into the given destination.
        /// </summary>
        public void CopyTo(Stream destination)
        {
            CopyTo(destination, 4096);
        }

        /// <summary>
        /// Copy bytes from this stream into the given destination.
        /// </summary>
        public void CopyTo(Stream destination, int bufferSize)
        {
            var buf = new byte[bufferSize];
            int len;
            while ((len = Read(buf, 0, buf.Length)) > 0)
            {
                destination.Write(buf, 0, len);
            }
        }

        /// <summary>
	    /// Perform application defined cleanup of the resource.
	    /// </summary>
	    public void Dispose()
	    {
	    }

        /// <summary>
        /// Release unmanaged resources.
        /// </summary>
        /// <param name="disposing">If set, also release managed resources.</param>
        protected virtual void Dispose(bool  disposing)
        {            
        }

        /// <summary>
        /// Ensure that any buffered data is written to the underlying device.
        /// </summary>
        public abstract void Flush();

        /// <summary>
        /// Read a sequence of bytes from this stream and advance the position of this stream.
        /// </summary>
        /// <param name="buffer">Destination</param>
        /// <param name="offset">Offset within the buffer</param>
        /// <param name="count">Number of bytes to read.</param>
        /// <returns>The total number of bytes read or 0 if the end of the stream has been reached.</returns>
        public abstract int Read(byte[] buffer, int offset, int count);

        /// <summary>
        /// Read a single byte and advance the position of this stream.
        /// </summary>
        /// <returns>The byte that was read or -1 if at the end of the stream.</returns>
        public virtual int ReadByte()
        {
            var buffer = new byte[1];
            return (Read(buffer, 0, 1) == 0) ? -1 : buffer[0];
        }

        /// <summary>
        /// Set the position of this stream.
        /// </summary>
        /// <param name="offset">Byte offset relative to origin.</param>
        /// <param name="origin">Reference point.</param>
        /// <returns>New position of the stream.</returns>
        public abstract long Seek(long offset, SeekOrigin origin);

        /// <summary>
        /// Sets the length of the current stream.
        /// </summary>
        /// <param name="value">The new length of the stream.</param>
        public abstract void SetLength(long value);

        /// <summary>
        /// Write a sequence of bytes to this stream and advance the position of this stream.
        /// </summary>
        /// <param name="buffer">Destination</param>
        /// <param name="offset">Offset within the buffer</param>
        /// <param name="count">Number of bytes to write.</param>
        public abstract void Write(byte[] buffer, int offset, int count);

        /// <summary>
        /// Write a single byte and advance the position of this stream.
        /// </summary>
        public virtual void WriteByte(byte value)
        {
            Write(new[] { value }, 0, 1);
        }

        /// <summary>
        /// Create a stream that wraps a java <see cref="Java.Io.InputStream"/>.
        /// </summary>
        public static Stream Wrap(JInputStream source)
        {
            return new JavaInputStreamWrapper(source);
        }

        /// <summary>
        /// Create a stream that wraps a java <see cref="Java.Io.OutputStream"/>.
        /// </summary>
        public static Stream Wrap(JOutputStream source)
        {
            return new JavaOutputStreamWrapper(source);
        }

        /// <summary>
        /// Create a java <see cref="Java.Io.InputStream"/> that wraps the given stream.
        /// </summary>
        public static implicit operator JInputStream(Stream source)
        {
            return source.inputStreamWrapper ?? (source.inputStreamWrapper = new InputStreamWrapper(source));
        }

        /// <summary>
        /// Create a java <see cref="Java.Io.OutputStream"/> that wraps the given stream.
        /// </summary>
        public static implicit operator JOutputStream(Stream source)
        {
            return source.outputStreamWrapper ?? (source.outputStreamWrapper = new OutputStreamWrapper(source));
        }
    }
}

