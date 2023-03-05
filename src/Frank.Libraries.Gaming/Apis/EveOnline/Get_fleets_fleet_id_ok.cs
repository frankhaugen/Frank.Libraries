using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_fleets_fleet_id_ok
{
    [JsonConstructor]
    public Get_fleets_fleet_id_ok(bool is_free_move, bool is_registered, bool is_voice_enabled, string motd)

    {
        Is_free_move = is_free_move;

        Is_registered = is_registered;

        Is_voice_enabled = is_voice_enabled;

        Motd = motd;
    }

    /// <summary>
    ///     Is free-move enabled
    /// </summary>

    [JsonPropertyName("is_free_move")]
    public bool Is_free_move { get; init; }

    /// <summary>
    ///     Does the fleet have an active fleet advertisement
    /// </summary>

    [JsonPropertyName("is_registered")]
    public bool Is_registered { get; init; }

    /// <summary>
    ///     Is EVE Voice enabled
    /// </summary>

    [JsonPropertyName("is_voice_enabled")]
    public bool Is_voice_enabled { get; init; }

    /// <summary>
    ///     Fleet MOTD in CCP flavoured HTML
    /// </summary>

    [JsonPropertyName("motd")]
    public string Motd { get; init; }
}