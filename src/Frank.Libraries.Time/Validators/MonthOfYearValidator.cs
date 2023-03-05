namespace Frank.Libraries.Time.Providers;

public class MonthOfYearValidator : IValidator<int>
{
    public string ValidationMessage { get; set; } = string.Empty;

    public bool IsValid(int value)
    {
        if (value == null)
        {
            ValidationMessage = "Null value is not allowed";
            return false;
        }

        if (value < 1)
        {
            ValidationMessage = "Month of year must be greater than 0";
            return false;
        }

        if (value > 12)
        {
            ValidationMessage = "Month of year must be less than 13";
            return false;
        }

        return true;
    }
}