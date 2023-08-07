using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class AccountBalance : Account
{
    /// <summary>
    ///     Balance of account for a given date given in cents (5050 = 50.50)
    /// </summary>
    /// <value>Balance of account for a given date given in cents (5050 = 50.50)</value>
    [DataMember(Name = "balance", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "balance")]
    public long? Balance { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AccountBalance {\n");
        sb.Append("  Balance: ")
          .Append(Balance)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}