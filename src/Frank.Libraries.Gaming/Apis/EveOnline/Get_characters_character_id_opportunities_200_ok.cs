using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_opportunities_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_opportunities_200_ok(DateTimeOffset completed_at, int task_id)

    {
        Completed_at = completed_at;

        Task_id = task_id;
    }

    /// <summary>
    ///     completed_at string
    /// </summary>

    [JsonPropertyName("completed_at")]
    public DateTimeOffset Completed_at { get; init; }

    /// <summary>
    ///     task_id integer
    /// </summary>

    [JsonPropertyName("task_id")]
    public int Task_id { get; init; }
}