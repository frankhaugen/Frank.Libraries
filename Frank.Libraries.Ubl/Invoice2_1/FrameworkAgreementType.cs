namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("FrameworkAgreement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class FrameworkAgreementType
    {

        private ExpectedOperatorQuantityType _expectedOperatorQuantityField;

        private MaximumOperatorQuantityType _maximumOperatorQuantityField;

        private JustificationType[] _justificationField;

        private FrequencyType[] _frequencyField;

        private PeriodType _durationPeriodField;

        private TenderRequirementType[] _subsequentProcessTenderRequirementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpectedOperatorQuantityType ExpectedOperatorQuantity
        {
            get
            {
                return _expectedOperatorQuantityField;
            }
            set
            {
                _expectedOperatorQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumOperatorQuantityType MaximumOperatorQuantity
        {
            get
            {
                return _maximumOperatorQuantityField;
            }
            set
            {
                _maximumOperatorQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Justification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public JustificationType[] Justification
        {
            get
            {
                return _justificationField;
            }
            set
            {
                _justificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Frequency", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FrequencyType[] Frequency
        {
            get
            {
                return _frequencyField;
            }
            set
            {
                _frequencyField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SubsequentProcessTenderRequirement")]
        public TenderRequirementType[] SubsequentProcessTenderRequirement
        {
            get
            {
                return _subsequentProcessTenderRequirementField;
            }
            set
            {
                _subsequentProcessTenderRequirementField = value;
            }
        }
    }
}