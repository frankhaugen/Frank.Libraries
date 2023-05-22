using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_planets_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_planets_200_ok(DateTimeOffset last_update, int num_pins, int owner_id, int planet_id, Get_characters_character_id_planets_200_okPlanet_type planet_type, int solar_system_id, int upgrade_level)

    {
        Last_update = last_update;

        Num_pins = num_pins;

        Owner_id = owner_id;

        Planet_id = planet_id;

        Planet_type = planet_type;

        Solar_system_id = solar_system_id;

        Upgrade_level = upgrade_level;
    }

    /// <summary>
    ///     last_update string
    /// </summary>

    [JsonPropertyName("last_update")]
    public DateTimeOffset Last_update { get; init; }

    /// <summary>
    ///     num_pins integer
    /// </summary>

    [JsonPropertyName("num_pins")]
    public int Num_pins { get; init; }

    /// <summary>
    ///     owner_id integer
    /// </summary>

    [JsonPropertyName("owner_id")]
    public int Owner_id { get; init; }

    /// <summary>
    ///     planet_id integer
    /// </summary>

    [JsonPropertyName("planet_id")]
    public int Planet_id { get; init; }

    /// <summary>
    ///     planet_type string
    /// </summary>

    [JsonPropertyName("planet_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_characters_character_id_planets_200_okPlanet_type Planet_type { get; init; }

    /// <summary>
    ///     solar_system_id integer
    /// </summary>

    [JsonPropertyName("solar_system_id")]
    public int Solar_system_id { get; init; }

    /// <summary>
    ///     upgrade_level integer
    /// </summary>

    [JsonPropertyName("upgrade_level")]
    public int Upgrade_level { get; init; }
}