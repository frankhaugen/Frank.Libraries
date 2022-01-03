using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_mail_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_mail_200_ok(int? @from, bool? @is_read, IList<int>? @labels, int? @mail_id, IList<Recipients2>? @recipients, string? @subject, System.DateTimeOffset? @timestamp)

        {

            this.From = @from;

            this.Is_read = @is_read;

            this.Labels = @labels;

            this.Mail_id = @mail_id;

            this.Recipients = @recipients;

            this.Subject = @subject;

            this.Timestamp = @timestamp;

        }    /// <summary>
        /// From whom the mail was sent
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("from")]
        public int? From { get; init; }

        /// <summary>
        /// is_read boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_read")]
        public bool? Is_read { get; init; }

        /// <summary>
        /// labels array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labels")]
        public IList<int>? Labels { get; init; }

        /// <summary>
        /// mail_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("mail_id")]
        public int? Mail_id { get; init; }

        /// <summary>
        /// Recipients of the mail
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("recipients")]
        public IList<Recipients2>? Recipients { get; init; }

        /// <summary>
        /// Mail subject
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; init; }

        /// <summary>
        /// When the mail was sent
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public System.DateTimeOffset? Timestamp { get; init; }

    }
