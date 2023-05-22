using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     label object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Post_characters_character_id_mail_labels_label
{
    [JsonConstructor]
    public Post_characters_character_id_mail_labels_label(Post_characters_character_id_mail_labels_labelColor? color, string name)

    {
        Color = color;

        Name = name;
    }

    /// <summary>
    ///     Hexadecimal string representing label color, in RGB format
    /// </summary>

    [JsonPropertyName("color")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Post_characters_character_id_mail_labels_labelColor? Color { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }
}