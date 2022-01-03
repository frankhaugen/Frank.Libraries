using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_medals_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_medals_200_ok(int @corporation_id, System.DateTimeOffset @date, string @description, IList<Graphics> @graphics, int @issuer_id, int @medal_id, string @reason, Get_characters_character_id_medals_200_okStatus @status, string @title)

        {

            this.Corporation_id = @corporation_id;

            this.Date = @date;

            this.Description = @description;

            this.Graphics = @graphics;

            this.Issuer_id = @issuer_id;

            this.Medal_id = @medal_id;

            this.Reason = @reason;

            this.Status = @status;

            this.Title = @title;

        }    /// <summary>
        /// corporation_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int Corporation_id { get; init; }

        /// <summary>
        /// date string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public System.DateTimeOffset Date { get; init; }

        /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// graphics array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("graphics")]
        public IList<Graphics> Graphics { get; init; }

        /// <summary>
        /// issuer_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issuer_id")]
        public int Issuer_id { get; init; }

        /// <summary>
        /// medal_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("medal_id")]
        public int Medal_id { get; init; }

        /// <summary>
        /// reason string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; init; }

        /// <summary>
        /// status string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_medals_200_okStatus Status { get; init; }

        /// <summary>
        /// title string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; init; }

    }
