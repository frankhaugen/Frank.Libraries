using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_ancestries_200_ok
{
    [JsonConstructor]
    public Get_universe_ancestries_200_ok(int bloodline_id, string description, int? icon_id, int id, string name, string? short_description)

    {
        Bloodline_id = bloodline_id;

        Description = description;

        Icon_id = icon_id;

        Id = id;

        Name = name;

        Short_description = short_description;
    }

    /// <summary>
    ///     The bloodline associated with this ancestry
    /// </summary>

    [JsonPropertyName("bloodline_id")]
    public int Bloodline_id { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    ///     icon_id integer
    /// </summary>

    [JsonPropertyName("icon_id")]
    public int? Icon_id { get; init; }

    /// <summary>
    ///     id integer
    /// </summary>

    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     short_description string
    /// </summary>

    [JsonPropertyName("short_description")]
    public string? Short_description { get; init; }
}