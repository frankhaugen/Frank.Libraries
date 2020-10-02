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

        private IDType idField;

        private TransportModeCodeType transportModeCodeField;

        private TransportMeansTypeCodeType transportMeansTypeCodeField;

        private TransitDirectionCodeType transitDirectionCodeField;

        private PreCarriageIndicatorType preCarriageIndicatorField;

        private OnCarriageIndicatorType onCarriageIndicatorField;

        private EstimatedDeliveryDateType estimatedDeliveryDateField;

        private EstimatedDeliveryTimeType estimatedDeliveryTimeField;

        private RequiredDeliveryDateType requiredDeliveryDateField;

        private RequiredDeliveryTimeType requiredDeliveryTimeField;

        private LoadingSequenceIDType loadingSequenceIDField;

        private SuccessiveSequenceIDType successiveSequenceIDField;

        private InstructionsType[] instructionsField;

        private DemurrageInstructionsType[] demurrageInstructionsField;

        private CrewQuantityType crewQuantityField;

        private PassengerQuantityType passengerQuantityField;

        private PeriodType transitPeriodField;

        private PartyType[] carrierPartyField;

        private TransportMeansType transportMeansField;

        private LocationType1 loadingPortLocationField;

        private LocationType1 unloadingPortLocationField;

        private LocationType1 transshipPortLocationField;

        private TransportEventType loadingTransportEventField;

        private TransportEventType examinationTransportEventField;

        private TransportEventType availabilityTransportEventField;

        private TransportEventType exportationTransportEventField;

        private TransportEventType dischargeTransportEventField;

        private TransportEventType warehousingTransportEventField;

        private TransportEventType takeoverTransportEventField;

        private TransportEventType optionalTakeoverTransportEventField;

        private TransportEventType dropoffTransportEventField;

        private TransportEventType actualPickupTransportEventField;

        private TransportEventType deliveryTransportEventField;

        private TransportEventType receiptTransportEventField;

        private TransportEventType storageTransportEventField;

        private TransportEventType acceptanceTransportEventField;

        private PartyType terminalOperatorPartyField;

        private PartyType customsAgentPartyField;

        private PeriodType estimatedTransitPeriodField;

        private AllowanceChargeType[] freightAllowanceChargeField;

        private LocationType1 freightChargeLocationField;

        private TransportEventType[] detentionTransportEventField;

        private TransportEventType requestedDepartureTransportEventField;

        private TransportEventType requestedArrivalTransportEventField;

        private TransportEventType[] requestedWaypointTransportEventField;

        private TransportEventType plannedDepartureTransportEventField;

        private TransportEventType plannedArrivalTransportEventField;

        private TransportEventType[] plannedWaypointTransportEventField;

        private TransportEventType actualDepartureTransportEventField;

        private TransportEventType actualWaypointTransportEventField;

        private TransportEventType actualArrivalTransportEventField;

        private TransportEventType[] transportEventField;

        private TransportEventType estimatedDepartureTransportEventField;

        private TransportEventType estimatedArrivalTransportEventField;

        private PersonType[] passengerPersonField;

        private PersonType[] driverPersonField;

        private PersonType reportingPersonField;

        private PersonType[] crewMemberPersonField;

        private PersonType securityOfficerPersonField;

        private PersonType masterPersonField;

        private PersonType shipsSurgeonPersonField;

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
        public TransportModeCodeType TransportModeCode
        {
            get
            {
                return transportModeCodeField;
            }
            set
            {
                transportModeCodeField = value;
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
        public TransitDirectionCodeType TransitDirectionCode
        {
            get
            {
                return transitDirectionCodeField;
            }
            set
            {
                transitDirectionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreCarriageIndicatorType PreCarriageIndicator
        {
            get
            {
                return preCarriageIndicatorField;
            }
            set
            {
                preCarriageIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OnCarriageIndicatorType OnCarriageIndicator
        {
            get
            {
                return onCarriageIndicatorField;
            }
            set
            {
                onCarriageIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedDeliveryDateType EstimatedDeliveryDate
        {
            get
            {
                return estimatedDeliveryDateField;
            }
            set
            {
                estimatedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedDeliveryTimeType EstimatedDeliveryTime
        {
            get
            {
                return estimatedDeliveryTimeField;
            }
            set
            {
                estimatedDeliveryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredDeliveryDateType RequiredDeliveryDate
        {
            get
            {
                return requiredDeliveryDateField;
            }
            set
            {
                requiredDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredDeliveryTimeType RequiredDeliveryTime
        {
            get
            {
                return requiredDeliveryTimeField;
            }
            set
            {
                requiredDeliveryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LoadingSequenceIDType LoadingSequenceID
        {
            get
            {
                return loadingSequenceIDField;
            }
            set
            {
                loadingSequenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SuccessiveSequenceIDType SuccessiveSequenceID
        {
            get
            {
                return successiveSequenceIDField;
            }
            set
            {
                successiveSequenceIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("DemurrageInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DemurrageInstructionsType[] DemurrageInstructions
        {
            get
            {
                return demurrageInstructionsField;
            }
            set
            {
                demurrageInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CrewQuantityType CrewQuantity
        {
            get
            {
                return crewQuantityField;
            }
            set
            {
                crewQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PassengerQuantityType PassengerQuantity
        {
            get
            {
                return passengerQuantityField;
            }
            set
            {
                passengerQuantityField = value;
            }
        }

        /// <remarks/>
        public PeriodType TransitPeriod
        {
            get
            {
                return transitPeriodField;
            }
            set
            {
                transitPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarrierParty")]
        public PartyType[] CarrierParty
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
        public TransportMeansType TransportMeans
        {
            get
            {
                return transportMeansField;
            }
            set
            {
                transportMeansField = value;
            }
        }

        /// <remarks/>
        public LocationType1 LoadingPortLocation
        {
            get
            {
                return loadingPortLocationField;
            }
            set
            {
                loadingPortLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 UnloadingPortLocation
        {
            get
            {
                return unloadingPortLocationField;
            }
            set
            {
                unloadingPortLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 TransshipPortLocation
        {
            get
            {
                return transshipPortLocationField;
            }
            set
            {
                transshipPortLocationField = value;
            }
        }

        /// <remarks/>
        public TransportEventType LoadingTransportEvent
        {
            get
            {
                return loadingTransportEventField;
            }
            set
            {
                loadingTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ExaminationTransportEvent
        {
            get
            {
                return examinationTransportEventField;
            }
            set
            {
                examinationTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType AvailabilityTransportEvent
        {
            get
            {
                return availabilityTransportEventField;
            }
            set
            {
                availabilityTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ExportationTransportEvent
        {
            get
            {
                return exportationTransportEventField;
            }
            set
            {
                exportationTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType DischargeTransportEvent
        {
            get
            {
                return dischargeTransportEventField;
            }
            set
            {
                dischargeTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType WarehousingTransportEvent
        {
            get
            {
                return warehousingTransportEventField;
            }
            set
            {
                warehousingTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType TakeoverTransportEvent
        {
            get
            {
                return takeoverTransportEventField;
            }
            set
            {
                takeoverTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType OptionalTakeoverTransportEvent
        {
            get
            {
                return optionalTakeoverTransportEventField;
            }
            set
            {
                optionalTakeoverTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType DropoffTransportEvent
        {
            get
            {
                return dropoffTransportEventField;
            }
            set
            {
                dropoffTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualPickupTransportEvent
        {
            get
            {
                return actualPickupTransportEventField;
            }
            set
            {
                actualPickupTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType DeliveryTransportEvent
        {
            get
            {
                return deliveryTransportEventField;
            }
            set
            {
                deliveryTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ReceiptTransportEvent
        {
            get
            {
                return receiptTransportEventField;
            }
            set
            {
                receiptTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType StorageTransportEvent
        {
            get
            {
                return storageTransportEventField;
            }
            set
            {
                storageTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType AcceptanceTransportEvent
        {
            get
            {
                return acceptanceTransportEventField;
            }
            set
            {
                acceptanceTransportEventField = value;
            }
        }

        /// <remarks/>
        public PartyType TerminalOperatorParty
        {
            get
            {
                return terminalOperatorPartyField;
            }
            set
            {
                terminalOperatorPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType CustomsAgentParty
        {
            get
            {
                return customsAgentPartyField;
            }
            set
            {
                customsAgentPartyField = value;
            }
        }

        /// <remarks/>
        public PeriodType EstimatedTransitPeriod
        {
            get
            {
                return estimatedTransitPeriodField;
            }
            set
            {
                estimatedTransitPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
        public AllowanceChargeType[] FreightAllowanceCharge
        {
            get
            {
                return freightAllowanceChargeField;
            }
            set
            {
                freightAllowanceChargeField = value;
            }
        }

        /// <remarks/>
        public LocationType1 FreightChargeLocation
        {
            get
            {
                return freightChargeLocationField;
            }
            set
            {
                freightChargeLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DetentionTransportEvent")]
        public TransportEventType[] DetentionTransportEvent
        {
            get
            {
                return detentionTransportEventField;
            }
            set
            {
                detentionTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType RequestedDepartureTransportEvent
        {
            get
            {
                return requestedDepartureTransportEventField;
            }
            set
            {
                requestedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType RequestedArrivalTransportEvent
        {
            get
            {
                return requestedArrivalTransportEventField;
            }
            set
            {
                requestedArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestedWaypointTransportEvent")]
        public TransportEventType[] RequestedWaypointTransportEvent
        {
            get
            {
                return requestedWaypointTransportEventField;
            }
            set
            {
                requestedWaypointTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedDepartureTransportEvent
        {
            get
            {
                return plannedDepartureTransportEventField;
            }
            set
            {
                plannedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedArrivalTransportEvent
        {
            get
            {
                return plannedArrivalTransportEventField;
            }
            set
            {
                plannedArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlannedWaypointTransportEvent")]
        public TransportEventType[] PlannedWaypointTransportEvent
        {
            get
            {
                return plannedWaypointTransportEventField;
            }
            set
            {
                plannedWaypointTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualDepartureTransportEvent
        {
            get
            {
                return actualDepartureTransportEventField;
            }
            set
            {
                actualDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualWaypointTransportEvent
        {
            get
            {
                return actualWaypointTransportEventField;
            }
            set
            {
                actualWaypointTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualArrivalTransportEvent
        {
            get
            {
                return actualArrivalTransportEventField;
            }
            set
            {
                actualArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
        public TransportEventType[] TransportEvent
        {
            get
            {
                return transportEventField;
            }
            set
            {
                transportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType EstimatedDepartureTransportEvent
        {
            get
            {
                return estimatedDepartureTransportEventField;
            }
            set
            {
                estimatedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType EstimatedArrivalTransportEvent
        {
            get
            {
                return estimatedArrivalTransportEventField;
            }
            set
            {
                estimatedArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PassengerPerson")]
        public PersonType[] PassengerPerson
        {
            get
            {
                return passengerPersonField;
            }
            set
            {
                passengerPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DriverPerson")]
        public PersonType[] DriverPerson
        {
            get
            {
                return driverPersonField;
            }
            set
            {
                driverPersonField = value;
            }
        }

        /// <remarks/>
        public PersonType ReportingPerson
        {
            get
            {
                return reportingPersonField;
            }
            set
            {
                reportingPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CrewMemberPerson")]
        public PersonType[] CrewMemberPerson
        {
            get
            {
                return crewMemberPersonField;
            }
            set
            {
                crewMemberPersonField = value;
            }
        }

        /// <remarks/>
        public PersonType SecurityOfficerPerson
        {
            get
            {
                return securityOfficerPersonField;
            }
            set
            {
                securityOfficerPersonField = value;
            }
        }

        /// <remarks/>
        public PersonType MasterPerson
        {
            get
            {
                return masterPersonField;
            }
            set
            {
                masterPersonField = value;
            }
        }

        /// <remarks/>
        public PersonType ShipsSurgeonPerson
        {
            get
            {
                return shipsSurgeonPersonField;
            }
            set
            {
                shipsSurgeonPersonField = value;
            }
        }
    }
}