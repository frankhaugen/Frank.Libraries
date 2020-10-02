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

        private IdType _idField;

        private RequestedDespatchDateType _requestedDespatchDateField;

        private RequestedDespatchTimeType _requestedDespatchTimeField;

        private EstimatedDespatchDateType _estimatedDespatchDateField;

        private EstimatedDespatchTimeType _estimatedDespatchTimeField;

        private ActualDespatchDateType _actualDespatchDateField;

        private ActualDespatchTimeType _actualDespatchTimeField;

        private GuaranteedDespatchDateType _guaranteedDespatchDateField;

        private GuaranteedDespatchTimeType _guaranteedDespatchTimeField;

        private ReleaseIdType _releaseIdField;

        private InstructionsType[] _instructionsField;

        private AddressType _despatchAddressField;

        private LocationType1 _despatchLocationField;

        private PartyType _despatchPartyField;

        private PartyType _carrierPartyField;

        private PartyType[] _notifyPartyField;

        private ContactType _contactField;

        private PeriodType _estimatedDespatchPeriodField;

        private PeriodType _requestedDespatchPeriodField;

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
        public RequestedDespatchDateType RequestedDespatchDate
        {
            get
            {
                return _requestedDespatchDateField;
            }
            set
            {
                _requestedDespatchDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequestedDespatchTimeType RequestedDespatchTime
        {
            get
            {
                return _requestedDespatchTimeField;
            }
            set
            {
                _requestedDespatchTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedDespatchDateType EstimatedDespatchDate
        {
            get
            {
                return _estimatedDespatchDateField;
            }
            set
            {
                _estimatedDespatchDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedDespatchTimeType EstimatedDespatchTime
        {
            get
            {
                return _estimatedDespatchTimeField;
            }
            set
            {
                _estimatedDespatchTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDespatchDateType ActualDespatchDate
        {
            get
            {
                return _actualDespatchDateField;
            }
            set
            {
                _actualDespatchDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDespatchTimeType ActualDespatchTime
        {
            get
            {
                return _actualDespatchTimeField;
            }
            set
            {
                _actualDespatchTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GuaranteedDespatchDateType GuaranteedDespatchDate
        {
            get
            {
                return _guaranteedDespatchDateField;
            }
            set
            {
                _guaranteedDespatchDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GuaranteedDespatchTimeType GuaranteedDespatchTime
        {
            get
            {
                return _guaranteedDespatchTimeField;
            }
            set
            {
                _guaranteedDespatchTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReleaseIdType ReleaseId
        {
            get
            {
                return _releaseIdField;
            }
            set
            {
                _releaseIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Instructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InstructionsType[] Instructions
        {
            get
            {
                return _instructionsField;
            }
            set
            {
                _instructionsField = value;
            }
        }

        /// <remarks/>
        public AddressType DespatchAddress
        {
            get
            {
                return _despatchAddressField;
            }
            set
            {
                _despatchAddressField = value;
            }
        }

        /// <remarks/>
        public LocationType1 DespatchLocation
        {
            get
            {
                return _despatchLocationField;
            }
            set
            {
                _despatchLocationField = value;
            }
        }

        /// <remarks/>
        public PartyType DespatchParty
        {
            get
            {
                return _despatchPartyField;
            }
            set
            {
                _despatchPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType CarrierParty
        {
            get
            {
                return _carrierPartyField;
            }
            set
            {
                _carrierPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
        public PartyType[] NotifyParty
        {
            get
            {
                return _notifyPartyField;
            }
            set
            {
                _notifyPartyField = value;
            }
        }

        /// <remarks/>
        public ContactType Contact
        {
            get
            {
                return _contactField;
            }
            set
            {
                _contactField = value;
            }
        }

        /// <remarks/>
        public PeriodType EstimatedDespatchPeriod
        {
            get
            {
                return _estimatedDespatchPeriodField;
            }
            set
            {
                _estimatedDespatchPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType RequestedDespatchPeriod
        {
            get
            {
                return _requestedDespatchPeriodField;
            }
            set
            {
                _requestedDespatchPeriodField = value;
            }
        }
    }
}