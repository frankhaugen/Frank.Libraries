using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_dogma_attributes_attribute_id_ok
{
    [JsonConstructor]
    public Get_dogma_attributes_attribute_id_ok(int attribute_id, float? default_value, string? description, string? display_name, bool? high_is_good, int? icon_id, string? name, bool? published, bool? stackable, int? unit_id)

    {
        Attribute_id = attribute_id;

        Default_value = default_value;

        Description = description;

        Display_name = display_name;

        High_is_good = high_is_good;

        Icon_id = icon_id;

        Name = name;

        Published = published;

        Stackable = stackable;

        Unit_id = unit_id;
    }

    /// <summary>
    ///     attribute_id integer
    /// </summary>

    [JsonPropertyName("attribute_id")]
    public int Attribute_id { get; init; }

    /// <summary>
    ///     default_value number
    /// </summary>

    [JsonPropertyName("default_value")]
    public float? Default_value { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    ///     display_name string
    /// </summary>

    [JsonPropertyName("display_name")]
    public string? Display_name { get; init; }

    /// <summary>
    ///     high_is_good boolean
    /// </summary>

    [JsonPropertyName("high_is_good")]
    public bool? High_is_good { get; init; }

    /// <summary>
    ///     icon_id integer
    /// </summary>

    [JsonPropertyName("icon_id")]
    public int? Icon_id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    ///     published boolean
    /// </summary>

    [JsonPropertyName("published")]
    public bool? Published { get; init; }

    /// <summary>
    ///     stackable boolean
    /// </summary>

    [JsonPropertyName("stackable")]
    public bool? Stackable { get; init; }

    /// <summary>
    ///     unit_id integer
    /// </summary>

    [JsonPropertyName("unit_id")]
    public int? Unit_id { get; init; }
}