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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Quotation-2")]
[XmlRoot("Quotation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Quotation-2", IsNullable = false)]
public class QuotationType
{
    private DocumentReferenceType[] additionalDocumentReferenceField;

    private AllowanceChargeType[] allowanceChargeField;

    private CustomerPartyType buyerCustomerPartyField;

    private ContractType[] contractField;

    private CopyIndicatorType copyIndicatorField;

    private CustomizationIDType customizationIDField;

    private DeliveryType[] deliveryField;

    private DeliveryTermsType deliveryTermsField;

    private CountryType destinationCountryField;

    private IDType idField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private LineCountNumericType lineCountNumericField;

    private NoteType[] noteField;

    private CustomerPartyType originatorCustomerPartyField;

    private PaymentMeansType paymentMeansField;

    private PricingCurrencyCodeType pricingCurrencyCodeField;

    private ProfileExecutionIDType profileExecutionIDField;

    private ProfileIDType profileIDField;

    private QuotationLineType[] quotationLineField;

    private MonetaryTotalType quotedMonetaryTotalField;

    private DocumentReferenceType requestForQuotationDocumentReferenceField;

    private SupplierPartyType sellerSupplierPartyField;

    private SignatureType[] signatureField;

    private TaxTotalType[] taxTotalField;

    private TransactionConditionsType transactionConditionsField;

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private UUIDType uUIDField;

    private PeriodType validityPeriodField;

    /// <remarks />
    [XmlArray(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlArrayItem("UBLExtension", IsNullable = false)]
    public UBLExtensionType[] UBLExtensions
    {
        get => uBLExtensionsField;
        set => uBLExtensionsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UBLVersionIDType UBLVersionID
    {
        get => uBLVersionIDField;
        set => uBLVersionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomizationIDType CustomizationID
    {
        get => customizationIDField;
        set => customizationIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileIDType ProfileID
    {
        get => profileIDField;
        set => profileIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileExecutionIDType ProfileExecutionID
    {
        get => profileExecutionIDField;
        set => profileExecutionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CopyIndicatorType CopyIndicator
    {
        get => copyIndicatorField;
        set => copyIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get => uUIDField;
        set => uUIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueDateType IssueDate
    {
        get => issueDateField;
        set => issueDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueTimeType IssueTime
    {
        get => issueTimeField;
        set => issueTimeField = value;
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
    public PricingCurrencyCodeType PricingCurrencyCode
    {
        get => pricingCurrencyCodeField;
        set => pricingCurrencyCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineCountNumericType LineCountNumeric
    {
        get => lineCountNumericField;
        set => lineCountNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType ValidityPeriod
    {
        get => validityPeriodField;
        set => validityPeriodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType RequestForQuotationDocumentReference
    {
        get => requestForQuotationDocumentReferenceField;
        set => requestForQuotationDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] AdditionalDocumentReference
    {
        get => additionalDocumentReferenceField;
        set => additionalDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("Contract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ContractType[] Contract
    {
        get => contractField;
        set => contractField = value;
    }

    /// <remarks />
    [XmlElement("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SignatureType[] Signature
    {
        get => signatureField;
        set => signatureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SupplierPartyType SellerSupplierParty
    {
        get => sellerSupplierPartyField;
        set => sellerSupplierPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CustomerPartyType BuyerCustomerParty
    {
        get => buyerCustomerPartyField;
        set => buyerCustomerPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CustomerPartyType OriginatorCustomerParty
    {
        get => originatorCustomerPartyField;
        set => originatorCustomerPartyField = value;
    }

    /// <remarks />
    [XmlElement("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DeliveryType[] Delivery
    {
        get => deliveryField;
        set => deliveryField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DeliveryTermsType DeliveryTerms
    {
        get => deliveryTermsField;
        set => deliveryTermsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PaymentMeansType PaymentMeans
    {
        get => paymentMeansField;
        set => paymentMeansField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransactionConditionsType TransactionConditions
    {
        get => transactionConditionsField;
        set => transactionConditionsField = value;
    }

    /// <remarks />
    [XmlElement("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public AllowanceChargeType[] AllowanceCharge
    {
        get => allowanceChargeField;
        set => allowanceChargeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CountryType DestinationCountry
    {
        get => destinationCountryField;
        set => destinationCountryField = value;
    }

    /// <remarks />
    [XmlElement("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TaxTotalType[] TaxTotal
    {
        get => taxTotalField;
        set => taxTotalField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public MonetaryTotalType QuotedMonetaryTotal
    {
        get => quotedMonetaryTotalField;
        set => quotedMonetaryTotalField = value;
    }

    /// <remarks />
    [XmlElement("QuotationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public QuotationLineType[] QuotationLine
    {
        get => quotationLineField;
        set => quotationLineField = value;
    }
}