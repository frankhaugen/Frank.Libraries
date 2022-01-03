namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Post_corporations_corporation_id_assets_names_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Post_corporations_corporation_id_assets_names_200_ok(long @item_id, string @name)

        {

            this.Item_id = @item_id;

            this.Name = @name;

        }    /// <summary>
        /// item_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public long Item_id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

    }
