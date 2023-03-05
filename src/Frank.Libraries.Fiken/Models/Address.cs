using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class Address
{
    /// <summary>
    ///     Gets or Sets StreetAddress
    /// </summary>
    [DataMember(Name = "streetAddress", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "streetAddress")]
    public string StreetAddress { get; set; }

    /// <summary>
    ///     Gets or Sets StreetAddressLine2
    /// </summary>
    [DataMember(Name = "streetAddressLine2", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "streetAddressLine2")]
    public string StreetAddressLine2 { get; set; }

    /// <summary>
    ///     Gets or Sets City
    /// </summary>
    [DataMember(Name = "city", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    ///     Gets or Sets PostCode
    /// </summary>
    [DataMember(Name = "postCode", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "postCode")]
    public string PostCode { get; set; }

    /// <summary>
    ///     Gets or Sets Country
    /// </summary>
    [DataMember(Name = "country", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Address {\n");
        sb.Append("  StreetAddress: ")
          .Append(StreetAddress)
          .Append("\n");
        sb.Append("  StreetAddressLine2: ")
          .Append(StreetAddressLine2)
          .Append("\n");
        sb.Append("  City: ")
          .Append(City)
          .Append("\n");
        sb.Append("  PostCode: ")
          .Append(PostCode)
          .Append("\n");
        sb.Append("  Country: ")
          .Append(Country)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}