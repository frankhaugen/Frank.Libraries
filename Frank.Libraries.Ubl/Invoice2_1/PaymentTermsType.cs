namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("BonusPaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PaymentTermsType
    {

        private IdType _idField;

        private PaymentMeansIdType[] _paymentMeansIdField;

        private PrepaidPaymentReferenceIdType _prepaidPaymentReferenceIdField;

        private NoteType[] _noteField;

        private ReferenceEventCodeType _referenceEventCodeField;

        private SettlementDiscountPercentType _settlementDiscountPercentField;

        private PenaltySurchargePercentType _penaltySurchargePercentField;

        private PaymentPercentType _paymentPercentField;

        private AmountType2 _amountField;

        private SettlementDiscountAmountType _settlementDiscountAmountField;

        private PenaltyAmountType _penaltyAmountField;

        private PaymentTermsDetailsUriType _paymentTermsDetailsUriField;

        private PaymentDueDateType _paymentDueDateField;

        private InstallmentDueDateType _installmentDueDateField;

        private InvoicingPartyReferenceType _invoicingPartyReferenceField;

        private PeriodType _settlementPeriodField;

        private PeriodType _penaltyPeriodField;

        private ExchangeRateType _exchangeRateField;

        private PeriodType _validityPeriodField;

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
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeansID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentMeansIdType[] PaymentMeansId
        {
            get
            {
                return _paymentMeansIdField;
            }
            set
            {
                _paymentMeansIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrepaidPaymentReferenceIdType PrepaidPaymentReferenceId
        {
            get
            {
                return _prepaidPaymentReferenceIdField;
            }
            set
            {
                _prepaidPaymentReferenceIdField = value;
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
        public ReferenceEventCodeType ReferenceEventCode
        {
            get
            {
                return _referenceEventCodeField;
            }
            set
            {
                _referenceEventCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SettlementDiscountPercentType SettlementDiscountPercent
        {
            get
            {
                return _settlementDiscountPercentField;
            }
            set
            {
                _settlementDiscountPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PenaltySurchargePercentType PenaltySurchargePercent
        {
            get
            {
                return _penaltySurchargePercentField;
            }
            set
            {
                _penaltySurchargePercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentPercentType PaymentPercent
        {
            get
            {
                return _paymentPercentField;
            }
            set
            {
                _paymentPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType2 Amount
        {
            get
            {
                return _amountField;
            }
            set
            {
                _amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SettlementDiscountAmountType SettlementDiscountAmount
        {
            get
            {
                return _settlementDiscountAmountField;
            }
            set
            {
                _settlementDiscountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PenaltyAmountType PenaltyAmount
        {
            get
            {
                return _penaltyAmountField;
            }
            set
            {
                _penaltyAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentTermsDetailsUriType PaymentTermsDetailsUri
        {
            get
            {
                return _paymentTermsDetailsUriField;
            }
            set
            {
                _paymentTermsDetailsUriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentDueDateType PaymentDueDate
        {
            get
            {
                return _paymentDueDateField;
            }
            set
            {
                _paymentDueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InstallmentDueDateType InstallmentDueDate
        {
            get
            {
                return _installmentDueDateField;
            }
            set
            {
                _installmentDueDateField = value;
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
        public PeriodType SettlementPeriod
        {
            get
            {
                return _settlementPeriodField;
            }
            set
            {
                _settlementPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType PenaltyPeriod
        {
            get
            {
                return _penaltyPeriodField;
            }
            set
            {
                _penaltyPeriodField = value;
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

        /// <remarks/>
        public PeriodType ValidityPeriod
        {
            get
            {
                return _validityPeriodField;
            }
            set
            {
                _validityPeriodField = value;
            }
        }
    }
}