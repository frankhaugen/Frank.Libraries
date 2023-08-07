namespace Frank.Libraries.DataProcessing.Validation;

public interface IValidationError
{
    string Message { get; }
    ValidationErrorType Type { get; }

    public static IValidationError Create(string message, ValidationErrorType type = ValidationErrorType.Error) => new ValidationError(message, type);
}