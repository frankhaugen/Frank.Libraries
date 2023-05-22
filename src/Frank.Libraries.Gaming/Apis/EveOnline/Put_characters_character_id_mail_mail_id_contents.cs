using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     contents object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Put_characters_character_id_mail_mail_id_contents
{
    [JsonConstructor]
    public Put_characters_character_id_mail_mail_id_contents(IList<int>? labels, bool? read)

    {
        Labels = labels;

        Read = read;
    }

    /// <summary>
    ///     Labels to assign to the mail. Pre-existing labels are unassigned.
    /// </summary>

    [JsonPropertyName("labels")]
    public IList<int>? Labels { get; init; }

    /// <summary>
    ///     Whether the mail is flagged as read
    /// </summary>

    [JsonPropertyName("read")]
    public bool? Read { get; init; }
}