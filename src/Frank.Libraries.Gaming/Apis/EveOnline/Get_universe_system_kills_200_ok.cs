using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_system_kills_200_ok
{
    [JsonConstructor]
    public Get_universe_system_kills_200_ok(int npc_kills, int pod_kills, int ship_kills, int system_id)

    {
        Npc_kills = npc_kills;

        Pod_kills = pod_kills;

        Ship_kills = ship_kills;

        System_id = system_id;
    }

    /// <summary>
    ///     Number of NPC ships killed in this system
    /// </summary>

    [JsonPropertyName("npc_kills")]
    public int Npc_kills { get; init; }

    /// <summary>
    ///     Number of pods killed in this system
    /// </summary>

    [JsonPropertyName("pod_kills")]
    public int Pod_kills { get; init; }

    /// <summary>
    ///     Number of player ships killed in this system
    /// </summary>

    [JsonPropertyName("ship_kills")]
    public int Ship_kills { get; init; }

    /// <summary>
    ///     system_id integer
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }
}