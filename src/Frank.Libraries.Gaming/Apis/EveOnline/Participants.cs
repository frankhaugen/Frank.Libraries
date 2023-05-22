using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     participant object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Participants
{
    [JsonConstructor]
    public Participants(int alliance_id, float score)

    {
        Alliance_id = alliance_id;

        Score = score;
    }

    /// <summary>
    ///     alliance_id integer
    /// </summary>

    [JsonPropertyName("alliance_id")]
    public int Alliance_id { get; init; }

    /// <summary>
    ///     score number
    /// </summary>

    [JsonPropertyName("score")]
    public float Score { get; init; }
}