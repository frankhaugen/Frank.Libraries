using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Destination
{
    [JsonConstructor]
    public Destination(int stargate_id, int system_id)

    {
        Stargate_id = stargate_id;

        System_id = system_id;
    }

    /// <summary>
    ///     The stargate this stargate connects to
    /// </summary>

    [JsonPropertyName("stargate_id")]
    public int Stargate_id { get; init; }

    /// <summary>
    ///     The solar system this stargate connects to
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }
}