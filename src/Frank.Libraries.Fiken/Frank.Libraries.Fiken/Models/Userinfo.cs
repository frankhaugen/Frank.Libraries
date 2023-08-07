using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class Userinfo
{
    /// <summary>
    ///     Name of the user.
    /// </summary>
    /// <value>Name of the user.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    ///     Users email address.
    /// </summary>
    /// <value>Users email address.</value>
    [DataMember(Name = "email", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Userinfo {\n");
        sb.Append("  Name: ")
          .Append(Name)
          .Append("\n");
        sb.Append("  Email: ")
          .Append(Email)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}