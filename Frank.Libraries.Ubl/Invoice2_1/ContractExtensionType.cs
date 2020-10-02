namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ContractExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ContractExtensionType
    {

        private OptionsDescriptionType[] _optionsDescriptionField;

        private MinimumNumberNumericType _minimumNumberNumericField;

        private MaximumNumberNumericType _maximumNumberNumericField;

        private PeriodType _optionValidityPeriodField;

        private RenewalType[] _renewalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OptionsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OptionsDescriptionType[] OptionsDescription
        {
            get
            {
                return _optionsDescriptionField;
            }
            set
            {
                _optionsDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumNumberNumericType MinimumNumberNumeric
        {
            get
            {
                return _minimumNumberNumericField;
            }
            set
            {
                _minimumNumberNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumNumberNumericType MaximumNumberNumeric
        {
            get
            {
                return _maximumNumberNumericField;
            }
            set
            {
                _maximumNumberNumericField = value;
            }
        }

        /// <remarks/>
        public PeriodType OptionValidityPeriod
        {
            get
            {
                return _optionValidityPeriodField;
            }
            set
            {
                _optionValidityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Renewal")]
        public RenewalType[] Renewal
        {
            get
            {
                return _renewalField;
            }
            set
            {
                _renewalField = value;
            }
        }
    }
}