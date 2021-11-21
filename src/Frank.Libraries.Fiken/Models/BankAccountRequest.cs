using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class BankAccountRequest
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountNumber
        /// </summary>
        [DataMember(Name = "bankAccountNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankAccountNumber")]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets Bic
        /// </summary>
        [DataMember(Name = "bic", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bic")]
        public string Bic { get; set; }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "iban")]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets ForeignService
        /// </summary>
        [DataMember(Name = "foreignService", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "foreignService")]
        public string ForeignService { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Inactive
        /// </summary>
        [DataMember(Name = "inactive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inactive")]
        public bool? Inactive { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccountRequest {\n");
            sb.Append("  Name: ")
              .Append(Name)
              .Append("\n");
            sb.Append("  BankAccountNumber: ")
              .Append(BankAccountNumber)
              .Append("\n");
            sb.Append("  Bic: ")
              .Append(Bic)
              .Append("\n");
            sb.Append("  Iban: ")
              .Append(Iban)
              .Append("\n");
            sb.Append("  ForeignService: ")
              .Append(ForeignService)
              .Append("\n");
            sb.Append("  Type: ")
              .Append(Type)
              .Append("\n");
            sb.Append("  Inactive: ")
              .Append(Inactive)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}