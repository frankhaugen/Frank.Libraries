namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("EvaluationCriterion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EvaluationCriterionType
    {

        private EvaluationCriterionTypeCodeType _evaluationCriterionTypeCodeField;

        private DescriptionType[] _descriptionField;

        private ThresholdAmountType _thresholdAmountField;

        private ThresholdQuantityType _thresholdQuantityField;

        private ExpressionCodeType _expressionCodeField;

        private ExpressionType[] _expressionField;

        private PeriodType _durationPeriodField;

        private EvidenceType[] _suggestedEvidenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EvaluationCriterionTypeCodeType EvaluationCriterionTypeCode
        {
            get
            {
                return _evaluationCriterionTypeCodeField;
            }
            set
            {
                _evaluationCriterionTypeCodeField = value;
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
        public ThresholdAmountType ThresholdAmount
        {
            get
            {
                return _thresholdAmountField;
            }
            set
            {
                _thresholdAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ThresholdQuantityType ThresholdQuantity
        {
            get
            {
                return _thresholdQuantityField;
            }
            set
            {
                _thresholdQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpressionCodeType ExpressionCode
        {
            get
            {
                return _expressionCodeField;
            }
            set
            {
                _expressionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Expression", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpressionType[] Expression
        {
            get
            {
                return _expressionField;
            }
            set
            {
                _expressionField = value;
            }
        }

        /// <remarks/>
        public PeriodType DurationPeriod
        {
            get
            {
                return _durationPeriodField;
            }
            set
            {
                _durationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SuggestedEvidence")]
        public EvidenceType[] SuggestedEvidence
        {
            get
            {
                return _suggestedEvidenceField;
            }
            set
            {
                _suggestedEvidenceField = value;
            }
        }
    }
}