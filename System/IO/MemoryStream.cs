// Copyright (C) 2014 dot42
//
// Original filename: MemoryStream.cs
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
using Java.Util;

namespace System.IO
{
	public class MemoryStream : Stream
	{
	    private byte[] buffer;
	    private int origin;
	    private int position;
	    private int length;
	    private int capacity;
	    private bool isOpen;
	    private bool canWrite;
	    private bool canExpand;
        private bool canExpose;

        /// <summary>
        /// Initialize a new instance, with an expandable capacity initialized to 0.
        /// </summary>
        public MemoryStream()
            : this(0)
        {            
        }

        /// <summary>
        /// Initialize a new instance, with an expandable capacity initialized as specified.
        /// </summary>
        public MemoryStream(int capacity)
        {
            if (capacity < 0) throw new ArgumentOutOfRangeException("capacity");
            buffer = new byte[capacity];
            this.capacity = capacity;
            canExpand = true;
            canWrite = true;
            canExpose = true;
            origin = 0;
            length = 0;
            isOpen = true;
        }

        /// <summary>
        /// Initialize a new instance, with an fixed size, writable buffer initialized as specified.
        /// </summary>
        public MemoryStream(byte[] buffer) : this(buffer, true)
        {            
        }

        /// <summary>
        /// Initialize a new instance, with an fixed size buffer initialized as specified.
        /// </summary>
        public MemoryStream(byte[] buffer, bool writable)
        {
            if (buffer == null) throw new ArgumentNullException("buffer");
            this.buffer = buffer;
            capacity = buffer.Length;
            length = buffer.Length;
            canExpand = false;
            canWrite = writable;
            canExpose = false;
            origin = 0;
            isOpen = true;
        }

        /// <summary>
        /// Initialize a new instance, with a buffer initialized as specified.
        /// </summary>
        public MemoryStream(byte[] buffer, int index, int count)
            : this(buffer, index, count, true, false)
        {            
        }

        /// <summary>
        /// Initialize a new instance, with a buffer initialized as specified.
        /// </summary>
        public MemoryStream(byte[] buffer, int index, int count, bool writable)
            : this(buffer, index, count, writable, false)
        {
        }

        /// <summary>
        /// Initialize a new instance, with a buffer initialized as specified.
        /// </summary>
        public MemoryStream(byte[] buffer, int index, int count, bool writable, bool exposable)
        {
            if (buffer == null) throw new ArgumentNullException("buffer");
            if (index < 0) throw new ArgumentOutOfRangeException("index");
            if (count < 0) throw new ArgumentOutOfRangeException("count");
            if (buffer.Length - index < count) throw new ArgumentException("range");
            this.buffer = buffer;
            capacity = index + count;
            length = capacity;
            canExpand = false;
            canWrite = writable;
            canExpose = exposable;
            origin = index;
            isOpen = true;
        }

	    /// <summary>
	    /// Is reading from this stream supported?
	    /// </summary>
	    public override bool CanRead
	    {
	        get { return isOpen; }
	    }

	    /// <summary>
	    /// Is writing to this stream supported?
	    /// </summary>
	    public override bool CanWrite
	    {
	        get { return isOpen && canWrite; }
	    }

	    /// <summary>
	    /// Is seeking supported?
	    /// </summary>
	    public override bool CanSeek
	    {
	        get { return isOpen; }
	    }

        /// <summary>
        /// Gets/sets the number of allocated bytes.
        /// </summary>
	    public virtual int Capacity
	    {
	        get
	        {
	            CheckOpen();
	            return capacity - origin;
	        }
            set
            {
                CheckOpen();
                if ((long) value < Length) throw new ArgumentOutOfRangeException("too small");
                if (value == Capacity) return;
                if (!canExpand) throw new NotSupportedException("Cannot expand");
                if (value > 0)
                {
                    var newBuffer = new byte[value];
                    if (length > 0)
                        Java.Lang.System.Arraycopy(buffer, 0, newBuffer, 0, length);
                    buffer = newBuffer;
                }
                else
                {
                    buffer = null;
                }
                capacity = value;
            }
	    }

	    /// <summary>
	    /// Gets the length of this sequence in bytes.
	    /// </summary>
	    public override long Length
	    {
	        get
	        {
	            CheckOpen();
	            return (long)(length - origin);
	        }
	    }

	    /// <summary>
	    /// Gets/sets the position within this stream.
	    /// </summary>
	    public override long Position
	    {
            get
            {
                CheckOpen();
                return (long) (position - origin);
            }
	        set 
            { 
                CheckOpen();
                if (value < 0L) throw new ArgumentOutOfRangeException("value");
                if (value > int.MaxValue) throw new ArgumentOutOfRangeException("value");
                position = origin + (int) value;
            }
	    }

