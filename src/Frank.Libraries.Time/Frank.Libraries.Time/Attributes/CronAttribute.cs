using System.ComponentModel.DataAnnotations;
using Frank.Libraries.Time.Parses;

namespace Frank.Libraries.Time.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class CronAttribute : ValidationAttribute
{
    private const string DefaultErrorMessage = "The {0} field is not a valid cron -expression";

    /// <inheritdoc />
    public override bool IsValid(object value)
    {
        var cronVarantParser = new CronVariantParser();

        if (cronVarantParser.TryParse(value.ToString() ?? string.Empty, out var _))
        {
            return true;
        }

        ErrorMessage = string.Format(DefaultErrorMessage, value);
        return false;
    }
}