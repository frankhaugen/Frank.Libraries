namespace Frank.Libraries.Json;

public interface IJsonSerializer
{
    string Serialize<T>(T obj);

    T Deserialize<T>(string json);
}

public static class JsonSerializerExtensions
{
    public static bool TrySerialize<T>(this IJsonSerializer serializer, T obj, out string? json)
    {
        try
        {
            json = serializer.Serialize(obj);
            return json != null;
        }
        catch (Exception)
        {
            json = null;
            return false;
        }
    }

    public static bool TryDeserialize<T>(this IJsonSerializer serializer, string json, T? obj)
    {
        try
        {
            obj = serializer.Deserialize<T>(json);
            return obj != null;
        }
        catch (Exception)
        {
            obj = default;
            return false;
        }
    }
}