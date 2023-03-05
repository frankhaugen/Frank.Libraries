namespace Frank.Libraries.Time.Providers;

public class HourValidator : IValidator<int>
{
    public string ValidationMessage { get; set; } = string.Empty;

    public bool IsValid(int value)
    {
        if (value < 0)
        {
            ValidationMessage = "Hour must be greater than or equal to 0";
            return false;
        }

        if (value > 23)
        {
            ValidationMessage = "Hour must be less than or equal to 23";
            return false;
        }

        return true;
    }
}