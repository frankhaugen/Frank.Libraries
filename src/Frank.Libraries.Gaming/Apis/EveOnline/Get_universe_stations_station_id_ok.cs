using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_stations_station_id_ok
{
    [JsonConstructor]
    public Get_universe_stations_station_id_ok(float max_dockable_ship_volume, string name, float office_rental_cost, int? owner, Position6 position, int? race_id, float reprocessing_efficiency, float reprocessing_stations_take, IList<Services2> services, int station_id, int system_id, int type_id)

    {
        Max_dockable_ship_volume = max_dockable_ship_volume;

        Name = name;

        Office_rental_cost = office_rental_cost;

        Owner = owner;

        Position = position;

        Race_id = race_id;

        Reprocessing_efficiency = reprocessing_efficiency;

        Reprocessing_stations_take = reprocessing_stations_take;

        Services = services;

        Station_id = station_id;

        System_id = system_id;

        Type_id = type_id;
    }

    /// <summary>
    ///     max_dockable_ship_volume number
    /// </summary>

    [JsonPropertyName("max_dockable_ship_volume")]
    public float Max_dockable_ship_volume { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     office_rental_cost number
    /// </summary>

    [JsonPropertyName("office_rental_cost")]
    public float Office_rental_cost { get; init; }

    /// <summary>
    ///     ID of the corporation that controls this station
    /// </summary>

    [JsonPropertyName("owner")]
    public int? Owner { get; init; }

    /// <summary>
    ///     position object
    /// </summary>

    [JsonPropertyName("position")]
    public Position6 Position { get; init; }

    /// <summary>
    ///     race_id integer
    /// </summary>

    [JsonPropertyName("race_id")]
    public int? Race_id { get; init; }

    /// <summary>
    ///     reprocessing_efficiency number
    /// </summary>

    [JsonPropertyName("reprocessing_efficiency")]
    public float Reprocessing_efficiency { get; init; }

    /// <summary>
    ///     reprocessing_stations_take number
    /// </summary>

    [JsonPropertyName("reprocessing_stations_take")]
    public float Reprocessing_stations_take { get; init; }

    /// <summary>
    ///     services array
    /// </summary>

    [JsonPropertyName("services")]

    // (system.text.json): Add string enum item converter
    public IList<Services2> Services { get; init; }

    /// <summary>
    ///     station_id integer
    /// </summary>

    [JsonPropertyName("station_id")]
    public int Station_id { get; init; }

    /// <summary>
    ///     The solar system this station is in
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}