using System.Collections.Generic;

namespace System
{
    public class StringComparer : IEqualityComparer<string>
    {
        private readonly StringComparison mode;

        public static IEqualityComparer<string> Ordinal = new StringComparer(StringComparison.Ordinal);
        public static IEqualityComparer<string> OrdinalIgnoreCase = new StringComparer(StringComparison.OrdinalIgnoreCase);
        public static IEqualityComparer<string> InvariantCulture = new StringComparer(StringComparison.InvariantCulture);
        public static IEqualityComparer<string> InvariantCultureIgnoreCase = new StringComparer(StringComparison.InvariantCultureIgnoreCase);

        public StringComparer(StringComparison mode)
        {
            this.mode = mode;
        }

        public bool Equals(string x, string y)
        {
            if (x == null || y == null)
                return x == null && y == null;

            return string.Equals(x, y, mode);
        }

        public int GetHashCode(string obj)
        {
            if (obj == null) return 0;
            return obj.GetHashCode();
        }
    }
}
