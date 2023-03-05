namespace Frank.Libraries.Time.Providers;

public class DayOfWeekValidator : IValidator<int>
{
    public string ValidationMessage { get; set; } = string.Empty;

    public bool IsValid(int value)
    {
        if (value == null)
        {
            ValidationMessage = "Null value is not allowed";
            return false;
        }

        if (value < 0)
        {
            ValidationMessage = "Day of week must be greater than or equal to 0";
            return false;
        }

        if (value > 6)
        {
            ValidationMessage = "Day of week must be less than or equal to 6";
            return false;
        }

        return true;
    }
}