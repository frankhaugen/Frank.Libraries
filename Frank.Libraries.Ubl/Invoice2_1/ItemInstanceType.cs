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

        private ProductTraceIDType productTraceIDField;

        private ManufactureDateType manufactureDateField;

        private ManufactureTimeType manufactureTimeField;

        private BestBeforeDateType bestBeforeDateField;

        private RegistrationIDType registrationIDField;

        private SerialIDType serialIDField;

        private ItemPropertyType[] additionalItemPropertyField;

        private LotIdentificationType lotIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProductTraceIDType ProductTraceID
        {
            get
            {
                return productTraceIDField;
            }
            set
            {
                productTraceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ManufactureDateType ManufactureDate
        {
            get
            {
                return manufactureDateField;
            }
            set
            {
                manufactureDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ManufactureTimeType ManufactureTime
        {
            get
            {
                return manufactureTimeField;
            }
            set
            {
                manufactureTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BestBeforeDateType BestBeforeDate
        {
            get
            {
                return bestBeforeDateField;
            }
            set
            {
                bestBeforeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationIDType RegistrationID
        {
            get
            {
                return registrationIDField;
            }
            set
            {
                registrationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SerialIDType SerialID
        {
            get
            {
                return serialIDField;
            }
            set
            {
                serialIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty")]
        public ItemPropertyType[] AdditionalItemProperty
        {
            get
            {
                return additionalItemPropertyField;
            }
            set
            {
                additionalItemPropertyField = value;
            }
        }

        /// <remarks/>
        public LotIdentificationType LotIdentification
        {
            get
            {
                return lotIdentificationField;
            }
            set
            {
                lotIdentificationField = value;
            }
        }
    }
}