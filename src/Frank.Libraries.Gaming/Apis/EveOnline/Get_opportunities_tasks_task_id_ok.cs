using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_opportunities_tasks_task_id_ok
{
    [JsonConstructor]
    public Get_opportunities_tasks_task_id_ok(string description, string name, string notification, int task_id)

    {
        Description = description;

        Name = name;

        Notification = notification;

        Task_id = task_id;
    }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     notification string
    /// </summary>

    [JsonPropertyName("notification")]
    public string Notification { get; init; }

    /// <summary>
    ///     task_id integer
    /// </summary>

    [JsonPropertyName("task_id")]
    public int Task_id { get; init; }
}