	    /// <summary>
	    /// Release unmanaged resources.
	    /// </summary>
	    /// <param name="disposing">If set, also release managed resources.</param>
	    protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    isOpen = false;
                    canWrite = false;
                    canExpand = false;
                    canExpose = false;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

	    /// <summary>
	    /// Ensure that any buffered data is written to the underlying device.
	    /// </summary>
	    public override void Flush()
	    {
            // Do nothing
	    }

        /// <summary>
        /// Get access to the underlying buffer.
        /// </summary>
        public virtual byte[] GetBuffer()
        {
            if (!canExpose) throw new UnauthorizedAccessException();
            return buffer;
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
	        CheckOpen();
            if (buffer == null) throw new ArgumentNullException("buffer");
            if (offset < 0) throw new ArgumentOutOfRangeException("offset");
            if (count < 0) throw new ArgumentOutOfRangeException("count");

	        var available = length - position;
            if (available <= 0) return 0;
            if (count > available) count = available;
	        Java.Lang.System.Arraycopy(this.buffer, position, buffer, offset, count);
	        position += count;
	        return count;
	    }

	    /// <summary>
	    /// Set the position of this stream.
	    /// </summary>
	    /// <param name="offset">Byte offset relative to origin.</param>
	    /// <param name="origin">Reference point.</param>
	    /// <returns>New position of the stream.</returns>
	    public override long Seek(long offset, SeekOrigin origin)
	    {
	        CheckOpen();
            if (offset > int.MaxValue) throw new ArgumentOutOfRangeException("offset");
            switch (origin)
            {
                case SeekOrigin.Begin:
                    {
                        if (offset < 0L) throw new IOException();
                        position = this.origin + (int) offset;
                    }
                    break;
                case SeekOrigin.Current:
                    {
                        var target = position + (int) offset;
                        if (target < this.origin) throw new IOException();
                        position = target;
                    }
                    break;
                case SeekOrigin.End:
                    {
                        var target = length + (int)offset;
                        if (target < this.origin) throw new IOException();
                        position = target;
                    }
                    break;
                default:
                    throw new ArgumentException("origin");
            }
	        return (long)position;
	    }

	    /// <summary>
	    /// Sets the length of the current stream.
	    /// </summary>
	    /// <param name="value">The new length of the stream.</param>
	    public override void SetLength(long value)
	    {
            if (!canWrite) throw new NotSupportedException();
            if ((value < 0L) || (value > int.MaxValue)) throw new ArgumentOutOfRangeException("value");
            if (value + (long)origin > int.MaxValue) throw new ArgumentOutOfRangeException("too large");
	        var newLength = origin + (int)value;
            if (!EnsureCapacity(newLength) && (newLength > length))
            {
                Arrays.Fill(buffer, length, newLength, 0);
            }
	        length = newLength;
            if (position > newLength)
            {
                position = newLength;
            }
	    }

        /// <summary>
        /// Create a copy of the entire stream, regardless of the current position.
        /// </summary>
        public virtual byte[] ToArray()
        {
            var count = length - origin;
            var result = new byte[count];
            Java.Lang.System.Arraycopy(buffer, origin, result, 0, count);
            return result;
        }

	    /// <summary>
	    /// Write a sequence of bytes to this stream and advance the position of this stream.
	    /// </summary>
	    /// <param name="buffer">Destination</param>
	    /// <param name="offset">Offset within the buffer</param>
	    /// <param name="count">Number of bytes to write.</param>
	    public override void Write(byte[] buffer, int offset, int count)
	    {
            CheckOpen();
            if (buffer == null) throw new ArgumentNullException("buffer");
            if (offset < 0) throw new ArgumentOutOfRangeException("offset");
            if (count < 0) throw new ArgumentOutOfRangeException("offset");
            if (!canWrite) throw new NotSupportedException("readonly");

	        var newPosition = position + count;
            if (newPosition > length)
            {
                // Should extend
                SetLength((long)(newPosition - origin));
            }
	        Java.Lang.System.Arraycopy(buffer, offset, this.buffer, position, count);
	        position = newPosition;
        }

        /// <summary>
        /// Throw an exception when this stream is not open.
        /// </summary>
        private void CheckOpen()
        {
            if (!isOpen)
                throw new ObjectDisposedException("stream");
        }

        /// <summary>
        /// Make sure the buffer is large enough.
        /// </summary>
        /// <returns>True when the buffer is modified, false otherwise</returns>
        private bool EnsureCapacity(int value)
        {
            if (value < 0) throw new IOException("value");
            if (value < capacity) return false;
            if (value < 256) value = 256;
            var upper = capacity * 2;
            if (value < upper) value = upper;
            Capacity = value;
            return true;
        }
	}
}

