using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_wars_war_id_ok
{
    [JsonConstructor]
    public Get_wars_war_id_ok(Aggressor aggressor, IList<Allies>? allies, DateTimeOffset declared, Defender defender, DateTimeOffset? finished, int id, bool mutual, bool open_for_allies, DateTimeOffset? retracted, DateTimeOffset? started)

    {
        Aggressor = aggressor;

        Allies = allies;

        Declared = declared;

        Defender = defender;

        Finished = finished;

        Id = id;

        Mutual = mutual;

        Open_for_allies = open_for_allies;

        Retracted = retracted;

        Started = started;
    }

    /// <summary>
    ///     The aggressor corporation or alliance that declared this war, only contains either corporation_id or alliance_id
    /// </summary>

    [JsonPropertyName("aggressor")]
    public Aggressor Aggressor { get; init; }

    /// <summary>
    ///     allied corporations or alliances, each object contains either corporation_id or alliance_id
    /// </summary>

    [JsonPropertyName("allies")]
    public IList<Allies>? Allies { get; init; }

    /// <summary>
    ///     Time that the war was declared
    /// </summary>

    [JsonPropertyName("declared")]
    public DateTimeOffset Declared { get; init; }

    /// <summary>
    ///     The defending corporation or alliance that declared this war, only contains either corporation_id or alliance_id
    /// </summary>

    [JsonPropertyName("defender")]
    public Defender Defender { get; init; }

    /// <summary>
    ///     Time the war ended and shooting was no longer allowed
    /// </summary>

    [JsonPropertyName("finished")]
    public DateTimeOffset? Finished { get; init; }

    /// <summary>
    ///     ID of the specified war
    /// </summary>

    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    ///     Was the war declared mutual by both parties
    /// </summary>

    [JsonPropertyName("mutual")]
    public bool Mutual { get; init; }

    /// <summary>
    ///     Is the war currently open for allies or not
    /// </summary>

    [JsonPropertyName("open_for_allies")]
    public bool Open_for_allies { get; init; }

    /// <summary>
    ///     Time the war was retracted but both sides could still shoot each other
    /// </summary>

    [JsonPropertyName("retracted")]
    public DateTimeOffset? Retracted { get; init; }

    /// <summary>
    ///     Time when the war started and both sides could shoot each other
    /// </summary>

    [JsonPropertyName("started")]
    public DateTimeOffset? Started { get; init; }
}