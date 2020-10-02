namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AllowedSubcontractTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class SubcontractTermsType
    {

        private RateType1 _rateField;

        private UnknownPriceIndicatorType _unknownPriceIndicatorField;

        private DescriptionType[] _descriptionField;

        private AmountType2 _amountField;

        private SubcontractingConditionsCodeType _subcontractingConditionsCodeField;

        private MaximumPercentType _maximumPercentField;

        private MinimumPercentType _minimumPercentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RateType1 Rate
        {
            get
            {
                return _rateField;
            }
            set
            {
                _rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UnknownPriceIndicatorType UnknownPriceIndicator
        {
            get
            {
                return _unknownPriceIndicatorField;
            }
            set
            {
                _unknownPriceIndicatorField = value;
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
        public SubcontractingConditionsCodeType SubcontractingConditionsCode
        {
            get
            {
                return _subcontractingConditionsCodeField;
            }
            set
            {
                _subcontractingConditionsCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumPercentType MaximumPercent
        {
            get
            {
                return _maximumPercentField;
            }
            set
            {
                _maximumPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumPercentType MinimumPercent
        {
            get
            {
                return _minimumPercentField;
            }
            set
            {
                _minimumPercentField = value;
            }
        }
    }
}