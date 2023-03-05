using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_fittings_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_fittings_200_ok(string description, int fitting_id, IList<Items2> items, string name, int ship_type_id)

    {
        Description = description;

        Fitting_id = fitting_id;

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
    ///     fitting_id integer
    /// </summary>

    [JsonPropertyName("fitting_id")]
    public int Fitting_id { get; init; }

    /// <summary>
    ///     items array
    /// </summary>

    [JsonPropertyName("items")]
    public IList<Items2> Items { get; init; }

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