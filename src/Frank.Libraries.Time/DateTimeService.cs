using System;
using System.Globalization;
using NodaTime;

namespace Frank.Libraries.Time
{
    public class DateTimeService
    {
        private readonly IClock _clock;

        public DateTimeService(IClock clock)
        {
            _clock = clock;
        }

        public int Year => _clock.GetCurrentInstant()
                                 .InUtc()
                                 .Year;

        public int Month => _clock.GetCurrentInstant()
                                  .InUtc()
                                  .Month;

        public int Day => _clock.GetCurrentInstant()
                                .InUtc()
                                .Day;

        public int Hours => _clock.GetCurrentInstant()
                                  .InUtc()
                                  .Hour;

        public int Minutes => _clock.GetCurrentInstant()
                                    .InUtc()
                                    .Minute;

        public int Seconds => _clock.GetCurrentInstant()
                                    .InUtc()
                                    .Second;

        public int Milliseconds => _clock.GetCurrentInstant()
                                         .InUtc()
                                         .Millisecond;

        public long UnixTime => _clock.GetCurrentInstant()
                                      .ToUnixTimeMilliseconds();

        public int Week => ISOWeek.GetWeekOfYear(_clock.GetCurrentInstant()
                                                       .ToDateTimeUtc());

        public int DayOfWeek => (int)_clock.GetCurrentInstant()
                                           .InUtc()
                                           .DayOfWeek;

        public Instant Instant() => _clock.GetCurrentInstant();

        public DateTime DateTime() => _clock.GetCurrentInstant()
                                            .ToDateTimeUtc();

        public DateTimeOffset DateTimeOffset() => _clock.GetCurrentInstant()
                                                        .ToDateTimeOffset();

        public TimeSpan TimeOfDay() => _clock.GetCurrentInstant()
                                             .ToDateTimeUtc()
                                             .TimeOfDay;

        public ZonedDateTime ZonedDateTime(string ianaTimezone) => _clock.GetCurrentInstant()
                                                                         .InZone(DateTimeZoneProviders.Tzdb[ianaTimezone]);

        public ZonedDateTime UtcDateTime() => _clock.GetCurrentInstant()
                                                    .InUtc();

        public override string ToString() => $"{Year:0000}-{Month:00}-{Day:00} {Hours:00}:{Minutes:00}:{Seconds:00}.{Milliseconds:000}";
    }
}