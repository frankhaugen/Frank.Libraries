namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ItemInstance", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemInstanceType
    {

        private ProductTraceIdType _productTraceIdField;

        private ManufactureDateType _manufactureDateField;

        private ManufactureTimeType _manufactureTimeField;

        private BestBeforeDateType _bestBeforeDateField;

        private RegistrationIdType _registrationIdField;

        private SerialIdType _serialIdField;

        private ItemPropertyType[] _additionalItemPropertyField;

        private LotIdentificationType _lotIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProductTraceIdType ProductTraceId
        {
            get
            {
                return _productTraceIdField;
            }
            set
            {
                _productTraceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ManufactureDateType ManufactureDate
        {
            get
            {
                return _manufactureDateField;
            }
            set
            {
                _manufactureDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ManufactureTimeType ManufactureTime
        {
            get
            {
                return _manufactureTimeField;
            }
            set
            {
                _manufactureTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BestBeforeDateType BestBeforeDate
        {
            get
            {
                return _bestBeforeDateField;
            }
            set
            {
                _bestBeforeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationIdType RegistrationId
        {
            get
            {
                return _registrationIdField;
            }
            set
            {
                _registrationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SerialIdType SerialId
        {
            get
            {
                return _serialIdField;
            }
            set
            {
                _serialIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty")]
        public ItemPropertyType[] AdditionalItemProperty
        {
            get
            {
                return _additionalItemPropertyField;
            }
            set
            {
                _additionalItemPropertyField = value;
            }
        }

        /// <remarks/>
        public LotIdentificationType LotIdentification
        {
            get
            {
                return _lotIdentificationField;
            }
            set
            {
                _lotIdentificationField = value;
            }
        }
    }
}