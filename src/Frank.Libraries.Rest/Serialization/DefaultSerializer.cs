using System.Text.Json;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Rest.Serialization;

public class DefaultSerializer : ISerializer
{
    private readonly JsonSerializerOptions _options;

    public DefaultSerializer()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };
        options.Converters.Add(new JsonStringEnumConverter(allowIntegerValues: true));

        _options = options;
    }

    public T Deserialize<T>(string content) => JsonSerializer.Deserialize<T>(content, _options);

    public string Serialize<T>(T content) => JsonSerializer.Serialize(content, _options);
}