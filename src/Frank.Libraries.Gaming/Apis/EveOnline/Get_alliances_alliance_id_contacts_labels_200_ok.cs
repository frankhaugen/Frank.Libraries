using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_alliances_alliance_id_contacts_labels_200_ok
{
    [JsonConstructor]
    public Get_alliances_alliance_id_contacts_labels_200_ok(long label_id, string label_name)

    {
        Label_id = label_id;

        Label_name = label_name;
    }

    /// <summary>
    ///     label_id integer
    /// </summary>

    [JsonPropertyName("label_id")]
    public long Label_id { get; init; }

    /// <summary>
    ///     label_name string
    /// </summary>

    [JsonPropertyName("label_name")]
    public string Label_name { get; init; }
}