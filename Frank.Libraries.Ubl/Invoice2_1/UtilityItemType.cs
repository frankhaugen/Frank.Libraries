namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("UtilityItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class UtilityItemType
    {

        private IDType idField;

        private SubscriberIDType subscriberIDField;

        private SubscriberTypeType subscriberTypeField;

        private SubscriberTypeCodeType subscriberTypeCodeField;

        private DescriptionType[] descriptionField;

        private PackQuantityType packQuantityField;

        private PackSizeNumericType packSizeNumericField;

        private ConsumptionTypeType consumptionTypeField;

        private ConsumptionTypeCodeType consumptionTypeCodeField;

        private CurrentChargeTypeType currentChargeTypeField;

        private CurrentChargeTypeCodeType currentChargeTypeCodeField;

        private OneTimeChargeTypeType oneTimeChargeTypeField;

        private OneTimeChargeTypeCodeType oneTimeChargeTypeCodeField;

        private TaxCategoryType taxCategoryField;

        private ContractType contractField;

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
        public PackQuantityType PackQuantity
        {
            get
            {
                return packQuantityField;
            }
            set
            {
                packQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackSizeNumericType PackSizeNumeric
        {
            get
            {
                return packSizeNumericField;
            }
            set
            {
                packSizeNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionTypeType ConsumptionType
        {
            get
            {
                return consumptionTypeField;
            }
            set
            {
                consumptionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionTypeCodeType ConsumptionTypeCode
        {
            get
            {
                return consumptionTypeCodeField;
            }
            set
            {
                consumptionTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrentChargeTypeType CurrentChargeType
        {
            get
            {
                return currentChargeTypeField;
            }
            set
            {
                currentChargeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrentChargeTypeCodeType CurrentChargeTypeCode
        {
            get
            {
                return currentChargeTypeCodeField;
            }
            set
            {
                currentChargeTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OneTimeChargeTypeType OneTimeChargeType
        {
            get
            {
                return oneTimeChargeTypeField;
            }
            set
            {
                oneTimeChargeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OneTimeChargeTypeCodeType OneTimeChargeTypeCode
        {
            get
            {
                return oneTimeChargeTypeCodeField;
            }
            set
            {
                oneTimeChargeTypeCodeField = value;
            }
        }

        /// <remarks/>
        public TaxCategoryType TaxCategory
        {
            get
            {
                return taxCategoryField;
            }
            set
            {
                taxCategoryField = value;
            }
        }

        /// <remarks/>
        public ContractType Contract
        {
            get
            {
                return contractField;
            }
            set
            {
                contractField = value;
            }
        }
    }
}