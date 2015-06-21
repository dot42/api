using System;
using System.Globalization;
using System.Net;
using System.Text;
using Java.Text;
using Java.Util;

namespace Dot42.Internal
{
    internal static class DateTimeFormatting
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
            //conv.Put("%", "");

            Conversion = conv;
        }

        public static string ToJavaFormatString(string format, IFormatProvider provider, DateTimeKind kind, bool dateTimeOffset, out bool useInvariant, out bool foundDateTimeKind, out bool useUtc)
        {
            if (string.IsNullOrEmpty(format))
                format = "G";

            DateTimeFormatInfo dtfi = null;

            if (provider != null)
                dtfi = (DateTimeFormatInfo)provider.GetFormat(typeof(DateTimeFormatInfo));

            if (dtfi == null)
                dtfi = DateTimeFormatInfo.CurrentInfo;

            bool needsTranslation = true;

            if (format.Length == 1 && dtfi != null)
            {
                format = GetStandardPattern(format[0], dtfi, dateTimeOffset, out useUtc, out useInvariant, out needsTranslation);

                if (format == null)
                    throw new FormatException(
                        "format is not one of the format specifier characters defined for DateTimeFormatInfo");
            }
            else
            {
                useInvariant = false;
                useUtc = false;
            }

            if (needsTranslation)
                format = ConvertFormatStringNetToJava(format, kind, out foundDateTimeKind);
            else
                foundDateTimeKind = false;

            return format;
        }

        
        private static string ConvertFormatStringNetToJava(string format, DateTimeKind kind, out bool foundDateTimeKind)
        {
            StringBuilder b = new StringBuilder(format.Length + 8);
            
            bool localFoundDateTimeKind = false;
            bool isInQuote = false;

            TokenizeFormatString(format, (token, isQuote) =>
            {
                if (isQuote)
                {
                    if (!isInQuote)
                    {
                        b.Append('\'');
                        isInQuote = true;
                    }

                    b.Append(token);
                    
                    return;
                }

                string conv = null;
                if (token == "K")
                {
                    localFoundDateTimeKind = true;
                    if (kind == DateTimeKind.Utc)
                    {
                        token = "Z";
                    }
                    else if (kind == DateTimeKind.Local)
                    {
                        // best we can do, even though not 100% accurate.
                        conv = "Z";
                    }
                }
                else
                {
                    conv = Conversion.Get(token);
                }

                if (conv != null)
                {
                    if (isInQuote)
                    {
                        isInQuote = false;
                        b.Append('\'');
                    }
                    b.Append(conv);
                }
                else
                {
                    if (!isInQuote)
                    {
                        b.Append('\'');
                        isInQuote = true;
                    }
                    b.Append(token);
                }
            });

            if(isInQuote)
                b.Append('\'');

            format = b.ToString();
            foundDateTimeKind = localFoundDateTimeKind;
            return format;
        }

        /// <summary>
        /// Will call 'token' for every found token/specifier. 
        /// First argument is the substring, second argument is true if this is a literal.
        /// </summary>
        public static void TokenizeFormatString(string format, Action<string, bool> token)
        {
            if (string.IsNullOrEmpty(format))
                return;

            bool isQuote = false;
            int  idx     = 0;
            int  idxStart = 0;
            char currentChar = '\0';

            for (; idx < format.Length; ++idx)
            {
                char c = format[idx];

                if (idx != idxStart)
                {
                    bool needsFlush = (!isQuote && (c != currentChar || c == '%')) || c == '\'' || c == '\\' ;

                    if (needsFlush)
                    {
                        string s = format.Substring(idxStart, idx - idxStart);
                        token(s, isQuote);
                        idxStart = idx;
                    }
                }

                if (c == '\'')
                {
                    isQuote = !isQuote;
                    idxStart = idx + 1;
                    continue;
                }

                if (c == '\\')
                {
                    if(idx == format.Length - 1)
                        throw new FormatException();
                    token(format.Substring(idx + 1, 1), true);
                    idx += 1;
                    idxStart = idx + 1;
                    continue;
                }

                if (!isQuote && c == '%')
                {
                    if (idx == format.Length - 1)
                        throw new FormatException();
                    string s = format.Substring(idx + 1, 1);
                    token(s, false);

                    idx += 1;
                    idxStart = idx + 1;
                    continue;
                }

                currentChar = c;
            }

            if(isQuote)
                throw new FormatException();

            if (idxStart != idx)
            {
                string s = format.Substring(idxStart, idx - idxStart);
                token(s, false);
            }
        }

        public static string GetStandardPattern(char format, DateTimeFormatInfo dfi, bool forDateTimeOffset, out bool useutc, out bool use_invariant, out bool needsTranslation)
        {
            String pattern;

            useutc = false;
            use_invariant = false;
            needsTranslation = true;

            switch (format)
            {
                case 'd':
                    if(dfi.ShortDatePattern != null)
                        pattern = dfi.ShortDatePattern;
                    else
                    {
                        pattern = dfi.GetJavaPattern(DateFormat.SHORT, -1);
                        needsTranslation = false;
                    }
                    break;
                case 'D':
                    if (dfi.LongDatePattern != null)
                        pattern = dfi.LongDatePattern;
                    else
                    {
                        pattern = dfi.GetJavaPattern(DateFormat.FULL, -1);
                        needsTranslation = false;
                    }
                    break;
                case 'f':
                    if (dfi.LongDatePattern != null && dfi.ShortTimePattern != null)
                        pattern = dfi.LongDatePattern + " " + dfi.ShortTimePattern;
                    else
                    {
                        pattern = dfi.GetJavaPattern(DateFormat.FULL, DateFormat.SHORT);
                        needsTranslation = false;
                    }
                    break;
                case 'F':
                    if (dfi.FullDateTimePattern != null)
                        pattern = dfi.FullDateTimePattern;
                    else
                    {
                        pattern = dfi.GetJavaPattern(DateFormat.FULL, DateFormat.MEDIUM);
                        needsTranslation = false;
                    }
                    break;
                case 'g':
                    if (dfi.ShortDatePattern != null && dfi.ShortTimePattern != null)
                        pattern = dfi.ShortDatePattern + " " + dfi.ShortTimePattern;
                    else
                    {
                        pattern = dfi.GetJavaPattern(DateFormat.SHORT, DateFormat.SHORT);
                        needsTranslation = false;
                        
                    }
                    break;
                case 'G':
                    if (dfi.ShortDatePattern != null && dfi.LongTimePattern != null)
                        pattern = dfi.ShortDatePattern + " " + dfi.LongTimePattern;
                    else
                    {
                        pattern = dfi.GetJavaPattern(DateFormat.SHORT, DateFormat.MEDIUM);
                        needsTranslation = false;
                        
                    }
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
                    if (forDateTimeOffset)
                        useutc = true;
                    use_invariant = true;
                    break;
                case 's':
                    pattern = dfi.SortableDateTimePattern;
                    use_invariant = true;
                    break;
                case 't':
                    if (dfi.ShortTimePattern != null)
                        pattern = dfi.ShortTimePattern;
                    else
                    {
                        pattern = dfi.GetJavaPattern(-1, DateFormat.SHORT);
                        needsTranslation = false;
                    }
                    break;
                case 'T':
                    if (dfi.LongTimePattern != null)
                        pattern = dfi.LongTimePattern;
                    else
                    {
                        pattern = dfi.GetJavaPattern(-1, DateFormat.MEDIUM);
                        needsTranslation = false;
                    }
                    break;
                case 'u':
                    pattern = dfi.UniversalSortableDateTimePattern;
                    if (forDateTimeOffset)
                        useutc = true;
                    use_invariant = true;
                    break;
                case 'U':
                    if (forDateTimeOffset)
                        pattern = null;
                    else
                    {
                        if (dfi.FullDateTimePattern != null)
                            pattern = dfi.FullDateTimePattern;
                        else
                        {
                            pattern = dfi.GetJavaPattern(DateFormat.FULL, DateFormat.MEDIUM);
                            needsTranslation = false;
                        }
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
