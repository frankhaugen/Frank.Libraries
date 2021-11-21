using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class SaleIdAttachmentsBody
    {
        /// <summary>
        /// The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf
        /// </summary>
        /// <value>The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf</value>
        [DataMember(Name = "filename", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// True if this attachment may document the payment (i.e. transaction receipt from credit card/payment company, export from bank, etc.). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true.
        /// </summary>
        /// <value>True if this attachment may document the payment (i.e. transaction receipt from credit card/payment company, export from bank, etc.). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true.</value>
        [DataMember(Name = "attachToPayment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attachToPayment")]
        public bool? AttachToPayment { get; set; }

        /// <summary>
        /// True if this attachment may document the sale (i.e. invoice, etc). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true.
        /// </summary>
        /// <value>True if this attachment may document the sale (i.e. invoice, etc). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true.</value>
        [DataMember(Name = "attachToSale", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attachToSale")]
        public bool? AttachToSale { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "file")]
        public byte[] File { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaleIdAttachmentsBody {\n");
            sb.Append("  Filename: ")
              .Append(Filename)
              .Append("\n");
            sb.Append("  AttachToPayment: ")
              .Append(AttachToPayment)
              .Append("\n");
            sb.Append("  AttachToSale: ")
              .Append(AttachToSale)
              .Append("\n");
            sb.Append("  File: ")
              .Append(File)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}