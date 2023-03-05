using System.Collections;

namespace Frank.Libraries.DataProcessing;

public class Validator<T> : IValidator<T>
{
    public IEnumerator<IValidationRule<T>> GetEnumerator() => Enumerable.Empty<IValidationRule<T>>()
                                                                        .GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}