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

        private JourneyIDType journeyIDField;

        private RegistrationNationalityIDType registrationNationalityIDField;

        private RegistrationNationalityType[] registrationNationalityField;

        private DirectionCodeType directionCodeField;

        private TransportMeansTypeCodeType transportMeansTypeCodeField;

        private TradeServiceCodeType tradeServiceCodeField;

        private StowageType stowageField;

        private AirTransportType airTransportField;

        private RoadTransportType roadTransportField;

        private RailTransportType railTransportField;

        private MaritimeTransportType maritimeTransportField;

        private PartyType ownerPartyField;

        private DimensionType[] measurementDimensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public JourneyIDType JourneyID
        {
            get
            {
                return journeyIDField;
            }
            set
            {
                journeyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNationalityIDType RegistrationNationalityID
        {
            get
            {
                return registrationNationalityIDField;
            }
            set
            {
                registrationNationalityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegistrationNationality", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNationalityType[] RegistrationNationality
        {
            get
            {
                return registrationNationalityField;
            }
            set
            {
                registrationNationalityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DirectionCodeType DirectionCode
        {
            get
            {
                return directionCodeField;
            }
            set
            {
                directionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportMeansTypeCodeType TransportMeansTypeCode
        {
            get
            {
                return transportMeansTypeCodeField;
            }
            set
            {
                transportMeansTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TradeServiceCodeType TradeServiceCode
        {
            get
            {
                return tradeServiceCodeField;
            }
            set
            {
                tradeServiceCodeField = value;
            }
        }

        /// <remarks/>
        public StowageType Stowage
        {
            get
            {
                return stowageField;
            }
            set
            {
                stowageField = value;
            }
        }

        /// <remarks/>
        public AirTransportType AirTransport
        {
            get
            {
                return airTransportField;
            }
            set
            {
                airTransportField = value;
            }
        }

        /// <remarks/>
        public RoadTransportType RoadTransport
        {
            get
            {
                return roadTransportField;
            }
            set
            {
                roadTransportField = value;
            }
        }

        /// <remarks/>
        public RailTransportType RailTransport
        {
            get
            {
                return railTransportField;
            }
            set
            {
                railTransportField = value;
            }
        }

        /// <remarks/>
        public MaritimeTransportType MaritimeTransport
        {
            get
            {
                return maritimeTransportField;
            }
            set
            {
                maritimeTransportField = value;
            }
        }

        /// <remarks/>
        public PartyType OwnerParty
        {
            get
            {
                return ownerPartyField;
            }
            set
            {
                ownerPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return measurementDimensionField;
            }
            set
            {
                measurementDimensionField = value;
            }
        }
    }
}