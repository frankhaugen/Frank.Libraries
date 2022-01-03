using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_members_titles_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_members_titles_200_ok(int @character_id, IList<int> @titles)

        {

            this.Character_id = @character_id;

            this.Titles = @titles;

        }    /// <summary>
        /// character_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character_id")]
        public int Character_id { get; init; }

        /// <summary>
        /// A list of title_id
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("titles")]
        public IList<int> Titles { get; init; }

    }
