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

        private IDType idField;

        private ActualPickupDateType actualPickupDateField;

        private ActualPickupTimeType actualPickupTimeField;

        private EarliestPickupDateType earliestPickupDateField;

        private EarliestPickupTimeType earliestPickupTimeField;

        private LatestPickupDateType latestPickupDateField;

        private LatestPickupTimeType latestPickupTimeField;

        private LocationType1 pickupLocationField;

        private PartyType pickupPartyField;

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
        public ActualPickupDateType ActualPickupDate
        {
            get
            {
                return actualPickupDateField;
            }
            set
            {
                actualPickupDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualPickupTimeType ActualPickupTime
        {
            get
            {
                return actualPickupTimeField;
            }
            set
            {
                actualPickupTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EarliestPickupDateType EarliestPickupDate
        {
            get
            {
                return earliestPickupDateField;
            }
            set
            {
                earliestPickupDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EarliestPickupTimeType EarliestPickupTime
        {
            get
            {
                return earliestPickupTimeField;
            }
            set
            {
                earliestPickupTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestPickupDateType LatestPickupDate
        {
            get
            {
                return latestPickupDateField;
            }
            set
            {
                latestPickupDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestPickupTimeType LatestPickupTime
        {
            get
            {
                return latestPickupTimeField;
            }
            set
            {
                latestPickupTimeField = value;
            }
        }

        /// <remarks/>
        public LocationType1 PickupLocation
        {
            get
            {
                return pickupLocationField;
            }
            set
            {
                pickupLocationField = value;
            }
        }

        /// <remarks/>
        public PartyType PickupParty
        {
            get
            {
                return pickupPartyField;
            }
            set
            {
                pickupPartyField = value;
            }
        }
    }
}