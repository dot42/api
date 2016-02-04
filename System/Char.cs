// Copyright (C) 2014 dot42
//
// Original filename: Char.cs
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

using System.Globalization;
using Dot42;

namespace System
{
	partial struct Char
	{
        public static bool IsNumber(char ch)
        {
            var type = char.GetType(ch);
            return (type == char.DECIMAL_DIGIT_NUMBER) ||
                   (type == char.LETTER_NUMBER) || 
                   (type == char.OTHER_NUMBER);
        }

        public static bool IsWhiteSpace(char ch)
        {
            return char.IsWhitespace(ch);
        }

        public static bool IsPunctuation(char ch)
        {
            var type = char.GetType(ch);
            return (type == char.CONNECTOR_PUNCTUATION) ||
                   (type == char.DASH_PUNCTUATION) ||
                   (type == char.END_PUNCTUATION) ||
                   (type == char.FINAL_QUOTE_PUNCTUATION) ||
                   (type == char.INITIAL_QUOTE_PUNCTUATION) ||
                   (type == char.START_PUNCTUATION) ||
                   (type == char.OTHER_PUNCTUATION);
        }

        public static bool IsSeparator(char ch)
        {
            var type = char.GetType(ch);
            return (type == char.SPACE_SEPARATOR) ||
                   (type == char.DIRECTIONALITY_PARAGRAPH_SEPARATOR) ||
                   (type == char.LINE_SEPARATOR);
        }

        public static bool IsControl(char ch)
        {
            var type = char.GetType(ch);
            return (type == char.CONTROL);
        }

        public static bool IsDigit(string s, int index)
        {
            if (s == null) throw new ArgumentNullException("s");
            if (index < 0 || index > s.Length) throw new ArgumentOutOfRangeException("index");

            return IsDigit(s[index]);
        }

        public static char Parse(string s)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (s.Length != 1)
                throw new FormatException("Length not 1, but " + s.Length + " s=" + s);
            return s[0];
        }

        public static char ToLower(char ch)
        {
            return char.ToLowerCase(ch);
        }

        public static char ToLowerInvariant(char ch)
        {
            return char.ToLowerCase(ch);
        }

        public static char ToUpperInvariant(char ch)
        {
            return char.ToUpperCase(ch);
        }

        public static char ToUpper(char ch)
        {
            return char.ToUpperCase(ch);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public bool Equals(char other)
        {
            return other == this;
        }

    }
}

