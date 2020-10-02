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

        private IdType _idField;

        private SubscriberIdType _subscriberIdField;

        private SubscriberTypeType _subscriberTypeField;

        private SubscriberTypeCodeType _subscriberTypeCodeField;

        private DescriptionType[] _descriptionField;

        private PackQuantityType _packQuantityField;

        private PackSizeNumericType _packSizeNumericField;

        private ConsumptionTypeType _consumptionTypeField;

        private ConsumptionTypeCodeType _consumptionTypeCodeField;

        private CurrentChargeTypeType _currentChargeTypeField;

        private CurrentChargeTypeCodeType _currentChargeTypeCodeField;

        private OneTimeChargeTypeType _oneTimeChargeTypeField;

        private OneTimeChargeTypeCodeType _oneTimeChargeTypeCodeField;

        private TaxCategoryType _taxCategoryField;

        private ContractType _contractField;

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
        public PackQuantityType PackQuantity
        {
            get
            {
                return _packQuantityField;
            }
            set
            {
                _packQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackSizeNumericType PackSizeNumeric
        {
            get
            {
                return _packSizeNumericField;
            }
            set
            {
                _packSizeNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionTypeType ConsumptionType
        {
            get
            {
                return _consumptionTypeField;
            }
            set
            {
                _consumptionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionTypeCodeType ConsumptionTypeCode
        {
            get
            {
                return _consumptionTypeCodeField;
            }
            set
            {
                _consumptionTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrentChargeTypeType CurrentChargeType
        {
            get
            {
                return _currentChargeTypeField;
            }
            set
            {
                _currentChargeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrentChargeTypeCodeType CurrentChargeTypeCode
        {
            get
            {
                return _currentChargeTypeCodeField;
            }
            set
            {
                _currentChargeTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OneTimeChargeTypeType OneTimeChargeType
        {
            get
            {
                return _oneTimeChargeTypeField;
            }
            set
            {
                _oneTimeChargeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OneTimeChargeTypeCodeType OneTimeChargeTypeCode
        {
            get
            {
                return _oneTimeChargeTypeCodeField;
            }
            set
            {
                _oneTimeChargeTypeCodeField = value;
            }
        }

        /// <remarks/>
        public TaxCategoryType TaxCategory
        {
            get
            {
                return _taxCategoryField;
            }
            set
            {
                _taxCategoryField = value;
            }
        }

        /// <remarks/>
        public ContractType Contract
        {
            get
            {
                return _contractField;
            }
            set
            {
                _contractField = value;
            }
        }
    }
}