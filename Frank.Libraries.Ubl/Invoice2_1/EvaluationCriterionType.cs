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

        private EvaluationCriterionTypeCodeType evaluationCriterionTypeCodeField;

        private DescriptionType[] descriptionField;

        private ThresholdAmountType thresholdAmountField;

        private ThresholdQuantityType thresholdQuantityField;

        private ExpressionCodeType expressionCodeField;

        private ExpressionType[] expressionField;

        private PeriodType durationPeriodField;

        private EvidenceType[] suggestedEvidenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EvaluationCriterionTypeCodeType EvaluationCriterionTypeCode
        {
            get
            {
                return evaluationCriterionTypeCodeField;
            }
            set
            {
                evaluationCriterionTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ThresholdAmountType ThresholdAmount
        {
            get
            {
                return thresholdAmountField;
            }
            set
            {
                thresholdAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ThresholdQuantityType ThresholdQuantity
        {
            get
            {
                return thresholdQuantityField;
            }
            set
            {
                thresholdQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpressionCodeType ExpressionCode
        {
            get
            {
                return expressionCodeField;
            }
            set
            {
                expressionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Expression", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpressionType[] Expression
        {
            get
            {
                return expressionField;
            }
            set
            {
                expressionField = value;
            }
        }

        /// <remarks/>
        public PeriodType DurationPeriod
        {
            get
            {
                return durationPeriodField;
            }
            set
            {
                durationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SuggestedEvidence")]
        public EvidenceType[] SuggestedEvidence
        {
            get
            {
                return suggestedEvidenceField;
            }
            set
            {
                suggestedEvidenceField = value;
            }
        }
    }
}