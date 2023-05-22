using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_sovereignty_map_200_ok
{
    [JsonConstructor]
    public Get_sovereignty_map_200_ok(int? alliance_id, int? corporation_id, int? faction_id, int system_id)

    {
        Alliance_id = alliance_id;

        Corporation_id = corporation_id;

        Faction_id = faction_id;

        System_id = system_id;
    }

    /// <summary>
    ///     alliance_id integer
    /// </summary>

    [JsonPropertyName("alliance_id")]
    public int? Alliance_id { get; init; }

    /// <summary>
    ///     corporation_id integer
    /// </summary>

    [JsonPropertyName("corporation_id")]
    public int? Corporation_id { get; init; }

    /// <summary>
    ///     faction_id integer
    /// </summary>

    [JsonPropertyName("faction_id")]
    public int? Faction_id { get; init; }

    /// <summary>
    ///     system_id integer
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }
}