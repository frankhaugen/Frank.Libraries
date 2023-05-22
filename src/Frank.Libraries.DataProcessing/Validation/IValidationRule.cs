namespace Frank.Libraries.DataProcessing.Validation;

public interface IValidationRule<T>
{
    string Message { get; }
    ValidationErrorType Type { get; }
    bool IsValid(T value);
}