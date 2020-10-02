namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("InventoryReportLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class InventoryReportLineType
    {

        private IdType _idField;

        private NoteType[] _noteField;

        private QuantityType2 _quantityField;

        private InventoryValueAmountType _inventoryValueAmountField;

        private AvailabilityDateType _availabilityDateField;

        private AvailabilityStatusCodeType _availabilityStatusCodeField;

        private ItemType _itemField;

        private LocationType1 _inventoryLocationField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return _noteField;
            }
            set
            {
                _noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity
        {
            get
            {
                return _quantityField;
            }
            set
            {
                _quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InventoryValueAmountType InventoryValueAmount
        {
            get
            {
                return _inventoryValueAmountField;
            }
            set
            {
                _inventoryValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AvailabilityDateType AvailabilityDate
        {
            get
            {
                return _availabilityDateField;
            }
            set
            {
                _availabilityDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AvailabilityStatusCodeType AvailabilityStatusCode
        {
            get
            {
                return _availabilityStatusCodeField;
            }
            set
            {
                _availabilityStatusCodeField = value;
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
        public LocationType1 InventoryLocation
        {
            get
            {
                return _inventoryLocationField;
            }
            set
            {
                _inventoryLocationField = value;
            }
        }
    }
}