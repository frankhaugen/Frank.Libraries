namespace Frank.Libraries.Time.Providers;

public class SecondValidator : IValidator<int>
{
    public string ValidationMessage { get; set; } = string.Empty;

    public bool IsValid(int value)
    {
        if (value < 0)
        {
            ValidationMessage = "Second must be greater than or equal to 0";
            return false;
        }

        if (value > 59)
        {
            ValidationMessage = "Second must be less than or equal to 59";
            return false;
        }

        return true;
    }
}