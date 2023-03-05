namespace Frank.Libraries.DataProcessing;

public interface IAsyncValidator<T> : IValidator<T>
{
    Task<bool> IsValidAsync(T value);
}