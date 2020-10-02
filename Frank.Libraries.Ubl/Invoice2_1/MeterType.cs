namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Meter", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class MeterType
    {

        private MeterNumberType _meterNumberField;

        private MeterNameType _meterNameField;

        private MeterConstantType _meterConstantField;

        private MeterConstantCodeType _meterConstantCodeField;

        private TotalDeliveredQuantityType _totalDeliveredQuantityField;

        private MeterReadingType[] _meterReadingField;

        private MeterPropertyType[] _meterPropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterNumberType MeterNumber
        {
            get
            {
                return _meterNumberField;
            }
            set
            {
                _meterNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterNameType MeterName
        {
            get
            {
                return _meterNameField;
            }
            set
            {
                _meterNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterConstantType MeterConstant
        {
            get
            {
                return _meterConstantField;
            }
            set
            {
                _meterConstantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterConstantCodeType MeterConstantCode
        {
            get
            {
                return _meterConstantCodeField;
            }
            set
            {
                _meterConstantCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalDeliveredQuantityType TotalDeliveredQuantity
        {
            get
            {
                return _totalDeliveredQuantityField;
            }
            set
            {
                _totalDeliveredQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterReading")]
        public MeterReadingType[] MeterReading
        {
            get
            {
                return _meterReadingField;
            }
            set
            {
                _meterReadingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterProperty")]
        public MeterPropertyType[] MeterProperty
        {
            get
            {
                return _meterPropertyField;
            }
            set
            {
                _meterPropertyField = value;
            }
        }
    }
}