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

        private IDType idField;

        private AwardingCriterionTypeCodeType awardingCriterionTypeCodeField;

        private DescriptionType[] descriptionField;

        private WeightNumericType weightNumericField;

        private WeightType[] weightField;

        private CalculationExpressionType[] calculationExpressionField;

        private CalculationExpressionCodeType calculationExpressionCodeField;

        private MinimumQuantityType minimumQuantityField;

        private MaximumQuantityType maximumQuantityField;

        private MinimumAmountType minimumAmountField;

        private MaximumAmountType maximumAmountField;

        private MinimumImprovementBidType[] minimumImprovementBidField;

        private AwardingCriterionType[] subordinateAwardingCriterionField;

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
        public AwardingCriterionTypeCodeType AwardingCriterionTypeCode
        {
            get
            {
                return awardingCriterionTypeCodeField;
            }
            set
            {
                awardingCriterionTypeCodeField = value;
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
        public WeightNumericType WeightNumeric
        {
            get
            {
                return weightNumericField;
            }
            set
            {
                weightNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Weight", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WeightType[] Weight
        {
            get
            {
                return weightField;
            }
            set
            {
                weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CalculationExpression", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationExpressionType[] CalculationExpression
        {
            get
            {
                return calculationExpressionField;
            }
            set
            {
                calculationExpressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationExpressionCodeType CalculationExpressionCode
        {
            get
            {
                return calculationExpressionCodeField;
            }
            set
            {
                calculationExpressionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return minimumQuantityField;
            }
            set
            {
                minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return maximumQuantityField;
            }
            set
            {
                maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumAmountType MinimumAmount
        {
            get
            {
                return minimumAmountField;
            }
            set
            {
                minimumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumAmountType MaximumAmount
        {
            get
            {
                return maximumAmountField;
            }
            set
            {
                maximumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MinimumImprovementBid", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumImprovementBidType[] MinimumImprovementBid
        {
            get
            {
                return minimumImprovementBidField;
            }
            set
            {
                minimumImprovementBidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubordinateAwardingCriterion")]
        public AwardingCriterionType[] SubordinateAwardingCriterion
        {
            get
            {
                return subordinateAwardingCriterionField;
            }
            set
            {
                subordinateAwardingCriterionField = value;
            }
        }
    }
}