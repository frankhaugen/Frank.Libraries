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
[XmlRoot("CreditNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class CreditNoteLineType
{
    private AccountingCostCodeType accountingCostCodeField;

    private AccountingCostType accountingCostField;

    private AllowanceChargeType[] allowanceChargeField;

    private BillingReferenceType[] billingReferenceField;

    private CreditedQuantityType creditedQuantityField;

    private DeliveryType[] deliveryField;

    private DeliveryTermsType[] deliveryTermsField;

    private LineReferenceType[] despatchLineReferenceField;

    private ResponseType[] discrepancyResponseField;

    private DocumentReferenceType[] documentReferenceField;

    private FreeOfChargeIndicatorType freeOfChargeIndicatorField;

    private IDType idField;

    private PeriodType[] invoicePeriodField;

    private ItemType itemField;

    private PriceExtensionType itemPriceExtensionField;

    private LineExtensionAmountType lineExtensionAmountField;

    private NoteType[] noteField;

    private OrderLineReferenceType[] orderLineReferenceField;

    private PartyType originatorPartyField;

    private PaymentPurposeCodeType paymentPurposeCodeField;

    private PaymentTermsType[] paymentTermsField;

    private PriceType priceField;

    private PricingReferenceType pricingReferenceField;

    private LineReferenceType[] receiptLineReferenceField;

    private CreditNoteLineType[] subCreditNoteLineField;

    private TaxPointDateType taxPointDateField;

    private TaxTotalType[] taxTotalField;

    private UUIDType uUIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get => uUIDField;
        set => uUIDField = value;
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
    public CreditedQuantityType CreditedQuantity
    {
        get => creditedQuantityField;
        set => creditedQuantityField = value;
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
    public TaxPointDateType TaxPointDate
    {
        get => taxPointDateField;
        set => taxPointDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostCodeType AccountingCostCode
    {
        get => accountingCostCodeField;
        set => accountingCostCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostType AccountingCost
    {
        get => accountingCostField;
        set => accountingCostField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentPurposeCodeType PaymentPurposeCode
    {
        get => paymentPurposeCodeField;
        set => paymentPurposeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FreeOfChargeIndicatorType FreeOfChargeIndicator
    {
        get => freeOfChargeIndicatorField;
        set => freeOfChargeIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("InvoicePeriod")]
    public PeriodType[] InvoicePeriod
    {
        get => invoicePeriodField;
        set => invoicePeriodField = value;
    }

    /// <remarks />
    [XmlElement("OrderLineReference")]
    public OrderLineReferenceType[] OrderLineReference
    {
        get => orderLineReferenceField;
        set => orderLineReferenceField = value;
    }

    /// <remarks />
    [XmlElement("DiscrepancyResponse")]
    public ResponseType[] DiscrepancyResponse
    {
        get => discrepancyResponseField;
        set => discrepancyResponseField = value;
    }

    /// <remarks />
    [XmlElement("DespatchLineReference")]
    public LineReferenceType[] DespatchLineReference
    {
        get => despatchLineReferenceField;
        set => despatchLineReferenceField = value;
    }

    /// <remarks />
    [XmlElement("ReceiptLineReference")]
    public LineReferenceType[] ReceiptLineReference
    {
        get => receiptLineReferenceField;
        set => receiptLineReferenceField = value;
    }

    /// <remarks />
    [XmlElement("BillingReference")]
    public BillingReferenceType[] BillingReference
    {
        get => billingReferenceField;
        set => billingReferenceField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    public PricingReferenceType PricingReference
    {
        get => pricingReferenceField;
        set => pricingReferenceField = value;
    }

    /// <remarks />
    public PartyType OriginatorParty
    {
        get => originatorPartyField;
        set => originatorPartyField = value;
    }

    /// <remarks />
    [XmlElement("Delivery")]
    public DeliveryType[] Delivery
    {
        get => deliveryField;
        set => deliveryField = value;
    }

    /// <remarks />
    [XmlElement("PaymentTerms")]
    public PaymentTermsType[] PaymentTerms
    {
        get => paymentTermsField;
        set => paymentTermsField = value;
    }

    /// <remarks />
    [XmlElement("TaxTotal")]
    public TaxTotalType[] TaxTotal
    {
        get => taxTotalField;
        set => taxTotalField = value;
    }

    /// <remarks />
    [XmlElement("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge
    {
        get => allowanceChargeField;
        set => allowanceChargeField = value;
    }

    /// <remarks />
    public ItemType Item
    {
        get => itemField;
        set => itemField = value;
    }

    /// <remarks />
    public PriceType Price
    {
        get => priceField;
        set => priceField = value;
    }

    /// <remarks />
    [XmlElement("DeliveryTerms")]
    public DeliveryTermsType[] DeliveryTerms
    {
        get => deliveryTermsField;
        set => deliveryTermsField = value;
    }

    /// <remarks />
    [XmlElement("SubCreditNoteLine")]
    public CreditNoteLineType[] SubCreditNoteLine
    {
        get => subCreditNoteLineField;
        set => subCreditNoteLineField = value;
    }

    /// <remarks />
    public PriceExtensionType ItemPriceExtension
    {
        get => itemPriceExtensionField;
        set => itemPriceExtensionField = value;
    }
}