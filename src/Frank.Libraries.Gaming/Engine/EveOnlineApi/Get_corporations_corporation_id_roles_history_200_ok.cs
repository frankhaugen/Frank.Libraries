using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_roles_history_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_roles_history_200_ok(System.DateTimeOffset @changed_at, int @character_id, int @issuer_id, IList<New_roles> @new_roles, IList<Old_roles> @old_roles, Get_corporations_corporation_id_roles_history_200_okRole_type @role_type)

        {

            this.Changed_at = @changed_at;

            this.Character_id = @character_id;

            this.Issuer_id = @issuer_id;

            this.New_roles = @new_roles;

            this.Old_roles = @old_roles;

            this.Role_type = @role_type;

        }    /// <summary>
        /// changed_at string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("changed_at")]
        public System.DateTimeOffset Changed_at { get; init; }

        /// <summary>
        /// The character whose roles are changed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character_id")]
        public int Character_id { get; init; }

        /// <summary>
        /// ID of the character who issued this change
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issuer_id")]
        public int Issuer_id { get; init; }

        /// <summary>
        /// new_roles array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("new_roles")]

        // (system.text.json): Add string enum item converter
        public IList<New_roles> New_roles { get; init; }

        /// <summary>
        /// old_roles array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("old_roles")]

        // (system.text.json): Add string enum item converter
        public IList<Old_roles> Old_roles { get; init; }

        /// <summary>
        /// role_type string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("role_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_roles_history_200_okRole_type Role_type { get; init; }

    }
