using System.Collections.Generic;

namespace EveOnlineApi;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Victory_points4
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Victory_points4(IList<Active_total4> @active_total, IList<Last_week4> @last_week, IList<Yesterday4> @yesterday)

        {

            this.Active_total = @active_total;

            this.Last_week = @last_week;

            this.Yesterday = @yesterday;

        }    /// <summary>
        /// Top 100 ranking of pilots active in faction warfare by total victory points. A pilot is considered "active" if they have participated in faction warfare in the past 14 days
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("active_total")]
        public IList<Active_total4> Active_total { get; init; }

        /// <summary>
        /// Top 100 ranking of pilots by victory points in the past week
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_week")]
        public IList<Last_week4> Last_week { get; init; }

        /// <summary>
        /// Top 100 ranking of pilots by victory points in the past day
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("yesterday")]
        public IList<Yesterday4> Yesterday { get; init; }

    }
