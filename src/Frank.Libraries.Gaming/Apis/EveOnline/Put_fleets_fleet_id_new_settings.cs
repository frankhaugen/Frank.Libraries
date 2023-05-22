using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     new_settings object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Put_fleets_fleet_id_new_settings
{
    [JsonConstructor]
    public Put_fleets_fleet_id_new_settings(bool? is_free_move, string? motd)

    {
        Is_free_move = is_free_move;

        Motd = motd;
    }

    /// <summary>
    ///     Should free-move be enabled in the fleet
    /// </summary>

    [JsonPropertyName("is_free_move")]
    public bool? Is_free_move { get; init; }

    /// <summary>
    ///     New fleet MOTD in CCP flavoured HTML
    /// </summary>

    [JsonPropertyName("motd")]
    public string? Motd { get; init; }
}