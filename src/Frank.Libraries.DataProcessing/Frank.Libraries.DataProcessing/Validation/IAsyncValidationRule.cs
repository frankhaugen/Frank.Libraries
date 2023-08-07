namespace Frank.Libraries.DataProcessing.Validation;

public interface IAsyncValidationRule<T> : IValidationRule<T>
{
    Task<bool> IsValidAsync(T value);
}