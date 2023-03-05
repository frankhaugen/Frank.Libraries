using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     mail object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Post_characters_character_id_mail_mail
{
    [JsonConstructor]
    public Post_characters_character_id_mail_mail(long? approved_cost, string body, IList<Recipients> recipients, string subject)

    {
        Approved_cost = approved_cost;

        Body = body;

        Recipients = recipients;

        Subject = subject;
    }

    /// <summary>
    ///     approved_cost integer
    /// </summary>

    [JsonPropertyName("approved_cost")]
    public long? Approved_cost { get; init; }

    /// <summary>
    ///     body string
    /// </summary>

    [JsonPropertyName("body")]
    public string Body { get; init; }

    /// <summary>
    ///     recipients array
    /// </summary>

    [JsonPropertyName("recipients")]
    public IList<Recipients> Recipients { get; init; }

    /// <summary>
    ///     subject string
    /// </summary>

    [JsonPropertyName("subject")]
    public string Subject { get; init; }
}