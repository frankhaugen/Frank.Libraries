using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_types_type_id_ok
{
    [JsonConstructor]
    public Get_universe_types_type_id_ok(float? capacity, string description, IList<Dogma_attributes2>? dogma_attributes, IList<Dogma_effects2>? dogma_effects, int? graphic_id, int group_id, int? icon_id, int? market_group_id, float? mass, string name, float? packaged_volume, int? portion_size, bool published, float? radius, int type_id, float? volume)

    {
        Capacity = capacity;

        Description = description;

        Dogma_attributes = dogma_attributes;

        Dogma_effects = dogma_effects;

        Graphic_id = graphic_id;

        Group_id = group_id;

        Icon_id = icon_id;

        Market_group_id = market_group_id;

        Mass = mass;

        Name = name;

        Packaged_volume = packaged_volume;

        Portion_size = portion_size;

        Published = published;

        Radius = radius;

        Type_id = type_id;

        Volume = volume;
    }

    /// <summary>
    ///     capacity number
    /// </summary>

    [JsonPropertyName("capacity")]
    public float? Capacity { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    ///     dogma_attributes array
    /// </summary>

    [JsonPropertyName("dogma_attributes")]
    public IList<Dogma_attributes2>? Dogma_attributes { get; init; }

    /// <summary>
    ///     dogma_effects array
    /// </summary>

    [JsonPropertyName("dogma_effects")]
    public IList<Dogma_effects2>? Dogma_effects { get; init; }

    /// <summary>
    ///     graphic_id integer
    /// </summary>

    [JsonPropertyName("graphic_id")]
    public int? Graphic_id { get; init; }

    /// <summary>
    ///     group_id integer
    /// </summary>

    [JsonPropertyName("group_id")]
    public int Group_id { get; init; }

    /// <summary>
    ///     icon_id integer
    /// </summary>

    [JsonPropertyName("icon_id")]
    public int? Icon_id { get; init; }

    /// <summary>
    ///     This only exists for types that can be put on the market
    /// </summary>

    [JsonPropertyName("market_group_id")]
    public int? Market_group_id { get; init; }

    /// <summary>
    ///     mass number
    /// </summary>

    [JsonPropertyName("mass")]
    public float? Mass { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     packaged_volume number
    /// </summary>

    [JsonPropertyName("packaged_volume")]
    public float? Packaged_volume { get; init; }

    /// <summary>
    ///     portion_size integer
    /// </summary>

    [JsonPropertyName("portion_size")]
    public int? Portion_size { get; init; }

    /// <summary>
    ///     published boolean
    /// </summary>

    [JsonPropertyName("published")]
    public bool Published { get; init; }

    /// <summary>
    ///     radius number
    /// </summary>

    [JsonPropertyName("radius")]
    public float? Radius { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }

    /// <summary>
    ///     volume number
    /// </summary>

    [JsonPropertyName("volume")]
    public float? Volume { get; init; }
}