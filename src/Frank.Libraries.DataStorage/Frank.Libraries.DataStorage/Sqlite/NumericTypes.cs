using System.Collections;

namespace Frank.Libraries.DataStorage.Sqlite;

internal class NumericTypes : IEnumerable<Type>
{
    public IEnumerator<Type> GetEnumerator()
    {
        yield return typeof(decimal);
        yield return typeof(decimal?);
        yield return typeof(bool);
        yield return typeof(bool?);
        yield return typeof(DateTime);
        yield return typeof(DateTime?);
        yield return typeof(TimeSpan);
        yield return typeof(TimeSpan?);
        yield return typeof(DateTimeOffset);
        yield return typeof(DateTimeOffset?);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}