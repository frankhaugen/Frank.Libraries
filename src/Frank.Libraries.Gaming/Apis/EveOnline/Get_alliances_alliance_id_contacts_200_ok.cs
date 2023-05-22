using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_alliances_alliance_id_contacts_200_ok
{
    [JsonConstructor]
    public Get_alliances_alliance_id_contacts_200_ok(int contact_id, Get_alliances_alliance_id_contacts_200_okContact_type contact_type, IList<long>? label_ids, float standing)

    {
        Contact_id = contact_id;

        Contact_type = contact_type;

        Label_ids = label_ids;

        Standing = standing;
    }

    /// <summary>
    ///     contact_id integer
    /// </summary>

    [JsonPropertyName("contact_id")]
    public int Contact_id { get; init; }

    /// <summary>
    ///     contact_type string
    /// </summary>

    [JsonPropertyName("contact_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_alliances_alliance_id_contacts_200_okContact_type Contact_type { get; init; }

    /// <summary>
    ///     label_ids array
    /// </summary>

    [JsonPropertyName("label_ids")]
    public IList<long>? Label_ids { get; init; }

    /// <summary>
    ///     Standing of the contact
    /// </summary>

    [JsonPropertyName("standing")]
    public float Standing { get; init; }
}