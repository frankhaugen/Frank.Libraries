namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ItemManagementProfile", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemManagementProfileType
    {

        private FrozenPeriodDaysNumericType _frozenPeriodDaysNumericField;

        private MinimumInventoryQuantityType _minimumInventoryQuantityField;

        private MultipleOrderQuantityType _multipleOrderQuantityField;

        private OrderIntervalDaysNumericType _orderIntervalDaysNumericField;

        private ReplenishmentOwnerDescriptionType[] _replenishmentOwnerDescriptionField;

        private TargetServicePercentType _targetServicePercentField;

        private TargetInventoryQuantityType _targetInventoryQuantityField;

        private PeriodType _effectivePeriodField;

        private ItemType _itemField;

        private ItemLocationQuantityType _itemLocationQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FrozenPeriodDaysNumericType FrozenPeriodDaysNumeric
        {
            get
            {
                return _frozenPeriodDaysNumericField;
            }
            set
            {
                _frozenPeriodDaysNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumInventoryQuantityType MinimumInventoryQuantity
        {
            get
            {
                return _minimumInventoryQuantityField;
            }
            set
            {
                _minimumInventoryQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MultipleOrderQuantityType MultipleOrderQuantity
        {
            get
            {
                return _multipleOrderQuantityField;
            }
            set
            {
                _multipleOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderIntervalDaysNumericType OrderIntervalDaysNumeric
        {
            get
            {
                return _orderIntervalDaysNumericField;
            }
            set
            {
                _orderIntervalDaysNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReplenishmentOwnerDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReplenishmentOwnerDescriptionType[] ReplenishmentOwnerDescription
        {
            get
            {
                return _replenishmentOwnerDescriptionField;
            }
            set
            {
                _replenishmentOwnerDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetServicePercentType TargetServicePercent
        {
            get
            {
                return _targetServicePercentField;
            }
            set
            {
                _targetServicePercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetInventoryQuantityType TargetInventoryQuantity
        {
            get
            {
                return _targetInventoryQuantityField;
            }
            set
            {
                _targetInventoryQuantityField = value;
            }
        }

        /// <remarks/>
        public PeriodType EffectivePeriod
        {
            get
            {
                return _effectivePeriodField;
            }
            set
            {
                _effectivePeriodField = value;
            }
        }

        /// <remarks/>
        public ItemType Item
        {
            get
            {
                return _itemField;
            }
            set
            {
                _itemField = value;
            }
        }

        /// <remarks/>
        public ItemLocationQuantityType ItemLocationQuantity
        {
            get
            {
                return _itemLocationQuantityField;
            }
            set
            {
                _itemLocationQuantityField = value;
            }
        }
    }
}