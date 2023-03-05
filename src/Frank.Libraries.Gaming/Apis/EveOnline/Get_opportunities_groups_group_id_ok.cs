using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_opportunities_groups_group_id_ok
{
    [JsonConstructor]
    public Get_opportunities_groups_group_id_ok(IList<int> connected_groups, string description, int group_id, string name, string notification, IList<int> required_tasks)

    {
        Connected_groups = connected_groups;

        Description = description;

        Group_id = group_id;

        Name = name;

        Notification = notification;

        Required_tasks = required_tasks;
    }

    /// <summary>
    ///     The groups that are connected to this group on the opportunities map
    /// </summary>

    [JsonPropertyName("connected_groups")]
    public IList<int> Connected_groups { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    ///     group_id integer
    /// </summary>

    [JsonPropertyName("group_id")]
    public int Group_id { get; init; }

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
    ///     Tasks need to complete for this group
    /// </summary>

    [JsonPropertyName("required_tasks")]
    public IList<int> Required_tasks { get; init; }
}