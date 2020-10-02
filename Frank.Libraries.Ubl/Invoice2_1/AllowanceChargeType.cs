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
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChargeIndicatorType ChargeIndicator
        {
            get
            {
                return chargeIndicatorField;
            }
            set
            {
                chargeIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AllowanceChargeReasonCodeType AllowanceChargeReasonCode
        {
            get
            {
                return allowanceChargeReasonCodeField;
            }
            set
            {
                allowanceChargeReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceChargeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AllowanceChargeReasonType[] AllowanceChargeReason
        {
            get
            {
                return allowanceChargeReasonField;
            }
            set
            {
                allowanceChargeReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MultiplierFactorNumericType MultiplierFactorNumeric
        {
            get
            {
                return multiplierFactorNumericField;
            }
            set
            {
                multiplierFactorNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrepaidIndicatorType PrepaidIndicator
        {
            get
            {
                return prepaidIndicatorField;
            }
            set
            {
                prepaidIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceNumericType SequenceNumeric
        {
            get
            {
                return sequenceNumericField;
            }
            set
            {
                sequenceNumericField = value;
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
        public BaseAmountType BaseAmount
        {
            get
            {
                return baseAmountField;
            }
            set
            {
                baseAmountField = value;
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
        public PerUnitAmountType PerUnitAmount
        {
            get
            {
                return perUnitAmountField;
            }
            set
            {
                perUnitAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxCategory")]
        public TaxCategoryType[] TaxCategory
        {
            get
            {
                return taxCategoryField;
            }
            set
            {
                taxCategoryField = value;
            }
        }

        /// <remarks/>
        public TaxTotalType TaxTotal
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
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans")]
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
    }
}