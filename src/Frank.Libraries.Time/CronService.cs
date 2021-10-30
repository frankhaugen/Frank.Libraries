using System;
using System.Globalization;
using CronExpressionDescriptor;
using Cronos;
using Frank.Libraries.Enums.Countries;

namespace Frank.Libraries.Time
{
    public class CronService
    {
        private readonly Culture _defaultCulture;
        private readonly Options _options;

        public CronService(Culture defaultCulture = Culture.IV) => _defaultCulture = defaultCulture;

        private Options GetOptions() => new Options()
        {
            DayOfWeekStartIndexZero = true,
            Use24HourTimeFormat = true,
            Verbose = true,
            Locale = _defaultCulture.ToString().ToLowerInvariant()
        };

        /// <summary>
        /// Checks if the expression is valid Cron
        /// </summary>
        /// <param name="expression">Cron expression</param>
        /// <param name="format">The format being parsed (second or minute precision)</param>
        /// <returns>if the event is not in future or has bad syntax, it returns false</returns>
        public bool IsValid(string expression, CronFormat format = CronFormat.IncludeSeconds) => ValidateExpression(expression, format);

        /// <summary>
        /// Parse a string to a <see cref="CronExpression"/> type
        /// </summary>
        /// <param name="expression">An expression string like "* * */1 * * *"</param>
        /// <returns><see cref="CronExpression"/></returns>
        public CronExpression Parse(string expression, CronFormat format = CronFormat.IncludeSeconds) => ParseExpression(expression, format);

        /// <summary>
        /// Parse a string to a <see cref="CronExpression"/> type
        /// </summary>
        /// <param name="expression">An expression string like "* * */1 * * *"</param>
        /// <param name="cronExpression">Out value</param>
        /// <param name="format"></param>
        /// <returns><see cref="CronExpression"/></returns>
        public bool TryParse(string expression, out CronExpression? cronExpression, CronFormat format = CronFormat.IncludeSeconds)
        {
            try
            {
                cronExpression = ParseExpression(expression, format);
                return ValidateExpression(expression, format);
            }
            catch
            {
                cronExpression = null;
                return false;
            }
        }

        /// <summary>
        /// Gets the friendly description from a Cron expression
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="cultureInfo"></param>
        /// <returns>Cron expression description in provided language</returns>
        /// <example>"* * * * * MON-FRI" => "Every second, Monday through Friday"</example>
        public string GetDescription(string expression, CultureInfo cultureInfo) => GetCronExpressionDescription(expression, Enum.Parse<Culture>(cultureInfo.TwoLetterISOLanguageName, true));

        /// <summary>
        /// Gets the friendly description from a Cron expression
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="cultureInfo"></param>
        /// <returns>Cron expression description in provided language</returns>
        /// <example>"* * * * * MON-FRI" => "Every second, Monday through Friday"</example>
        public string GetDescription(CronExpression expression, CultureInfo cultureInfo) => GetCronExpressionDescription(expression.ToString(), Enum.Parse<Culture>(cultureInfo.TwoLetterISOLanguageName, true));

        /// <summary>
        /// Gets the friendly description from a Cron expression
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="culture"></param>
        /// <returns>Cron expression description in provided language</returns>
        /// <example>"* * * * * MON-FRI" => "Every second, Monday through Friday"</example>
        public string GetDescription(string expression, Culture culture = Culture.IV) => GetCronExpressionDescription(expression, culture);

        /// <summary>
        /// Gets the friendly description from a Cron expression
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="culture">The culture of the descriptor string</param>
        /// <returns>Cron expression description in provided language</returns>
        /// <example>"* * * * * MON-FRI" => "Every second, Monday through Friday"</example>
        public string GetDescription(CronExpression expression, Culture culture = Culture.IV) => GetCronExpressionDescription(expression.ToString(), culture);

        private static string GetCronExpressionDescription(string expression, Culture culture) =>
            ExpressionDescriptor.GetDescription(expression, new Options());

        private static CronExpression ParseExpression(string expression, CronFormat format) => CronExpression.Parse(expression, format);

        private bool ValidateExpression(string expression, CronFormat format = CronFormat.IncludeSeconds)
        {
            try
            {
                var cronExpression = ParseExpression(expression, format);
                var nextOccurrence = cronExpression.GetNextOccurrence(DateTime.UtcNow);
                return nextOccurrence != null;
            }
            catch
            {
                return false;
            }
        }
    }
}