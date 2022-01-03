using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// new_mail object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Post_ui_openwindow_newmail_new_mail
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Post_ui_openwindow_newmail_new_mail(string @body, IList<int> @recipients, string @subject, int? @to_corp_or_alliance_id, int? @to_mailing_list_id)

        {

            this.Body = @body;

            this.Recipients = @recipients;

            this.Subject = @subject;

            this.To_corp_or_alliance_id = @to_corp_or_alliance_id;

            this.To_mailing_list_id = @to_mailing_list_id;

        }    /// <summary>
        /// body string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public string Body { get; init; }

        /// <summary>
        /// recipients array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("recipients")]
        public IList<int> Recipients { get; init; }

        /// <summary>
        /// subject string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string Subject { get; init; }

        /// <summary>
        /// to_corp_or_alliance_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("to_corp_or_alliance_id")]
        public int? To_corp_or_alliance_id { get; init; }

        /// <summary>
        /// Corporations, alliances and mailing lists are all types of mailing groups. You may only send to one mailing group, at a time, so you may fill out either this field or the to_corp_or_alliance_ids field
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("to_mailing_list_id")]
        public int? To_mailing_list_id { get; init; }

    }
