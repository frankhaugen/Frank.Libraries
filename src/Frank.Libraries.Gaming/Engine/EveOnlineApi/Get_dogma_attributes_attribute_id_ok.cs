namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_dogma_attributes_attribute_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_dogma_attributes_attribute_id_ok(int @attribute_id, float? @default_value, string? @description, string? @display_name, bool? @high_is_good, int? @icon_id, string? @name, bool? @published, bool? @stackable, int? @unit_id)

        {

            this.Attribute_id = @attribute_id;

            this.Default_value = @default_value;

            this.Description = @description;

            this.Display_name = @display_name;

            this.High_is_good = @high_is_good;

            this.Icon_id = @icon_id;

            this.Name = @name;

            this.Published = @published;

            this.Stackable = @stackable;

            this.Unit_id = @unit_id;

        }    /// <summary>
        /// attribute_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("attribute_id")]
        public int Attribute_id { get; init; }

        /// <summary>
        /// default_value number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("default_value")]
        public float? Default_value { get; init; }

        /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// display_name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? Display_name { get; init; }

        /// <summary>
        /// high_is_good boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("high_is_good")]
        public bool? High_is_good { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("icon_id")]
        public int? Icon_id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published")]
        public bool? Published { get; init; }

        /// <summary>
        /// stackable boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("stackable")]
        public bool? Stackable { get; init; }

        /// <summary>
        /// unit_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unit_id")]
        public int? Unit_id { get; init; }

    }
