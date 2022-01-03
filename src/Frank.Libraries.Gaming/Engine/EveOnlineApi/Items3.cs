using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// item object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Items3
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Items3(int @flag, int @item_type_id, IList<Items4>? @items, long? @quantity_destroyed, long? @quantity_dropped, int @singleton)

        {

            this.Flag = @flag;

            this.Item_type_id = @item_type_id;

            this.Items = @items;

            this.Quantity_destroyed = @quantity_destroyed;

            this.Quantity_dropped = @quantity_dropped;

            this.Singleton = @singleton;

        }    /// <summary>
        /// Flag for the location of the item
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("flag")]
        public int Flag { get; init; }

        /// <summary>
        /// item_type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("item_type_id")]
        public int Item_type_id { get; init; }

        /// <summary>
        /// items array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public IList<Items4>? Items { get; init; }

        /// <summary>
        /// How many of the item were destroyed if any
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity_destroyed")]
        public long? Quantity_destroyed { get; init; }

        /// <summary>
        /// How many of the item were dropped if any
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity_dropped")]
        public long? Quantity_dropped { get; init; }

        /// <summary>
        /// singleton integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("singleton")]
        public int Singleton { get; init; }

    }
