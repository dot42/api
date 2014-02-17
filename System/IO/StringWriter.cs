// Copyright (C) 2014 dot42
//
// Original filename: StringWriter.cs
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
    public class StringWriter : TextWriter
    {
        //private Java.Io.StringWriter _writer;
        private StringBuilder _stringBuilder;

        /// <summary>
        /// Default constructor
        /// </summary>
        public StringWriter()
            : this(new StringBuilder())
        {
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public StringWriter(IFormatProvider formatProvider)
            : this(new StringBuilder(), formatProvider)
        {
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public StringWriter(StringBuilder sb)
            : this(sb, null)
        {
        }

        public StringWriter(StringBuilder sb, IFormatProvider formatProvider)
            : base(formatProvider)
        {
            _stringBuilder = sb;
        }

        /// <summary>
        /// The Encoding in which the output is written.
        /// </summary>
        public override Encoding Encoding
        {
            get { return Encoding.Unicode; }
        }

        /// <summary>
        /// Return the underlyingStringBuilder.
        /// </summary>
        /// <returns></returns>
        public virtual StringBuilder GetStringBuilder()
        {
            return _stringBuilder;
        }


        /// <summary>
        /// Returns a string containing the characters written to the current StringWriter so far.
        /// </summary>
        public override string ToString()
        {
            return _stringBuilder.ToString();
        }


        /// <summary>
        /// Write the character
        /// </summary>
        public override void Write(char value)
        {
            _stringBuilder.Append(value);
        }

        /// <summary>
        /// Write the string
        /// </summary>
        public override void Write(string value)
        {
            _stringBuilder.Append(value);
        }

        /// <summary>
        /// Write the character array (from index)
        /// </summary>
        public override void Write(char[] buffer, int index, int count)
        {
            _stringBuilder.Append(buffer, index, count);
        }
    }
}

