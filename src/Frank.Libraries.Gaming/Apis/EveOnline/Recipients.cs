using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     recipient object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Recipients
{
    [JsonConstructor]
    public Recipients(int recipient_id, RecipientsRecipient_type recipient_type)

    {
        Recipient_id = recipient_id;

        Recipient_type = recipient_type;
    }

    /// <summary>
    ///     recipient_id integer
    /// </summary>

    [JsonPropertyName("recipient_id")]
    public int Recipient_id { get; init; }

    /// <summary>
    ///     recipient_type string
    /// </summary>

    [JsonPropertyName("recipient_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public RecipientsRecipient_type Recipient_type { get; init; }
}