using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_markets_groups_market_group_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_markets_groups_market_group_id_ok(string @description, int @market_group_id, string @name, int? @parent_group_id, IList<int> @types)

        {

            this.Description = @description;

            this.Market_group_id = @market_group_id;

            this.Name = @name;

            this.Parent_group_id = @parent_group_id;

            this.Types = @types;

        }    /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// market_group_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("market_group_id")]
        public int Market_group_id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// parent_group_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("parent_group_id")]
        public int? Parent_group_id { get; init; }

        /// <summary>
        /// types array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("types")]
        public IList<int> Types { get; init; }

    }
