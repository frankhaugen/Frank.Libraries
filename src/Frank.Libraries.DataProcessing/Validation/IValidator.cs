namespace Frank.Libraries.DataProcessing;

public interface IValidator<T> : IEnumerable<IValidationRule<T>>
{
}