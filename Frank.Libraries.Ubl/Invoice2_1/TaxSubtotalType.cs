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

        private TaxableAmountType taxableAmountField;

        private TaxAmountType taxAmountField;

        private CalculationSequenceNumericType calculationSequenceNumericField;

        private TransactionCurrencyTaxAmountType transactionCurrencyTaxAmountField;

        private PercentType1 percentField;

        private BaseUnitMeasureType baseUnitMeasureField;

        private PerUnitAmountType perUnitAmountField;

        private TierRangeType tierRangeField;

        private TierRatePercentType tierRatePercentField;

        private TaxCategoryType taxCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxableAmountType TaxableAmount
        {
            get
            {
                return taxableAmountField;
            }
            set
            {
                taxableAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxAmountType TaxAmount
        {
            get
            {
                return taxAmountField;
            }
            set
            {
                taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationSequenceNumericType CalculationSequenceNumeric
        {
            get
            {
                return calculationSequenceNumericField;
            }
            set
            {
                calculationSequenceNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransactionCurrencyTaxAmountType TransactionCurrencyTaxAmount
        {
            get
            {
                return transactionCurrencyTaxAmountField;
            }
            set
            {
                transactionCurrencyTaxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType1 Percent
        {
            get
            {
                return percentField;
            }
            set
            {
                percentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseUnitMeasureType BaseUnitMeasure
        {
            get
            {
                return baseUnitMeasureField;
            }
            set
            {
                baseUnitMeasureField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TierRangeType TierRange
        {
            get
            {
                return tierRangeField;
            }
            set
            {
                tierRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TierRatePercentType TierRatePercent
        {
            get
            {
                return tierRatePercentField;
            }
            set
            {
                tierRatePercentField = value;
            }
        }

        /// <remarks/>
        public TaxCategoryType TaxCategory
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
    }
}