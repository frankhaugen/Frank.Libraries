using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_groups_group_id_ok
{
    [JsonConstructor]
    public Get_universe_groups_group_id_ok(int category_id, int group_id, string name, bool published, IList<int> types)

    {
        Category_id = category_id;

        Group_id = group_id;

        Name = name;

        Published = published;

        Types = types;
    }

    /// <summary>
    ///     category_id integer
    /// </summary>

    [JsonPropertyName("category_id")]
    public int Category_id { get; init; }

    /// <summary>
    ///     group_id integer
    /// </summary>

    [JsonPropertyName("group_id")]
    public int Group_id { get; init; }

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

    /// <summary>
    ///     types array
    /// </summary>

    [JsonPropertyName("types")]
    public IList<int> Types { get; init; }
}