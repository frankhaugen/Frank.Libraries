namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")]
    [System.Xml.Serialization.XmlRootAttribute("CreditNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2", IsNullable = false)]
    public partial class CreditNoteType
    {

        private UblExtensionType[] _uBlExtensionsField;

        private UblVersionIdType _uBlVersionIdField;

        private CustomizationIdType _customizationIdField;

        private ProfileIdType _profileIdField;

        private ProfileExecutionIdType _profileExecutionIdField;

        private IdType _idField;

        private CopyIndicatorType _copyIndicatorField;

        private UuidType _uUidField;

        private IssueDateType _issueDateField;

        private IssueTimeType _issueTimeField;

        private TaxPointDateType _taxPointDateField;

        private CreditNoteTypeCodeType _creditNoteTypeCodeField;

        private NoteType[] _noteField;

        private DocumentCurrencyCodeType _documentCurrencyCodeField;

        private TaxCurrencyCodeType _taxCurrencyCodeField;

        private PricingCurrencyCodeType _pricingCurrencyCodeField;

        private PaymentCurrencyCodeType _paymentCurrencyCodeField;

        private PaymentAlternativeCurrencyCodeType _paymentAlternativeCurrencyCodeField;

        private AccountingCostCodeType _accountingCostCodeField;

        private AccountingCostType _accountingCostField;

        private LineCountNumericType _lineCountNumericField;

        private BuyerReferenceType _buyerReferenceField;

        private PeriodType[] _invoicePeriodField;

        private ResponseType[] _discrepancyResponseField;

        private OrderReferenceType _orderReferenceField;

        private BillingReferenceType[] _billingReferenceField;

        private DocumentReferenceType[] _despatchDocumentReferenceField;

        private DocumentReferenceType[] _receiptDocumentReferenceField;

        private DocumentReferenceType[] _contractDocumentReferenceField;

        private DocumentReferenceType[] _additionalDocumentReferenceField;

        private DocumentReferenceType[] _statementDocumentReferenceField;

        private DocumentReferenceType[] _originatorDocumentReferenceField;

        private SignatureType[] _signatureField;

        private SupplierPartyType _accountingSupplierPartyField;

        private CustomerPartyType _accountingCustomerPartyField;

        private PartyType _payeePartyField;

        private CustomerPartyType _buyerCustomerPartyField;

        private SupplierPartyType _sellerSupplierPartyField;

        private PartyType _taxRepresentativePartyField;

        private DeliveryType[] _deliveryField;

        private DeliveryTermsType[] _deliveryTermsField;

        private PaymentMeansType[] _paymentMeansField;

        private PaymentTermsType[] _paymentTermsField;

        private ExchangeRateType _taxExchangeRateField;

        private ExchangeRateType _pricingExchangeRateField;

        private ExchangeRateType _paymentExchangeRateField;

        private ExchangeRateType _paymentAlternativeExchangeRateField;

        private AllowanceChargeType[] _allowanceChargeField;

        private TaxTotalType[] _taxTotalField;

        private MonetaryTotalType _legalMonetaryTotalField;

        private CreditNoteLineType[] _creditNoteLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable = false)]
        public UblExtensionType[] UblExtensions
        {
            get
            {
                return _uBlExtensionsField;
            }
            set
            {
                _uBlExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UblVersionIdType UblVersionId
        {
            get
            {
                return _uBlVersionIdField;
            }
            set
            {
                _uBlVersionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomizationIdType CustomizationId
        {
            get
            {
                return _customizationIdField;
            }
            set
            {
                _customizationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProfileIdType ProfileId
        {
            get
            {
                return _profileIdField;
            }
            set
            {
                _profileIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProfileExecutionIdType ProfileExecutionId
        {
            get
            {
                return _profileExecutionIdField;
            }
            set
            {
                _profileExecutionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdType Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CopyIndicatorType CopyIndicator
        {
            get
            {
                return _copyIndicatorField;
            }
            set
            {
                _copyIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UuidType Uuid
        {
            get
            {
                return _uUidField;
            }
            set
            {
                _uUidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueDateType IssueDate
        {
            get
            {
                return _issueDateField;
            }
            set
            {
                _issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTimeType IssueTime
        {
            get
            {
                return _issueTimeField;
            }
            set
            {
                _issueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxPointDateType TaxPointDate
        {
            get
            {
                return _taxPointDateField;
            }
            set
            {
                _taxPointDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CreditNoteTypeCodeType CreditNoteTypeCode
        {
            get
            {
                return _creditNoteTypeCodeField;
            }
            set
            {
                _creditNoteTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return _noteField;
            }
            set
            {
                _noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentCurrencyCodeType DocumentCurrencyCode
        {
            get
            {
                return _documentCurrencyCodeField;
            }
            set
            {
                _documentCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxCurrencyCodeType TaxCurrencyCode
        {
            get
            {
                return _taxCurrencyCodeField;
            }
            set
            {
                _taxCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PricingCurrencyCodeType PricingCurrencyCode
        {
            get
            {
                return _pricingCurrencyCodeField;
            }
            set
            {
                _pricingCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentCurrencyCodeType PaymentCurrencyCode
        {
            get
            {
                return _paymentCurrencyCodeField;
            }
            set
            {
                _paymentCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentAlternativeCurrencyCodeType PaymentAlternativeCurrencyCode
        {
            get
            {
                return _paymentAlternativeCurrencyCodeField;
            }
            set
            {
                _paymentAlternativeCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostCodeType AccountingCostCode
        {
            get
            {
                return _accountingCostCodeField;
            }
            set
            {
                _accountingCostCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostType AccountingCost
        {
            get
            {
                return _accountingCostField;
            }
            set
            {
                _accountingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineCountNumericType LineCountNumeric
        {
            get
            {
                return _lineCountNumericField;
            }
            set
            {
                _lineCountNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuyerReferenceType BuyerReference
        {
            get
            {
                return _buyerReferenceField;
            }
            set
            {
                _buyerReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] InvoicePeriod
        {
            get
            {
                return _invoicePeriodField;
            }
            set
            {
                _invoicePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ResponseType[] DiscrepancyResponse
        {
            get
            {
                return _discrepancyResponseField;
            }
            set
            {
                _discrepancyResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderReferenceType OrderReference
        {
            get
            {
                return _orderReferenceField;
            }
            set
            {
                _orderReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public BillingReferenceType[] BillingReference
        {
            get
            {
                return _billingReferenceField;
            }
            set
            {
                _billingReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] DespatchDocumentReference
        {
            get
            {
                return _despatchDocumentReferenceField;
            }
            set
            {
                _despatchDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ReceiptDocumentReference
        {
            get
            {
                return _receiptDocumentReferenceField;
            }
            set
            {
                _receiptDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ContractDocumentReference
        {
            get
            {
                return _contractDocumentReferenceField;
            }
            set
            {
                _contractDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference
        {
            get
            {
                return _additionalDocumentReferenceField;
            }
            set
            {
                _additionalDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StatementDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] StatementDocumentReference
        {
            get
            {
                return _statementDocumentReferenceField;
            }
            set
            {
                _statementDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OriginatorDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] OriginatorDocumentReference
        {
            get
            {
                return _originatorDocumentReferenceField;
            }
            set
            {
                _originatorDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature
        {
            get
            {
                return _signatureField;
            }
            set
            {
                _signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty
        {
            get
            {
                return _accountingSupplierPartyField;
            }
            set
            {
                _accountingSupplierPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty
        {
            get
            {
                return _accountingCustomerPartyField;
            }
            set
            {
                _accountingCustomerPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType PayeeParty
        {
            get
            {
                return _payeePartyField;
            }
            set
            {
                _payeePartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                return _buyerCustomerPartyField;
            }
            set
            {
                _buyerCustomerPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return _sellerSupplierPartyField;
            }
            set
            {
                _sellerSupplierPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType TaxRepresentativeParty
        {
            get
            {
                return _taxRepresentativePartyField;
            }
            set
            {
                _taxRepresentativePartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryType[] Delivery
        {
            get
            {
                return _deliveryField;
            }
            set
            {
                _deliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryTermsType[] DeliveryTerms
        {
            get
            {
                return _deliveryTermsField;
            }
            set
            {
                _deliveryTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentMeansType[] PaymentMeans
        {
            get
            {
                return _paymentMeansField;
            }
            set
            {
                _paymentMeansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return _paymentTermsField;
            }
            set
            {
                _paymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType TaxExchangeRate
        {
            get
            {
                return _taxExchangeRateField;
            }
            set
            {
                _taxExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PricingExchangeRate
        {
            get
            {
                return _pricingExchangeRateField;
            }
            set
            {
                _pricingExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentExchangeRate
        {
            get
            {
                return _paymentExchangeRateField;
            }
            set
            {
                _paymentExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentAlternativeExchangeRate
        {
            get
            {
                return _paymentAlternativeExchangeRateField;
            }
            set
            {
                _paymentAlternativeExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return _allowanceChargeField;
            }
            set
            {
                _allowanceChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return _taxTotalField;
            }
            set
            {
                _taxTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return _legalMonetaryTotalField;
            }
            set
            {
                _legalMonetaryTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CreditNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CreditNoteLineType[] CreditNoteLine
        {
            get
            {
                return _creditNoteLineField;
            }
            set
            {
                _creditNoteLineField = value;
            }
        }
    }
}