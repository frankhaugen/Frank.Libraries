using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// mail object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Post_characters_character_id_mail_mail
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Post_characters_character_id_mail_mail(long? @approved_cost, string @body, IList<Recipients> @recipients, string @subject)

        {

            this.Approved_cost = @approved_cost;

            this.Body = @body;

            this.Recipients = @recipients;

            this.Subject = @subject;

        }    /// <summary>
        /// approved_cost integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("approved_cost")]
        public long? Approved_cost { get; init; }

        /// <summary>
        /// body string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public string Body { get; init; }

        /// <summary>
        /// recipients array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("recipients")]
        public IList<Recipients> Recipients { get; init; }

        /// <summary>
        /// subject string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string Subject { get; init; }

    }
