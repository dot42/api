using System;
using System.Globalization;
using System.Threading;
using Android.Util;
using Java.Text;
using Java.Util;
using TimeZone = Java.Util.TimeZone;

namespace Dot42.Internal
{
    internal class DateFormatFactory
    {
        private const int CacheSize = 20;

        private static readonly DateFormatCache Cache = new DateFormatCache();

        public static DateFormatResult GetFormat(string format, DateTimeKind kind, IFormatProvider formatProvider)
        {
            var key = new Key(Thread.CurrentThread.Id, format, kind, formatProvider);

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
            bool useInvariant, foundK;
            var javaFormat = DateTimeFormatting.ToJavaFormatString(format, provider, DateTimeKind.Unspecified, out useInvariant, out foundK);
            
            Java.Util.Locale locale = useInvariant ? CultureInfo.InvariantCulture.Locale : provider.ToLocale();

            DateFormat formatter = new SimpleDateFormat(javaFormat, locale);

            return new DateFormatResult(formatter, foundK);
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
            public readonly DateFormat Format;
            public readonly bool ContainsK;

            public DateFormatResult(DateFormat format, bool foundK)
            {
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
