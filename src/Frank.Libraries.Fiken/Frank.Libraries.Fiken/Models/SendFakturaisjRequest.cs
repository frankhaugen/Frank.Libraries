using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class SendFakturaisjRequest
{
    /// <summary>
    ///     The method of sending. Has to be auto, email, ehf, vipps or sms.
    /// </summary>
    /// <value>The method of sending. Has to be auto, email, ehf, vipps or sms.</value>
    [DataMember(Name = "method", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "method")]
    public List<string> Method { get; set; }

    /// <summary>
    ///     Whether the document's attachment should be included when sending (True) or not (False).
    /// </summary>
    /// <value>Whether the document's attachment should be included when sending (True) or not (False).</value>
    [DataMember(Name = "includeDocumentAttachments", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "includeDocumentAttachments")]
    public bool? IncludeDocumentAttachments { get; set; }

    /// <summary>
    ///     Gets or Sets RecipientName
    /// </summary>
    [DataMember(Name = "recipientName", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "recipientName")]
    public string RecipientName { get; set; }

    /// <summary>
    ///     Gets or Sets RecipientEmail
    /// </summary>
    [DataMember(Name = "recipientEmail", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "recipientEmail")]
    public string RecipientEmail { get; set; }

    /// <summary>
    ///     Additional message to send with document.
    /// </summary>
    /// <value>Additional message to send with document.</value>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    ///     document_link, attachment or auto. Defaults to auto which uses customer/company settings.
    /// </summary>
    /// <value>document_link, attachment or auto. Defaults to auto which uses customer/company settings.</value>
    [DataMember(Name = "emailSendOption", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "emailSendOption")]
    public string EmailSendOption { get; set; }

    /// <summary>
    ///     Brreg organiztion number. Defaults to the customers organization number if not provided.
    /// </summary>
    /// <value>Brreg organiztion number. Defaults to the customers organization number if not provided.</value>
    [DataMember(Name = "organizationNumber", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "organizationNumber")]
    public string OrganizationNumber { get; set; }

    /// <summary>
    ///     Defaults to the customers phone number. Format should include the country code. If a Norwegian phone number, the
    ///     country code is not necessary.
    /// </summary>
    /// <value>
    ///     Defaults to the customers phone number. Format should include the country code. If a Norwegian phone number, the
    ///     country code is not necessary.
    /// </value>
    [DataMember(Name = "mobileNumber", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "mobileNumber")]
    public string MobileNumber { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SendFakturaisjRequest {\n");
        sb.Append("  Method: ")
          .Append(Method)
          .Append("\n");
        sb.Append("  IncludeDocumentAttachments: ")
          .Append(IncludeDocumentAttachments)
          .Append("\n");
        sb.Append("  RecipientName: ")
          .Append(RecipientName)
          .Append("\n");
        sb.Append("  RecipientEmail: ")
          .Append(RecipientEmail)
          .Append("\n");
        sb.Append("  Message: ")
          .Append(Message)
          .Append("\n");
        sb.Append("  EmailSendOption: ")
          .Append(EmailSendOption)
          .Append("\n");
        sb.Append("  OrganizationNumber: ")
          .Append(OrganizationNumber)
          .Append("\n");
        sb.Append("  MobileNumber: ")
          .Append(MobileNumber)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}