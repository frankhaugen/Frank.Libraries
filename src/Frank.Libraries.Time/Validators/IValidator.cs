namespace Frank.Libraries.Time.Validators;

public interface IValidator<in T>
{
    string ValidationMessage { get; set; }
    bool IsValid(T value);
}