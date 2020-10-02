namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Pickup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PickupType
    {

        private IdType _idField;

        private ActualPickupDateType _actualPickupDateField;

        private ActualPickupTimeType _actualPickupTimeField;

        private EarliestPickupDateType _earliestPickupDateField;

        private EarliestPickupTimeType _earliestPickupTimeField;

        private LatestPickupDateType _latestPickupDateField;

        private LatestPickupTimeType _latestPickupTimeField;

        private LocationType1 _pickupLocationField;

        private PartyType _pickupPartyField;

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
        public ActualPickupDateType ActualPickupDate
        {
            get
            {
                return _actualPickupDateField;
            }
            set
            {
                _actualPickupDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualPickupTimeType ActualPickupTime
        {
            get
            {
                return _actualPickupTimeField;
            }
            set
            {
                _actualPickupTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EarliestPickupDateType EarliestPickupDate
        {
            get
            {
                return _earliestPickupDateField;
            }
            set
            {
                _earliestPickupDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EarliestPickupTimeType EarliestPickupTime
        {
            get
            {
                return _earliestPickupTimeField;
            }
            set
            {
                _earliestPickupTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestPickupDateType LatestPickupDate
        {
            get
            {
                return _latestPickupDateField;
            }
            set
            {
                _latestPickupDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestPickupTimeType LatestPickupTime
        {
            get
            {
                return _latestPickupTimeField;
            }
            set
            {
                _latestPickupTimeField = value;
            }
        }

        /// <remarks/>
        public LocationType1 PickupLocation
        {
            get
            {
                return _pickupLocationField;
            }
            set
            {
                _pickupLocationField = value;
            }
        }

        /// <remarks/>
        public PartyType PickupParty
        {
            get
            {
                return _pickupPartyField;
            }
            set
            {
                _pickupPartyField = value;
            }
        }
    }
}