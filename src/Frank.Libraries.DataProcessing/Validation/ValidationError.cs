namespace Frank.Libraries.DataProcessing.Validation;

public readonly record struct ValidationError(string Message, ValidationErrorType Type) : IValidationError;