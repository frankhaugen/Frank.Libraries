using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_categories_category_id_ok
{
    [JsonConstructor]
    public Get_universe_categories_category_id_ok(int category_id, IList<int> groups, string name, bool published)

    {
        Category_id = category_id;

        Groups = groups;

        Name = name;

        Published = published;
    }

    /// <summary>
    ///     category_id integer
    /// </summary>

    [JsonPropertyName("category_id")]
    public int Category_id { get; init; }

    /// <summary>
    ///     groups array
    /// </summary>

    [JsonPropertyName("groups")]
    public IList<int> Groups { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     published boolean
    /// </summary>

    [JsonPropertyName("published")]
    public bool Published { get; init; }
}