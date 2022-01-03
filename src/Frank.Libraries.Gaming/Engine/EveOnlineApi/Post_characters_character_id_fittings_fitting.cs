using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// fitting object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Post_characters_character_id_fittings_fitting
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Post_characters_character_id_fittings_fitting(string @description, IList<Items> @items, string @name, int @ship_type_id)

        {

            this.Description = @description;

            this.Items = @items;

            this.Name = @name;

            this.Ship_type_id = @ship_type_id;

        }    /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// items array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public IList<Items> Items { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ship_type_id")]
        public int Ship_type_id { get; init; }

    }
