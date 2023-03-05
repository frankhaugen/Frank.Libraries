namespace Frank.Libraries.DataProcessing;

public readonly record struct ValidationError(string Message, ValidationErrorType Type) : IValidationError;