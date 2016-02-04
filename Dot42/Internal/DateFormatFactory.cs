using System;
using System.Globalization;
using System.Threading;
using Android.Util;
using Java.Text;
using Java.Util;

namespace Dot42.Internal
{
    internal class DateFormatFactory
    {
        private const int CacheSize = 20;

        private static readonly DateFormatCache Cache = new DateFormatCache();

        public static DateFormatResult GetFormat(string format, DateTimeKind kind, IFormatProvider formatProvider)
        {
            var key = new Key(Thread.CurrentThread.Id, format ?? "G", kind, formatProvider);

#if !ANDROID_12P
            lock (Cache)
#endif
            {
                var f = Cache.Get(key);
                if (f == null)
                {
                    Cache.Put(key, f = CreateFormat(format, formatProvider));
                }
                return f;
            }
        }

        private static DateFormatResult CreateFormat(string format, IFormatProvider provider)
        {
            if (format == null || format.Length == 1)
            {
                var ret = GetStandardFormat(format == null ? 'G' : format[0], provider);
                if (ret != null)
                    return ret;
            }

            bool useInvariant, foundK, useUtc;
            string javaFormat = DateTimeFormatting.ToJavaFormatString(format, provider, DateTimeKind.Unspecified, false, out useInvariant, out foundK, out useUtc);
            
            Java.Util.Locale locale = useInvariant ? CultureInfo.InvariantCulture.Locale : provider.ToLocale();

            DateFormat formatter = new SimpleDateFormat(javaFormat, locale);
            return new DateFormatResult(formatter, foundK, useUtc);
        }

        private static DateFormatResult GetStandardFormat(char c, IFormatProvider provider)
        {
            DateTimeFormatInfo dtfi = null;

            if (provider != null)
                dtfi = (DateTimeFormatInfo)provider.GetFormat(typeof(DateTimeFormatInfo));

            if (dtfi == null)
                dtfi = DateTimeFormatInfo.CurrentInfo;

            DateFormat df = null;
            bool useUtc = false;

            switch (c)
            {
                case 'd':
                    df = dtfi.CreateDateFormat(DateFormat.SHORT, -1);
                    break;
                case 'D':
                    df = dtfi.CreateDateFormat(DateFormat.LONG, -1);
                    break;
                case 'f':
                    df = dtfi.CreateDateFormat(DateFormat.LONG, DateFormat.SHORT);
                    break;
                case 'F':
                    df = dtfi.CreateDateFormat(DateFormat.LONG, DateFormat.LONG);
                    break;
                case 'g':
                    df = dtfi.CreateDateFormat(DateFormat.SHORT, DateFormat.SHORT);
                    break;
                case 'G':
                    df = dtfi.CreateDateFormat(DateFormat.SHORT, DateFormat.LONG);
                    break;
                case 't':
                    df = dtfi.CreateDateFormat(-1, DateFormat.SHORT);
                    break;
                case 'T':
                    df = dtfi.CreateDateFormat(-1, DateFormat.LONG);
                    break;
                case 'U':
                    df = dtfi.CreateDateFormat(DateFormat.LONG, DateFormat.LONG);
                    useUtc = true;
                    break;
            }

            if(df != null)
                return new DateFormatResult(df, false, useUtc);
            return null;
        }


        static DateFormatFactory()
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

        public sealed class Key
        {
            public readonly long ThreadId;
            public readonly string FormatString;
            public readonly DateTimeKind Kind;
            public readonly IFormatProvider FormatProvider;

            public Key(long threadId, string formatString, DateTimeKind kind, IFormatProvider formatProvider)
            {
                FormatProvider = formatProvider;
                FormatString = formatString;
                Kind = kind;
                ThreadId = threadId;
            }

            protected bool Equals(Key other)
            {
                return ThreadId == other.ThreadId 
                    && Kind == other.Kind 
                    && FormatString.Equals(other.FormatString) 
                    && Equals(FormatProvider, other.FormatProvider);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((Key) obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    var hashCode = ((int) (ThreadId & 0xFFFFFFFF) | (int) (ThreadId >> 32));
                    hashCode = (hashCode*397) ^ FormatString.GetHashCode();
                    hashCode = (hashCode * 397) ^ (int)Kind;
                    hashCode = (hashCode*397) ^ (FormatProvider != null ? FormatProvider.GetHashCode() : 0);
                    return hashCode;
                }
            }
        }

        public class DateFormatResult
        {
            public readonly bool UseUtc;
            public readonly DateFormat Format;
            public readonly bool ContainsK;

            public DateFormatResult(DateFormat format, bool foundK, bool useUtc)
            {
                UseUtc = useUtc;
                Format = format;
                ContainsK = foundK;
            }
        }

        private class DateFormatCache : LruCache<Key, DateFormatResult>
        {
            public DateFormatCache()
                : base(CacheSize)
            {
            }
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
