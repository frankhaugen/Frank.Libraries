using System;
using System.Globalization;

// ReSharper disable once CheckNamespace
namespace Frank.Libraries
{
    public static class WeekTimeExtensions
    {
        /// <summary>
        /// Converts a WeekTime to DateTime
        /// </summary>
        /// <param name="weekTime"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this WeekTime weekTime)
        {
            var dayOfYear = weekTime.ToDayOfYear();
            var dateTime = new DateTime(weekTime.Year, 1, 1, weekTime.Hour - 1, weekTime.Minute - 1, weekTime.Second - 1, weekTime.Millisecond, DateTimeKind.Utc);
            dateTime = dateTime.AddDays(dayOfYear - 1);
            return dateTime;
        }

        /// <summary>
        /// Get day of the year from weekTime
        /// </summary>
        /// <param name="weekTime"></param>
        /// <returns></returns>
        public static int ToDayOfYear(this WeekTime weekTime)
        {
            var jan1 = new DateTime(weekTime.Year, 1, 1).ToUniversalTime();
            var daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            var firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            var firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekTime.Week;
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }

            var dateTime = firstThursday
                .AddDays(weekNum * 7)
                .AddDays(-3)
                .AddDays(weekTime.Day - 1);

            return dateTime.DayOfYear;
        }
    }
}
