using System.Collections;

namespace Frank.Libraries.DataProcessing.Validation;

public class ValidationErrors<T> : IValidationErrors<T>
{
    private readonly List<IValidationError> _errors = new();
    private readonly List<IValidationError> _warnings = new();

    public bool HasErrors => _errors.Any();
    public bool HasWarnings => _warnings.Any();
    public bool HasErrorsOrWarnings => HasErrors || HasWarnings;
    public IEnumerable<IValidationError> Errors => _errors;
    public IEnumerable<IValidationError> Warnings => _warnings;
    public IEnumerable<IValidationError> ErrorsAndWarnings => _errors.Concat(_warnings);
    public IEnumerable<IValidationError> All => ErrorsAndWarnings;

    public IEnumerator<IValidationError> GetEnumerator() => All.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void AddError(string message) => _errors.Add(new ValidationError(message, ValidationErrorType.Error));
    public void AddWarning(string message) => _warnings.Add(new ValidationError(message, ValidationErrorType.Warning));
}