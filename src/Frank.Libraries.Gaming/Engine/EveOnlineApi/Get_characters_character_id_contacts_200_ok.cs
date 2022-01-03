using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_contacts_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_contacts_200_ok(int @contact_id, Get_characters_character_id_contacts_200_okContact_type @contact_type, bool? @is_blocked, bool? @is_watched, IList<long>? @label_ids, float @standing)

        {

            this.Contact_id = @contact_id;

            this.Contact_type = @contact_type;

            this.Is_blocked = @is_blocked;

            this.Is_watched = @is_watched;

            this.Label_ids = @label_ids;

            this.Standing = @standing;

        }    /// <summary>
        /// contact_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("contact_id")]
        public int Contact_id { get; init; }

        /// <summary>
        /// contact_type string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("contact_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_contacts_200_okContact_type Contact_type { get; init; }

        /// <summary>
        /// Whether this contact is in the blocked list. Note a missing value denotes unknown, not true or false
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_blocked")]
        public bool? Is_blocked { get; init; }

        /// <summary>
        /// Whether this contact is being watched
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_watched")]
        public bool? Is_watched { get; init; }

        /// <summary>
        /// label_ids array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("label_ids")]
        public IList<long>? Label_ids { get; init; }

        /// <summary>
        /// Standing of the contact
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("standing")]
        public float Standing { get; init; }

    }
