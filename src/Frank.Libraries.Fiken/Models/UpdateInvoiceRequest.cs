using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateInvoiceRequest
    {
        /// <summary>
        /// Due date of invoice, format yyyy-mm-dd
        /// </summary>
        /// <value>Due date of invoice, format yyyy-mm-dd</value>
        [DataMember(Name = "newDueDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "newDueDate")]
        public DateTime? NewDueDate { get; set; }

        /// <summary>
        /// If the invoice was not sent using Fiken this can be set to \"true\"
        /// </summary>
        /// <value>If the invoice was not sent using Fiken this can be set to \"true\"</value>
        [DataMember(Name = "sentManually", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sentManually")]
        public bool? SentManually { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInvoiceRequest {\n");
            sb.Append("  NewDueDate: ")
              .Append(NewDueDate)
              .Append("\n");
            sb.Append("  SentManually: ")
              .Append(SentManually)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}