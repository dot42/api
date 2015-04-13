using System;
using JetBrains.Annotations;

namespace Android.Util
{
    public partial class Log
    {
        [StringFormatMethod("format")]
        public static void Verbose(string tag, string format, object[] args)
        {
            V(tag, Format(format, args));
        }

        public static void Verbose(string tag, string format)
        {
            V(tag, format);
        }

        [StringFormatMethod("format")]
        public static void Debug(string tag, string format, object[] args)
        {
            D(tag, Format(format, args));
        }

        public static void Debug(string tag, string format)
        {
            D(tag, format);
        }

        [StringFormatMethod("format")]
        public static void Info(string tag, string format, object[] args)
        {
            I(tag, Format(format, args));
        }

        public static void Info(string tag, string format)
        {
            I(tag, format);
        }

        [StringFormatMethod("format")]
        public static void Warn(string tag, string format, object[] args)
        {
            W(tag, Format(format, args));
        }

        public static void Warn(string tag, string format)
        {
            W(tag, format);
        }

        [StringFormatMethod("format")]
        public static void Error(string tag, string format, object[] args)
        {
            E(tag, Format(format, args));
        }

        public static void Error(string tag, string format)
        {
            E(tag, format);
        }

        // ignore formatting errors; this is logging!
        private static string Format(string format, object[] args)
        {
            if (args.Length == 0) return format;
            try
            {
                return string.Format(format, args);
            }
            catch (Exception)
            {
                return format;
            }
        }
    }

    public class LogPriority
    {
        public const int Verbose = Log.VERBOSE;
        public const int Debug   = Log.DEBUG;
        public const int Info    = Log.INFO;
        public const int Warn    = Log.WARN;
        public const int Error   = Log.ERROR;
        public const int Assert  = Log.ASSERT;
    }
}
