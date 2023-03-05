using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_medals_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_medals_200_ok(DateTimeOffset created_at, int creator_id, string description, int medal_id, string title)

    {
        Created_at = created_at;

        Creator_id = creator_id;

        Description = description;

        Medal_id = medal_id;

        Title = title;
    }

    /// <summary>
    ///     created_at string
    /// </summary>

    [JsonPropertyName("created_at")]
    public DateTimeOffset Created_at { get; init; }

    /// <summary>
    ///     ID of the character who created this medal
    /// </summary>

    [JsonPropertyName("creator_id")]
    public int Creator_id { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    ///     medal_id integer
    /// </summary>

    [JsonPropertyName("medal_id")]
    public int Medal_id { get; init; }

    /// <summary>
    ///     title string
    /// </summary>

    [JsonPropertyName("title")]
    public string Title { get; init; }
}