using System;
using System.Globalization;
using System.Threading;
using Android.Util;
using Java.Lang;
using Java.Text;
using Java.Util;

namespace Dot42.Internal
{
    public static class NumberFormatFactory
    {
        private const int CacheSize = 40; // TODO: maybe this should scale with the number of threads.

        private static readonly NumberFormatCache Cache = new NumberFormatCache();

        private const int FormatNormal     = 0;
        private const int FormatDecimal    = 1;
        private const int FormatHex        = 2;
        private const int FormatScientific = 3;
        private const int FormatCurrency   = 4;

        public static NumberFormat GetFormat(string javaPattern, IFormatProvider formatProvider)
        {
            var entry = new Entry(Thread.CurrentThread.Id, FormatNormal, formatProvider, javaPattern, 0, false);
            return GetOrCreate(entry);
        }

        public static NumberFormat GetFormat(IFormatProvider formatProvider)
        {
            var entry = new Entry(Thread.CurrentThread.Id, FormatNormal, formatProvider, null, 0, false);
            return GetOrCreate(entry);
        }

        public static NumberFormat GetDecimalFormat(string javaPattern, IFormatProvider formatProvider)
        {
            var entry = new Entry(Thread.CurrentThread.Id, FormatDecimal, formatProvider, javaPattern, 0, false);
            return GetOrCreate(entry);
        }

        public static NumberFormat GetHexFormat(int digits, bool isuppercase)
        {
            var entry = new Entry(Thread.CurrentThread.Id, FormatHex, null, null, digits, isuppercase);
            return GetOrCreate(entry);
        }

        public static NumberFormat GetCurrencyFormat(IFormatProvider formatProvider)
        {
            var entry = new Entry(Thread.CurrentThread.Id, FormatCurrency, formatProvider, null, 0, false);
            return GetOrCreate(entry);
        }

        public static NumberFormat GetScientificFormat(string javaPattern, IFormatProvider formatProvider)
        {
            var entry = new Entry(Thread.CurrentThread.Id, FormatScientific, formatProvider, javaPattern, 0, false);
            return GetOrCreate(entry);
        }

        static NumberFormatFactory()
        {
            Application.ReleaseCaches += ClearCache;
            Application.LocaleChanged += ClearCache;
        }

        private static void ClearCache(object sender, EventArgs e)
        {
#if ANDROID_12P
            Cache.EvictAll();
#else
            lock(Cache)
                Cache.Clear();
#endif
        }

        private static NumberFormat GetOrCreate(Entry entry)
        {
#if !ANDROID_12P
            lock (Cache)
#endif
            {
                var f = Cache.Get(entry);
                if (f == null)
                {
                    Cache.Put(entry, f = CreateFormat(entry));
                }
                return f;
            }
        }

        private static NumberFormat CreateFormat(Entry type)
        {
            var locale = type.FormatProvider.ToLocale();

            if(type.FormatType == FormatHex)
                return new HexFormat(type.HexDigits, type.IsUpperCase);

            if(type.FormatType == FormatScientific)
                return new ScientificFormat(type.Pattern, locale);

            if (type.FormatType == FormatDecimal)
            {
                DecimalFormatSymbols symbols = new DecimalFormatSymbols(locale) { Infinity = "Infinity" };
                return new DecimalFormat(type.Pattern, symbols);
            }

            if (type.FormatType == FormatCurrency)
            {
                return NumberFormat.GetCurrencyInstance(locale);
            }
            
            // default
            var format = NumberFormat.GetNumberInstance(locale);
            
            if (type.Pattern != null)
            {
                var decf = format as DecimalFormat;
                if (decf != null)
                {
                    decf.ApplyLocalizedPattern(type.Pattern);
                }
            }

            return format;
        }

        private class HexFormat : NumberFormat
        {
            private readonly int numDigits;
            private readonly bool upperCase;

            public HexFormat(int numDigits, bool upperCase)
            {
                this.numDigits = numDigits;
                this.upperCase = upperCase;
            }

            public override StringBuffer Format(double @double, StringBuffer stringBuffer, FieldPosition fieldPosition)
            {
                return Format((long)@double, stringBuffer, fieldPosition);
            }

