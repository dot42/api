// Copyright (C) 2014 dot42
//
// Original filename: XmlConvert.cs
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
using Dot42;
using Java.Security;
using Java.Text;
using Locale = Java.Util.Locale;

namespace System.Xml
{
    /// <summary>
    /// Convert from XML types to CLR types.
    /// </summary>
	public class XmlConvert
    {
        private const string defaultDateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffffzzz";
        private const string defaultDateFormat = "yyyy-MM-dd";
        private const string defaultTimeFormat = "HH:mm:ss.fffffzzz";

        /// <summary>
        /// Convert a string to a boolean.
        /// </summary>
        public static bool ToBoolean(string s)
        {
            return bool.Parse(s);
        }

        /// <summary>
        /// Convert a string to a byte.
        /// </summary>
        public static byte ToByte(string s)
        {
            return byte.Parse(s);
        }

        /// <summary>
        /// Convert a string to a character.
        /// </summary>
        public static char ToChar(string s)
        {
            return char.Parse(s);
        }

        /// <summary>
        /// Convert a string to a date time.
        /// </summary>
        public static DateTime ToDateTime(string s)
        {
            return ToDateTime(s, new []{defaultDateTimeFormat, defaultDateFormat, defaultTimeFormat});
        }

        /// <summary>
        /// Convert a string to a date time.
        /// </summary>
        public static DateTime ToDateTime(string s, string format)
        {
            return ToDateTime(s, new[] {format});
        }

        public static DateTime ToDateTime(string s, string[] formats)
        {
            foreach (var format in formats)
            {
                var simpleDateFormat = new SimpleDateFormat(ToJavaFormat(format), Locale.US);
                var parsePosition = new ParsePosition(0);
                var date = simpleDateFormat.Parse(s, parsePosition);
                if (date != null && parsePosition.Index != 0) return DateTime.FromDate(date);
            }

            throw new ArgumentException(s + " cannot be parsed as DateTime");
        }

        /// <summary>
        /// Convert a string to a decimal.
        /// </summary>
        public static decimal ToDecimal(string s)
        {
            return decimal.Parse(s);
        }

        /// <summary>
        /// Convert a string to a double.
        /// </summary>
        public static double ToDouble(string s)
        {
            return double.Parse(s);
        }

        /// <summary>
        /// Convert a string to a guid.
        /// </summary>
        public static Guid ToGuid(string s)
        {
            return new Guid(s);
        }
        
        /// <summary>
        /// Convert a string to a short.
        /// </summary>
        public static short ToInt16(string s)
        {
            return short.Parse(s);
        }

        /// <summary>
        /// Convert a string to an int.
        /// </summary>
        public static int ToInt32(string s)
        {
            return int.Parse(s);
        }

        /// <summary>
        /// Convert a string to a long.
        /// </summary>
        public static long ToInt64(string s)
        {
            return long.Parse(s);
        }

        /// <summary>
        /// Convert a string to a signed byte.
        /// </summary>
        [CLSCompliant(false)]
        public static sbyte ToSByte(string s)
        {
            return sbyte.Parse(s);
        }

        /// <summary>
        /// Convert a string to a float.
        /// </summary>
        public static float ToSingle(string s)
        {
            return float.Parse(s);
        }

        /// <summary>
        /// Convert a string to a time span.
        /// </summary>
        public static TimeSpan ToTimeSpan(string s)
        {
            return TimeSpan.Parse(s);
        }

        /// <summary>
        /// Convert a string to an unsigned short.
        /// </summary>
        [CLSCompliant(false)]
        public static ushort ToUInt16(string s)
        {
            return ushort.Parse(s);
        }

        /// <summary>
        /// Convert a string to an unsigned integer.
        /// </summary>
        [CLSCompliant(false)]
        public static uint ToUInt32(string s)
        {
            return uint.Parse(s);
        }

        /// <summary>
        /// Convert a string to an unsigned long.
        /// </summary>
        [CLSCompliant(false)]
        public static ulong ToUInt64(string s)
        {
            return ulong.Parse(s);
        }

        public static string ToString(bool value)
        {
            return value ? "true" : "false";
        }

        public static string ToString(byte value)
        {
            return value.ToString();
        }

        public static string ToString(char value)
        {
            return value.ToString();
        }

        public static string ToString(DateTime value)
        {
            return ToString(value, defaultDateTimeFormat);
        }

        public static string ToString(DateTime value, string format)
        {
            var simpleDateFormat = new SimpleDateFormat(ToJavaFormat(format), Locale.US);
            var result = simpleDateFormat.Format(value.ToDate());
            if (format.EndsWith("zzz"))
            {
                var tempResult = result;
                result = tempResult.Substring(0, tempResult.Length - 2) + ":" + tempResult.Substring(tempResult.Length - 2);
            }
            return result;
        }

        public static string ToString(decimal value)
        {
            return value.ToString();
        }

        public static string ToString(double value)
        {
            if (double.NegativeInfinity == value)
                return "-INF";
            if (double.PositiveInfinity == value)
                return "INF";
            return double.ToString(value);
        }

        public static string ToString(Guid value)
        {
            return value.ToString();
        }

        public static string ToString(Int16 value)
        {
            return value.ToString();
        }

        public static string ToString(Int32 value)
        {
            return value.ToString();
        }

        public static string ToString(Int64 value)
        {
            return value.ToString();
        }

        public static string ToString(SByte value)
        {
            return value.ToString();
        }

        public static string ToString(float value) //single
        {
            if (float.NegativeInfinity == value)
                return "-INF";
            if (float.PositiveInfinity == value)
                return "INF";
            return float.ToString(value);
        }

        public static string ToString(TimeSpan value)
        {
            return value.ToString();
        }

        public static string ToString(UInt16 value)
        {
            return value.ToString();
        }

        public static string ToString(UInt32 value)
        {
            return value.ToString();
        }

        public static string ToString(UInt64 value)
        {
            return value.ToString();
        }  

        [Inline]
        private static string ToJavaFormat(string dotNetFormat)
        {
            //'zzz' should be Z
            //every f should be S
            //the T should be escaped
            var javaFormat = dotNetFormat.Replace("zzz", "Z").Replace('f', 'S').Replace("T", "'T'");
            return javaFormat;
        }
    }
}

