using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_skills_ok
{
    [JsonConstructor]
    public Get_characters_character_id_skills_ok(IList<Skills> skills, long total_sp, int? unallocated_sp)

    {
        Skills = skills;

        Total_sp = total_sp;

        Unallocated_sp = unallocated_sp;
    }

    /// <summary>
    ///     skills array
    /// </summary>

    [JsonPropertyName("skills")]
    public IList<Skills> Skills { get; init; }

    /// <summary>
    ///     total_sp integer
    /// </summary>

    [JsonPropertyName("total_sp")]
    public long Total_sp { get; init; }

    /// <summary>
    ///     Skill points available to be assigned
    /// </summary>

    [JsonPropertyName("unallocated_sp")]
    public int? Unallocated_sp { get; init; }
}