namespace System
{
    /// <summary>
    /// this is a minimal implementation atm.
    /// </summary>
    public class TimeZoneInfo
    {
        public static TimeZoneInfo Local = new TimeZoneInfo(Java.Util.TimeZone.Default);

        private readonly Java.Util.TimeZone _timeZone;

        internal TimeZoneInfo(Java.Util.TimeZone timeZone)
        {
            _timeZone = timeZone;
        }

        public TimeSpan GetUtcOffset(DateTime d)
        {
            return GetUtcOffset(d.Ticks);
        }

        internal TimeSpan GetUtcOffset(long ticks)
        {
            var millis = (ticks / TimeSpan.TicksPerMillisecond) - DateTime.EraDifferenceInMs;
            var offsetInMs = _timeZone.GetOffset(millis);
            return new TimeSpan(offsetInMs * TimeSpan.TicksPerMillisecond);
        }

        public TimeSpan BaseUtcOffset
        {
            get
            {
                var offsetInMs = Java.Util.TimeZone.Default.RawOffset;
                return new TimeSpan(offsetInMs * TimeSpan.TicksPerMillisecond);
            }
        }

        internal static TimeSpan GetLocalUtcOffset(DateTime dateTime)
        {
            return Local.GetUtcOffset(dateTime);
        }
    }
}
