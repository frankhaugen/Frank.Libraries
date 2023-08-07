namespace Frank.Libraries.DataProcessing.Validation;

public interface IValidationErrors<T> : IEnumerable<IValidationError>
{
    bool HasErrors { get; }
    bool HasWarnings { get; }
    bool HasErrorsOrWarnings { get; }
    IEnumerable<IValidationError> Errors { get; }
    IEnumerable<IValidationError> Warnings { get; }
    IEnumerable<IValidationError> ErrorsAndWarnings { get; }
    IEnumerable<IValidationError> All { get; }
}