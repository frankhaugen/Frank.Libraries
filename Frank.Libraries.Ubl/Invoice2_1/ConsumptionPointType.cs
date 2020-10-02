namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ConsumptionPoint", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ConsumptionPointType
    {

        private IdType _idField;

        private DescriptionType[] _descriptionField;

        private SubscriberIdType _subscriberIdField;

        private SubscriberTypeType _subscriberTypeField;

        private SubscriberTypeCodeType _subscriberTypeCodeField;

        private TotalDeliveredQuantityType _totalDeliveredQuantityField;

        private AddressType _addressField;

        private WebSiteAccessType _webSiteAccessField;

        private MeterType[] _utilityMeterField;

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
        public SubscriberIdType SubscriberId
        {
            get
            {
                return _subscriberIdField;
            }
            set
            {
                _subscriberIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubscriberTypeType SubscriberType
        {
            get
            {
                return _subscriberTypeField;
            }
            set
            {
                _subscriberTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubscriberTypeCodeType SubscriberTypeCode
        {
            get
            {
                return _subscriberTypeCodeField;
            }
            set
            {
                _subscriberTypeCodeField = value;
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
        public AddressType Address
        {
            get
            {
                return _addressField;
            }
            set
            {
                _addressField = value;
            }
        }

        /// <remarks/>
        public WebSiteAccessType WebSiteAccess
        {
            get
            {
                return _webSiteAccessField;
            }
            set
            {
                _webSiteAccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UtilityMeter")]
        public MeterType[] UtilityMeter
        {
            get
            {
                return _utilityMeterField;
            }
            set
            {
                _utilityMeterField = value;
            }
        }
    }
}