using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_mail_mail_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_mail_mail_id_ok(string? @body, int? @from, IList<int>? @labels, bool? @read, IList<Recipients3>? @recipients, string? @subject, System.DateTimeOffset? @timestamp)

        {

            this.Body = @body;

            this.From = @from;

            this.Labels = @labels;

            this.Read = @read;

            this.Recipients = @recipients;

            this.Subject = @subject;

            this.Timestamp = @timestamp;

        }    /// <summary>
        /// Mail's body
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; init; }

        /// <summary>
        /// From whom the mail was sent
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("from")]
        public int? From { get; init; }

        /// <summary>
        /// Labels attached to the mail
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labels")]
        public IList<int>? Labels { get; init; }

        /// <summary>
        /// Whether the mail is flagged as read
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("read")]
        public bool? Read { get; init; }

        /// <summary>
        /// Recipients of the mail
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("recipients")]
        public IList<Recipients3>? Recipients { get; init; }

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