            public override StringBuffer Format(long value, StringBuffer stringBuffer, FieldPosition fieldPosition)
            {
                var l_hex = Int64.ToHexString(value);
                if (upperCase)
                    l_hex = l_hex.ToUpper();
                int l_pad = numDigits - l_hex.Length;
                l_pad = (0 < l_pad) ? l_pad : 0;

                var l_extended = new StringBuffer();
                for (int i = 0; i < l_pad; i++)
                {
                    l_extended.Append('0');
                }
                l_extended.Append(l_hex);

                return l_extended;
            }

            public override Number Parse(string @string, ParsePosition position)
            {
                return null;
            }
        }

        private class ScientificFormat : DecimalFormat
        {
            private readonly DecimalFormat _format;

            public ScientificFormat(string format, Java.Util.Locale locale)
            {
                DecimalFormatSymbols symbols = new DecimalFormatSymbols(locale) { Infinity = "Infinity" };
                _format = new DecimalFormat(format, symbols);
            }

            public override StringBuffer Format(double @double, StringBuffer stringBuffer, FieldPosition fieldPosition)
            {
                return CheckForPositiveExponent(_format.Format(@double, stringBuffer, fieldPosition));
            }

            public override StringBuffer Format(long value, StringBuffer stringBuffer, FieldPosition fieldPosition)
            {
                return CheckForPositiveExponent(_format.Format(value, stringBuffer, fieldPosition));
            }

            private StringBuffer CheckForPositiveExponent(StringBuffer number)
            {
                int len = number.Length();
                for (int i = len - 2; i >= 0; --i)
                {
                    var c = number.CharAt(i);
                    if (c == 'e' || c == 'E')
                    {
                        if(number.CharAt(i + 1) == '-')
                            return number;
                        return number.Insert(i + 1, "+");    
                    }
                }
                return number;
            }

            public override Number Parse(string @string)
            {
                return _format.Parse(@string);
            }
        }

        private class Entry
        {
            public readonly long ThreadId;
            public readonly int FormatType;
            public readonly IFormatProvider FormatProvider;
            
            public readonly int HexDigits;
            public readonly bool IsUpperCase;

            public readonly string Pattern;
            public Entry(long threadId, int formatType, IFormatProvider formatProvider, string pattern, int hexDigits, bool isUpperCase)
            {
                FormatType = formatType;
                Pattern = pattern;
                FormatProvider = formatProvider;
                HexDigits = hexDigits;
                IsUpperCase = isUpperCase;
                ThreadId = threadId;
            }

            private bool Equals(Entry other)
            {
                return
                    ThreadId ==other.ThreadId
                    && FormatType == other.FormatType
                    && Equals(FormatProvider, other.FormatProvider) 
                    && Equals(Pattern, other.Pattern)
                    && HexDigits == other.HexDigits 
                    && IsUpperCase == other.IsUpperCase;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((Entry) obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    var hashCode = (Pattern != null ? Pattern.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (FormatProvider != null ? FormatProvider.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ FormatType;
                    hashCode = (hashCode*397) ^ ((int)(ThreadId & 0xFFFFFFFF) | (int)(ThreadId >> 32));
                    hashCode = (hashCode*397) ^ HexDigits;
                    hashCode = (hashCode*397) ^ (IsUpperCase?1:0);
                    return hashCode;
                }
            }
        }

        class NumberFormatCache : LruCache<Entry, NumberFormat>
        {
            public NumberFormatCache()
                : base(CacheSize)
            {
            }

            // Doesn't get called, don't know why
            //protected internal override NumberFormat Create(Entry key)
            //{
            //    return CreateFormat(key);
            //}
        }

#if !ANDROID_12P
        private class LruCache<K, V> : LinkedHashMap<K, V> 
        {
          private int cacheSize;

          public LruCache(int cacheSize) : base(16, 0.75f, true)
          {
            this.cacheSize = cacheSize;
          }

            protected internal override bool RemoveEldestEntry(IMap_IEntry<K, V> eldest)
            {
                return Size() >= cacheSize;
            }
        }
#endif
    }

}

