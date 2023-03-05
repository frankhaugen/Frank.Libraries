using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_fleet_ok
{
    [JsonConstructor]
    public Get_characters_character_id_fleet_ok(long fleet_id, Get_characters_character_id_fleet_okRole role, long squad_id, long wing_id)

    {
        Fleet_id = fleet_id;

        Role = role;

        Squad_id = squad_id;

        Wing_id = wing_id;
    }

    /// <summary>
    ///     The character's current fleet ID
    /// </summary>

    [JsonPropertyName("fleet_id")]
    public long Fleet_id { get; init; }

    /// <summary>
    ///     Member’s role in fleet
    /// </summary>

    [JsonPropertyName("role")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_characters_character_id_fleet_okRole Role { get; init; }

    /// <summary>
    ///     ID of the squad the member is in. If not applicable, will be set to -1
    /// </summary>

    [JsonPropertyName("squad_id")]
    public long Squad_id { get; init; }

    /// <summary>
    ///     ID of the wing the member is in. If not applicable, will be set to -1
    /// </summary>

    [JsonPropertyName("wing_id")]
    public long Wing_id { get; init; }
}