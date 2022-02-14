namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:OrderChange-2")]
[System.Xml.Serialization.XmlRootAttribute("OrderChange", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:OrderChange-2", IsNullable = false)]
public partial class OrderChangeType
{

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private CustomizationIDType customizationIDField;

    private ProfileIDType profileIDField;

    private ProfileExecutionIDType profileExecutionIDField;

    private IDType idField;

    private SalesOrderIDType salesOrderIDField;

    private CopyIndicatorType copyIndicatorField;

    private UUIDType uUIDField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private SequenceNumberIDType sequenceNumberIDField;

    private NoteType[] noteField;

    private RequestedInvoiceCurrencyCodeType requestedInvoiceCurrencyCodeField;

    private DocumentCurrencyCodeType documentCurrencyCodeField;

    private PricingCurrencyCodeType pricingCurrencyCodeField;

    private TaxCurrencyCodeType taxCurrencyCodeField;

    private CustomerReferenceType customerReferenceField;

    private AccountingCostCodeType accountingCostCodeField;

    private AccountingCostType accountingCostField;

    private LineCountNumericType lineCountNumericField;

    private PeriodType[] validityPeriodField;

    private OrderReferenceType orderReferenceField;

    private DocumentReferenceType quotationDocumentReferenceField;

    private DocumentReferenceType originatorDocumentReferenceField;

    private DocumentReferenceType[] additionalDocumentReferenceField;

    private ContractType[] contractField;

    private SignatureType[] signatureField;

    private CustomerPartyType buyerCustomerPartyField;

    private SupplierPartyType sellerSupplierPartyField;

    private CustomerPartyType originatorCustomerPartyField;

    private PartyType freightForwarderPartyField;

    private CustomerPartyType accountingCustomerPartyField;

    private SupplierPartyType accountingSupplierPartyField;

    private DeliveryType[] deliveryField;

    private DeliveryTermsType deliveryTermsField;

    private PaymentMeansType[] paymentMeansField;

    private PaymentTermsType[] paymentTermsField;

    private TransactionConditionsType transactionConditionsField;

    private AllowanceChargeType[] allowanceChargeField;

    private ExchangeRateType taxExchangeRateField;

    private ExchangeRateType pricingExchangeRateField;

    private ExchangeRateType paymentExchangeRateField;

    private CountryType destinationCountryField;

    private TaxTotalType[] taxTotalField;

    private MonetaryTotalType anticipatedMonetaryTotalField;

    private OrderLineType[] orderLineField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable = false)]
    public UBLExtensionType[] UBLExtensions
    {
        get
        {
            return this.uBLExtensionsField;
        }
        set
        {
            this.uBLExtensionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UBLVersionIDType UBLVersionID
    {
        get
        {
            return this.uBLVersionIDField;
        }
        set
        {
            this.uBLVersionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomizationIDType CustomizationID
    {
        get
        {
            return this.customizationIDField;
        }
        set
        {
            this.customizationIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileIDType ProfileID
    {
        get
        {
            return this.profileIDField;
        }
        set
        {
            this.profileIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileExecutionIDType ProfileExecutionID
    {
        get
        {
            return this.profileExecutionIDField;
        }
        set
        {
            this.profileExecutionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SalesOrderIDType SalesOrderID
    {
        get
        {
            return this.salesOrderIDField;
        }
        set
        {
            this.salesOrderIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CopyIndicatorType CopyIndicator
    {
        get
        {
            return this.copyIndicatorField;
        }
        set
        {
            this.copyIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get
        {
            return this.uUIDField;
        }
        set
        {
            this.uUIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueDateType IssueDate
    {
        get
        {
            return this.issueDateField;
        }
        set
        {
            this.issueDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueTimeType IssueTime
    {
        get
        {
            return this.issueTimeField;
        }
        set
        {
            this.issueTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceNumberIDType SequenceNumberID
    {
        get
        {
            return this.sequenceNumberIDField;
        }
        set
        {
            this.sequenceNumberIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequestedInvoiceCurrencyCodeType RequestedInvoiceCurrencyCode
    {
        get
        {
            return this.requestedInvoiceCurrencyCodeField;
        }
        set
        {
            this.requestedInvoiceCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentCurrencyCodeType DocumentCurrencyCode
    {
        get
        {
            return this.documentCurrencyCodeField;
        }
        set
        {
            this.documentCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PricingCurrencyCodeType PricingCurrencyCode
    {
        get
        {
            return this.pricingCurrencyCodeField;
        }
        set
        {
            this.pricingCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxCurrencyCodeType TaxCurrencyCode
    {
        get
        {
            return this.taxCurrencyCodeField;
        }
        set
        {
            this.taxCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomerReferenceType CustomerReference
    {
        get
        {
            return this.customerReferenceField;
        }
        set
        {
            this.customerReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostCodeType AccountingCostCode
    {
        get
        {
            return this.accountingCostCodeField;
        }
        set
        {
            this.accountingCostCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostType AccountingCost
    {
        get
        {
            return this.accountingCostField;
        }
        set
        {
            this.accountingCostField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineCountNumericType LineCountNumeric
    {
        get
        {
            return this.lineCountNumericField;
        }
        set
        {
            this.lineCountNumericField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType[] ValidityPeriod
    {
        get
        {
            return this.validityPeriodField;
        }
        set
        {
            this.validityPeriodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public OrderReferenceType OrderReference
    {
        get
        {
            return this.orderReferenceField;
        }
        set
        {
            this.orderReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType QuotationDocumentReference
    {
        get
        {
            return this.quotationDocumentReferenceField;
        }
        set
        {
            this.quotationDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType OriginatorDocumentReference
    {
        get
        {
            return this.originatorDocumentReferenceField;
        }
        set
        {
            this.originatorDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] AdditionalDocumentReference
    {
        get
        {
            return this.additionalDocumentReferenceField;
        }
        set
        {
            this.additionalDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Contract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ContractType[] Contract
    {
        get
        {
            return this.contractField;
        }
        set
        {
            this.contractField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SignatureType[] Signature
    {
        get
        {
            return this.signatureField;
        }
        set
        {
            this.signatureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CustomerPartyType BuyerCustomerParty
    {
        get
        {
            return this.buyerCustomerPartyField;
        }
        set
        {
            this.buyerCustomerPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SupplierPartyType SellerSupplierParty
    {
        get
        {
            return this.sellerSupplierPartyField;
        }
        set
        {
            this.sellerSupplierPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CustomerPartyType OriginatorCustomerParty
    {
        get
        {
            return this.originatorCustomerPartyField;
        }
        set
        {
            this.originatorCustomerPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType FreightForwarderParty
    {
        get
        {
            return this.freightForwarderPartyField;
        }
        set
        {
            this.freightForwarderPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CustomerPartyType AccountingCustomerParty
    {
        get
        {
            return this.accountingCustomerPartyField;
        }
        set
        {
            this.accountingCustomerPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SupplierPartyType AccountingSupplierParty
    {
        get
        {
            return this.accountingSupplierPartyField;
        }
        set
        {
            this.accountingSupplierPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DeliveryType[] Delivery
    {
        get
        {
            return this.deliveryField;
        }
        set
        {
            this.deliveryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DeliveryTermsType DeliveryTerms
    {
        get
        {
            return this.deliveryTermsField;
        }
        set
        {
            this.deliveryTermsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PaymentMeansType[] PaymentMeans
    {
        get
        {
            return this.paymentMeansField;
        }
        set
        {
            this.paymentMeansField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PaymentTermsType[] PaymentTerms
    {
        get
        {
            return this.paymentTermsField;
        }
        set
        {
            this.paymentTermsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransactionConditionsType TransactionConditions
    {
        get
        {
            return this.transactionConditionsField;
        }
        set
        {
            this.transactionConditionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public AllowanceChargeType[] AllowanceCharge
    {
        get
        {
            return this.allowanceChargeField;
        }
        set
        {
            this.allowanceChargeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ExchangeRateType TaxExchangeRate
    {
        get
        {
            return this.taxExchangeRateField;
        }
        set
        {
            this.taxExchangeRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ExchangeRateType PricingExchangeRate
    {
        get
        {
            return this.pricingExchangeRateField;
        }
        set
        {
            this.pricingExchangeRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ExchangeRateType PaymentExchangeRate
    {
        get
        {
            return this.paymentExchangeRateField;
        }
        set
        {
            this.paymentExchangeRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CountryType DestinationCountry
    {
        get
        {
            return this.destinationCountryField;
        }
        set
        {
            this.destinationCountryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TaxTotalType[] TaxTotal
    {
        get
        {
            return this.taxTotalField;
        }
        set
        {
            this.taxTotalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public MonetaryTotalType AnticipatedMonetaryTotal
    {
        get
        {
            return this.anticipatedMonetaryTotalField;
        }
        set
        {
            this.anticipatedMonetaryTotalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OrderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public OrderLineType[] OrderLine
    {
        get
        {
            return this.orderLineField;
        }
        set
        {
            this.orderLineField = value;
        }
    }
}