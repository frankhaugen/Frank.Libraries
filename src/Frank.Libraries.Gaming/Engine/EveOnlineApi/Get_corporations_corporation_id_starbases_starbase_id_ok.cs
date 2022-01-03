using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_starbases_starbase_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_starbases_starbase_id_ok(bool @allow_alliance_members, bool @allow_corporation_members, Get_corporations_corporation_id_starbases_starbase_id_okAnchor @anchor, bool @attack_if_at_war, bool @attack_if_other_security_status_dropping, float? @attack_security_status_threshold, float? @attack_standing_threshold, Get_corporations_corporation_id_starbases_starbase_id_okFuel_bay_take @fuel_bay_take, Get_corporations_corporation_id_starbases_starbase_id_okFuel_bay_view @fuel_bay_view, IList<Fuels>? @fuels, Get_corporations_corporation_id_starbases_starbase_id_okOffline @offline, Get_corporations_corporation_id_starbases_starbase_id_okOnline @online, Get_corporations_corporation_id_starbases_starbase_id_okUnanchor @unanchor, bool @use_alliance_standings)

        {

            this.Allow_alliance_members = @allow_alliance_members;

            this.Allow_corporation_members = @allow_corporation_members;

            this.Anchor = @anchor;

            this.Attack_if_at_war = @attack_if_at_war;

            this.Attack_if_other_security_status_dropping = @attack_if_other_security_status_dropping;

            this.Attack_security_status_threshold = @attack_security_status_threshold;

            this.Attack_standing_threshold = @attack_standing_threshold;

            this.Fuel_bay_take = @fuel_bay_take;

            this.Fuel_bay_view = @fuel_bay_view;

            this.Fuels = @fuels;

            this.Offline = @offline;

            this.Online = @online;

            this.Unanchor = @unanchor;

            this.Use_alliance_standings = @use_alliance_standings;

        }    /// <summary>
        /// allow_alliance_members boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("allow_alliance_members")]
        public bool Allow_alliance_members { get; init; }

        /// <summary>
        /// allow_corporation_members boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("allow_corporation_members")]
        public bool Allow_corporation_members { get; init; }

        /// <summary>
        /// Who can anchor starbase (POS) and its structures
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("anchor")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_starbases_starbase_id_okAnchor Anchor { get; init; }

        /// <summary>
        /// attack_if_at_war boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("attack_if_at_war")]
        public bool Attack_if_at_war { get; init; }

        /// <summary>
        /// attack_if_other_security_status_dropping boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("attack_if_other_security_status_dropping")]
        public bool Attack_if_other_security_status_dropping { get; init; }

        /// <summary>
        /// Starbase (POS) will attack if target's security standing is lower than this value
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("attack_security_status_threshold")]
        public float? Attack_security_status_threshold { get; init; }

        /// <summary>
        /// Starbase (POS) will attack if target's standing is lower than this value
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("attack_standing_threshold")]
        public float? Attack_standing_threshold { get; init; }

        /// <summary>
        /// Who can take fuel blocks out of the starbase (POS)'s fuel bay
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fuel_bay_take")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_starbases_starbase_id_okFuel_bay_take Fuel_bay_take { get; init; }

        /// <summary>
        /// Who can view the starbase (POS)'s fule bay. Characters either need to have required role or belong to the starbase (POS) owner's corporation or alliance, as described by the enum, all other access settings follows the same scheme
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fuel_bay_view")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_starbases_starbase_id_okFuel_bay_view Fuel_bay_view { get; init; }

        /// <summary>
        /// Fuel blocks and other things that will be consumed when operating a starbase (POS)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fuels")]
        public IList<Fuels>? Fuels { get; init; }

        /// <summary>
        /// Who can offline starbase (POS) and its structures
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("offline")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_starbases_starbase_id_okOffline Offline { get; init; }

        /// <summary>
        /// Who can online starbase (POS) and its structures
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("online")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_starbases_starbase_id_okOnline Online { get; init; }

        /// <summary>
        /// Who can unanchor starbase (POS) and its structures
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unanchor")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_starbases_starbase_id_okUnanchor Unanchor { get; init; }

        /// <summary>
        /// True if the starbase (POS) is using alliance standings, otherwise using corporation's
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("use_alliance_standings")]
        public bool Use_alliance_standings { get; init; }

    }
