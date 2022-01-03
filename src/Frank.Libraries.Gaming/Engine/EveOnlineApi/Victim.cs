using System.Collections.Generic;

namespace EveOnlineApi;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Victim
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Victim(int? @alliance_id, int? @character_id, int? @corporation_id, int @damage_taken, int? @faction_id, IList<Items3>? @items, Position11? @position, int @ship_type_id)

        {

            this.Alliance_id = @alliance_id;

            this.Character_id = @character_id;

            this.Corporation_id = @corporation_id;

            this.Damage_taken = @damage_taken;

            this.Faction_id = @faction_id;

            this.Items = @items;

            this.Position = @position;

            this.Ship_type_id = @ship_type_id;

        }    /// <summary>
        /// alliance_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int? Alliance_id { get; init; }

        /// <summary>
        /// character_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character_id")]
        public int? Character_id { get; init; }

        /// <summary>
        /// corporation_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int? Corporation_id { get; init; }

        /// <summary>
        /// How much total damage was taken by the victim
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("damage_taken")]
        public int Damage_taken { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int? Faction_id { get; init; }

        /// <summary>
        /// items array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public IList<Items3>? Items { get; init; }

        /// <summary>
        /// Coordinates of the victim in Cartesian space relative to the Sun
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        public Position11? Position { get; init; }

        /// <summary>
        /// The ship that the victim was piloting and was destroyed
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ship_type_id")]
        public int Ship_type_id { get; init; }

    }
