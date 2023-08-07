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
[XmlRoot("QuotationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class QuotationLineType
{
    private LineItemType[] alternativeLineItemField;

    private DocumentReferenceType[] documentReferenceField;

    private IDType idField;

    private LineExtensionAmountType lineExtensionAmountField;

    private LineItemType lineItemField;

    private NoteType[] noteField;

    private QuantityType2 quantityField;

    private RequestForQuotationLineIDType requestForQuotationLineIDField;

    private LineReferenceType requestLineReferenceField;

    private LineItemType[] sellerProposedSubstituteLineItemField;

    private TotalTaxAmountType totalTaxAmountField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity
    {
        get => quantityField;
        set => quantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineExtensionAmountType LineExtensionAmount
    {
        get => lineExtensionAmountField;
        set => lineExtensionAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalTaxAmountType TotalTaxAmount
    {
        get => totalTaxAmountField;
        set => totalTaxAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequestForQuotationLineIDType RequestForQuotationLineID
    {
        get => requestForQuotationLineIDField;
        set => requestForQuotationLineIDField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    public LineItemType LineItem
    {
        get => lineItemField;
        set => lineItemField = value;
    }

    /// <remarks />
    [XmlElement("SellerProposedSubstituteLineItem")]
    public LineItemType[] SellerProposedSubstituteLineItem
    {
        get => sellerProposedSubstituteLineItemField;
        set => sellerProposedSubstituteLineItemField = value;
    }

    /// <remarks />
    [XmlElement("AlternativeLineItem")]
    public LineItemType[] AlternativeLineItem
    {
        get => alternativeLineItemField;
        set => alternativeLineItemField = value;
    }

    /// <remarks />
    public LineReferenceType RequestLineReference
    {
        get => requestLineReferenceField;
        set => requestLineReferenceField = value;
    }
}