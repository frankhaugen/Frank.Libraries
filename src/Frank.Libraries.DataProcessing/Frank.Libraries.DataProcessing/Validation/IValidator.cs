namespace Frank.Libraries.DataProcessing.Validation;

public interface IValidator<T> : IEnumerable<IValidationRule<T>>
{
}