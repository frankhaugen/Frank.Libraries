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

        private IDType idField;

        private PaymentMeansIDType[] paymentMeansIDField;

        private PrepaidPaymentReferenceIDType prepaidPaymentReferenceIDField;

        private NoteType[] noteField;

        private ReferenceEventCodeType referenceEventCodeField;

        private SettlementDiscountPercentType settlementDiscountPercentField;

        private PenaltySurchargePercentType penaltySurchargePercentField;

        private PaymentPercentType paymentPercentField;

        private AmountType2 amountField;

        private SettlementDiscountAmountType settlementDiscountAmountField;

        private PenaltyAmountType penaltyAmountField;

        private PaymentTermsDetailsURIType paymentTermsDetailsURIField;

        private PaymentDueDateType paymentDueDateField;

        private InstallmentDueDateType installmentDueDateField;

        private InvoicingPartyReferenceType invoicingPartyReferenceField;

        private PeriodType settlementPeriodField;

        private PeriodType penaltyPeriodField;

        private ExchangeRateType exchangeRateField;

        private PeriodType validityPeriodField;

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
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeansID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentMeansIDType[] PaymentMeansID
        {
            get
            {
                return paymentMeansIDField;
            }
            set
            {
                paymentMeansIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrepaidPaymentReferenceIDType PrepaidPaymentReferenceID
        {
            get
            {
                return prepaidPaymentReferenceIDField;
            }
            set
            {
                prepaidPaymentReferenceIDField = value;
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
        public ReferenceEventCodeType ReferenceEventCode
        {
            get
            {
                return referenceEventCodeField;
            }
            set
            {
                referenceEventCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SettlementDiscountPercentType SettlementDiscountPercent
        {
            get
            {
                return settlementDiscountPercentField;
            }
            set
            {
                settlementDiscountPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PenaltySurchargePercentType PenaltySurchargePercent
        {
            get
            {
                return penaltySurchargePercentField;
            }
            set
            {
                penaltySurchargePercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentPercentType PaymentPercent
        {
            get
            {
                return paymentPercentField;
            }
            set
            {
                paymentPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType2 Amount
        {
            get
            {
                return amountField;
            }
            set
            {
                amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SettlementDiscountAmountType SettlementDiscountAmount
        {
            get
            {
                return settlementDiscountAmountField;
            }
            set
            {
                settlementDiscountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PenaltyAmountType PenaltyAmount
        {
            get
            {
                return penaltyAmountField;
            }
            set
            {
                penaltyAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentTermsDetailsURIType PaymentTermsDetailsURI
        {
            get
            {
                return paymentTermsDetailsURIField;
            }
            set
            {
                paymentTermsDetailsURIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentDueDateType PaymentDueDate
        {
            get
            {
                return paymentDueDateField;
            }
            set
            {
                paymentDueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InstallmentDueDateType InstallmentDueDate
        {
            get
            {
                return installmentDueDateField;
            }
            set
            {
                installmentDueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InvoicingPartyReferenceType InvoicingPartyReference
        {
            get
            {
                return invoicingPartyReferenceField;
            }
            set
            {
                invoicingPartyReferenceField = value;
            }
        }

        /// <remarks/>
        public PeriodType SettlementPeriod
        {
            get
            {
                return settlementPeriodField;
            }
            set
            {
                settlementPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType PenaltyPeriod
        {
            get
            {
                return penaltyPeriodField;
            }
            set
            {
                penaltyPeriodField = value;
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
        public PeriodType ValidityPeriod
        {
            get
            {
                return validityPeriodField;
            }
            set
            {
                validityPeriodField = value;
            }
        }
    }
}