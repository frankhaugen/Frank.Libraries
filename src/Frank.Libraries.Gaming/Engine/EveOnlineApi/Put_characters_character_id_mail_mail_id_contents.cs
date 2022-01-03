using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// contents object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Put_characters_character_id_mail_mail_id_contents
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Put_characters_character_id_mail_mail_id_contents(IList<int>? @labels, bool? @read)

        {

            this.Labels = @labels;

            this.Read = @read;

        }    /// <summary>
        /// Labels to assign to the mail. Pre-existing labels are unassigned.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("labels")]
        public IList<int>? Labels { get; init; }

        /// <summary>
        /// Whether the mail is flagged as read
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("read")]
        public bool? Read { get; init; }

    }
