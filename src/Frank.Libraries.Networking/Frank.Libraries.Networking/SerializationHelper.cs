using System.Text.Json;

namespace Frank.Libraries.Networking;

public static class SerializationHelper
{
    public static byte[] Serialize<T>(T data)
    {
        return JsonSerializer.SerializeToUtf8Bytes(data);
    }

    public static T? Deserialize<T>(ReadOnlySpan<byte> bytes)
    {
        return JsonSerializer.Deserialize<T>(bytes);
    }
}