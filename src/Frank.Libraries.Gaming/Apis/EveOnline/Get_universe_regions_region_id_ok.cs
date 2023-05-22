using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_regions_region_id_ok
{
    [JsonConstructor]
    public Get_universe_regions_region_id_ok(IList<int> constellations, string? description, string name, int region_id)

    {
        Constellations = constellations;

        Description = description;

        Name = name;

        Region_id = region_id;
    }

    /// <summary>
    ///     constellations array
    /// </summary>

    [JsonPropertyName("constellations")]
    public IList<int> Constellations { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     region_id integer
    /// </summary>

    [JsonPropertyName("region_id")]
    public int Region_id { get; init; }
}