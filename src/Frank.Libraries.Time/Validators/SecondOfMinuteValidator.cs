namespace Frank.Libraries.Time.Validators;

public class SecondOfMinuteValidator : IValidator<int>
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
            ValidationMessage = "Second of minute must be greater than or equal to 0";
            return false;
        }

        if (value > 59)
        {
            ValidationMessage = "Second of minute must be less than or equal to 59";
            return false;
        }

        return true;
    }
}