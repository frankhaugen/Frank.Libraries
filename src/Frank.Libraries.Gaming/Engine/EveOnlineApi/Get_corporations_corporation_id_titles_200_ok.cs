using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_titles_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_titles_200_ok(IList<Grantable_roles2>? @grantable_roles, IList<Grantable_roles_at_base2>? @grantable_roles_at_base, IList<Grantable_roles_at_hq2>? @grantable_roles_at_hq, IList<Grantable_roles_at_other2>? @grantable_roles_at_other, string? @name, IList<Roles3>? @roles, IList<Roles_at_base3>? @roles_at_base, IList<Roles_at_hq3>? @roles_at_hq, IList<Roles_at_other3>? @roles_at_other, int? @title_id)

        {

            this.Grantable_roles = @grantable_roles;

            this.Grantable_roles_at_base = @grantable_roles_at_base;

            this.Grantable_roles_at_hq = @grantable_roles_at_hq;

            this.Grantable_roles_at_other = @grantable_roles_at_other;

            this.Name = @name;

            this.Roles = @roles;

            this.Roles_at_base = @roles_at_base;

            this.Roles_at_hq = @roles_at_hq;

            this.Roles_at_other = @roles_at_other;

            this.Title_id = @title_id;

        }    /// <summary>
        /// grantable_roles array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("grantable_roles")]

        // (system.text.json): Add string enum item converter
        public IList<Grantable_roles2>? Grantable_roles { get; init; }

        /// <summary>
        /// grantable_roles_at_base array
        /// </summary

        [System.Text.Json.Serialization.JsonPropertyName("grantable_roles_at_base")]

        // (system.text.json): Add string enum item converter
        public IList<Grantable_roles_at_base2>? Grantable_roles_at_base { get; init; }

        /// <summary>
        /// grantable_roles_at_hq array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("grantable_roles_at_hq")]

        // (system.text.json): Add string enum item converter
        public IList<Grantable_roles_at_hq2>? Grantable_roles_at_hq { get; init; }

        /// <summary>
        /// grantable_roles_at_other array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("grantable_roles_at_other")]

        // (system.text.json): Add string enum item converter
        public IList<Grantable_roles_at_other2>? Grantable_roles_at_other { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// roles array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("roles")]

        // (system.text.json): Add string enum item converter
        public IList<Roles3>? Roles { get; init; }

        /// <summary>
        /// roles_at_base array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("roles_at_base")]

        // (system.text.json): Add string enum item converter
        public IList<Roles_at_base3>? Roles_at_base { get; init; }

        /// <summary>
        /// roles_at_hq array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("roles_at_hq")]

        // (system.text.json): Add string enum item converter
        public IList<Roles_at_hq3>? Roles_at_hq { get; init; }

        /// <summary>
        /// roles_at_other array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("roles_at_other")]

        // (system.text.json): Add string enum item converter
        public IList<Roles_at_other3>? Roles_at_other { get; init; }

        /// <summary>
        /// title_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title_id")]
        public int? Title_id { get; init; }

    }
