using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Java.Util;

namespace Dot42.Internal
{
    internal class DateTimeFormatting
    {
        private static readonly HashMap<string, string> Conversion;

        static DateTimeFormatting()
        {
            var conv = new HashMap<string, string>();
            conv.Put("d", "d");
            conv.Put("dd", "dd");
            conv.Put("ddd", "E");
            conv.Put("dddd", "EEEE");
            conv.Put("f", "S");
            conv.Put("ff", "SS");
            conv.Put("fff", "SSS");
            conv.Put("ffff", "SSSS");
            conv.Put("fffff", "SSSSS");
            conv.Put("ffffff", "SSSSSS");
            conv.Put("fffffff", "SSSSSSS");
            conv.Put("F", "S");
            conv.Put("FF", "SS");
            conv.Put("FFF", "SSS");
            conv.Put("FFFF", "SSSS");
            conv.Put("FFFFF", "SSSSS");
            conv.Put("FFFFFF", "SSSSSS");
            conv.Put("FFFFFFF", "SSSSSSS");
            conv.Put("g", "G");
            conv.Put("gg", "GG");
            conv.Put("h", "K");
            conv.Put("hh", "KK");
            conv.Put("H", "H");
            conv.Put("HH", "HH");
            // K is handled in Code.
            //conv.Put("K", "X");
            conv.Put("m", "m");
            conv.Put("mm", "mm");
            conv.Put("M", "M");
            conv.Put("MM", "MM");
            conv.Put("MMM", "MMM");
            conv.Put("MMMM", "MMMM");
            conv.Put("s", "s");
            conv.Put("ss", "ss");
            conv.Put("t", "a");
            conv.Put("tt", "aa");
            conv.Put("y", "y");
            conv.Put("yy", "yy");
            conv.Put("yyy", "yyy");
            conv.Put("yyyy", "yyyy");
            conv.Put("yyyyy", "yyyyy");
            conv.Put("yyyyy", "yyyyy");
            conv.Put("yyyyyy", "yyyyyy");
            conv.Put("yyyyyyy", "yyyyyyy");
            conv.Put("z", "Z");
            conv.Put("zz", "ZZ");
            conv.Put("zzz", "ZZZ");
            conv.Put("%", "");

            Conversion = conv;
        }

        public static string ToJavaFormatString(string format, IFormatProvider provider, DateTimeKind kind, out bool useInvariant, out bool foundDateTimeKind)
        {
            if (string.IsNullOrEmpty(format))
                format = "G";

            DateTimeFormatInfo dtfi = null;

            if (provider != null)
                dtfi = (DateTimeFormatInfo)provider.GetFormat(typeof(DateTimeFormatInfo));

            if (dtfi == null)
                dtfi = DateTimeFormatInfo.CurrentInfo;

            if (format.Length == 1 && dtfi != null)
            {
                bool useUtc;
                format = GetStandardPattern(format[0], dtfi, out useInvariant, out useUtc, false);

                if (format == null)
                    throw new FormatException(
                        "format is not one of the format specifier characters defined for DateTimeFormatInfo");
            }
            else
                useInvariant = false;

            format = ConvertFormatStringNetToJava(format, kind, out foundDateTimeKind);
            return format;
        }

        
        private static string ConvertFormatStringNetToJava(string format, DateTimeKind kind, out bool foundDateTimeKind)
        {
            foundDateTimeKind = false;

            StringBuilder b = new StringBuilder(format.Length + 6);
            bool isQuote = false;
            bool isAutoQuote = false;

            StringBuilder currentPart = new StringBuilder();


            for (int i = 0; true; ++i)
            {
                char c = i >= format.Length ? '\0' : format[i];

                if (currentPart.Length > 0 && c != currentPart[0])
                {
                    string part = currentPart.ToString();
                    string conv = null;
                    if (part == "K")
                    {
                        // special case.
                        foundDateTimeKind = true;
                        if (kind == DateTimeKind.Utc)
                        {
                            part = "Z";
                        }
                        else if (kind == DateTimeKind.Local)
                        {
                            // best we can do, even though not 100% accurate.
                            conv = "Z";
                        }
                    }
                    else
                    {
                        // append collected.
                        conv = Conversion.Get(part);
                    }
                    if (conv == null)
                    {
                        // not in map.
                        if (!isAutoQuote)
                        {
                            b.Append('\'');
                            isAutoQuote = true;
                        }
                        b.Append(part);
                    }
                    else
                    {
                        if (isAutoQuote)
                        {
                            b.Append('\'');
                            isAutoQuote = false;
                        }
                        b.Append(conv);
                    }

                    currentPart = new StringBuilder();
                }

                if (i >= format.Length)
                    break;

                if (c == '\'' || c == '\"')
                {
                    if (isAutoQuote)
                        isAutoQuote = false;
                    else
                        b.Append('\'');
                    isQuote = !isQuote;
                    continue;
                }

                if (isQuote)
                {
                    b.Append(c);
                    continue;
                }

                if (c == '\\')
                {
                    if (i < format.Length - 1)
                    {
                        if (!isAutoQuote)
                        {
                            isAutoQuote = true;
                            b.Append('\'');
                        }
                        b.Append(format[i + 1]);

                        ++i;
                    }
                    continue;
                }

                if (!char.IsLetter(c) && c != '%')
                {
                    b.Append(c);
                    continue;
                }

                currentPart.Append(c);
            }

            if (isAutoQuote) b.Append('\'');

            format = b.ToString();
            return format;
        }

        //Mono code (DateTimeUtils.cs):
        public static string GetStandardPattern(char format, DateTimeFormatInfo dfi, out bool useutc, out bool use_invariant, bool date_time_offset)
        {
            String pattern;

            useutc = false;
            use_invariant = false;

            switch (format)
            {
                case 'd':
                    pattern = dfi.ShortDatePattern;
                    break;
                case 'D':
                    pattern = dfi.LongDatePattern;
                    break;
                case 'f':
                    pattern = dfi.LongDatePattern + " " + dfi.ShortTimePattern;
                    break;
                case 'F':
                    pattern = dfi.FullDateTimePattern;
                    break;
                case 'g':
                    pattern = dfi.ShortDatePattern + " " + dfi.ShortTimePattern;
                    break;
                case 'G':
                    pattern = dfi.ShortDatePattern + " " + dfi.LongTimePattern;
                    break;
                case 'm':
                case 'M':
                    pattern = dfi.MonthDayPattern;
                    break;
                case 'o':
                case 'O':
                    pattern = dfi.RoundtripPattern;
                    use_invariant = true;
                    break;
                case 'r':
                case 'R':
                    pattern = dfi.RFC1123Pattern;
                    if (date_time_offset)
                        useutc = true;
                    use_invariant = true;
                    break;
                case 's':
                    pattern = dfi.SortableDateTimePattern;
                    use_invariant = true;
                    break;
                case 't':
                    pattern = dfi.ShortTimePattern;
                    break;
                case 'T':
                    pattern = dfi.LongTimePattern;
                    break;
                case 'u':
                    pattern = dfi.UniversalSortableDateTimePattern;
                    if (date_time_offset)
                        useutc = true;
                    use_invariant = true;
                    break;
                case 'U':
                    if (date_time_offset)
                        pattern = null;
                    else
                    {
                        pattern = dfi.FullDateTimePattern;
                        useutc = true;
                    }
                    break;
                case 'y':
                case 'Y':
                    pattern = dfi.YearMonthPattern;
                    break;
                default:
                    pattern = null;
                    break;
            }

            return pattern;
        }
    }
}
