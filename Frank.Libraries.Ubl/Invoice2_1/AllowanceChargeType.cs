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

        private IdType _idField;

        private ChargeIndicatorType _chargeIndicatorField;

        private AllowanceChargeReasonCodeType _allowanceChargeReasonCodeField;

        private AllowanceChargeReasonType[] _allowanceChargeReasonField;

        private MultiplierFactorNumericType _multiplierFactorNumericField;

        private PrepaidIndicatorType _prepaidIndicatorField;

        private SequenceNumericType _sequenceNumericField;

        private AmountType2 _amountField;

        private BaseAmountType _baseAmountField;

        private AccountingCostCodeType _accountingCostCodeField;

        private AccountingCostType _accountingCostField;

        private PerUnitAmountType _perUnitAmountField;

        private TaxCategoryType[] _taxCategoryField;

        private TaxTotalType _taxTotalField;

        private PaymentMeansType[] _paymentMeansField;

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
        public ChargeIndicatorType ChargeIndicator
        {
            get
            {
                return _chargeIndicatorField;
            }
            set
            {
                _chargeIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AllowanceChargeReasonCodeType AllowanceChargeReasonCode
        {
            get
            {
                return _allowanceChargeReasonCodeField;
            }
            set
            {
                _allowanceChargeReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceChargeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AllowanceChargeReasonType[] AllowanceChargeReason
        {
            get
            {
                return _allowanceChargeReasonField;
            }
            set
            {
                _allowanceChargeReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MultiplierFactorNumericType MultiplierFactorNumeric
        {
            get
            {
                return _multiplierFactorNumericField;
            }
            set
            {
                _multiplierFactorNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrepaidIndicatorType PrepaidIndicator
        {
            get
            {
                return _prepaidIndicatorField;
            }
            set
            {
                _prepaidIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceNumericType SequenceNumeric
        {
            get
            {
                return _sequenceNumericField;
            }
            set
            {
                _sequenceNumericField = value;
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
        public BaseAmountType BaseAmount
        {
            get
            {
                return _baseAmountField;
            }
            set
            {
                _baseAmountField = value;
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
        public PerUnitAmountType PerUnitAmount
        {
            get
            {
                return _perUnitAmountField;
            }
            set
            {
                _perUnitAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxCategory")]
        public TaxCategoryType[] TaxCategory
        {
            get
            {
                return _taxCategoryField;
            }
            set
            {
                _taxCategoryField = value;
            }
        }

        /// <remarks/>
        public TaxTotalType TaxTotal
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
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans")]
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
    }
}