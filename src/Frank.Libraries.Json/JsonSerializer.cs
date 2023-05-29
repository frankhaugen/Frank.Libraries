using System.Text.Json;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Json;

public class JsonSerializer : IJsonSerializer
{
    private readonly JsonSerializerOptions _options;

    public JsonSerializer()
    {
        _options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() },
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };
    }

    public string Serialize<T>(T obj)
    {
        return System.Text.Json.JsonSerializer.Serialize(obj, _options);
    }

    public T Deserialize<T>(string json)
    {
        return System.Text.Json.JsonSerializer.Deserialize<T>(json, _options) ?? throw new JsonException();
    }
}