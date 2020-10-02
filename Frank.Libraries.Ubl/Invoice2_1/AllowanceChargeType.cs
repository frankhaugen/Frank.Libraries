namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AllowanceChargeType
    {

        private IDType idField;

        private ChargeIndicatorType chargeIndicatorField;

        private AllowanceChargeReasonCodeType allowanceChargeReasonCodeField;

        private AllowanceChargeReasonType[] allowanceChargeReasonField;

        private MultiplierFactorNumericType multiplierFactorNumericField;

        private PrepaidIndicatorType prepaidIndicatorField;

        private SequenceNumericType sequenceNumericField;

        private AmountType2 amountField;

        private BaseAmountType baseAmountField;

        private AccountingCostCodeType accountingCostCodeField;

        private AccountingCostType accountingCostField;

        private PerUnitAmountType perUnitAmountField;

        private TaxCategoryType[] taxCategoryField;

        private TaxTotalType taxTotalField;

        private PaymentMeansType[] paymentMeansField;

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
        public ChargeIndicatorType ChargeIndicator
        {
            get
            {
                return this.chargeIndicatorField;
            }
            set
            {
                this.chargeIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AllowanceChargeReasonCodeType AllowanceChargeReasonCode
        {
            get
            {
                return this.allowanceChargeReasonCodeField;
            }
            set
            {
                this.allowanceChargeReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceChargeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AllowanceChargeReasonType[] AllowanceChargeReason
        {
            get
            {
                return this.allowanceChargeReasonField;
            }
            set
            {
                this.allowanceChargeReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MultiplierFactorNumericType MultiplierFactorNumeric
        {
            get
            {
                return this.multiplierFactorNumericField;
            }
            set
            {
                this.multiplierFactorNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrepaidIndicatorType PrepaidIndicator
        {
            get
            {
                return this.prepaidIndicatorField;
            }
            set
            {
                this.prepaidIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceNumericType SequenceNumeric
        {
            get
            {
                return this.sequenceNumericField;
            }
            set
            {
                this.sequenceNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType2 Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseAmountType BaseAmount
        {
            get
            {
                return this.baseAmountField;
            }
            set
            {
                this.baseAmountField = value;
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
        public PerUnitAmountType PerUnitAmount
        {
            get
            {
                return this.perUnitAmountField;
            }
            set
            {
                this.perUnitAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxCategory")]
        public TaxCategoryType[] TaxCategory
        {
            get
            {
                return this.taxCategoryField;
            }
            set
            {
                this.taxCategoryField = value;
            }
        }

        /// <remarks/>
        public TaxTotalType TaxTotal
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
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans")]
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
    }
}