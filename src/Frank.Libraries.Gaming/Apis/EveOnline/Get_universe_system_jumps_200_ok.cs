using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_system_jumps_200_ok
{
    [JsonConstructor]
    public Get_universe_system_jumps_200_ok(int ship_jumps, int system_id)

    {
        Ship_jumps = ship_jumps;

        System_id = system_id;
    }

    /// <summary>
    ///     ship_jumps integer
    /// </summary>

    [JsonPropertyName("ship_jumps")]
    public int Ship_jumps { get; init; }

    /// <summary>
    ///     system_id integer
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }
}