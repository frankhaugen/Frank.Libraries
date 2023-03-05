using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     skill object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Skills
{
    [JsonConstructor]
    public Skills(int active_skill_level, int skill_id, long skillpoints_in_skill, int trained_skill_level)

    {
        Active_skill_level = active_skill_level;

        Skill_id = skill_id;

        Skillpoints_in_skill = skillpoints_in_skill;

        Trained_skill_level = trained_skill_level;
    }

    /// <summary>
    ///     active_skill_level integer
    /// </summary>

    [JsonPropertyName("active_skill_level")]
    public int Active_skill_level { get; init; }

    /// <summary>
    ///     skill_id integer
    /// </summary>

    [JsonPropertyName("skill_id")]
    public int Skill_id { get; init; }

    /// <summary>
    ///     skillpoints_in_skill integer
    /// </summary>

    [JsonPropertyName("skillpoints_in_skill")]
    public long Skillpoints_in_skill { get; init; }

    /// <summary>
    ///     trained_skill_level integer
    /// </summary>

    [JsonPropertyName("trained_skill_level")]
    public int Trained_skill_level { get; init; }
}