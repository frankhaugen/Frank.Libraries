namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("MeterReading", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class MeterReadingType
    {

        private IdType _idField;

        private MeterReadingTypeType _meterReadingType1Field;

        private MeterReadingTypeCodeType _meterReadingTypeCodeField;

        private PreviousMeterReadingDateType _previousMeterReadingDateField;

        private PreviousMeterQuantityType _previousMeterQuantityField;

        private LatestMeterReadingDateType _latestMeterReadingDateField;

        private LatestMeterQuantityType _latestMeterQuantityField;

        private PreviousMeterReadingMethodType _previousMeterReadingMethodField;

        private PreviousMeterReadingMethodCodeType _previousMeterReadingMethodCodeField;

        private LatestMeterReadingMethodType _latestMeterReadingMethodField;

        private LatestMeterReadingMethodCodeType _latestMeterReadingMethodCodeField;

        private MeterReadingCommentsType[] _meterReadingCommentsField;

        private DeliveredQuantityType _deliveredQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdType Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterReadingType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterReadingTypeType MeterReadingType1
        {
            get
            {
                return _meterReadingType1Field;
            }
            set
            {
                _meterReadingType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterReadingTypeCodeType MeterReadingTypeCode
        {
            get
            {
                return _meterReadingTypeCodeField;
            }
            set
            {
                _meterReadingTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterReadingDateType PreviousMeterReadingDate
        {
            get
            {
                return _previousMeterReadingDateField;
            }
            set
            {
                _previousMeterReadingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterQuantityType PreviousMeterQuantity
        {
            get
            {
                return _previousMeterQuantityField;
            }
            set
            {
                _previousMeterQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterReadingDateType LatestMeterReadingDate
        {
            get
            {
                return _latestMeterReadingDateField;
            }
            set
            {
                _latestMeterReadingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterQuantityType LatestMeterQuantity
        {
            get
            {
                return _latestMeterQuantityField;
            }
            set
            {
                _latestMeterQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterReadingMethodType PreviousMeterReadingMethod
        {
            get
            {
                return _previousMeterReadingMethodField;
            }
            set
            {
                _previousMeterReadingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterReadingMethodCodeType PreviousMeterReadingMethodCode
        {
            get
            {
                return _previousMeterReadingMethodCodeField;
            }
            set
            {
                _previousMeterReadingMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterReadingMethodType LatestMeterReadingMethod
        {
            get
            {
                return _latestMeterReadingMethodField;
            }
            set
            {
                _latestMeterReadingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterReadingMethodCodeType LatestMeterReadingMethodCode
        {
            get
            {
                return _latestMeterReadingMethodCodeField;
            }
            set
            {
                _latestMeterReadingMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterReadingComments", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterReadingCommentsType[] MeterReadingComments
        {
            get
            {
                return _meterReadingCommentsField;
            }
            set
            {
                _meterReadingCommentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeliveredQuantityType DeliveredQuantity
        {
            get
            {
                return _deliveredQuantityField;
            }
            set
            {
                _deliveredQuantityField = value;
            }
        }
    }
}