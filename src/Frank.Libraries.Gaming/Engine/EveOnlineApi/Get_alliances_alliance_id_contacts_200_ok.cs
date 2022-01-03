using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_alliances_alliance_id_contacts_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_alliances_alliance_id_contacts_200_ok(int @contact_id, Get_alliances_alliance_id_contacts_200_okContact_type @contact_type, IList<long>? @label_ids, float @standing)

        {

            this.Contact_id = @contact_id;

            this.Contact_type = @contact_type;

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
        public Get_alliances_alliance_id_contacts_200_okContact_type Contact_type { get; init; }

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
