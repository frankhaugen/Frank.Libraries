using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_mail_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_mail_200_ok(int? from, bool? is_read, IList<int>? labels, int? mail_id, IList<Recipients2>? recipients, string? subject, DateTimeOffset? timestamp)

    {
        From = from;

        Is_read = is_read;

        Labels = labels;

        Mail_id = mail_id;

        Recipients = recipients;

        Subject = subject;

        Timestamp = timestamp;
    }

    /// <summary>
    ///     From whom the mail was sent
    /// </summary>

    [JsonPropertyName("from")]
    public int? From { get; init; }

    /// <summary>
    ///     is_read boolean
    /// </summary>

    [JsonPropertyName("is_read")]
    public bool? Is_read { get; init; }

    /// <summary>
    ///     labels array
    /// </summary>

    [JsonPropertyName("labels")]
    public IList<int>? Labels { get; init; }

    /// <summary>
    ///     mail_id integer
    /// </summary>

    [JsonPropertyName("mail_id")]
    public int? Mail_id { get; init; }

    /// <summary>
    ///     Recipients of the mail
    /// </summary>

    [JsonPropertyName("recipients")]
    public IList<Recipients2>? Recipients { get; init; }

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