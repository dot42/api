using System;
using System.Globalization;
using Java.Text;
using Java.Util;
using TimeZone = Java.Util.TimeZone;

namespace Dot42.Internal
{
    internal static class DateTimeParsing
    {
        /// <summary>
        /// Convert from java based date to DateTime.
        /// </summary>
        private static DateTime FromParsedDate(Date value, string originalString, DateTimeStyles style, DateFormat formatter, bool forceRoundtripKind, bool useUtc)
        {
            bool assumeLocal = (style & DateTimeStyles.AssumeLocal) != 0;
            bool assumeUtc = useUtc || (style & DateTimeStyles.AssumeUniversal) != 0;
            bool roundtripKind = forceRoundtripKind || (style & DateTimeStyles.RoundtripKind) != 0;

            var millis = value.Time;
            var ticks = (millis + DateTime.EraDifferenceInMs) * TimeSpan.TicksPerMillisecond;

            //long offset = 0L;
            DateTimeKind kind;

            if (roundtripKind)
            {
                var tz = formatter.TimeZone;
                if(tz.RawOffset == 0 || originalString.EndsWith("Z"))
                    kind = DateTimeKind.Utc;
                else if(tz.RawOffset == TimeZone.Default.RawOffset)
                    kind = DateTimeKind.Local;
                else
                    kind = DateTimeKind.Unspecified;
            }
            else if (assumeUtc)
            {
                kind = DateTimeKind.Utc;
            }
            else if (assumeLocal)
            {
                kind = DateTimeKind.Local;
            }
            else
            {
                kind = DateTimeKind.Unspecified;
            }

            DateTime result;

            if (millis == DateTime.MinValueJavaMillies)
                result = new DateTime(0L, kind);
            else
            {
                result = new DateTime(ticks, kind);
            }


            if ((style & DateTimeStyles.AdjustToUniversal) != 0)
                result = result.ToUniversalTime();
            else if (assumeUtc) // no typo, but bad naming/semantics in the BCL
                result = result.ToLocalTime();

            return result;
        }

        public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
        {
            // Note: the Date/Time handling in java is just broken, and putting a 
            //       .NET compatibility layer on top of it will probalby not fix much
            if (s == null || format == null)
                throw new ArgumentNullException();

            if ((style & DateTimeStyles.AllowLeadingWhite) != 0)
                s = s.TrimStart();
            if ((style & DateTimeStyles.AllowTrailingWhite) != 0)
                s = s.TrimEnd();
            if ((style & DateTimeStyles.AllowWhiteSpaces) != 0)
                s = s.Trim();

            try
            {
                var formatter = DateFormatFactory.GetFormat(format, DateTimeKind.Unspecified, provider);
                formatter.Format.TimeZone = TimeZone.GetTimeZone("UTC"); // reset mutable value

                Date parsed = formatter.Format.Parse(s);

                var result = FromParsedDate(parsed, s, style, formatter.Format, formatter.ContainsK, formatter.UseUtc);
                return result;
            }
            catch (ArgumentException ex)
            {
                throw new FormatException(ex.Message);
            }
            catch (ParseException ex)
            {
                throw new ArgumentException(ex.Message, "s");
            }
        }

        public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles style)
        {
            if (s == null)
                throw new ArgumentNullException("s");

            s = s.Trim();

            // try all .NET date time formats
            // Note: the Date/Time handling in java is just broken, and putting a 
            //       .NET compatibility layer on top of it will probalby not fix much
            var ci = provider.ToCultureInfo();

            string[] formats = 
            {
                ci.DateTimeFormat.UniversalSortableDateTimePattern,
                ci.DateTimeFormat.SortableDateTimePattern,
                ci.DateTimeFormat.FullDateTimePattern,
                ci.DateTimeFormat.RFC1123Pattern,
                ci.DateTimeFormat.LongDatePattern,
                ci.DateTimeFormat.LongTimePattern,
                ci.DateTimeFormat.ShortDatePattern,
                ci.DateTimeFormat.ShortTimePattern
            };

            var utc = TimeZone.GetTimeZone("UTC");

            // Note: I'm not sure this whole approach is the best anyway. Exception handling
            //       for control flow, a loop to tests all formats and such.
            //       It would probably better to use jodatime or nodatime. Maybe the parsing
            //       routine can be ripped off nodatime, so we don't have to include the whole
            //       library.

            foreach (var pattern in formats)
            {
                try
                {
                    var formatter = DateFormatFactory.GetFormat(pattern, DateTimeKind.Unspecified, provider);
                    formatter.Format.TimeZone = utc; // reset mutable value

                    Date parsed = formatter.Format.Parse(s);
                    var result = FromParsedDate(parsed, s, style, formatter.Format, formatter.ContainsK, formatter.UseUtc);
                    return result;
                }
                catch (ParseException)
                {
                }
            }
            throw new ArgumentException("unable to parse " + s);
        }
    }
}
