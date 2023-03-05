namespace Frank.Libraries.Time.Providers;

public class HourOfDayValidator : IValidator<int>
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
            ValidationMessage = "Hour of day must be greater than or equal to 0";
            return false;
        }

        if (value > 23)
        {
            ValidationMessage = "Hour of day must be less than or equal to 23";
            return false;
        }

        return true;
    }
}