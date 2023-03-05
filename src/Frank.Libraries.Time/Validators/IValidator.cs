namespace Frank.Libraries.Time.Providers;

public interface IValidator<in T>
{
    string ValidationMessage { get; set; }
    bool IsValid(T value);
}