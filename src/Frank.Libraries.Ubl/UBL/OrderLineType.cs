using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("OrderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class OrderLineType
{
    private LineItemType[] buyerProposedSubstituteLineItemField;

    private LineReferenceType catalogueLineReferenceField;

    private DocumentReferenceType[] documentReferenceField;

    private LineItemType lineItemField;

    private NoteType[] noteField;

    private OrderLineReferenceType[] orderLineReferenceField;

    private LineReferenceType quotationLineReferenceField;

    private LineItemType[] sellerProposedSubstituteLineItemField;

    private LineItemType[] sellerSubstitutedLineItemField;

    private SubstitutionStatusCodeType substitutionStatusCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubstitutionStatusCodeType SubstitutionStatusCode
    {
        get => substitutionStatusCodeField;
        set => substitutionStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
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
    [XmlElement("SellerSubstitutedLineItem")]
    public LineItemType[] SellerSubstitutedLineItem
    {
        get => sellerSubstitutedLineItemField;
        set => sellerSubstitutedLineItemField = value;
    }

    /// <remarks />
    [XmlElement("BuyerProposedSubstituteLineItem")]
    public LineItemType[] BuyerProposedSubstituteLineItem
    {
        get => buyerProposedSubstituteLineItemField;
        set => buyerProposedSubstituteLineItemField = value;
    }

    /// <remarks />
    public LineReferenceType CatalogueLineReference
    {
        get => catalogueLineReferenceField;
        set => catalogueLineReferenceField = value;
    }

    /// <remarks />
    public LineReferenceType QuotationLineReference
    {
        get => quotationLineReferenceField;
        set => quotationLineReferenceField = value;
    }

    /// <remarks />
    [XmlElement("OrderLineReference")]
    public OrderLineReferenceType[] OrderLineReference
    {
        get => orderLineReferenceField;
        set => orderLineReferenceField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }
}