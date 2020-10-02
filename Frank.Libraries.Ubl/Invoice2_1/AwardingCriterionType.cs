namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AwardingCriterion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AwardingCriterionType
    {

        private IdType _idField;

        private AwardingCriterionTypeCodeType _awardingCriterionTypeCodeField;

        private DescriptionType[] _descriptionField;

        private WeightNumericType _weightNumericField;

        private WeightType[] _weightField;

        private CalculationExpressionType[] _calculationExpressionField;

        private CalculationExpressionCodeType _calculationExpressionCodeField;

        private MinimumQuantityType _minimumQuantityField;

        private MaximumQuantityType _maximumQuantityField;

        private MinimumAmountType _minimumAmountField;

        private MaximumAmountType _maximumAmountField;

        private MinimumImprovementBidType[] _minimumImprovementBidField;

        private AwardingCriterionType[] _subordinateAwardingCriterionField;

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
        public AwardingCriterionTypeCodeType AwardingCriterionTypeCode
        {
            get
            {
                return _awardingCriterionTypeCodeField;
            }
            set
            {
                _awardingCriterionTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WeightNumericType WeightNumeric
        {
            get
            {
                return _weightNumericField;
            }
            set
            {
                _weightNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Weight", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WeightType[] Weight
        {
            get
            {
                return _weightField;
            }
            set
            {
                _weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CalculationExpression", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationExpressionType[] CalculationExpression
        {
            get
            {
                return _calculationExpressionField;
            }
            set
            {
                _calculationExpressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationExpressionCodeType CalculationExpressionCode
        {
            get
            {
                return _calculationExpressionCodeField;
            }
            set
            {
                _calculationExpressionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return _minimumQuantityField;
            }
            set
            {
                _minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return _maximumQuantityField;
            }
            set
            {
                _maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumAmountType MinimumAmount
        {
            get
            {
                return _minimumAmountField;
            }
            set
            {
                _minimumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumAmountType MaximumAmount
        {
            get
            {
                return _maximumAmountField;
            }
            set
            {
                _maximumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MinimumImprovementBid", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumImprovementBidType[] MinimumImprovementBid
        {
            get
            {
                return _minimumImprovementBidField;
            }
            set
            {
                _minimumImprovementBidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubordinateAwardingCriterion")]
        public AwardingCriterionType[] SubordinateAwardingCriterion
        {
            get
            {
                return _subordinateAwardingCriterionField;
            }
            set
            {
                _subordinateAwardingCriterionField = value;
            }
        }
    }
}