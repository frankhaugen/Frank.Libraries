using System;
using NodaTime;

namespace Frank.Libraries.Time
{
    public class TimeService : TimeBaseService
    {
        public TimeService(IClock clock) : base(clock)
        {
        }

        public Instant Instant() => Clock.GetCurrentInstant();
        public DateTime DateTime() => Clock.GetCurrentInstant().ToDateTimeUtc();
        public DateTimeOffset DateTimeOffset() => Clock.GetCurrentInstant().ToDateTimeOffset();
        public TimeSpan TimeOfDay() => Clock.GetCurrentInstant().ToDateTimeUtc().TimeOfDay;
        public ZonedDateTime ZonedDateTime() => Clock.GetCurrentInstant().InUtc();
        public long UnixTime() => Clock.GetCurrentInstant().ToUnixTimeMilliseconds();

        public override string ToString() => GetTimeString();
    }
}