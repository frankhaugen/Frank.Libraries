namespace Frank.Libraries.Time.Providers;

public class MinuteOfHourValidator : IValidator<int>
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
            ValidationMessage = "Minute of hour must be greater than or equal to 0";
            return false;
        }

        if (value > 59)
        {
            ValidationMessage = "Minute of hour must be less than or equal to 59";
            return false;
        }

        return true;
    }
}