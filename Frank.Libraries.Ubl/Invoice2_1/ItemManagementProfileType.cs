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

        private FrozenPeriodDaysNumericType frozenPeriodDaysNumericField;

        private MinimumInventoryQuantityType minimumInventoryQuantityField;

        private MultipleOrderQuantityType multipleOrderQuantityField;

        private OrderIntervalDaysNumericType orderIntervalDaysNumericField;

        private ReplenishmentOwnerDescriptionType[] replenishmentOwnerDescriptionField;

        private TargetServicePercentType targetServicePercentField;

        private TargetInventoryQuantityType targetInventoryQuantityField;

        private PeriodType effectivePeriodField;

        private ItemType itemField;

        private ItemLocationQuantityType itemLocationQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FrozenPeriodDaysNumericType FrozenPeriodDaysNumeric
        {
            get
            {
                return frozenPeriodDaysNumericField;
            }
            set
            {
                frozenPeriodDaysNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumInventoryQuantityType MinimumInventoryQuantity
        {
            get
            {
                return minimumInventoryQuantityField;
            }
            set
            {
                minimumInventoryQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MultipleOrderQuantityType MultipleOrderQuantity
        {
            get
            {
                return multipleOrderQuantityField;
            }
            set
            {
                multipleOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderIntervalDaysNumericType OrderIntervalDaysNumeric
        {
            get
            {
                return orderIntervalDaysNumericField;
            }
            set
            {
                orderIntervalDaysNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReplenishmentOwnerDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReplenishmentOwnerDescriptionType[] ReplenishmentOwnerDescription
        {
            get
            {
                return replenishmentOwnerDescriptionField;
            }
            set
            {
                replenishmentOwnerDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetServicePercentType TargetServicePercent
        {
            get
            {
                return targetServicePercentField;
            }
            set
            {
                targetServicePercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetInventoryQuantityType TargetInventoryQuantity
        {
            get
            {
                return targetInventoryQuantityField;
            }
            set
            {
                targetInventoryQuantityField = value;
            }
        }

        /// <remarks/>
        public PeriodType EffectivePeriod
        {
            get
            {
                return effectivePeriodField;
            }
            set
            {
                effectivePeriodField = value;
            }
        }

        /// <remarks/>
        public ItemType Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        public ItemLocationQuantityType ItemLocationQuantity
        {
            get
            {
                return itemLocationQuantityField;
            }
            set
            {
                itemLocationQuantityField = value;
            }
        }
    }
}