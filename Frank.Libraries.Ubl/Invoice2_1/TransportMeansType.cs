namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ApplicableTransportMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportMeansType
    {

        private JourneyIdType _journeyIdField;

        private RegistrationNationalityIdType _registrationNationalityIdField;

        private RegistrationNationalityType[] _registrationNationalityField;

        private DirectionCodeType _directionCodeField;

        private TransportMeansTypeCodeType _transportMeansTypeCodeField;

        private TradeServiceCodeType _tradeServiceCodeField;

        private StowageType _stowageField;

        private AirTransportType _airTransportField;

        private RoadTransportType _roadTransportField;

        private RailTransportType _railTransportField;

        private MaritimeTransportType _maritimeTransportField;

        private PartyType _ownerPartyField;

        private DimensionType[] _measurementDimensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public JourneyIdType JourneyId
        {
            get
            {
                return _journeyIdField;
            }
            set
            {
                _journeyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNationalityIdType RegistrationNationalityId
        {
            get
            {
                return _registrationNationalityIdField;
            }
            set
            {
                _registrationNationalityIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegistrationNationality", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNationalityType[] RegistrationNationality
        {
            get
            {
                return _registrationNationalityField;
            }
            set
            {
                _registrationNationalityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DirectionCodeType DirectionCode
        {
            get
            {
                return _directionCodeField;
            }
            set
            {
                _directionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportMeansTypeCodeType TransportMeansTypeCode
        {
            get
            {
                return _transportMeansTypeCodeField;
            }
            set
            {
                _transportMeansTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TradeServiceCodeType TradeServiceCode
        {
            get
            {
                return _tradeServiceCodeField;
            }
            set
            {
                _tradeServiceCodeField = value;
            }
        }

        /// <remarks/>
        public StowageType Stowage
        {
            get
            {
                return _stowageField;
            }
            set
            {
                _stowageField = value;
            }
        }

        /// <remarks/>
        public AirTransportType AirTransport
        {
            get
            {
                return _airTransportField;
            }
            set
            {
                _airTransportField = value;
            }
        }

        /// <remarks/>
        public RoadTransportType RoadTransport
        {
            get
            {
                return _roadTransportField;
            }
            set
            {
                _roadTransportField = value;
            }
        }

        /// <remarks/>
        public RailTransportType RailTransport
        {
            get
            {
                return _railTransportField;
            }
            set
            {
                _railTransportField = value;
            }
        }

        /// <remarks/>
        public MaritimeTransportType MaritimeTransport
        {
            get
            {
                return _maritimeTransportField;
            }
            set
            {
                _maritimeTransportField = value;
            }
        }

        /// <remarks/>
        public PartyType OwnerParty
        {
            get
            {
                return _ownerPartyField;
            }
            set
            {
                _ownerPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return _measurementDimensionField;
            }
            set
            {
                _measurementDimensionField = value;
            }
        }
    }
}