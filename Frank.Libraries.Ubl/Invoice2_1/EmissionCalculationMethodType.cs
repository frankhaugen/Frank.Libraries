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

        private CalculationMethodCodeType calculationMethodCodeField;

        private FullnessIndicationCodeType fullnessIndicationCodeField;

        private LocationType1 measurementFromLocationField;

        private LocationType1 measurementToLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationMethodCodeType CalculationMethodCode
        {
            get
            {
                return calculationMethodCodeField;
            }
            set
            {
                calculationMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FullnessIndicationCodeType FullnessIndicationCode
        {
            get
            {
                return fullnessIndicationCodeField;
            }
            set
            {
                fullnessIndicationCodeField = value;
            }
        }

        /// <remarks/>
        public LocationType1 MeasurementFromLocation
        {
            get
            {
                return measurementFromLocationField;
            }
            set
            {
                measurementFromLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 MeasurementToLocation
        {
            get
            {
                return measurementToLocationField;
            }
            set
            {
                measurementToLocationField = value;
            }
        }
    }
}