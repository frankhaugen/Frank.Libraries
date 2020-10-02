namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("RemittanceAdviceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class RemittanceAdviceLineType
    {

        private IdType _idField;

        private NoteType[] _noteField;

        private UuidType _uUidField;

        private DebitLineAmountType _debitLineAmountField;

        private CreditLineAmountType _creditLineAmountField;

        private BalanceAmountType _balanceAmountField;

        private PaymentPurposeCodeType _paymentPurposeCodeField;

        private InvoicingPartyReferenceType _invoicingPartyReferenceField;

        private SupplierPartyType _accountingSupplierPartyField;

        private CustomerPartyType _accountingCustomerPartyField;

        private CustomerPartyType _buyerCustomerPartyField;

        private SupplierPartyType _sellerSupplierPartyField;

        private CustomerPartyType _originatorCustomerPartyField;

        private PartyType _payeePartyField;

        private PeriodType[] _invoicePeriodField;

        private BillingReferenceType[] _billingReferenceField;

        private DocumentReferenceType[] _documentReferenceField;

        private ExchangeRateType _exchangeRateField;

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
        public DebitLineAmountType DebitLineAmount
        {
            get
            {
                return _debitLineAmountField;
            }
            set
            {
                _debitLineAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CreditLineAmountType CreditLineAmount
        {
            get
            {
                return _creditLineAmountField;
            }
            set
            {
                _creditLineAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BalanceAmountType BalanceAmount
        {
            get
            {
                return _balanceAmountField;
            }
            set
            {
                _balanceAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentPurposeCodeType PaymentPurposeCode
        {
            get
            {
                return _paymentPurposeCodeField;
            }
            set
            {
                _paymentPurposeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InvoicingPartyReferenceType InvoicingPartyReference
        {
            get
            {
                return _invoicingPartyReferenceField;
            }
            set
            {
                _invoicingPartyReferenceField = value;
            }
        }

        /// <remarks/>
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
        public CustomerPartyType OriginatorCustomerParty
        {
            get
            {
                return _originatorCustomerPartyField;
            }
            set
            {
                _originatorCustomerPartyField = value;
            }
        }

        /// <remarks/>
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
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod")]
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
        [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
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
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return _documentReferenceField;
            }
            set
            {
                _documentReferenceField = value;
            }
        }

        /// <remarks/>
        public ExchangeRateType ExchangeRate
        {
            get
            {
                return _exchangeRateField;
            }
            set
            {
                _exchangeRateField = value;
            }
        }
    }
}