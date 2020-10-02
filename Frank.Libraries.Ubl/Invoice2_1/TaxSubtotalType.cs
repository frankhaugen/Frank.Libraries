namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TaxSubtotalType
    {

        private TaxableAmountType _taxableAmountField;

        private TaxAmountType _taxAmountField;

        private CalculationSequenceNumericType _calculationSequenceNumericField;

        private TransactionCurrencyTaxAmountType _transactionCurrencyTaxAmountField;

        private PercentType1 _percentField;

        private BaseUnitMeasureType _baseUnitMeasureField;

        private PerUnitAmountType _perUnitAmountField;

        private TierRangeType _tierRangeField;

        private TierRatePercentType _tierRatePercentField;

        private TaxCategoryType _taxCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxableAmountType TaxableAmount
        {
            get
            {
                return _taxableAmountField;
            }
            set
            {
                _taxableAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxAmountType TaxAmount
        {
            get
            {
                return _taxAmountField;
            }
            set
            {
                _taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationSequenceNumericType CalculationSequenceNumeric
        {
            get
            {
                return _calculationSequenceNumericField;
            }
            set
            {
                _calculationSequenceNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransactionCurrencyTaxAmountType TransactionCurrencyTaxAmount
        {
            get
            {
                return _transactionCurrencyTaxAmountField;
            }
            set
            {
                _transactionCurrencyTaxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType1 Percent
        {
            get
            {
                return _percentField;
            }
            set
            {
                _percentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseUnitMeasureType BaseUnitMeasure
        {
            get
            {
                return _baseUnitMeasureField;
            }
            set
            {
                _baseUnitMeasureField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TierRangeType TierRange
        {
            get
            {
                return _tierRangeField;
            }
            set
            {
                _tierRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TierRatePercentType TierRatePercent
        {
            get
            {
                return _tierRatePercentField;
            }
            set
            {
                _tierRatePercentField = value;
            }
        }

        /// <remarks/>
        public TaxCategoryType TaxCategory
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
    }
}