using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     new_mail object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Post_ui_openwindow_newmail_new_mail
{
    [JsonConstructor]
    public Post_ui_openwindow_newmail_new_mail(string body, IList<int> recipients, string subject, int? to_corp_or_alliance_id, int? to_mailing_list_id)

    {
        Body = body;

        Recipients = recipients;

        Subject = subject;

        To_corp_or_alliance_id = to_corp_or_alliance_id;

        To_mailing_list_id = to_mailing_list_id;
    }

    /// <summary>
    ///     body string
    /// </summary>

    [JsonPropertyName("body")]
    public string Body { get; init; }

    /// <summary>
    ///     recipients array
    /// </summary>

    [JsonPropertyName("recipients")]
    public IList<int> Recipients { get; init; }

    /// <summary>
    ///     subject string
    /// </summary>

    [JsonPropertyName("subject")]
    public string Subject { get; init; }

    /// <summary>
    ///     to_corp_or_alliance_id integer
    /// </summary>

    [JsonPropertyName("to_corp_or_alliance_id")]
    public int? To_corp_or_alliance_id { get; init; }

    /// <summary>
    ///     Corporations, alliances and mailing lists are all types of mailing groups. You may only send to one mailing group,
    ///     at a time, so you may fill out either this field or the to_corp_or_alliance_ids field
    /// </summary>

    [JsonPropertyName("to_mailing_list_id")]
    public int? To_mailing_list_id { get; init; }
}