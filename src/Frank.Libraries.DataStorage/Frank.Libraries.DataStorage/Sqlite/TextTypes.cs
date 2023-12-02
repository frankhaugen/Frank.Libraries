using System.Collections;

namespace Frank.Libraries.DataStorage.Sqlite;

internal class TextTypes : IEnumerable<Type>
{
    public IEnumerator<Type> GetEnumerator()
    {
        yield return typeof(string);
        yield return typeof(Guid);
        yield return typeof(Guid?);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}