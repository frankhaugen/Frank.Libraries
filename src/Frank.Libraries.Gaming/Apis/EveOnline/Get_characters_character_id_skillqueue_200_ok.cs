using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_skillqueue_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_skillqueue_200_ok(DateTimeOffset? finish_date, int finished_level, int? level_end_sp, int? level_start_sp, int queue_position, int skill_id, DateTimeOffset? start_date, int? training_start_sp)

    {
        Finish_date = finish_date;

        Finished_level = finished_level;

        Level_end_sp = level_end_sp;

        Level_start_sp = level_start_sp;

        Queue_position = queue_position;

        Skill_id = skill_id;

        Start_date = start_date;

        Training_start_sp = training_start_sp;
    }

    /// <summary>
    ///     Date on which training of the skill will complete. Omitted if the skill queue is paused.
    /// </summary>

    [JsonPropertyName("finish_date")]
    public DateTimeOffset? Finish_date { get; init; }

    /// <summary>
    ///     finished_level integer
    /// </summary>

    [JsonPropertyName("finished_level")]
    public int Finished_level { get; init; }

    /// <summary>
    ///     level_end_sp integer
    /// </summary>

    [JsonPropertyName("level_end_sp")]
    public int? Level_end_sp { get; init; }

    /// <summary>
    ///     Amount of SP that was in the skill when it started training it's current level. Used to calculate % of current
    ///     level complete.
    /// </summary>

    [JsonPropertyName("level_start_sp")]
    public int? Level_start_sp { get; init; }

    /// <summary>
    ///     queue_position integer
    /// </summary>

    [JsonPropertyName("queue_position")]
    public int Queue_position { get; init; }

    /// <summary>
    ///     skill_id integer
    /// </summary>

    [JsonPropertyName("skill_id")]
    public int Skill_id { get; init; }

    /// <summary>
    ///     start_date string
    /// </summary>

    [JsonPropertyName("start_date")]
    public DateTimeOffset? Start_date { get; init; }

    /// <summary>
    ///     training_start_sp integer
    /// </summary>

    [JsonPropertyName("training_start_sp")]
    public int? Training_start_sp { get; init; }
}