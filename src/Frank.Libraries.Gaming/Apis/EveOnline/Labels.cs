using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     label object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Labels
{
    [JsonConstructor]
    public Labels(LabelsColor? color, int? label_id, string? name, int? unread_count)

    {
        Color = color;

        Label_id = label_id;

        Name = name;

        Unread_count = unread_count;
    }

    /// <summary>
    ///     color string
    /// </summary>

    [JsonPropertyName("color")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LabelsColor? Color { get; init; }

    /// <summary>
    ///     label_id integer
    /// </summary>

    [JsonPropertyName("label_id")]
    public int? Label_id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    ///     unread_count integer
    /// </summary>

    [JsonPropertyName("unread_count")]
    public int? Unread_count { get; init; }
}