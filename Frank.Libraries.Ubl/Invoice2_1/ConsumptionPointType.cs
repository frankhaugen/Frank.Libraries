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

        private IDType idField;

        private DescriptionType[] descriptionField;

        private SubscriberIDType subscriberIDField;

        private SubscriberTypeType subscriberTypeField;

        private SubscriberTypeCodeType subscriberTypeCodeField;

        private TotalDeliveredQuantityType totalDeliveredQuantityField;

        private AddressType addressField;

        private WebSiteAccessType webSiteAccessField;

        private MeterType[] utilityMeterField;

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
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubscriberIDType SubscriberID
        {
            get
            {
                return subscriberIDField;
            }
            set
            {
                subscriberIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubscriberTypeType SubscriberType
        {
            get
            {
                return subscriberTypeField;
            }
            set
            {
                subscriberTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubscriberTypeCodeType SubscriberTypeCode
        {
            get
            {
                return subscriberTypeCodeField;
            }
            set
            {
                subscriberTypeCodeField = value;
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
        public AddressType Address
        {
            get
            {
                return addressField;
            }
            set
            {
                addressField = value;
            }
        }

        /// <remarks/>
        public WebSiteAccessType WebSiteAccess
        {
            get
            {
                return webSiteAccessField;
            }
            set
            {
                webSiteAccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UtilityMeter")]
        public MeterType[] UtilityMeter
        {
            get
            {
                return utilityMeterField;
            }
            set
            {
                utilityMeterField = value;
            }
        }
    }
}