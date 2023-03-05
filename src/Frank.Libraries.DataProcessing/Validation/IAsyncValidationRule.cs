namespace Frank.Libraries.DataProcessing;

public interface IAsyncValidationRule<T> : IValidationRule<T>
{
    Task<bool> IsValidAsync(T value);
}