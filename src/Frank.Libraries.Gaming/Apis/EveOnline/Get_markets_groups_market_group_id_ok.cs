using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_markets_groups_market_group_id_ok
{
    [JsonConstructor]
    public Get_markets_groups_market_group_id_ok(string description, int market_group_id, string name, int? parent_group_id, IList<int> types)

    {
        Description = description;

        Market_group_id = market_group_id;

        Name = name;

        Parent_group_id = parent_group_id;

        Types = types;
    }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    ///     market_group_id integer
    /// </summary>

    [JsonPropertyName("market_group_id")]
    public int Market_group_id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     parent_group_id integer
    /// </summary>

    [JsonPropertyName("parent_group_id")]
    public int? Parent_group_id { get; init; }

    /// <summary>
    ///     types array
    /// </summary>

    [JsonPropertyName("types")]
    public IList<int> Types { get; init; }
}