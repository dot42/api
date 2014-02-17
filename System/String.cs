// Copyright (C) 2014 dot42
//
// Original filename: String.cs
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
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Dot42;
using Dot42.Internal;
using Java.Lang;
using Java.Util;

namespace System
{
	partial class String
	{
	    public const string Empty = "";

        /// <summary>
        /// Creates a string with the specified character repeated 'count' times.
        /// </summary>
        public String(char c, int count)
            : this(Constuct(c, count))
        {
        }

        private static char[] Constuct(char c, int count)
        {
            var result = new char[count];
            Arrays.Fill(result, c);
            return result;
        }

        /// <summary>
        /// Gets the number of characters in the string
        /// </summary>
        int Java.Lang.ICharSequence.GetLength()
        {
            return Length;
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        [Inline]
        public static int Compare(string strA, string strB)
        {
            return Compare(strA, strB, false);
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        public static int Compare(string strA, string strB, bool ignoreCase)
        {
            if (ReferenceEquals(strA, null) && ReferenceEquals(strB, null)) return 0;
            if (ReferenceEquals(strA, null)) return 1;
            if (ReferenceEquals(strB, null)) return -1;
            if (ignoreCase)
                return strA.CompareToIgnoreCase(strB);
            return strA.CompareTo(strB);
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        public static int Compare(string strA, string strB, StringComparison comparisonType)
        {
            var ignoreCase = (comparisonType == StringComparison.InvariantCultureIgnoreCase) ||
                             (comparisonType == StringComparison.CurrentCultureIgnoreCase) ||
                             (comparisonType == StringComparison.OrdinalIgnoreCase);
            return Compare(strA, strB, ignoreCase);
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo cultureInfo)
        {
            var a = strA.JavaSubstring(indexA, indexA + length);
            var b = strB.JavaSubstring(indexB, indexB + length);
            if (ignoreCase)
                return a.CompareToIgnoreCase(b);
            else return a.CompareTo(b);
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        [Inline]
        public static int CompareOrdinal(string strA, string strB)
        {
            return Compare(strA, strB, StringComparison.Ordinal);
        }


        /// <summary>
        /// Does this string contain the given sub string?
        /// </summary>
        [Inline]
        public bool Contains(string value)
        {
            return Contains((ICharSequence) value);
        }

        /// <summary>
        /// Copy a specified numbers of characters from this string to the given array.
        /// </summary>
        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            if (destination == null)
                throw new ArgumentNullException("destination");
            if (sourceIndex < 0)
                throw new ArgumentOutOfRangeException("sourceIndex");
            if (destinationIndex < 0)
                throw new ArgumentOutOfRangeException("destinationIndex");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (sourceIndex + count > Length)
                throw new ArgumentOutOfRangeException("count");
            if (destinationIndex + count > destination.Length)
                throw new ArgumentOutOfRangeException("count");
            while (count > 0)
            {
                destination[destinationIndex++] = this[sourceIndex++];
                count--;
            }
        }

        /// <summary>
        /// Replaces format items in the given string with a string representation of the given argument.
        /// </summary>
        [Inline]
        public static string Format(string format, object arg0)
        {
            if (format == null)
                throw new ArgumentNullException("format");
            return Format(null, format, new[] { arg0 });
        }

        /// <summary>
        /// Replaces format items in the given string with a string representations of the given arguments.
        /// </summary>
        [Inline]
        public static string Format(string format, object arg0, object arg1)
        {
            if (format == null)
                throw new ArgumentNullException("format");
            return Format(null, format, new[] { arg0, arg1 });
        }

        /// <summary>
        /// Replaces format items in the given string with a string representations of the given arguments.
        /// </summary>
        [Inline]
        public static string Format(string format, object arg0, object arg1, object arg2)
        {
            if (format == null)
                throw new ArgumentNullException("format");
            return Format(null, format, new[] { arg0, arg1, arg2 });
        }

        /// <summary>
        /// Replaces format items in the given string with a string representations of the given arguments.
        /// </summary>
        [Inline]
        public static string Format(string format, params object[] args)
        {
            return Format(null, format, args);
        }

        /// <summary>
        /// Replaces format items in the given string with a string representations of the given arguments.
        /// </summary>
        [Inline]
        public static string Format(IFormatProvider provider, string format, params object[] args)
        {
            var helper = new FormatHelper(null, provider, format, args);
            return helper.Format().ToString();
        }

        /// <summary>
        /// Gets the index of the first use of the given character in this string.
        /// </summary>
        /// <returns>The index of the first use of the given character or -1 if the given character is not used.</returns>
        [Inline]
        public int IndexOf(char ch)
        {
            return IndexOf((int) ch);
        }

        /// <summary>
        /// Gets the index of the first use of the given character in this string.
        /// The search starts at the given index.
        /// </summary>
        /// <returns>The index of the first use of the given character or -1 if the given character is not used.</returns>
        [Inline]
        public int IndexOf(char ch, int startIndex)
        {
            return IndexOf((int)ch, startIndex);
        }

        /// <summary>
        /// Gets the index of the first use of any of the given characters in this string.
        /// </summary>
        /// <returns>The index of the first use of any of the given character or -1 if the given character is not used.</returns>
        [Inline]
        public int IndexOfAny(char[] array)
        {
            return IndexOfAny(array, 0, GetLength());
        }

        /// <summary>
        /// Gets the index of the first use of any of the given characters in this string.
        /// </summary>
        /// <returns>The index of the first use of any of the given character or -1 if the given character is not used.</returns>
        [Inline]
        public int IndexOfAny(char[] array, int startIndex)
        {
            return IndexOfAny(array, startIndex, GetLength() - startIndex);
        }

        /// <summary>
        /// Gets the index of the first use of any of the given characters in this string.
        /// </summary>
        /// <returns>The index of the first use of any of the given character or -1 if the given character is not used.</returns>
        public int IndexOfAny(char[] array, int startIndex, int count)
        {
            if (startIndex < 0) throw new ArgumentOutOfRangeException("startIndex");
            if (count < 0) throw new ArgumentOutOfRangeException("count");
            var length = GetLength();
            if (startIndex + count > length) throw new ArgumentOutOfRangeException();
            var arrayLen = array.Length;
            var endIndex = startIndex + count;
            for (var i = startIndex; i < endIndex; i++)
            {
                var ch = CharAt(i);
                for (var j = 0; j < arrayLen; j++)
                {
                    if (array[j] == ch) return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in this instance. The search starts at a specified character position and examines a specified number of character positions.
        /// </summary>
        public int IndexOf(string value, int startIndex, int count)
        {
            if ((count < 0) || (count > (Length - startIndex)))
                throw new ArgumentOutOfRangeException("count");
            if ((startIndex < 0) || (startIndex > Length))
                throw new ArgumentOutOfRangeException("startIndex");
            var subString = JavaSubstring(startIndex, startIndex + count);
            var index = subString.IndexOf(value);
            return (index < 0) ? index : index + startIndex;
        }

        /// <summary>
        /// Returns a new string that right-aligns the characters in this string by padding them with spaces on the left, for a specified total length.
        /// </summary>
        [Inline]
        public string PadLeft(int totalWidth)
        {
            return PadLeft(totalWidth, ' ');
        }

        /// <summary>
        /// Returns a new string that right-aligns the characters in this string by padding them given character on the left, for a specified total length.
        /// </summary>
        public string PadLeft(int totalWidth, char paddingChar)
        {
            var length = Length;
            if (totalWidth <= length) return this;
            var builder = new StringBuilder(this);
            var padLength = totalWidth - length;
            builder.Insert(0, new RepeatingCharSequence(paddingChar, padLength));
            return builder.ToString();
        }

        /// <summary>
        /// Returns a new string that left-aligns the characters in this string by padding them with spaces on the right, for a specified total length.
        /// </summary>
        [Inline]
        public string PadRight(int totalWidth)
        {
            return PadRight(totalWidth, ' ');
        }

        /// <summary>
        /// Returns a new string that left-aligns the characters in this string by padding them given character on the right, for a specified total length.
        /// </summary>
        public string PadRight(int totalWidth, char paddingChar)
        {
            var length = Length;
            if (totalWidth <= length) return this;
            var builder = new StringBuilder(this);
            var padLength = totalWidth - length;
            builder.Append(new RepeatingCharSequence(paddingChar, padLength));
            return builder.ToString();
        }

        /// <summary>
        /// Return a new instance which is this string with all characters from the given index on removed.
        /// </summary>
        [Inline]
        public string Remove(int startIndex)
        {
            if ((startIndex < 0) || (startIndex >= Length))
                throw new ArgumentOutOfRangeException("startIndex");
            return JavaSubstring(0, startIndex);
        }

        /// <summary>
        /// Return a new instance which is this string with count characters from the given index on removed.
        /// </summary>
        public string Remove(int startIndex, int count)
        {
            var len = Length;
            if ((startIndex < 0) || (startIndex >= len))
                throw new ArgumentOutOfRangeException("startIndex");
            if ((count < 0) || (startIndex + count >= len))
                throw new ArgumentOutOfRangeException("count");
            if (count == 0)
                return this;
            if (startIndex == 0)
                return JavaSubstring(count, (len - count + 1));
            var sb = new StringBuilder();
            sb.Append(this, 0, startIndex);
            sb.Append(this, startIndex + count, len - (startIndex + count));
            return sb.ToString();
        }

        /// <summary>
        /// Split this string into parts delimited by the given separators.
        /// </summary>
        [Inline]
        public string[] Split(params char[] separator)
        {
            return Split(separator, int.MaxValue, StringSplitOptions.None);
        }

        /// <summary>
        /// Split this string into parts delimited by the given separators.
        /// </summary>
        [Inline]
        public string[] Split(char[] separator, int count)
        {
            return Split(separator, count, StringSplitOptions.None);
        }

        /// <summary>
        /// Split this string into parts delimited by the given separators.
        /// </summary>
        [Inline]
        public string[] Split(char[] separator, StringSplitOptions options)
        {
            return Split(separator, int.MaxValue, options);
        }

        /// <summary>
        /// Split this string into parts delimited by the given separators.
        /// </summary>
        public string[] Split(char[] separator, int count, StringSplitOptions options)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
            if ((options != StringSplitOptions.None) && (options != StringSplitOptions.RemoveEmptyEntries))
                throw new ArgumentException("Illegal enum value: " + options + ".");

            var removeEmptyEntries = (options & StringSplitOptions.RemoveEmptyEntries) != 0;
            var length = Length;
            if ((length == 0) && removeEmptyEntries)
                return new string[0];

            if (count <= 1)
            {
                return count == 0 ? new string[0] : new[] { this };
            }

            var list = new ArrayList<string>();
            var start = 0;
            var index = 0;
            while (index < length)
            {
                if (Contains(separator, CharAt(index)))
                {
                    // Split here
                    if ((!removeEmptyEntries) || (start != index))
                    {
                        list.Add(JavaSubstring(start, index));
                    }
                    index++;
                    start = index;
                    if (list.Count + 1 >= count)
                        break;
                }
                else
                {
                    index++;
                }
            }
            // Add last part (if needed)
            if (start <= index)
            {
                if ((!removeEmptyEntries) || (start != index))
                {
                    list.Add(JavaSubstring(start, index));
                }                
            }
            return list.ToArray<string>(new string[list.Count]);
        }

        /// <summary>
        /// Does the given array contain the given character?
        /// </summary>
        private static bool Contains(char[] array, char value)
        {
            var length = array.Length;
            for (var i = 0; i < length; i++)
                if (array[i] == value)
                    return true;
            return false;
        }

        /// <summary>
        /// Return a substring of this instance.  
        /// </summary>
        [Dot42.DexImport("substring", "(I)Ljava/lang/String;")]
        public string Substring(int start)
        {
            return default(string);
        }

        /// <summary>
        /// Return a substring of this instance. 
        /// </summary>
        [Inline]
        public string Substring(int startIndex, int length)
        {
            if (length < 0)
                throw new ArgumentOutOfRangeException("length");
            return JavaSubstring(startIndex, startIndex + length);
        }

        /// <summary>
        /// Is the given string null or zero length.
        /// </summary>
        [Inline]
        public static bool IsNullOrEmpty(string value)
        {
            return (value == null) || (value.Length == 0);
        }

        /// <summary>
        /// Is the given string null or consists only of whitespace characters.
        /// </summary>
        [Inline]
        public static bool IsNullOrWhiteSpace(string value)
        {
            return (value == null) || (value.Trim().Length == 0);
        }

        /// <summary>
        /// Create a concatenation of all strings in the array with the given separator between each array element.
        /// </summary>
        public static string Join(string separator, params string[] array)
        {
            if (array.Length == 0)
                return "";
            var sb = new StringBuffer();
            var first = true;
            foreach (var element in array)
            {
                if (first)
                {
                    first = false;
                }
                else if (separator != null)
                {
                    sb.Append(separator);
                }
                if (element != null)
                {
                    sb.Append(element);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Create a concatenation of all strings in the array with the given separator between each array element.
        /// </summary>
        public static string Join(string separator, params object[] array)
        {
            if ((array.Length == 0) || (array[0] == null))
                return "";
            var sb = new StringBuffer();
            var first = true;
            foreach (var element in array)
            {
                if (first)
                {
                    first = false;
                }
                else if (separator != null)
                {
                    sb.Append(separator);
                }
                if (element != null)
                {
                    sb.Append(element);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Create a concatenation of all strings in the array with the given separator between each array element.
        /// </summary>
        public static string Join(string separator, IEnumerable<string> strings)
        {
            var sb = new StringBuffer();
            var first = true;
            foreach (var element in strings)
            {
                if (first)
                {
                    first = false;
                }
                else if (separator != null)
                {
                    sb.Append(separator);
                }
                if (element != null)
                {
                    sb.Append(element);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Create a concatenation of all objects in the enumerable with the given separator between each element.
        /// </summary>
        public static string Join<T>(string separator, IEnumerable<T> objects)
        {
            var sb = new StringBuffer();
            var first = true;
            foreach (var element in objects)
            {
                if (first)
                {
                    first = false;
                }
                else if (separator != null)
                {
                    sb.Append(separator);
                }
                if (element != null)
                {
                    sb.Append(element);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Gets a string representation of the given value.
        /// </summary>
        public static string Concat(object value)
        {
            return (value == null) ? string.Empty : value.ToString();
        }

        /// <summary>
        /// Gets a concatenation of the string representation of the given values.
        /// </summary>
        public static string Concat(object v1, object v2)
        {
            v1 = v1 ?? string.Empty;
            v2 = v2 ?? string.Empty;
            return Concat(v1.ToString(), v2.ToString());
        }

        /// <summary>
        /// Gets a concatenation of the string representation of the given values.
        /// </summary>
        public static string Concat(object v1, object v2, object v3)
        {
            v1 = v1 ?? string.Empty;
            v2 = v2 ?? string.Empty;
            v3 = v3 ?? string.Empty;
            return Concat(v1.ToString(), v2.ToString(), v3.ToString());
        }

        /// <summary>
        /// Gets a concatenation of the string representation of the given values.
        /// </summary>
        public static string Concat(object v1, object v2, object v3, object v4)
        {
            v1 = v1 ?? string.Empty;
            v2 = v2 ?? string.Empty;
            v3 = v3 ?? string.Empty;
            v4 = v4 ?? string.Empty;
            return Concat(v1.ToString(), v2.ToString(), v3.ToString(), v4.ToString());
        }

        /// <summary>
        /// Gets a concatenation of the string representation of the given values.
        /// </summary>
        public static string Concat(params object[] args)
        {
            if (args == null)
                throw new ArgumentNullException("args");
            var sb = new Java.Lang.StringBuffer();
            for (var i = 0; i < args.Length; i++)
            {
                var arg = args[i];
                if (arg != null)
                    sb.Append(arg);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Concatenate v1 and v2.
        /// </summary>
        public static string Concat(string v1, string v2)
        {
            if (string.IsNullOrEmpty(v1))
            {
                if (string.IsNullOrEmpty(v2))
                    return string.Empty;
                return v2;
            }
            if (string.IsNullOrEmpty(v2))
                return v1;
            return v1.Concat(v2);
        }

        /// <summary>
        /// Concatenate v1, v2 and v3.
        /// </summary>
        public static string Concat(string v1, string v2, string v3)
        {
            v1 = v1 ?? string.Empty;
            v2 = v2 ?? string.Empty;
            v3 = v3 ?? string.Empty;
            return v1.Concat(v2).Concat(v3);
        }

        /// <summary>
        /// Concatenate v1, v2, v3 and v4.
        /// </summary>
        public static string Concat(string v1, string v2, string v3, string v4)
        {
            v1 = v1 ?? string.Empty;
            v2 = v2 ?? string.Empty;
            v3 = v3 ?? string.Empty;
            v4 = v4 ?? string.Empty;
            return v1.Concat(v2).Concat(v3).Concat(v4);
        }

        /// <summary>
        /// Gets a concatenation of the string representation of the given values.
        /// </summary>
        public static string Concat(params string[] args)
        {
            if (args == null)
                throw new ArgumentNullException("args");
            var sb = new Java.Lang.StringBuffer();
            for (var i = 0; i < args.Length; i++)
            {
                var arg = args[i];
                if (arg != null)
                    sb.Append(arg);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Is this string equal to the given string?
        /// </summary>
        [Inline]
        public bool Equals(string other)
        {
            return Equals((object) other);
        }

        /// <summary>
        /// Is string a equal to string b?
        /// </summary>
        [Inline]
        public static bool Equals(string a, string b)
        {
            if (a == null) return b == null;
            return a.Equals(b);
        }

        /// <summary>
        /// Return a new string in which all occurrences of the given old value have been replaced with the given new value.
        /// </summary>
        [Inline]
        public string Replace(string oldValue, string newValue)
        {
            return Replace((ICharSequence) oldValue, (ICharSequence) newValue);
        }

        [Inline]
        public string ToUpper(CultureInfo culture)
        {
            return ToUpper(culture.Locale);
        }

        [Inline]
        public string ToUpperInvariant()
        {
            return ToUpper(CultureInfo.InvariantCulture);
        }

        [Inline]
        public string ToLower(CultureInfo culture)
        {
            return ToLower(culture.Locale);
        }

        [Inline]
        public string ToLowerInvariant()
        {
            return ToLower(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Removes all leading and trailing occurrences of a set of characters specified in an array from the current object.
        /// </summary>
        public string Trim(params char[] trimChars)
        {
            if (Length == 0)
                return Empty;

            int start = 0;
            if (trimChars != null && trimChars.Length != 0)
                start = FindNotInTable(0, Length, 1, trimChars);

            int end = 0;
            if (trimChars != null && trimChars.Length != 0)
                end = FindNotInTable(Length - 1, -1, -1, trimChars);

            end++;
            if (start == 0 && end == Length)
                return this;

            return JavaSubstring(start, end);
        }

        /// <summary>
        /// Removes all leading occurrences of a set of characters specified in an array from the current object.
        /// </summary>
        public string TrimStart(params char[] trimChars)
        {
            if (Length == 0)
                return Empty;

            int start = 0;
            if (trimChars != null && trimChars.Length != 0)
                start = FindNotInTable(0, Length, 1, trimChars);

            if (start == 0)
                return this;

            return JavaSubstring(start, Length);
        }

        /// <summary>
        /// Removes all trailing occurrences of a set of characters specified in an array from the current object.
        /// </summary>
        public String TrimEnd(params char[] trimChars)
        {
            if (Length == 0)
                return Empty;

            int end = 0;
            if (trimChars != null && trimChars.Length != 0)
                end = FindNotInTable(Length - 1, -1, -1, trimChars);

            end++;
            if (end == Length)
                return this;

            return JavaSubstring(0, end);
        }

        private int FindNotInTable(int pos, int target, int change, char[] table)
        {
            while (pos != target)
            {
                char c = this[pos];
                int x = 0;
                while (x < table.Length)
                {
                    if (c == table[x])
                        break;
                    x++;
                }
                if (x == table.Length)
                    return pos;
                pos += change;
            }
         
            return pos;
        }

        /// <summary>
        /// Is string a equal to string b?
        /// </summary>
        public static bool operator ==(string a, string b)
        {
            return Equals(a, b);
        }

        /// <summary>
        /// Is string a not equal to string b?
        /// </summary>
        public static bool operator !=(string a, string b)
        {
            return !Equals(a, b);
        }
    }
}

