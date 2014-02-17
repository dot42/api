// Copyright (C) 2014 dot42
//
// Original filename: FormatHelper.cs
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
using System.Text;

namespace Dot42.Internal
{
    internal sealed class FormatHelper
    {
        private readonly StringBuilder result;
        private readonly IFormatProvider provider;
        private readonly string format;
        private readonly object[] args;
        private int ptr;
        int n, width;
        bool left_align;
        string arg_format;


        /// <summary>
        /// Default ctor
        /// </summary>
        internal FormatHelper(StringBuilder result, IFormatProvider provider, string format, params object[] args)
        {
            this.result = result;
            this.provider = provider;
            this.format = format;
            this.args = args;
            if (format == null)
                throw new ArgumentNullException("format");
            if (args == null)
                throw new ArgumentNullException("args");

            if (this.result == null)
            {
                /* Try to approximate the size of result to avoid reallocations */
                int i, len;

                len = 0;
                for (i = 0; i < args.Length; ++i)
                {
                    string s = args[i] as string;
                    if (s != null)
                        len += s.Length;
                    else
                        break;
                }
                if (i == args.Length)
                    this.result = new StringBuilder(len + format.Length);
                else
                    this.result = new StringBuilder();
            }
        }

        /// <summary>
        /// Perform the actual formatting.
        /// </summary>
        internal StringBuilder Format()
        {
            ptr = 0;
            int start = ptr;
            var formatter = provider != null ? provider.GetFormat(typeof(ICustomFormatter)) as ICustomFormatter : null;

            var formatLength = format.Length;
            while (ptr < formatLength)
            {
                char c = format[ptr++];

                if (c == '{')
                {
                    result.Append(format, start, ptr - start - 1);

                    // check for escaped open bracket

                    if (format[ptr] == '{')
                    {
                        start = ptr++;
                        continue;
                    }

                    // parse specifier

                    ParseFormatSpecifier(format);
                    if (n >= args.Length)
                        throw new FormatException("Index (zero based) must be greater than or equal to zero and less than the size of the argument list.");

                    // format argument

                    object arg = args[n];

                    string str;
                    if (arg == null)
                        str = string.Empty;
                    else if (formatter != null)
                        str = formatter.Format(arg_format, arg, provider);
                    else
                        str = null;

                    if (str == null)
                    {
                        if (arg is IFormattable)
                            str = ((IFormattable)arg).ToString(arg_format, provider);
                        else
                            str = arg.ToString();
                    }

                    // pad formatted string and append to result
                    if (width > str.Length)
                    {
                        const char padchar = ' ';
                        int padlen = width - str.Length;

                        if (left_align)
                        {
                            result.Append(str);
                            result.Append(padchar, padlen);
                        }
                        else
                        {
                            result.Append(padchar, padlen);
                            result.Append(str);
                        }
                    }
                    else
                    {
                        result.Append(str);
                    }

                    start = ptr;
                }
                else if (c == '}' && ptr < format.Length && format[ptr] == '}')
                {
                    result.Append(format, start, ptr - start - 1);
                    start = ptr++;
                }
                else if (c == '}')
                {
                    throw new FormatException("Input string was not in a correct format.");
                }
            }

            if (start < formatLength)
                result.Append(format, start, format.Length - start);

            return result;
        }

        private void ParseFormatSpecifier(string str)
        {
            int max = str.Length;

            // parses format specifier of form:
            //   N,[\ +[-]M][:F]}
            //
            // where:
            // N = argument number (non-negative integer)

            n = ParseDecimal(str);
            if (n < 0)
                throw new FormatException("Input string was not in a correct format.");

            // M = width (non-negative integer)

            if (ptr < max && str[ptr] == ',')
            {
                // White space between ',' and number or sign.
                ++ptr;
                while (ptr < max && Char.IsWhiteSpace(str[ptr]))
                    ++ptr;
                int start = ptr;

                arg_format = str.Substring(start, ptr - start);

                left_align = (ptr < max && str[ptr] == '-');
                if (left_align)
                    ++ptr;

                width = ParseDecimal(str);
                if (width < 0)
                    throw new FormatException("Input string was not in a correct format.");
            }
            else
            {
                width = 0;
                left_align = false;
                arg_format = string.Empty;
            }

            // F = argument format (string)

            if (ptr < max && str[ptr] == ':')
            {
                int start = ++ptr;
                while (ptr < max && str[ptr] != '}')
                    ++ptr;

                arg_format += str.Substring(start, ptr - start);
            }
            else
                arg_format = null;

            if ((ptr >= max) || str[ptr++] != '}')
                throw new FormatException("Input string was not in a correct format.");
        }

        private int ParseDecimal(string str)
        {
            int p = ptr;
            int n = 0;
            int max = str.Length;

            while (p < max)
            {
                char c = str[p];
                if (c < '0' || '9' < c)
                    break;

                n = n * 10 + c - '0';
                ++p;
            }

            if (p == ptr || p == max)
                return -1;

            ptr = p;
            return n;
        }
    }
}

