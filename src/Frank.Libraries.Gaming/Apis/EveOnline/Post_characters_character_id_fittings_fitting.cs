using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     fitting object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Post_characters_character_id_fittings_fitting
{
    [JsonConstructor]
    public Post_characters_character_id_fittings_fitting(string description, IList<Items> items, string name, int ship_type_id)

    {
        Description = description;

        Items = items;

        Name = name;

        Ship_type_id = ship_type_id;
    }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    ///     items array
    /// </summary>

    [JsonPropertyName("items")]
    public IList<Items> Items { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     ship_type_id integer
    /// </summary>

    [JsonPropertyName("ship_type_id")]
    public int Ship_type_id { get; init; }
}