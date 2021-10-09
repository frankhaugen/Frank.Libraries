
using System;
using System.Globalization;
using CronExpressionDescriptor;
using Cronos;

namespace Frank.Libraries.Time.Utilities
{
    public static class CronUtilities
    {
        /// <summary>
        /// Checks if the expression results in some event in the future, and is valid
        /// </summary>
        /// <param name="expression">Cron expression including seconds</param>
        /// <returns>if the event is not in future or has bad syntax, it returns false</returns>
        public static bool ExpressionIsValid(string expression)
        {
            try
            {
                var cronExpression = Parse(expression);
                var nextOccurrence = cronExpression.GetNextOccurrence(DateTime.UtcNow);
                return nextOccurrence > DateTime.UtcNow;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Parse a string to a <see cref="CronExpression"/> type
        /// </summary>
        /// <param name="expression">An expression string like "* * */1 * * *"</param>
        /// <returns><see cref="CronExpression"/></returns>
        public static CronExpression Parse(string expression) => CronExpression.Parse(expression, CronFormat.IncludeSeconds);

        /// <summary>
        /// Gets the friendly description from a Cron expression
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="cultureInfo"></param>
        /// <returns>Cron expression description in provided language</returns>
        /// <example>"* * * * * MON-FRI" => "Every second, Monday through Friday"</example>
        public static string GetDescription(string expression, CultureInfo cultureInfo) => GetDescription(expression, Enum.Parse<Culture>(cultureInfo.TwoLetterISOLanguageName, true));

        /// <summary>
        /// Gets the friendly description from a Cron expression
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="culture"></param>
        /// <returns>Cron expression description in provided language</returns>
        /// <example>"* * * * * MON-FRI" => "Every second, Monday through Friday"</example>
        public static string GetDescription(string expression, Culture culture = Culture.IV) => GetDescription(Parse(expression), culture);

        /// <summary>
        /// Gets the friendly description from a Cron expression
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="culture">The culture of the descriptor string</param>
        /// <returns>Cron expression description in provided language</returns>
        /// <example>"* * * * * MON-FRI" => "Every second, Monday through Friday"</example>
        public static string GetDescription(CronExpression expression, Culture culture = Culture.IV) =>
            ExpressionDescriptor.GetDescription(expression.ToString(), new Options()
            {
                DayOfWeekStartIndexZero = false,
                Use24HourTimeFormat = true,
                Locale = culture.ToString().ToLowerInvariant()
            });
    }
}
