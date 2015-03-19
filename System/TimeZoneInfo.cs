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
            var offsetInMs = Java.Util.TimeZone.GetDefault().GetRawOffset();
            return new TimeSpan(offsetInMs*TimeSpan.TicksPerMillisecond);
        }
    }
}
