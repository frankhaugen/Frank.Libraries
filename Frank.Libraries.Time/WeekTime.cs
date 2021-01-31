using System;
using System.Globalization;

// ReSharper disable once CheckNamespace
namespace Frank.Libraries
{
    /// <summary>
    /// An instant of time to millisecond precision
    /// </summary>
    public readonly struct WeekTime
    {
        /// <summary>
        /// The year
        /// </summary>
        public readonly int Year;

        /// <summary>
        /// The week of the year
        /// </summary>
        public readonly int Week;

        /// <summary>
        /// The day of the week
        /// </summary>
        public readonly int Day;

        /// <summary>
        /// The hour of the 24-hour day 
        /// </summary>
        public readonly int Hour;

        /// <summary>
        /// The minute of the hour
        /// </summary>
        public readonly int Minute;

        /// <summary>
        /// The second of the minute
        /// </summary>
        public readonly int Second;

        /// <summary>
        /// The millisecond of the second
        /// </summary>
        public readonly int Millisecond;

        /// <inheritdoc cref="WeekTime" />
        public static readonly WeekTime Now = new WeekTime(DateTime.UtcNow);

        /// <inheritdoc cref="WeekTime" />
        public WeekTime(DateTime dateTime)
        {
            var calendar = new GregorianCalendar(GregorianCalendarTypes.TransliteratedEnglish);

            Year = dateTime.Year;
            Week = calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            Day = dateTime.DayOfWeek.ToInt();
            Hour = dateTime.Hour + 1;
            Minute = dateTime.Minute + 1;
            Second = dateTime.Second + 1;
            Millisecond = dateTime.Millisecond;
        }

        /// <summary>
        /// Get the instant in a friendly string
        /// </summary>
        /// <returns>YYYY-WW-DD HH:MM:SS:FFF</returns>
        public override string ToString() => $"{Year:0000}-{Week:00}-{Day} {Hour:00}:{Minute:00}:{Second:00}:{Millisecond:000}";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool Equals(object? obj)
        {
            // TODO: Create cases for types like datetime
            return GetHashCode() == obj?.GetHashCode();
        }

        /// <summary>
        /// Creates a <see cref="HashCode"/>
        /// </summary>
        /// <returns><see cref="HashCode"/>.Combine() of: Year, Week, Day, Hour, Minute, Second, Millisecond</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Year, Week, Day, Hour, Minute, Second, Millisecond);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(WeekTime left, WeekTime right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(WeekTime left, WeekTime right)
        {
            return !(left == right);
        }
    }
}
