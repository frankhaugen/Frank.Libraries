using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_mail_labels_ok
{
    [JsonConstructor]
    public Get_characters_character_id_mail_labels_ok(IList<Labels>? labels, int? total_unread_count)

    {
        Labels = labels;

        Total_unread_count = total_unread_count;
    }

    /// <summary>
    ///     labels array
    /// </summary>

    [JsonPropertyName("labels")]
    public IList<Labels>? Labels { get; init; }

    /// <summary>
    ///     total_unread_count integer
    /// </summary>

    [JsonPropertyName("total_unread_count")]
    public int? Total_unread_count { get; init; }
}