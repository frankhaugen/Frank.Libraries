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

        private MeterNumberType meterNumberField;

        private MeterNameType meterNameField;

        private MeterConstantType meterConstantField;

        private MeterConstantCodeType meterConstantCodeField;

        private TotalDeliveredQuantityType totalDeliveredQuantityField;

        private MeterReadingType[] meterReadingField;

        private MeterPropertyType[] meterPropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterNumberType MeterNumber
        {
            get
            {
                return meterNumberField;
            }
            set
            {
                meterNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterNameType MeterName
        {
            get
            {
                return meterNameField;
            }
            set
            {
                meterNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterConstantType MeterConstant
        {
            get
            {
                return meterConstantField;
            }
            set
            {
                meterConstantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterConstantCodeType MeterConstantCode
        {
            get
            {
                return meterConstantCodeField;
            }
            set
            {
                meterConstantCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalDeliveredQuantityType TotalDeliveredQuantity
        {
            get
            {
                return totalDeliveredQuantityField;
            }
            set
            {
                totalDeliveredQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterReading")]
        public MeterReadingType[] MeterReading
        {
            get
            {
                return meterReadingField;
            }
            set
            {
                meterReadingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterProperty")]
        public MeterPropertyType[] MeterProperty
        {
            get
            {
                return meterPropertyField;
            }
            set
            {
                meterPropertyField = value;
            }
        }
    }
}