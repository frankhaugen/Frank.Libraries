namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("EventLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EventLineItemType
    {

        private LineNumberNumericType _lineNumberNumericField;

        private LocationType1 _participatingLocationsLocationField;

        private RetailPlannedImpactType[] _retailPlannedImpactField;

        private ItemType _supplyItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineNumberNumericType LineNumberNumeric
        {
            get
            {
                return _lineNumberNumericField;
            }
            set
            {
                _lineNumberNumericField = value;
            }
        }

        /// <remarks/>
        public LocationType1 ParticipatingLocationsLocation
        {
            get
            {
                return _participatingLocationsLocationField;
            }
            set
            {
                _participatingLocationsLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RetailPlannedImpact")]
        public RetailPlannedImpactType[] RetailPlannedImpact
        {
            get
            {
                return _retailPlannedImpactField;
            }
            set
            {
                _retailPlannedImpactField = value;
            }
        }

        /// <remarks/>
        public ItemType SupplyItem
        {
            get
            {
                return _supplyItemField;
            }
            set
            {
                _supplyItemField = value;
            }
        }
    }
}