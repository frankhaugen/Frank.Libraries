namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_graphics_graphic_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_graphics_graphic_id_ok(string? @collision_file, string? @graphic_file, int @graphic_id, string? @icon_folder, string? @sof_dna, string? @sof_fation_name, string? @sof_hull_name, string? @sof_race_name)

        {

            this.Collision_file = @collision_file;

            this.Graphic_file = @graphic_file;

            this.Graphic_id = @graphic_id;

            this.Icon_folder = @icon_folder;

            this.Sof_dna = @sof_dna;

            this.Sof_fation_name = @sof_fation_name;

            this.Sof_hull_name = @sof_hull_name;

            this.Sof_race_name = @sof_race_name;

        }    /// <summary>
        /// collision_file string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("collision_file")]
        public string? Collision_file { get; init; }

        /// <summary>
        /// graphic_file string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("graphic_file")]
        public string? Graphic_file { get; init; }

        /// <summary>
        /// graphic_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("graphic_id")]
        public int Graphic_id { get; init; }

        /// <summary>
        /// icon_folder string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("icon_folder")]
        public string? Icon_folder { get; init; }

        /// <summary>
        /// sof_dna string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sof_dna")]
        public string? Sof_dna { get; init; }

        /// <summary>
        /// sof_fation_name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sof_fation_name")]
        public string? Sof_fation_name { get; init; }

        /// <summary>
        /// sof_hull_name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sof_hull_name")]
        public string? Sof_hull_name { get; init; }

        /// <summary>
        /// sof_race_name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sof_race_name")]
        public string? Sof_race_name { get; init; }

    }
