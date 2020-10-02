namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("EnvironmentalEmission", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EnvironmentalEmissionType
    {

        private EnvironmentalEmissionTypeCodeType _environmentalEmissionTypeCodeField;

        private ValueMeasureType _valueMeasureField;

        private DescriptionType[] _descriptionField;

        private EmissionCalculationMethodType[] _emissionCalculationMethodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EnvironmentalEmissionTypeCodeType EnvironmentalEmissionTypeCode
        {
            get
            {
                return _environmentalEmissionTypeCodeField;
            }
            set
            {
                _environmentalEmissionTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValueMeasureType ValueMeasure
        {
            get
            {
                return _valueMeasureField;
            }
            set
            {
                _valueMeasureField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("EmissionCalculationMethod")]
        public EmissionCalculationMethodType[] EmissionCalculationMethod
        {
            get
            {
                return _emissionCalculationMethodField;
            }
            set
            {
                _emissionCalculationMethodField = value;
            }
        }
    }
}