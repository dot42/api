// Copyright (C) 2014 dot42
//
// Original filename: FileStream.cs
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

namespace System.IO
{
	public class FileStream : Stream
	{
	    private readonly RandomAccessFile file;
	    private readonly FileAccess access;

        /// <summary>
        /// Initialize a filestream from and input and/or output stream.
        /// </summary>
        private FileStream(RandomAccessFile file, FileAccess access)
	    {
            if (file == null)
                throw new ArgumentNullException("file");
            this.file = file;
            this.access = access;
	    }

        /// <summary>
        /// Open a new file stream for the given path, mode and access.
        /// </summary>
        /// <param name="path">Path of the file</param>
        /// <param name="mode">How to open the file</param>
        /// <param name="access">Read/write access</param>
        public FileStream(string path, FileMode mode, FileAccess access)
            : this(Open(path, mode, access), access)
        {            
        }

        /// <summary>
        /// Open a new file stream for the given path, mode and access.
        /// </summary>
        /// <param name="path">Path of the file</param>
        /// <param name="mode">How to open the file</param>
        /// <param name="access">Read/write access</param>
        /// <param name="share">The file share</param>
        public FileStream(string path, FileMode mode, FileAccess access, FileShare share)
            : this(Open(path, mode, access), access)
        {
        }

        public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
            : this(Open(path, mode, access), access)
        {
        }


        /// <summary>
        /// Open a new file stream for the given path, mode and access.
        /// </summary>
        /// <param name="path">Path of the file</param>
        /// <param name="mode">How to open the file</param>
        public FileStream(string path, FileMode mode)
            : this(path, mode, ModeToAccess(mode))
        {
        }

        
	    /// <summary>
	    /// Is reading from this stream supported?
	    /// </summary>
	    public override bool CanRead
	    {
	        get { return ((access & FileAccess.Read) == FileAccess.Read); }
	    }

	    /// <summary>
	    /// Is writing to this stream supported?
	    /// </summary>
	    public override bool CanWrite
	    {
            get { return ((access & FileAccess.Write) == FileAccess.Write); }
        }

	    /// <summary>
	    /// Is seeking supported?
	    /// </summary>
	    public override bool CanSeek
	    {
	        get { return true; }
	    }

	    /// <summary>
	    /// Gets the length of this sequence in bytes.
	    /// </summary>
	    public override long Length
	    {
	        get { return file.Length(); }
	    }

	    /// <summary>
	    /// Gets/sets the position within this stream.
	    /// </summary>
	    public override long Position
	    {
            get { return file.FilePointer; }
            set { file.Seek(value); }
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
	        var rc = file.Read(buffer, offset, count);
	        return (rc < 0) ? 0 : rc;
	    }

	    /// <summary>
	    /// Set the position of this stream.
	    /// </summary>
	    /// <param name="offset">Byte offset relative to origin.</param>
	    /// <param name="origin">Reference point.</param>
	    /// <returns>New position of the stream.</returns>
	    public override long Seek(long offset, SeekOrigin origin)
	    {
	        long target;
            switch (origin)
            {
                case SeekOrigin.Current:
                    target = Position + offset;
                    break;
                case SeekOrigin.Begin:
                    target = offset;
                    break;
                case SeekOrigin.End:
                    target = file.Length() + offset;
                    break;
                default:
                    throw new ArgumentException("Invalid origin");
            }
            if ((target < 0) || (target > file.Length()))
	        {
	            throw new IOException("Seek outside file limits");
	        }
	        file.Seek(target);
	        return Position;
	    }

	    /// <summary>
	    /// Sets the length of the current stream.
	    /// </summary>
	    /// <param name="value">The new length of the stream.</param>
	    public override void SetLength(long value)
	    {
	        file.SetLength(value);
	    }

	    /// <summary>
	    /// Write a sequence of bytes to this stream and advance the position of this stream.
	    /// </summary>
	    /// <param name="buffer">Destination</param>
	    /// <param name="offset">Offset within the buffer</param>
	    /// <param name="count">Number of bytes to write.</param>
	    public override void Write(byte[] buffer, int offset, int count)
	    {
	        file.Write(buffer, offset, count);
	    }

        /// <summary>
        /// Open a random access file for the given path, more and access.
        /// </summary>
        private static RandomAccessFile Open(string path, FileMode mode, FileAccess access)
        {
            var file = new Java.Io.File(path);
            switch (mode)
            {
                case FileMode.CreateNew:
                    if (file.Exists())
                        throw new IOException("File already exists");
                    break;
                case FileMode.Open:
                    if (!file.Exists())
                        throw new FileNotFoundException(path);
                    break;
                case FileMode.Append:
                    access = FileAccess.Write;
                    break;
            }

            switch (mode)
            {
                case FileMode.Create:
                case FileMode.CreateNew:
                case FileMode.OpenOrCreate:
                    if (access == FileAccess.Read)
                    {
                        //create empty file, so it can be opened again with read only right, 
                        //otherwise an FilNotFoundException is thrown.
                        var additinalAccessFile = new RandomAccessFile(file, "rw");
                    }
                    break;
            }

            var jMode = (access == FileAccess.Read) ? "r" : "rw";
            var randomAccessFile = new RandomAccessFile(file, jMode);
            switch (mode)
            {
                case FileMode.Truncate:
                    randomAccessFile.SetLength(0);
                    break;
                case FileMode.Append:
                    randomAccessFile.Seek(randomAccessFile.Length());
                    break;
            }

            return randomAccessFile;
        }

        /// <summary>
        /// Derive a file access from a file mode.
        /// </summary>
        private static FileAccess ModeToAccess(FileMode mode)
        {
            switch (mode)
            {
                case FileMode.Append:
                    return FileAccess.Write;
                default:
                    return FileAccess.ReadWrite;
            }
        }
	}
}

