namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("EmissionCalculationMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EmissionCalculationMethodType
    {

        private CalculationMethodCodeType _calculationMethodCodeField;

        private FullnessIndicationCodeType _fullnessIndicationCodeField;

        private LocationType1 _measurementFromLocationField;

        private LocationType1 _measurementToLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationMethodCodeType CalculationMethodCode
        {
            get
            {
                return _calculationMethodCodeField;
            }
            set
            {
                _calculationMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FullnessIndicationCodeType FullnessIndicationCode
        {
            get
            {
                return _fullnessIndicationCodeField;
            }
            set
            {
                _fullnessIndicationCodeField = value;
            }
        }

        /// <remarks/>
        public LocationType1 MeasurementFromLocation
        {
            get
            {
                return _measurementFromLocationField;
            }
            set
            {
                _measurementFromLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 MeasurementToLocation
        {
            get
            {
                return _measurementToLocationField;
            }
            set
            {
                _measurementToLocationField = value;
            }
        }
    }
}