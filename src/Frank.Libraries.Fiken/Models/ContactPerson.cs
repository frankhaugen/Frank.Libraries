using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class ContactPerson
    {
        /// <summary>
        /// Gets or Sets ContactPersonId
        /// </summary>
        [DataMember(Name = "contactPersonId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contactPersonId")]
        public long? ContactPersonId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        public Address Address { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactPerson {\n");
            sb.Append("  ContactPersonId: ")
              .Append(ContactPersonId)
              .Append("\n");
            sb.Append("  Name: ")
              .Append(Name)
              .Append("\n");
            sb.Append("  Email: ")
              .Append(Email)
              .Append("\n");
            sb.Append("  PhoneNumber: ")
              .Append(PhoneNumber)
              .Append("\n");
            sb.Append("  Address: ")
              .Append(Address)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}