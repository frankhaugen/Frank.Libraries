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

        private IDType idField;

        private MeterReadingTypeType meterReadingType1Field;

        private MeterReadingTypeCodeType meterReadingTypeCodeField;

        private PreviousMeterReadingDateType previousMeterReadingDateField;

        private PreviousMeterQuantityType previousMeterQuantityField;

        private LatestMeterReadingDateType latestMeterReadingDateField;

        private LatestMeterQuantityType latestMeterQuantityField;

        private PreviousMeterReadingMethodType previousMeterReadingMethodField;

        private PreviousMeterReadingMethodCodeType previousMeterReadingMethodCodeField;

        private LatestMeterReadingMethodType latestMeterReadingMethodField;

        private LatestMeterReadingMethodCodeType latestMeterReadingMethodCodeField;

        private MeterReadingCommentsType[] meterReadingCommentsField;

        private DeliveredQuantityType deliveredQuantityField;

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
        [System.Xml.Serialization.XmlElementAttribute("MeterReadingType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterReadingTypeType MeterReadingType1
        {
            get
            {
                return meterReadingType1Field;
            }
            set
            {
                meterReadingType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterReadingTypeCodeType MeterReadingTypeCode
        {
            get
            {
                return meterReadingTypeCodeField;
            }
            set
            {
                meterReadingTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterReadingDateType PreviousMeterReadingDate
        {
            get
            {
                return previousMeterReadingDateField;
            }
            set
            {
                previousMeterReadingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterQuantityType PreviousMeterQuantity
        {
            get
            {
                return previousMeterQuantityField;
            }
            set
            {
                previousMeterQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterReadingDateType LatestMeterReadingDate
        {
            get
            {
                return latestMeterReadingDateField;
            }
            set
            {
                latestMeterReadingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterQuantityType LatestMeterQuantity
        {
            get
            {
                return latestMeterQuantityField;
            }
            set
            {
                latestMeterQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterReadingMethodType PreviousMeterReadingMethod
        {
            get
            {
                return previousMeterReadingMethodField;
            }
            set
            {
                previousMeterReadingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterReadingMethodCodeType PreviousMeterReadingMethodCode
        {
            get
            {
                return previousMeterReadingMethodCodeField;
            }
            set
            {
                previousMeterReadingMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterReadingMethodType LatestMeterReadingMethod
        {
            get
            {
                return latestMeterReadingMethodField;
            }
            set
            {
                latestMeterReadingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterReadingMethodCodeType LatestMeterReadingMethodCode
        {
            get
            {
                return latestMeterReadingMethodCodeField;
            }
            set
            {
                latestMeterReadingMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterReadingComments", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterReadingCommentsType[] MeterReadingComments
        {
            get
            {
                return meterReadingCommentsField;
            }
            set
            {
                meterReadingCommentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeliveredQuantityType DeliveredQuantity
        {
            get
            {
                return deliveredQuantityField;
            }
            set
            {
                deliveredQuantityField = value;
            }
        }
    }
}