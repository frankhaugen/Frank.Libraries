using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_groups_group_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_groups_group_id_ok(int @category_id, int @group_id, string @name, bool @published, IList<int> @types)

        {

            this.Category_id = @category_id;

            this.Group_id = @group_id;

            this.Name = @name;

            this.Published = @published;

            this.Types = @types;

        }    /// <summary>
        /// category_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public int Category_id { get; init; }

        /// <summary>
        /// group_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public int Group_id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published")]
        public bool Published { get; init; }

        /// <summary>
        /// types array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("types")]
        public IList<int> Types { get; init; }

    }
