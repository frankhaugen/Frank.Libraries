using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_planets_planet_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_planets_planet_id_ok(IList<Links> @links, IList<Pins> @pins, IList<Routes> @routes)

        {

            this.Links = @links;

            this.Pins = @pins;

            this.Routes = @routes;

        }    /// <summary>
        /// links array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("links")]
        public IList<Links> Links { get; init; }

        /// <summary>
        /// pins array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pins")]
        public IList<Pins> Pins { get; init; }

        /// <summary>
        /// routes array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("routes")]
        public IList<Routes> Routes { get; init; }

    }
