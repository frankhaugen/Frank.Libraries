using System;
using NodaTime;

namespace Frank.Libraries.Time
{
    public class DateService : TimeBaseService
    {
        public DateService(IClock clock) : base(clock)
        {
        }

        public DateTime GetDate() => Clock.GetCurrentInstant().ToDateTimeUtc().Date;
        public int GetMonth() => Clock.GetCurrentInstant().ToDateTimeUtc().Month;
        public int GetYear() => Clock.GetCurrentInstant().ToDateTimeUtc().Year;
    }
}