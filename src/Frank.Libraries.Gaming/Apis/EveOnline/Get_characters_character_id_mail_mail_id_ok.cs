using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_mail_mail_id_ok
{
    [JsonConstructor]
    public Get_characters_character_id_mail_mail_id_ok(string? body, int? from, IList<int>? labels, bool? read, IList<Recipients3>? recipients, string? subject, DateTimeOffset? timestamp)

    {
        Body = body;

        From = from;

        Labels = labels;

        Read = read;

        Recipients = recipients;

        Subject = subject;

        Timestamp = timestamp;
    }

    /// <summary>
    ///     Mail's body
    /// </summary>

    [JsonPropertyName("body")]
    public string? Body { get; init; }

    /// <summary>
    ///     From whom the mail was sent
    /// </summary>

    [JsonPropertyName("from")]
    public int? From { get; init; }

    /// <summary>
    ///     Labels attached to the mail
    /// </summary>

    [JsonPropertyName("labels")]
    public IList<int>? Labels { get; init; }

    /// <summary>
    ///     Whether the mail is flagged as read
    /// </summary>

    [JsonPropertyName("read")]
    public bool? Read { get; init; }

    /// <summary>
    ///     Recipients of the mail
    /// </summary>

    [JsonPropertyName("recipients")]
    public IList<Recipients3>? Recipients { get; init; }

    /// <summary>
    ///     Mail subject
    /// </summary>

    [JsonPropertyName("subject")]
    public string? Subject { get; init; }

    /// <summary>
    ///     When the mail was sent
    /// </summary>

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; init; }
}