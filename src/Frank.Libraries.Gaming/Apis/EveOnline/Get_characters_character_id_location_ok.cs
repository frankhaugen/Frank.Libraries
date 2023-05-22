using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_location_ok
{
    [JsonConstructor]
    public Get_characters_character_id_location_ok(int solar_system_id, int? station_id, long? structure_id)

    {
        Solar_system_id = solar_system_id;

        Station_id = station_id;

        Structure_id = structure_id;
    }

    /// <summary>
    ///     solar_system_id integer
    /// </summary>

    [JsonPropertyName("solar_system_id")]
    public int Solar_system_id { get; init; }

    /// <summary>
    ///     station_id integer
    /// </summary>

    [JsonPropertyName("station_id")]
    public int? Station_id { get; init; }

    /// <summary>
    ///     structure_id integer
    /// </summary>

    [JsonPropertyName("structure_id")]
    public long? Structure_id { get; init; }
}