// Copyright (C) 2014 dot42
//
// Original filename: TextWriter.cs
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.IO
{
    /// <summary>
    /// Represents a writer that can write a sequential series of characters.
    /// </summary>
    public abstract class TextWriter : MarshalByRefObject, IDisposable
    {
        private const string _newLine = "\r\n";
        private IFormatProvider _formatProvider;
        
        /// <summary>
        /// Stores the new line characters used for this TextWriter.
        /// </summary>
        protected char[] CoreNewLine;

        /// <summary>
        /// Writer that do not store data
        /// </summary>
        public static readonly TextWriter Null = new NullTextWriter();

        /// <summary>
        /// Default constuctor
        /// </summary>
        protected TextWriter()
            : this(null)
        {
        }

        /// <summary>
        /// Constucts a TextWriter with the specified format provider.
        /// </summary>
        protected TextWriter(IFormatProvider formatProvider)
        {
            _formatProvider = formatProvider;

            CoreNewLine = _newLine.ToCharArray();
        }

        /// <summary>
        /// The Encoding in which the output is written.
        /// </summary>
        public abstract Encoding Encoding { get; }
        
        /// <summary>
        /// The format provider
        /// </summary>
        public virtual IFormatProvider FormatProvider
        { 
            get
            {
                return _formatProvider;
            } 
        }
        
        /// <summary>
        /// The line terminator string
        /// </summary>
        public virtual string NewLine
        {
            get
            {
                return new string(CoreNewLine);
            }
            set
            {
                if (value == null) value = _newLine;
                CoreNewLine = value.ToCharArray();
            }
        }

        /// <summary>
        /// Closes the current writer
        /// </summary>
        public virtual void Close()
        {
            Dispose(true);
        }


        /// <summary>
        /// Disposes all resources
        /// </summary>
        public void Dispose()
        {
            Dispose(true);

            // If we are explicitly disposed, we can avoid finalization.
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes all unmanaged and optional managed resources
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // If we are explicitly disposed, we can avoid finalization.
                GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// Clears all buffers for the current writer
        /// </summary>
        public virtual void Flush()
        {
            //nothing to do in the base
        }

        /// <summary>
        ///  Creates a thread-safe wrapper around the specified TextWriter
        /// </summary>
        public static TextWriter Synchronized(TextWriter writer)
        {
            throw new NotImplementedException("System.IO.TextWriter.Synchronized");
        }

        /// <summary>
        /// Write a boolean.
        /// </summary>
        public virtual void Write(bool value)
        {
            Write(value.ToString());
        }

        /// <summary>
        /// Write a char.
        /// </summary>
        public virtual void Write(char value)
        {
            // Do nothing
        }

        /// <summary>
        /// Write a char array.
        /// </summary>
        public virtual void Write(char[] buffer)
        {
            if (buffer == null) return;
            Write(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Write a decimal.
        /// </summary>
        public virtual void Write(decimal value)
        {
            Write(value.ToString(_formatProvider));
        }

        /// <summary>
        /// Write a double.
        /// </summary>
        public virtual void Write(double value)
        {
            Write(value.ToString(_formatProvider));
        }

        /// <summary>
        /// Write an integer.
        /// </summary>
        public virtual void Write(int value)
        {
            Write(value.ToString(_formatProvider));
        }

        /// <summary>
        /// Write a long
        /// </summary>
        public virtual void Write(long value)
        {
            Write(value.ToString(_formatProvider));
        }

        /// <summary>
        /// Write an object Notice .ToString will be called without format provider
        /// </summary>
        public virtual void Write(object value)
        {
            if (value != null)
                Write(value.ToString());
        }

        /// <summary>
        /// Write a float
        /// </summary>
        public virtual void Write(float value)
        {
            Write(value.ToString(_formatProvider));
        }

        /// <summary>
        /// Write a string
        /// </summary>
        public virtual void Write(string value)
        {
            if (value != null)
                Write(value.ToCharArray());
        }

        /// <summary>
        /// Write a uint
        /// </summary>
        [CLSCompliant(false)]
        public virtual void Write(uint value)
        {
            Write(value.ToString(_formatProvider));
        }

        /// <summary>
        /// Write a ulong
        /// </summary>
        /// <param name="value"></param>
        [CLSCompliant(false)]
        public virtual void Write(ulong value)
        {
            Write(value.ToString(_formatProvider));
        }

        /// <summary>
        /// Write a char buffer with a specified index and count.
        /// </summary>
        public virtual void Write(char[] buffer, int index, int count)
        {
            if (buffer == null)
                throw new ArgumentNullException("buffer");

            if (index < 0 || index > buffer.Length)
                throw new ArgumentOutOfRangeException("index");

            if (count < 0 || (index > buffer.Length - count))
                throw new ArgumentOutOfRangeException("count");

            for (; count > 0; --count, ++index)
            {
                Write(buffer[index]);
            }
        }

        /// <summary>
        /// Write a formatted string
        /// </summary>
        public virtual void Write(string format, object arg0)
        {
            Write(string.Format(format, arg0));
        }

        /// <summary>
        /// Write a formatted string
        /// </summary>
        public virtual void Write(string format, params object[] arg)
        {
            Write(string.Format(format, arg));
        }

        /// <summary>
        /// Write a formatted string
        /// </summary>
        public virtual void Write(string format, object arg0, object arg1)
        {
            Write(string.Format(format, arg0, arg1));
        }

        /// <summary>
        /// Write a formatted string
        /// </summary>
        public virtual void Write(string format, object arg0, object arg1, object arg2)
        {
            Write(string.Format(format, arg0, arg1, arg2));
        }

        /// <summary>
        /// Write a newline
        /// </summary>
        public virtual void WriteLine()
        {
            Write(CoreNewLine);
        }

        /// <summary>
        /// Write a boolean and a newline
        /// </summary>
        public virtual void WriteLine(bool value)
        {
            Write(value);
            WriteLine();
        }

        /// <summary>
        /// Write a char and a newline
        /// </summary>
        public virtual void WriteLine(char value)
        {
            Write(value);
            WriteLine();
        }

        /// <summary>
        /// Write a char array and a newline
        /// </summary>
        public virtual void WriteLine(char[] buffer)
        {
            Write(buffer);
            WriteLine();
        }

        /// <summary>
        /// Write a decimal and a newline
        /// </summary>
        public virtual void WriteLine(decimal value)
        {
            Write(value);
            WriteLine();
        }

        /// <summary>
        /// Write a double and a newline
        /// </summary>
        public virtual void WriteLine(double value)
        {
            Write(value);
            WriteLine();
        }

        /// <summary>
        /// Write an int and a newline
        /// </summary>
        public virtual void WriteLine(int value)
        {
            Write(value);
            WriteLine();
        }

        /// <summary>
        /// Write a long and a newline
        /// </summary>
        public virtual void WriteLine(long value)
        {
            Write(value);
            WriteLine();
        }

        /// <summary>
        /// Write the string representation of an object and a newline
        /// </summary>
        public virtual void WriteLine(object value)
        {
            Write(value);
            WriteLine();
        }

        /// <summary>
        /// Write a float and a newline
        /// </summary>
        public virtual void WriteLine(float value)
        {
            Write(value);
            WriteLine();
        }

        /// <summary>
        /// Write a string and a newline
        /// </summary>
        public virtual void WriteLine(string value)
        {
            Write(value);
            WriteLine();
        }

        /// <summary>
        /// Write an uint and a newline
        /// </summary>
        [CLSCompliant(false)]
        public virtual void WriteLine(uint value)
        {
            Write(value);
            WriteLine();
        }

        /// <summary>
        /// Write an ulong and a newline
        /// </summary>
        [CLSCompliant(false)]
        public virtual void WriteLine(ulong value)
        {
            Write(value);
            WriteLine();
        }

        /// <summary>
        /// Write a char array (from index) and a newline
        /// </summary>
        public virtual void WriteLine(char[] buffer, int index, int count)
        {
            Write(buffer, index, count);
            WriteLine();
        }

        /// <summary>
        /// Write a formatted string and a newline
        /// </summary>
        public virtual void WriteLine(string format, object arg0)
        {
            Write(format, arg0);
            WriteLine();
        }

        /// <summary>
        /// Write a formatted string and a newline
        /// </summary>
        public virtual void WriteLine(string format, object arg0, object arg1)
        {
            Write(format, arg0, arg1);
            WriteLine();
        }

        /// <summary>
        /// Write a formatted string and a newline
        /// </summary>
        public virtual void WriteLine(string format, params object[] arg)
        {
            Write(format, arg);
            WriteLine();
        }

        /// <summary>
        /// Write a formatted string and a newline
        /// </summary>
        public virtual void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            Write(format, arg0, arg1, arg2);
            WriteLine();
        }

        private sealed class NullTextWriter : TextWriter
        {
            public override Encoding Encoding
            {
                get
                {
                    return Encoding.ASCII;
                }
            }

            public override void Write(string s)
            {
            }
            public override void Write(char value)
            {
            }
            public override void Write(char[] value, int index, int count)
            {
            }
        }
	}
}

