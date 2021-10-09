using System.Text;
using NodaTime;

namespace Frank.Libraries.Time
{
    public abstract class TimeBaseService
    {
        protected TimeBaseService(IClock clock)
        {
            Clock = clock;
        }

        protected IClock Clock { get; }

        protected virtual int GetDayOfYear() => Clock.GetCurrentInstant().ToDateTimeUtc().DayOfYear;
        protected int GetDayOfMonth() => Clock.GetCurrentInstant().ToDateTimeUtc().Day;
        protected string NowAsIsoString() => Clock.GetCurrentInstant().ToDateTimeOffset().ToString("O");
        protected string NowAsDateString() => Clock.GetCurrentInstant().ToDateTimeUtc().ToString("yyyy-MM-dd");

        /// <example>2021-97 for 2021-04-08</example>
        public string NowAsYearDayString() => $"{Clock.GetCurrentInstant().ToDateTimeUtc().Year}-{Clock.GetCurrentInstant().ToDateTimeUtc().DayOfYear}";

        protected static string GetDateTimeString(ZonedDateTime time) =>
            new StringBuilder()
                .Append(time.Year.ToString("0000"))
                .Append('-')
                .Append(time.Month.ToString("00"))
                .Append('-')
                .Append(time.Day.ToString("00"))
                .Append('T')
                .Append(time.Hour.ToString("00"))
                .Append(':')
                .Append(time.Minute.ToString("00"))
                .Append(':')
                .Append(time.Second.ToString("00"))
                .Append(':')
                .Append(time.Millisecond.ToString("000"))
                .ToString();

        protected static string GetDateTimeWithOffsetString(ZonedDateTime time) =>
            new StringBuilder().Append(GetDateTimeString(time)).Append($" ({DateTimeZoneProviders.Tzdb.GetZoneOrNull(time.Zone.Id)})").ToString();

        protected string GetTimeString() => GetTimeString(Clock.GetCurrentInstant().InUtc());

        protected static string GetTimeString(ZonedDateTime time) =>
            new StringBuilder()
                .Append(time.Hour.ToString("00"))
                .Append(':')
                .Append(time.Minute.ToString("00"))
                .Append(':')
                .Append(time.Second.ToString("00"))
                .Append(':')
                .Append(time.Millisecond.ToString("000"))
                .ToString();

        protected static string GetTimeWithOffsetString(ZonedDateTime time) =>
            new StringBuilder().Append(GetTimeString(time)).Append($" ({DateTimeZoneProviders.Tzdb.GetZoneOrNull(time.Zone.Id)})").ToString();
    }
}