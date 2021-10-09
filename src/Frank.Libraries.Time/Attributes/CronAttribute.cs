using System;
using System.ComponentModel.DataAnnotations;

namespace Frank.Libraries.Time.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class CronAttribute : ValidationAttribute
    {
        private const string DefaultErrorMessage = "The {0} field is not a valid cron -expression";

        public CronAttribute() : base(DefaultErrorMessage) { }

        public override bool IsValid(object value)
        {
            var cron = value?.ToString();

            return Utilities.CronUtilities.ExpressionIsValid(cron);
        }
    }
}
