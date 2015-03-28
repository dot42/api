namespace System
{
    /// <summary>
    /// this is a minimal implementation atm.
    /// </summary>
    public class TimeZoneInfo
    {
        public static TimeZoneInfo Local = new TimeZoneInfo();

        public TimeSpan GetUtcOffset(DateTime d)
        {
            return GetUtcOffset(d.Ticks);
        }

        internal TimeSpan GetUtcOffset(long ticks)
        {
            var millis = (ticks / TimeSpan.TicksPerMillisecond) - DateTime.EraDifferenceInMs;
            var offsetInMs = Java.Util.TimeZone.GetDefault().GetOffset(millis);
            return new TimeSpan(offsetInMs * TimeSpan.TicksPerMillisecond);
        }

        public TimeSpan BaseUtcOffset
        {
            get
            {
                var offsetInMs = Java.Util.TimeZone.GetDefault().GetRawOffset();
                return new TimeSpan(offsetInMs * TimeSpan.TicksPerMillisecond);
            }
        }
    }
}
