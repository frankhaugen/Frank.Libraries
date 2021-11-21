using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product Id.
        /// </summary>
        /// <value>Product Id.</value>
        [DataMember(Name = "productId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productId")]
        public long? ProductId { get; set; }

        /// <summary>
        /// Date that product was created in Fiken, format yyyy-mm-dd
        /// </summary>
        /// <value>Date that product was created in Fiken, format yyyy-mm-dd</value>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "createdDate")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Date that product was last modified in Fiken, format yyyy-mm-dd.
        /// </summary>
        /// <value>Date that product was last modified in Fiken, format yyyy-mm-dd.</value>
        [DataMember(Name = "lastModifiedDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastModifiedDate")]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        /// <value>Product name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The net unit price in cents.
        /// </summary>
        /// <value>The net unit price in cents.</value>
        [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "unitPrice")]
        public long? UnitPrice { get; set; }

        /// <summary>
        /// The accounting account that will receive the payment.
        /// </summary>
        /// <value>The accounting account that will receive the payment.</value>
        [DataMember(Name = "incomeAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "incomeAccount")]
        public string IncomeAccount { get; set; }

        /// <summary>
        /// One of {\"HIGH\", \"MEDIUM\", \"LOW\", \"EXEMPT\", \"EXEMPT_IMPORT_EXPORT\", \"EXEMPT_REVERSE\", \"OUTSIDE\", \"NONE\"}. \"HIGH\" is the most common.
        /// </summary>
        /// <value>One of {\"HIGH\", \"MEDIUM\", \"LOW\", \"EXEMPT\", \"EXEMPT_IMPORT_EXPORT\", \"EXEMPT_REVERSE\", \"OUTSIDE\", \"NONE\"}. \"HIGH\" is the most common.</value>
        [DataMember(Name = "vatType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vatType")]
        public string VatType { get; set; }

        /// <summary>
        /// If product is in use (True) or not (False).
        /// </summary>
        /// <value>If product is in use (True) or not (False).</value>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets ProductNumber
        /// </summary>
        [DataMember(Name = "productNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productNumber")]
        public string ProductNumber { get; set; }

        /// <summary>
        /// Number of products available in stock. If not provided, stock value is set to null. Decimal values are accepted. For example 5.5
        /// </summary>
        /// <value>Number of products available in stock. If not provided, stock value is set to null. Decimal values are accepted. For example 5.5</value>
        [DataMember(Name = "stock", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stock")]
        public float? Stock { get; set; }

        /// <summary>
        /// Optional field for additional information.
        /// </summary>
        /// <value>Optional field for additional information.</value>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  ProductId: ")
              .Append(ProductId)
              .Append("\n");
            sb.Append("  CreatedDate: ")
              .Append(CreatedDate)
              .Append("\n");
            sb.Append("  LastModifiedDate: ")
              .Append(LastModifiedDate)
              .Append("\n");
            sb.Append("  Name: ")
              .Append(Name)
              .Append("\n");
            sb.Append("  UnitPrice: ")
              .Append(UnitPrice)
              .Append("\n");
            sb.Append("  IncomeAccount: ")
              .Append(IncomeAccount)
              .Append("\n");
            sb.Append("  VatType: ")
              .Append(VatType)
              .Append("\n");
            sb.Append("  Active: ")
              .Append(Active)
              .Append("\n");
            sb.Append("  ProductNumber: ")
              .Append(ProductNumber)
              .Append("\n");
            sb.Append("  Stock: ")
              .Append(Stock)
              .Append("\n");
            sb.Append("  Note: ")
              .Append(Note)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}