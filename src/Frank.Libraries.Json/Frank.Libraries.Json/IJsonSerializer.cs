namespace Frank.Libraries.Json;

public interface IJsonSerializer
{
    string Serialize<T>(T obj);

    ReadOnlyMemory<byte> SerializeToUtf8Bytes<T>(T obj);

    T? Deserialize<T>(string json);

    T? Deserialize<T>(ReadOnlySpan<byte> utf8Json);
}