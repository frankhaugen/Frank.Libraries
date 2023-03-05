using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_agents_research_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_agents_research_200_ok(int agent_id, float points_per_day, float remainder_points, int skill_type_id, DateTimeOffset started_at)

    {
        Agent_id = agent_id;

        Points_per_day = points_per_day;

        Remainder_points = remainder_points;

        Skill_type_id = skill_type_id;

        Started_at = started_at;
    }

    /// <summary>
    ///     agent_id integer
    /// </summary>

    [JsonPropertyName("agent_id")]
    public int Agent_id { get; init; }

    /// <summary>
    ///     points_per_day number
    /// </summary>

    [JsonPropertyName("points_per_day")]
    public float Points_per_day { get; init; }

    /// <summary>
    ///     remainder_points number
    /// </summary>

    [JsonPropertyName("remainder_points")]
    public float Remainder_points { get; init; }

    /// <summary>
    ///     skill_type_id integer
    /// </summary>

    [JsonPropertyName("skill_type_id")]
    public int Skill_type_id { get; init; }

    /// <summary>
    ///     started_at string
    /// </summary>

    [JsonPropertyName("started_at")]
    public DateTimeOffset Started_at { get; init; }
}