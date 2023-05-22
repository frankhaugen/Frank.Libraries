namespace Frank.Libraries.DataProcessing.Validation;

public interface IAsyncValidator<T> : IValidator<T>
{
    Task<bool> IsValidAsync(T value);
}