using System;
using System.Globalization;
using NodaTime;

namespace Frank.Libraries.Time
{
    public class WeekService : TimeBaseService
    {
        public WeekService(IClock clock) : base(clock)
        {
        }

        public int GetIsoWeek() => ISOWeek.GetWeekOfYear(Clock.GetCurrentInstant().ToDateTimeUtc());
        public int GetIsoWeek(DateTime dateTime) => ISOWeek.GetWeekOfYear(dateTime);

        public int GetIsoWeeksInYear(DateTime dateTime) => ISOWeek.GetWeeksInYear(dateTime.Year);
        public int GetIsoWeeksInYear() => ISOWeek.GetWeeksInYear(Clock.GetCurrentInstant().ToDateTimeUtc().Year);

        public int GetWeek(CalendarWeekRule weekRule = CalendarWeekRule.FirstFourDayWeek, DayOfWeek firstDayOfWeek = DayOfWeek.Monday) => new GregorianCalendar(GregorianCalendarTypes.TransliteratedEnglish).GetWeekOfYear(Clock.GetCurrentInstant().ToDateTimeUtc(), weekRule, firstDayOfWeek);
        public int ToWeek(Instant instant, CalendarWeekRule weekRule = CalendarWeekRule.FirstFourDayWeek, DayOfWeek firstDayOfWeek = DayOfWeek.Monday) => new GregorianCalendar(GregorianCalendarTypes.TransliteratedEnglish).GetWeekOfYear(instant.ToDateTimeUtc(), weekRule, firstDayOfWeek);
        public int ToWeek(DateTime dateTime, CalendarWeekRule weekRule = CalendarWeekRule.FirstFourDayWeek, DayOfWeek firstDayOfWeek = DayOfWeek.Monday) => ToWeek(Instant.FromDateTimeUtc(dateTime), weekRule, firstDayOfWeek);

        public DayOfWeek GetDayOfWeek() => Clock.GetCurrentInstant().ToDateTimeUtc().DayOfWeek;

        /// <summary>
        /// The day of week starts on monday
        /// </summary>
        /// <example>2021-14-4 for 2021-04-08</example>
        public string NowAsYearWeekDayString() => $"{Clock.GetCurrentInstant().ToDateTimeUtc().Year}-{GetWeek()}-{(int)GetDayOfWeek() + 1}";
    }
}