namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("MainCarriageShipmentStage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ShipmentStageType
    {

        private IdType _idField;

        private TransportModeCodeType _transportModeCodeField;

        private TransportMeansTypeCodeType _transportMeansTypeCodeField;

        private TransitDirectionCodeType _transitDirectionCodeField;

        private PreCarriageIndicatorType _preCarriageIndicatorField;

        private OnCarriageIndicatorType _onCarriageIndicatorField;

        private EstimatedDeliveryDateType _estimatedDeliveryDateField;

        private EstimatedDeliveryTimeType _estimatedDeliveryTimeField;

        private RequiredDeliveryDateType _requiredDeliveryDateField;

        private RequiredDeliveryTimeType _requiredDeliveryTimeField;

        private LoadingSequenceIdType _loadingSequenceIdField;

        private SuccessiveSequenceIdType _successiveSequenceIdField;

        private InstructionsType[] _instructionsField;

        private DemurrageInstructionsType[] _demurrageInstructionsField;

        private CrewQuantityType _crewQuantityField;

        private PassengerQuantityType _passengerQuantityField;

        private PeriodType _transitPeriodField;

        private PartyType[] _carrierPartyField;

        private TransportMeansType _transportMeansField;

        private LocationType1 _loadingPortLocationField;

        private LocationType1 _unloadingPortLocationField;

        private LocationType1 _transshipPortLocationField;

        private TransportEventType _loadingTransportEventField;

        private TransportEventType _examinationTransportEventField;

        private TransportEventType _availabilityTransportEventField;

        private TransportEventType _exportationTransportEventField;

        private TransportEventType _dischargeTransportEventField;

        private TransportEventType _warehousingTransportEventField;

        private TransportEventType _takeoverTransportEventField;

        private TransportEventType _optionalTakeoverTransportEventField;

        private TransportEventType _dropoffTransportEventField;

        private TransportEventType _actualPickupTransportEventField;

        private TransportEventType _deliveryTransportEventField;

        private TransportEventType _receiptTransportEventField;

        private TransportEventType _storageTransportEventField;

        private TransportEventType _acceptanceTransportEventField;

        private PartyType _terminalOperatorPartyField;

        private PartyType _customsAgentPartyField;

        private PeriodType _estimatedTransitPeriodField;

        private AllowanceChargeType[] _freightAllowanceChargeField;

        private LocationType1 _freightChargeLocationField;

        private TransportEventType[] _detentionTransportEventField;

        private TransportEventType _requestedDepartureTransportEventField;

        private TransportEventType _requestedArrivalTransportEventField;

        private TransportEventType[] _requestedWaypointTransportEventField;

        private TransportEventType _plannedDepartureTransportEventField;

        private TransportEventType _plannedArrivalTransportEventField;

        private TransportEventType[] _plannedWaypointTransportEventField;

        private TransportEventType _actualDepartureTransportEventField;

        private TransportEventType _actualWaypointTransportEventField;

        private TransportEventType _actualArrivalTransportEventField;

        private TransportEventType[] _transportEventField;

        private TransportEventType _estimatedDepartureTransportEventField;

        private TransportEventType _estimatedArrivalTransportEventField;

        private PersonType[] _passengerPersonField;

        private PersonType[] _driverPersonField;

        private PersonType _reportingPersonField;

        private PersonType[] _crewMemberPersonField;

        private PersonType _securityOfficerPersonField;

        private PersonType _masterPersonField;

        private PersonType _shipsSurgeonPersonField;

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
        public TransportModeCodeType TransportModeCode
        {
            get
            {
                return _transportModeCodeField;
            }
            set
            {
                _transportModeCodeField = value;
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
        public TransitDirectionCodeType TransitDirectionCode
        {
            get
            {
                return _transitDirectionCodeField;
            }
            set
            {
                _transitDirectionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreCarriageIndicatorType PreCarriageIndicator
        {
            get
            {
                return _preCarriageIndicatorField;
            }
            set
            {
                _preCarriageIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OnCarriageIndicatorType OnCarriageIndicator
        {
            get
            {
                return _onCarriageIndicatorField;
            }
            set
            {
                _onCarriageIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedDeliveryDateType EstimatedDeliveryDate
        {
            get
            {
                return _estimatedDeliveryDateField;
            }
            set
            {
                _estimatedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedDeliveryTimeType EstimatedDeliveryTime
        {
            get
            {
                return _estimatedDeliveryTimeField;
            }
            set
            {
                _estimatedDeliveryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredDeliveryDateType RequiredDeliveryDate
        {
            get
            {
                return _requiredDeliveryDateField;
            }
            set
            {
                _requiredDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredDeliveryTimeType RequiredDeliveryTime
        {
            get
            {
                return _requiredDeliveryTimeField;
            }
            set
            {
                _requiredDeliveryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LoadingSequenceIdType LoadingSequenceId
        {
            get
            {
                return _loadingSequenceIdField;
            }
            set
            {
                _loadingSequenceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SuccessiveSequenceIdType SuccessiveSequenceId
        {
            get
            {
                return _successiveSequenceIdField;
            }
            set
            {
                _successiveSequenceIdField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("DemurrageInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DemurrageInstructionsType[] DemurrageInstructions
        {
            get
            {
                return _demurrageInstructionsField;
            }
            set
            {
                _demurrageInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CrewQuantityType CrewQuantity
        {
            get
            {
                return _crewQuantityField;
            }
            set
            {
                _crewQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PassengerQuantityType PassengerQuantity
        {
            get
            {
                return _passengerQuantityField;
            }
            set
            {
                _passengerQuantityField = value;
            }
        }

        /// <remarks/>
        public PeriodType TransitPeriod
        {
            get
            {
                return _transitPeriodField;
            }
            set
            {
                _transitPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarrierParty")]
        public PartyType[] CarrierParty
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
        public TransportMeansType TransportMeans
        {
            get
            {
                return _transportMeansField;
            }
            set
            {
                _transportMeansField = value;
            }
        }

        /// <remarks/>
        public LocationType1 LoadingPortLocation
        {
            get
            {
                return _loadingPortLocationField;
            }
            set
            {
                _loadingPortLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 UnloadingPortLocation
        {
            get
            {
                return _unloadingPortLocationField;
            }
            set
            {
                _unloadingPortLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 TransshipPortLocation
        {
            get
            {
                return _transshipPortLocationField;
            }
            set
            {
                _transshipPortLocationField = value;
            }
        }

        /// <remarks/>
        public TransportEventType LoadingTransportEvent
        {
            get
            {
                return _loadingTransportEventField;
            }
            set
            {
                _loadingTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ExaminationTransportEvent
        {
            get
            {
                return _examinationTransportEventField;
            }
            set
            {
                _examinationTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType AvailabilityTransportEvent
        {
            get
            {
                return _availabilityTransportEventField;
            }
            set
            {
                _availabilityTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ExportationTransportEvent
        {
            get
            {
                return _exportationTransportEventField;
            }
            set
            {
                _exportationTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType DischargeTransportEvent
        {
            get
            {
                return _dischargeTransportEventField;
            }
            set
            {
                _dischargeTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType WarehousingTransportEvent
        {
            get
            {
                return _warehousingTransportEventField;
            }
            set
            {
                _warehousingTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType TakeoverTransportEvent
        {
            get
            {
                return _takeoverTransportEventField;
            }
            set
            {
                _takeoverTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType OptionalTakeoverTransportEvent
        {
            get
            {
                return _optionalTakeoverTransportEventField;
            }
            set
            {
                _optionalTakeoverTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType DropoffTransportEvent
        {
            get
            {
                return _dropoffTransportEventField;
            }
            set
            {
                _dropoffTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualPickupTransportEvent
        {
            get
            {
                return _actualPickupTransportEventField;
            }
            set
            {
                _actualPickupTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType DeliveryTransportEvent
        {
            get
            {
                return _deliveryTransportEventField;
            }
            set
            {
                _deliveryTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ReceiptTransportEvent
        {
            get
            {
                return _receiptTransportEventField;
            }
            set
            {
                _receiptTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType StorageTransportEvent
        {
            get
            {
                return _storageTransportEventField;
            }
            set
            {
                _storageTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType AcceptanceTransportEvent
        {
            get
            {
                return _acceptanceTransportEventField;
            }
            set
            {
                _acceptanceTransportEventField = value;
            }
        }

        /// <remarks/>
        public PartyType TerminalOperatorParty
        {
            get
            {
                return _terminalOperatorPartyField;
            }
            set
            {
                _terminalOperatorPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType CustomsAgentParty
        {
            get
            {
                return _customsAgentPartyField;
            }
            set
            {
                _customsAgentPartyField = value;
            }
        }

        /// <remarks/>
        public PeriodType EstimatedTransitPeriod
        {
            get
            {
                return _estimatedTransitPeriodField;
            }
            set
            {
                _estimatedTransitPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
        public AllowanceChargeType[] FreightAllowanceCharge
        {
            get
            {
                return _freightAllowanceChargeField;
            }
            set
            {
                _freightAllowanceChargeField = value;
            }
        }

        /// <remarks/>
        public LocationType1 FreightChargeLocation
        {
            get
            {
                return _freightChargeLocationField;
            }
            set
            {
                _freightChargeLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DetentionTransportEvent")]
        public TransportEventType[] DetentionTransportEvent
        {
            get
            {
                return _detentionTransportEventField;
            }
            set
            {
                _detentionTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType RequestedDepartureTransportEvent
        {
            get
            {
                return _requestedDepartureTransportEventField;
            }
            set
            {
                _requestedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType RequestedArrivalTransportEvent
        {
            get
            {
                return _requestedArrivalTransportEventField;
            }
            set
            {
                _requestedArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestedWaypointTransportEvent")]
        public TransportEventType[] RequestedWaypointTransportEvent
        {
            get
            {
                return _requestedWaypointTransportEventField;
            }
            set
            {
                _requestedWaypointTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedDepartureTransportEvent
        {
            get
            {
                return _plannedDepartureTransportEventField;
            }
            set
            {
                _plannedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedArrivalTransportEvent
        {
            get
            {
                return _plannedArrivalTransportEventField;
            }
            set
            {
                _plannedArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlannedWaypointTransportEvent")]
        public TransportEventType[] PlannedWaypointTransportEvent
        {
            get
            {
                return _plannedWaypointTransportEventField;
            }
            set
            {
                _plannedWaypointTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualDepartureTransportEvent
        {
            get
            {
                return _actualDepartureTransportEventField;
            }
            set
            {
                _actualDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualWaypointTransportEvent
        {
            get
            {
                return _actualWaypointTransportEventField;
            }
            set
            {
                _actualWaypointTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualArrivalTransportEvent
        {
            get
            {
                return _actualArrivalTransportEventField;
            }
            set
            {
                _actualArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
        public TransportEventType[] TransportEvent
        {
            get
            {
                return _transportEventField;
            }
            set
            {
                _transportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType EstimatedDepartureTransportEvent
        {
            get
            {
                return _estimatedDepartureTransportEventField;
            }
            set
            {
                _estimatedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType EstimatedArrivalTransportEvent
        {
            get
            {
                return _estimatedArrivalTransportEventField;
            }
            set
            {
                _estimatedArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PassengerPerson")]
        public PersonType[] PassengerPerson
        {
            get
            {
                return _passengerPersonField;
            }
            set
            {
                _passengerPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DriverPerson")]
        public PersonType[] DriverPerson
        {
            get
            {
                return _driverPersonField;
            }
            set
            {
                _driverPersonField = value;
            }
        }

        /// <remarks/>
        public PersonType ReportingPerson
        {
            get
            {
                return _reportingPersonField;
            }
            set
            {
                _reportingPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CrewMemberPerson")]
        public PersonType[] CrewMemberPerson
        {
            get
            {
                return _crewMemberPersonField;
            }
            set
            {
                _crewMemberPersonField = value;
            }
        }

        /// <remarks/>
        public PersonType SecurityOfficerPerson
        {
            get
            {
                return _securityOfficerPersonField;
            }
            set
            {
                _securityOfficerPersonField = value;
            }
        }

        /// <remarks/>
        public PersonType MasterPerson
        {
            get
            {
                return _masterPersonField;
            }
            set
            {
                _masterPersonField = value;
            }
        }

        /// <remarks/>
        public PersonType ShipsSurgeonPerson
        {
            get
            {
                return _shipsSurgeonPersonField;
            }
            set
            {
                _shipsSurgeonPersonField = value;
            }
        }
    }
}