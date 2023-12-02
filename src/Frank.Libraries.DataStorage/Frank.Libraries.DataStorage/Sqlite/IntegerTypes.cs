using System.Collections;

namespace Frank.Libraries.DataStorage.Sqlite;

internal class IntegerTypes : IEnumerable<Type>
{
    public IEnumerator<Type> GetEnumerator()
    {
        yield return typeof(int);
        yield return typeof(long);
        yield return typeof(short);
        yield return typeof(byte);
        yield return typeof(uint);
        yield return typeof(ulong);
        yield return typeof(ushort);
        yield return typeof(sbyte);
        yield return typeof(char);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}