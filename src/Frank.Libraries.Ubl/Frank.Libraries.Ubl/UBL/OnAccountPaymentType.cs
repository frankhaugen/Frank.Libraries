using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("MainOnAccountPayment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class OnAccountPaymentType
{
    private EstimatedConsumedQuantityType estimatedConsumedQuantityField;

    private NoteType[] noteField;

    private PaymentTermsType[] paymentTermsField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedConsumedQuantityType EstimatedConsumedQuantity
    {
        get => estimatedConsumedQuantityField;
        set => estimatedConsumedQuantityField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement("PaymentTerms")]
    public PaymentTermsType[] PaymentTerms
    {
        get => paymentTermsField;
        set => paymentTermsField = value;
    }
}