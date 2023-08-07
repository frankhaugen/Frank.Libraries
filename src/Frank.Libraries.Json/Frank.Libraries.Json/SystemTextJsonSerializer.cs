using System.Text.Json;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.Json;

public class SystemTextJsonSerializer : IJsonSerializer
{
    private readonly IOptions<JsonSerializerOptions> _options;

    public SystemTextJsonSerializer(IOptions<JsonSerializerOptions> options) => _options = options;

    public string Serialize<T>(T obj) => JsonSerializer.Serialize(obj, _options.Value);

    public ReadOnlyMemory<byte> SerializeToUtf8Bytes<T>(T obj) => JsonSerializer.SerializeToUtf8Bytes(obj, _options.Value);

    public T? Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json, _options.Value);

    public T? Deserialize<T>(ReadOnlySpan<byte> utf8Json) => JsonSerializer.Deserialize<T>(utf8Json, _options.Value);
}