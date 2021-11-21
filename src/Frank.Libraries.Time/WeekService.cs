using System.Globalization;
using NodaTime;

namespace Frank.Libraries.Time
{
    public class WeekService
    {
        private readonly IClock _clock;

        public WeekService(IClock clock)
        {
            _clock = clock;
        }

        public int Year => _clock.GetCurrentInstant()
                                 .InUtc()
                                 .Year;

        public int Week => ISOWeek.GetWeekOfYear(_clock.GetCurrentInstant()
                                                       .ToDateTimeUtc());

        public int Day => (int)_clock.GetCurrentInstant()
                                     .InUtc()
                                     .DayOfWeek;

        /// <summary>
        /// The day of week starts on monday
        /// </summary>
        /// <example>2021-14-4 for 2021-04-08</example>
        public override string ToString() => $"{Year:0000}-{Week:00}-{Day}";
    }
}