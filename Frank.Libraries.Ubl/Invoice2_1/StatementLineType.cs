namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("StatementLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class StatementLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private UUIDType uUIDField;

        private BalanceBroughtForwardIndicatorType balanceBroughtForwardIndicatorField;

        private DebitLineAmountType debitLineAmountField;

        private CreditLineAmountType creditLineAmountField;

        private BalanceAmountType balanceAmountField;

        private PaymentPurposeCodeType paymentPurposeCodeField;

        private PaymentMeansType paymentMeansField;

        private PaymentTermsType[] paymentTermsField;

        private CustomerPartyType buyerCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private CustomerPartyType originatorCustomerPartyField;

        private CustomerPartyType accountingCustomerPartyField;

        private SupplierPartyType accountingSupplierPartyField;

        private PartyType payeePartyField;

        private PeriodType[] invoicePeriodField;

        private BillingReferenceType[] billingReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private ExchangeRateType exchangeRateField;

        private AllowanceChargeType[] allowanceChargeField;

        private PaymentType[] collectedPaymentField;

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
        public BalanceBroughtForwardIndicatorType BalanceBroughtForwardIndicator
        {
            get
            {
                return balanceBroughtForwardIndicatorField;
            }
            set
            {
                balanceBroughtForwardIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DebitLineAmountType DebitLineAmount
        {
            get
            {
                return debitLineAmountField;
            }
            set
            {
                debitLineAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CreditLineAmountType CreditLineAmount
        {
            get
            {
                return creditLineAmountField;
            }
            set
            {
                creditLineAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BalanceAmountType BalanceAmount
        {
            get
            {
                return balanceAmountField;
            }
            set
            {
                balanceAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentPurposeCodeType PaymentPurposeCode
        {
            get
            {
                return paymentPurposeCodeField;
            }
            set
            {
                paymentPurposeCodeField = value;
            }
        }

        /// <remarks/>
        public PaymentMeansType PaymentMeans
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
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
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
        public CustomerPartyType OriginatorCustomerParty
        {
            get
            {
                return originatorCustomerPartyField;
            }
            set
            {
                originatorCustomerPartyField = value;
            }
        }

        /// <remarks/>
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
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod")]
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
        [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
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
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return documentReferenceField;
            }
            set
            {
                documentReferenceField = value;
            }
        }

        /// <remarks/>
        public ExchangeRateType ExchangeRate
        {
            get
            {
                return exchangeRateField;
            }
            set
            {
                exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
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
        [System.Xml.Serialization.XmlElementAttribute("CollectedPayment")]
        public PaymentType[] CollectedPayment
        {
            get
            {
                return collectedPaymentField;
            }
            set
            {
                collectedPaymentField = value;
            }
        }
    }
}