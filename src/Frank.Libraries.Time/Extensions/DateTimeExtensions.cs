using System;

// ReSharper disable once CheckNamespace
namespace Frank.Libraries
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Converts a DateTime to a WeekTime
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static WeekTime ToWeekTime(this DateTime dateTime) => new WeekTime(dateTime);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dayOfWeek"></param>
        /// <returns></returns>
        public static int ToInt(this DayOfWeek dayOfWeek) =>
            dayOfWeek switch
            {
                DayOfWeek.Monday => 1,
                DayOfWeek.Tuesday => 2,
                DayOfWeek.Wednesday => 3,
                DayOfWeek.Thursday => 4,
                DayOfWeek.Friday => 5,
                DayOfWeek.Saturday => 6,
                DayOfWeek.Sunday => 7,
                _ => throw new ArgumentOutOfRangeException(nameof(dayOfWeek), dayOfWeek, null)
            };
    }
}
