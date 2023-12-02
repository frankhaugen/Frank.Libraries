using System.Collections;

namespace Frank.Libraries.DataStorage.Sqlite;

internal class BlobTypes : IEnumerable<Type>
{
    public IEnumerator<Type> GetEnumerator()
    {
        yield return typeof(byte[]);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}