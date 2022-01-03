namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_bookmarks_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_bookmarks_200_ok(int @bookmark_id, Coordinates? @coordinates, System.DateTimeOffset @created, int @creator_id, int? @folder_id, Item? @item, string @label, int @location_id, string @notes)

        {

            this.Bookmark_id = @bookmark_id;

            this.Coordinates = @coordinates;

            this.Created = @created;

            this.Creator_id = @creator_id;

            this.Folder_id = @folder_id;

            this.Item = @item;

            this.Label = @label;

            this.Location_id = @location_id;

            this.Notes = @notes;

        }    /// <summary>
        /// bookmark_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("bookmark_id")]
        public int Bookmark_id { get; init; }

        /// <summary>
        /// Optional object that is returned if a bookmark was made on a planet or a random location in space.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("coordinates")]
        public Coordinates? Coordinates { get; init; }

        /// <summary>
        /// created string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("created")]
        public System.DateTimeOffset Created { get; init; }

        /// <summary>
        /// creator_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        public int Creator_id { get; init; }

        /// <summary>
        /// folder_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? Folder_id { get; init; }

        /// <summary>
        /// Optional object that is returned if a bookmark was made on a particular item.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Item? Item { get; init; }

        /// <summary>
        /// label string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("label")]
        public string Label { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public int Location_id { get; init; }

        /// <summary>
        /// notes string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string Notes { get; init; }

    }
