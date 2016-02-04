using System;
using JetBrains.Annotations;

namespace Android.Util
{
    public partial class Log
    {
        private const string Null = @"(null)";

        [StringFormatMethod("format")]
        public static void Verbose(string tag, string format, params object[] args)
        {
            V(tag, Format(format, args));
        }

        public static void Verbose(string tag, object obj)
        {
            V(tag, (obj ?? Null).ToString());
        }

        [StringFormatMethod("format")]
        public static void Debug(string tag, string format, params object[] args)
        {
            D(tag, Format(format, args));
        }

        public static void Debug(string tag, object obj)
        {
            D(tag, (obj ?? Null).ToString());
        }

        [StringFormatMethod("format")]
        public static void Info(string tag, string format, params object[] args)
        {
            I(tag, Format(format, args));
        }

        public static void Info(string tag, object obj)
        {
            I(tag, (obj??Null).ToString());
        }

        [StringFormatMethod("format")]
        public static void Warn(string tag, string format, params object[] args)
        {
            W(tag, Format(format, args));
        }

        public static void Warn(string tag, object obj)
        {
            W(tag, (obj ?? Null).ToString());
        }

        [StringFormatMethod("format")]
        public static void Error(string tag, string format, params object[] args)
        {
            E(tag, Format(format, args));
        }

        public static void Error(string tag, object obj)
        {
            E(tag, (obj ?? Null).ToString());
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

    public static class LogPriority
    {
        public const int Verbose = Log.VERBOSE;
        public const int Debug   = Log.DEBUG;
        public const int Info    = Log.INFO;
        public const int Warn    = Log.WARN;
        public const int Error   = Log.ERROR;
        public const int Assert  = Log.ASSERT;
    }
}
