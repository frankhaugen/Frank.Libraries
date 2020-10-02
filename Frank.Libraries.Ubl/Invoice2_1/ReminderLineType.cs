namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ReminderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ReminderLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private UUIDType uUIDField;

        private BalanceBroughtForwardIndicatorType balanceBroughtForwardIndicatorField;

        private DebitLineAmountType debitLineAmountField;

        private CreditLineAmountType creditLineAmountField;

        private AccountingCostCodeType accountingCostCodeField;

        private AccountingCostType accountingCostField;

        private PenaltySurchargePercentType penaltySurchargePercentField;

        private AmountType2 amountField;

        private PaymentPurposeCodeType paymentPurposeCodeField;

        private PeriodType[] reminderPeriodField;

        private BillingReferenceType[] billingReferenceField;

        private ExchangeRateType exchangeRateField;

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
        [System.Xml.Serialization.XmlElementAttribute("ReminderPeriod")]
        public PeriodType[] ReminderPeriod
        {
            get
            {
                return reminderPeriodField;
            }
            set
            {
                reminderPeriodField = value;
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
    }
}