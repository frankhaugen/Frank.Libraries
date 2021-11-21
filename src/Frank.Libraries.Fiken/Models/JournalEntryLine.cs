using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class JournalEntryLine
    {
        /// <summary>
        /// Net amount
        /// </summary>
        /// <value>Net amount</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets VatCode
        /// </summary>
        [DataMember(Name = "vatCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vatCode")]
        public string VatCode { get; set; }

        /// <summary>
        /// Gets or Sets DebitAccount
        /// </summary>
        [DataMember(Name = "debitAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "debitAccount")]
        public string DebitAccount { get; set; }

        /// <summary>
        /// Gets or Sets DebitVatCode
        /// </summary>
        [DataMember(Name = "debitVatCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "debitVatCode")]
        public long? DebitVatCode { get; set; }

        /// <summary>
        /// Gets or Sets CreditAccount
        /// </summary>
        [DataMember(Name = "creditAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creditAccount")]
        public string CreditAccount { get; set; }

        /// <summary>
        /// Gets or Sets CreditVatCode
        /// </summary>
        [DataMember(Name = "creditVatCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creditVatCode")]
        public long? CreditVatCode { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JournalEntryLine {\n");
            sb.Append("  Amount: ")
              .Append(Amount)
              .Append("\n");
            sb.Append("  Account: ")
              .Append(Account)
              .Append("\n");
            sb.Append("  VatCode: ")
              .Append(VatCode)
              .Append("\n");
            sb.Append("  DebitAccount: ")
              .Append(DebitAccount)
              .Append("\n");
            sb.Append("  DebitVatCode: ")
              .Append(DebitVatCode)
              .Append("\n");
            sb.Append("  CreditAccount: ")
              .Append(CreditAccount)
              .Append("\n");
            sb.Append("  CreditVatCode: ")
              .Append(CreditVatCode)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}