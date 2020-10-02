namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Despatch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DespatchType
    {

        private IDType idField;

        private RequestedDespatchDateType requestedDespatchDateField;

        private RequestedDespatchTimeType requestedDespatchTimeField;

        private EstimatedDespatchDateType estimatedDespatchDateField;

        private EstimatedDespatchTimeType estimatedDespatchTimeField;

        private ActualDespatchDateType actualDespatchDateField;

        private ActualDespatchTimeType actualDespatchTimeField;

        private GuaranteedDespatchDateType guaranteedDespatchDateField;

        private GuaranteedDespatchTimeType guaranteedDespatchTimeField;

        private ReleaseIDType releaseIDField;

        private InstructionsType[] instructionsField;

        private AddressType despatchAddressField;

        private LocationType1 despatchLocationField;

        private PartyType despatchPartyField;

        private PartyType carrierPartyField;

        private PartyType[] notifyPartyField;

        private ContactType contactField;

        private PeriodType estimatedDespatchPeriodField;

        private PeriodType requestedDespatchPeriodField;

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
        public RequestedDespatchDateType RequestedDespatchDate
        {
            get
            {
                return requestedDespatchDateField;
            }
            set
            {
                requestedDespatchDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequestedDespatchTimeType RequestedDespatchTime
        {
            get
            {
                return requestedDespatchTimeField;
            }
            set
            {
                requestedDespatchTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedDespatchDateType EstimatedDespatchDate
        {
            get
            {
                return estimatedDespatchDateField;
            }
            set
            {
                estimatedDespatchDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedDespatchTimeType EstimatedDespatchTime
        {
            get
            {
                return estimatedDespatchTimeField;
            }
            set
            {
                estimatedDespatchTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDespatchDateType ActualDespatchDate
        {
            get
            {
                return actualDespatchDateField;
            }
            set
            {
                actualDespatchDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDespatchTimeType ActualDespatchTime
        {
            get
            {
                return actualDespatchTimeField;
            }
            set
            {
                actualDespatchTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GuaranteedDespatchDateType GuaranteedDespatchDate
        {
            get
            {
                return guaranteedDespatchDateField;
            }
            set
            {
                guaranteedDespatchDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GuaranteedDespatchTimeType GuaranteedDespatchTime
        {
            get
            {
                return guaranteedDespatchTimeField;
            }
            set
            {
                guaranteedDespatchTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReleaseIDType ReleaseID
        {
            get
            {
                return releaseIDField;
            }
            set
            {
                releaseIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Instructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InstructionsType[] Instructions
        {
            get
            {
                return instructionsField;
            }
            set
            {
                instructionsField = value;
            }
        }

        /// <remarks/>
        public AddressType DespatchAddress
        {
            get
            {
                return despatchAddressField;
            }
            set
            {
                despatchAddressField = value;
            }
        }

        /// <remarks/>
        public LocationType1 DespatchLocation
        {
            get
            {
                return despatchLocationField;
            }
            set
            {
                despatchLocationField = value;
            }
        }

        /// <remarks/>
        public PartyType DespatchParty
        {
            get
            {
                return despatchPartyField;
            }
            set
            {
                despatchPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType CarrierParty
        {
            get
            {
                return carrierPartyField;
            }
            set
            {
                carrierPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
        public PartyType[] NotifyParty
        {
            get
            {
                return notifyPartyField;
            }
            set
            {
                notifyPartyField = value;
            }
        }

        /// <remarks/>
        public ContactType Contact
        {
            get
            {
                return contactField;
            }
            set
            {
                contactField = value;
            }
        }

        /// <remarks/>
        public PeriodType EstimatedDespatchPeriod
        {
            get
            {
                return estimatedDespatchPeriodField;
            }
            set
            {
                estimatedDespatchPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType RequestedDespatchPeriod
        {
            get
            {
                return requestedDespatchPeriodField;
            }
            set
            {
                requestedDespatchPeriodField = value;
            }
        }
    }
}