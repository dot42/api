// Copyright (C) 2014 dot42
//
// Original filename: StringBuilder.cs
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
using Dot42.Internal;
using Java.Lang;
using Java.Text;

namespace System.Text
{
	partial class StringBuilder
	{
        /// <summary>
        /// Initialize a new instance with given initial and maximum capacity.
        /// </summary>
        /// <remarks>
        /// The maximum capacity is not used in this implementation.</remarks>
        /// <param name="capacity"></param>
        /// <param name="maxCapacity"></param>
        public StringBuilder(int capacity, int maxCapacity)
            : this(capacity)
        {
            if ((maxCapacity < 1) || (capacity < 1) || (capacity > maxCapacity))
                throw new ArgumentOutOfRangeException();
        }

        /// <summary>
        /// Initialize a new instance with given initial value and capacity.
        /// </summary>
        public StringBuilder(string value, int capacity)
            : this(capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException();
            Append(value);
        }

        /// <summary>
        /// Initialize a new instance with given substring of the given value and capacity.
        /// </summary>
        public StringBuilder(string value, int startIndex, int length, int capacity)
            : this(capacity)
        {
            if (capacity < 0) 
                throw new ArgumentOutOfRangeException();
            if (value != null)
            {
                if ((startIndex < 0) || (length < 0) || (startIndex + length > value.Length))
                    throw new ArgumentOutOfRangeException();
                JavaAppend(value, startIndex, startIndex + length);
            }
        }

        /// <summary>
        /// Append a given number of the given characters.
        /// </summary>
        public StringBuilder Append(char value, int repeatCount)
        {
            Append(new RepeatingCharSequence(value, repeatCount));
            return this;
        }

        /// <summary>
        /// Append a substring of the given string from into this builder.
        /// </summary>
        public StringBuilder Append(string value, int startIndex, int count)
        {
            JavaAppend(value, startIndex, startIndex + count);
            return this;
        }

        /// <summary>
        /// Append a substring of the given string from into this builder.
        /// </summary>
        public StringBuilder AppendFormat(string format, params object[] args)
        {
            Append(string.Format(format, args));
            return this;
        }

        /// <summary>
        /// Appends the default line terminator to the end of the current StringBuilder object.
        /// </summary>
	    public StringBuilder AppendLine()
	    {
	        return Append(Environment.NewLine);
	    }

        /// <summary>
        /// Appends a copy of the specified string followed by the default line terminator to the end of the current StringBuilder object.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
	    public StringBuilder AppendLine(string value)
        {
            Append(value);
            return AppendLine();
        }

        /// <summary>
        /// Insert the one or more copies of the given string at the given index in this string builder.
        /// </summary>
        public StringBuilder Insert(int index, string value, int count)
        {
            var length = value.Length;
            while (count > 0)
            {
                JavaInsert(index, value, 0, length);
                count--;
            }
            return this;
        }

        /// <summary>
        /// Remove length characters from this string builder, starting at the given start index.
        /// </summary>
        public StringBuilder Remove(int startIndex, int length)
        {
            JavaDelete(startIndex, startIndex + length);
            return this;
        }

        /// <summary>
        /// Replace all occurrences of the given old character with the given new character.
        /// </summary>
        public StringBuilder Replace(char oldChar, char newChar)
        {
            var length = Length;
            for (var i = 0; i < length; i++)
            {
                if (this[i] == oldChar)
                {
                    SetCharAt(i, newChar);
                }
            }
            return this;
        }

        /// <summary>
        /// Replace all occurrences of the given old character with the given new character.
        /// </summary>
        public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
        {
            if (startIndex < 0)
                throw new ArgumentOutOfRangeException("startIndex");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (startIndex + count > Length)
                throw new ArgumentOutOfRangeException("overflow");
            for (var i = 0; i < count; i++)
            {
                if (this[startIndex + i] == oldChar)
                {
                    SetCharAt(startIndex + i, newChar);
                }
            }
            return this;
        }

        /// <summary>
        /// Replace all occurrences of the given old string with the given new string.
        /// </summary>
        public StringBuilder Replace(string oldValue, string newValue)
        {
            if (oldValue == null)
                throw new ArgumentNullException("oldValue");
            if (oldValue.Length == 0)
                throw new ArgumentException("oldValue is empty");
            var start = 0;
            int index;
            while ((index = IndexOf(oldValue, start)) >= 0)
            {
                Remove(index, oldValue.Length);
                start = index;
                if (!string.IsNullOrEmpty(newValue))
                {
                    Insert(index, newValue);
                    start += newValue.Length;
                }
            }
            return this;
        }

        /// <summary>
        /// Replace all occurrences of the given old string with the given new string.
        /// </summary>
        public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
        {
            if (oldValue == null)
                throw new ArgumentNullException("oldValue");
            if (oldValue.Length == 0)
                throw new ArgumentException("oldValue is empty");
            if (startIndex < 0)
                throw new ArgumentOutOfRangeException("startIndex");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if ((startIndex + count > Length) || (startIndex + count < 0))
                throw new ArgumentOutOfRangeException("overflow");
            var start = startIndex;
            int index;
            while ((index = IndexOf(oldValue, start)) >= 0)
            {
                if (index >= startIndex + count)
                    break;
                Remove(index, oldValue.Length);
                start = index;
                if (!string.IsNullOrEmpty(newValue))
                {
                    Insert(index, newValue);
                    start += newValue.Length;
                }
            }
            return this;
        }

        /// <summary>
        /// Gets the maximum capacity of this builder.
        /// </summary>
	    public int MaxCapacity
	    {
            get { return int.MaxValue; }
	    }

        /// <summary>
        /// Return a substring of this instance.
        /// </summary>
        public string ToString(int startIndex, int length)
        {
            if (startIndex < 0)
                throw new ArgumentOutOfRangeException("startIndex");
            if (length < 0)
                throw new ArgumentOutOfRangeException("length");
            if ((startIndex + length > Length) || (startIndex + length < 0))
                throw new ArgumentOutOfRangeException("overflow");
            return JavaSubstring(startIndex, startIndex + length);
        }

        /// <summary>
        /// Returns the number of chars in this string. 
        /// </summary>
        public int Length
        {
            [Dot42.DexImport("length", "()I", AccessFlags = 257)]
            get { return default(int); }
            [Dot42.DexImport("setLength", "(I)V", AccessFlags = 1)]
            set { }
        }

        /// <summary>
        ///  Returns the char at index.
        /// </summary>
        [global::System.Runtime.CompilerServices.IndexerName("Chars")]
        public char this[int index]
        {
            [Dot42.DexImport("charAt", "(I)C", AccessFlags = 1)]
            get { return default(char); }
            [Dot42.DexImport("setCharAt", "(IC)V", AccessFlags = 1)] 
            set { }
        }
    }
}

