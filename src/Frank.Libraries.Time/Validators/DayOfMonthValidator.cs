namespace Frank.Libraries.Time.Providers;

public class DayOfMonthValidator : IValidator<int>
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
            ValidationMessage = "Day of month must be greater than 0";
            return false;
        }

        if (value > 31)
        {
            ValidationMessage = "Day of month must be less than 32";
            return false;
        }

        return true;
    }
}