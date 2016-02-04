using System;

namespace Dot42.Internal
{
    partial class CompilerHelper
    {
        [Include(TypeCondition = typeof(System.Enum))]
        public static string EnumToString(Java.Lang.Enum<object> e, string format)
        {
            if (string.IsNullOrEmpty(format)
                || format == "G" || format == "g"
                || format == "f" || format == "F")
                return e.ToString();
            
            var internalEnum = ((object)e) as Enum;

            long val = internalEnum == null ? (long)e.Ordinal() : internalEnum.LongValue();

            if (format == "X")
                return val.ToString("X8");
            if (format == "x")
                return val.ToString("x8");
            if (format == "d" || format == "D")
                return val.ToString();

            throw new ArgumentException("invalid format specifier: " + format);
        }
    }
}
