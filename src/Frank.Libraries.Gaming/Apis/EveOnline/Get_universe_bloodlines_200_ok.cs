using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_bloodlines_200_ok
{
    [JsonConstructor]
    public Get_universe_bloodlines_200_ok(int bloodline_id, int charisma, int corporation_id, string description, int intelligence, int memory, string name, int perception, int race_id, int? ship_type_id, int willpower)

    {
        Bloodline_id = bloodline_id;

        Charisma = charisma;

        Corporation_id = corporation_id;

        Description = description;

        Intelligence = intelligence;

        Memory = memory;

        Name = name;

        Perception = perception;

        Race_id = race_id;

        Ship_type_id = ship_type_id;

        Willpower = willpower;
    }

    /// <summary>
    ///     bloodline_id integer
    /// </summary>

    [JsonPropertyName("bloodline_id")]
    public int Bloodline_id { get; init; }

    /// <summary>
    ///     charisma integer
    /// </summary>

    [JsonPropertyName("charisma")]
    public int Charisma { get; init; }

    /// <summary>
    ///     corporation_id integer
    /// </summary>

    [JsonPropertyName("corporation_id")]
    public int Corporation_id { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    ///     intelligence integer
    /// </summary>

    [JsonPropertyName("intelligence")]
    public int Intelligence { get; init; }

    /// <summary>
    ///     memory integer
    /// </summary>

    [JsonPropertyName("memory")]
    public int Memory { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     perception integer
    /// </summary>

    [JsonPropertyName("perception")]
    public int Perception { get; init; }

    /// <summary>
    ///     race_id integer
    /// </summary>

    [JsonPropertyName("race_id")]
    public int Race_id { get; init; }

    /// <summary>
    ///     ship_type_id integer
    /// </summary>

    [JsonPropertyName("ship_type_id")]
    public int? Ship_type_id { get; init; }

    /// <summary>
    ///     willpower integer
    /// </summary>

    [JsonPropertyName("willpower")]
    public int Willpower { get; init; }
}