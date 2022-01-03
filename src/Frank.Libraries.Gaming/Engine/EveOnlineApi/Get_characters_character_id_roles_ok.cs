using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_roles_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_roles_ok(IList<Roles>? @roles, IList<Roles_at_base>? @roles_at_base, IList<Roles_at_hq>? @roles_at_hq, IList<Roles_at_other>? @roles_at_other)

        {

            this.Roles = @roles;

            this.Roles_at_base = @roles_at_base;

            this.Roles_at_hq = @roles_at_hq;

            this.Roles_at_other = @roles_at_other;

        }    /// <summary>
        /// roles array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("roles")]

        // (system.text.json): Add string enum item converter
        public IList<Roles>? Roles { get; init; }

        /// <summary>
        /// roles_at_base array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("roles_at_base")]

        // (system.text.json): Add string enum item converter
        public IList<Roles_at_base>? Roles_at_base { get; init; }

        /// <summary>
        /// roles_at_hq array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("roles_at_hq")]

        // (system.text.json): Add string enum item converter
        public IList<Roles_at_hq>? Roles_at_hq { get; init; }

        /// <summary>
        /// roles_at_other array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("roles_at_other")]

        // (system.text.json): Add string enum item converter
        public IList<Roles_at_other>? Roles_at_other { get; init; }

    }
