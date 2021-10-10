using System;
using System.ComponentModel.DataAnnotations;
using Cronos;

namespace Frank.Libraries.Time.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class CronAttribute : ValidationAttribute
    {
        private const string DefaultErrorMessage = "The {0} field is not a valid cron -expression";
        private readonly CronFormat _format;

        public CronAttribute(CronFormat format = CronFormat.IncludeSeconds) : base(DefaultErrorMessage) => _format = format;

        /// <inheritdoc />
        public override bool IsValid(object value)
        {
            var cron = value.ToString();
            return new CronService().IsValid(cron ?? "", _format);
        }
    }
}
