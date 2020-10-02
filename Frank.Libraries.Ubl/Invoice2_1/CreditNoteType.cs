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

        private UBLExtensionType[] uBLExtensionsField;

        private UBLVersionIDType uBLVersionIDField;

        private CustomizationIDType customizationIDField;

        private ProfileIDType profileIDField;

        private ProfileExecutionIDType profileExecutionIDField;

        private IDType idField;

        private CopyIndicatorType copyIndicatorField;

        private UUIDType uUIDField;

        private IssueDateType issueDateField;

        private IssueTimeType issueTimeField;

        private TaxPointDateType taxPointDateField;

        private CreditNoteTypeCodeType creditNoteTypeCodeField;

        private NoteType[] noteField;

        private DocumentCurrencyCodeType documentCurrencyCodeField;

        private TaxCurrencyCodeType taxCurrencyCodeField;

        private PricingCurrencyCodeType pricingCurrencyCodeField;

        private PaymentCurrencyCodeType paymentCurrencyCodeField;

        private PaymentAlternativeCurrencyCodeType paymentAlternativeCurrencyCodeField;

        private AccountingCostCodeType accountingCostCodeField;

        private AccountingCostType accountingCostField;

        private LineCountNumericType lineCountNumericField;

        private BuyerReferenceType buyerReferenceField;

        private PeriodType[] invoicePeriodField;

        private ResponseType[] discrepancyResponseField;

        private OrderReferenceType orderReferenceField;

        private BillingReferenceType[] billingReferenceField;

        private DocumentReferenceType[] despatchDocumentReferenceField;

        private DocumentReferenceType[] receiptDocumentReferenceField;

        private DocumentReferenceType[] contractDocumentReferenceField;

        private DocumentReferenceType[] additionalDocumentReferenceField;

        private DocumentReferenceType[] statementDocumentReferenceField;

        private DocumentReferenceType[] originatorDocumentReferenceField;

        private SignatureType[] signatureField;

        private SupplierPartyType accountingSupplierPartyField;

        private CustomerPartyType accountingCustomerPartyField;

        private PartyType payeePartyField;

        private CustomerPartyType buyerCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private PartyType taxRepresentativePartyField;

        private DeliveryType[] deliveryField;

        private DeliveryTermsType[] deliveryTermsField;

        private PaymentMeansType[] paymentMeansField;

        private PaymentTermsType[] paymentTermsField;

        private ExchangeRateType taxExchangeRateField;

        private ExchangeRateType pricingExchangeRateField;

        private ExchangeRateType paymentExchangeRateField;

        private ExchangeRateType paymentAlternativeExchangeRateField;

        private AllowanceChargeType[] allowanceChargeField;

        private TaxTotalType[] taxTotalField;

        private MonetaryTotalType legalMonetaryTotalField;

        private CreditNoteLineType[] creditNoteLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable = false)]
        public UBLExtensionType[] UBLExtensions
        {
            get
            {
                return uBLExtensionsField;
            }
            set
            {
                uBLExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UBLVersionIDType UBLVersionID
        {
            get
            {
                return uBLVersionIDField;
            }
            set
            {
                uBLVersionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomizationIDType CustomizationID
        {
            get
            {
                return customizationIDField;
            }
            set
            {
                customizationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProfileIDType ProfileID
        {
            get
            {
                return profileIDField;
            }
            set
            {
                profileIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProfileExecutionIDType ProfileExecutionID
        {
            get
            {
                return profileExecutionIDField;
            }
            set
            {
                profileExecutionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CopyIndicatorType CopyIndicator
        {
            get
            {
                return copyIndicatorField;
            }
            set
            {
                copyIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUIDType UUID
        {
            get
            {
                return uUIDField;
            }
            set
            {
                uUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueDateType IssueDate
        {
            get
            {
                return issueDateField;
            }
            set
            {
                issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTimeType IssueTime
        {
            get
            {
                return issueTimeField;
            }
            set
            {
                issueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxPointDateType TaxPointDate
        {
            get
            {
                return taxPointDateField;
            }
            set
            {
                taxPointDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CreditNoteTypeCodeType CreditNoteTypeCode
        {
            get
            {
                return creditNoteTypeCodeField;
            }
            set
            {
                creditNoteTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return noteField;
            }
            set
            {
                noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentCurrencyCodeType DocumentCurrencyCode
        {
            get
            {
                return documentCurrencyCodeField;
            }
            set
            {
                documentCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxCurrencyCodeType TaxCurrencyCode
        {
            get
            {
                return taxCurrencyCodeField;
            }
            set
            {
                taxCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PricingCurrencyCodeType PricingCurrencyCode
        {
            get
            {
                return pricingCurrencyCodeField;
            }
            set
            {
                pricingCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentCurrencyCodeType PaymentCurrencyCode
        {
            get
            {
                return paymentCurrencyCodeField;
            }
            set
            {
                paymentCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentAlternativeCurrencyCodeType PaymentAlternativeCurrencyCode
        {
            get
            {
                return paymentAlternativeCurrencyCodeField;
            }
            set
            {
                paymentAlternativeCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostCodeType AccountingCostCode
        {
            get
            {
                return accountingCostCodeField;
            }
            set
            {
                accountingCostCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostType AccountingCost
        {
            get
            {
                return accountingCostField;
            }
            set
            {
                accountingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineCountNumericType LineCountNumeric
        {
            get
            {
                return lineCountNumericField;
            }
            set
            {
                lineCountNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuyerReferenceType BuyerReference
        {
            get
            {
                return buyerReferenceField;
            }
            set
            {
                buyerReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] InvoicePeriod
        {
            get
            {
                return invoicePeriodField;
            }
            set
            {
                invoicePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ResponseType[] DiscrepancyResponse
        {
            get
            {
                return discrepancyResponseField;
            }
            set
            {
                discrepancyResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderReferenceType OrderReference
        {
            get
            {
                return orderReferenceField;
            }
            set
            {
                orderReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public BillingReferenceType[] BillingReference
        {
            get
            {
                return billingReferenceField;
            }
            set
            {
                billingReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] DespatchDocumentReference
        {
            get
            {
                return despatchDocumentReferenceField;
            }
            set
            {
                despatchDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ReceiptDocumentReference
        {
            get
            {
                return receiptDocumentReferenceField;
            }
            set
            {
                receiptDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ContractDocumentReference
        {
            get
            {
                return contractDocumentReferenceField;
            }
            set
            {
                contractDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference
        {
            get
            {
                return additionalDocumentReferenceField;
            }
            set
            {
                additionalDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StatementDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] StatementDocumentReference
        {
            get
            {
                return statementDocumentReferenceField;
            }
            set
            {
                statementDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OriginatorDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] OriginatorDocumentReference
        {
            get
            {
                return originatorDocumentReferenceField;
            }
            set
            {
                originatorDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature
        {
            get
            {
                return signatureField;
            }
            set
            {
                signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty
        {
            get
            {
                return accountingSupplierPartyField;
            }
            set
            {
                accountingSupplierPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty
        {
            get
            {
                return accountingCustomerPartyField;
            }
            set
            {
                accountingCustomerPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType PayeeParty
        {
            get
            {
                return payeePartyField;
            }
            set
            {
                payeePartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                return buyerCustomerPartyField;
            }
            set
            {
                buyerCustomerPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return sellerSupplierPartyField;
            }
            set
            {
                sellerSupplierPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType TaxRepresentativeParty
        {
            get
            {
                return taxRepresentativePartyField;
            }
            set
            {
                taxRepresentativePartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryType[] Delivery
        {
            get
            {
                return deliveryField;
            }
            set
            {
                deliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryTermsType[] DeliveryTerms
        {
            get
            {
                return deliveryTermsField;
            }
            set
            {
                deliveryTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentMeansType[] PaymentMeans
        {
            get
            {
                return paymentMeansField;
            }
            set
            {
                paymentMeansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return paymentTermsField;
            }
            set
            {
                paymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType TaxExchangeRate
        {
            get
            {
                return taxExchangeRateField;
            }
            set
            {
                taxExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PricingExchangeRate
        {
            get
            {
                return pricingExchangeRateField;
            }
            set
            {
                pricingExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentExchangeRate
        {
            get
            {
                return paymentExchangeRateField;
            }
            set
            {
                paymentExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentAlternativeExchangeRate
        {
            get
            {
                return paymentAlternativeExchangeRateField;
            }
            set
            {
                paymentAlternativeExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return allowanceChargeField;
            }
            set
            {
                allowanceChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return taxTotalField;
            }
            set
            {
                taxTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return legalMonetaryTotalField;
            }
            set
            {
                legalMonetaryTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CreditNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CreditNoteLineType[] CreditNoteLine
        {
            get
            {
                return creditNoteLineField;
            }
            set
            {
                creditNoteLineField = value;
            }
        }
    }
}