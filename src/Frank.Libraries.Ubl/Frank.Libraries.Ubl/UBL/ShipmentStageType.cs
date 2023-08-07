using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("MainCarriageShipmentStage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ShipmentStageType
{
    private TransportEventType acceptanceTransportEventField;

    private TransportEventType actualArrivalTransportEventField;

    private TransportEventType actualDepartureTransportEventField;

    private TransportEventType actualPickupTransportEventField;

    private TransportEventType actualWaypointTransportEventField;

    private TransportEventType availabilityTransportEventField;

    private PartyType[] carrierPartyField;

    private PersonType[] crewMemberPersonField;

    private CrewQuantityType crewQuantityField;

    private PartyType customsAgentPartyField;

    private TransportEventType deliveryTransportEventField;

    private DemurrageInstructionsType[] demurrageInstructionsField;

    private TransportEventType[] detentionTransportEventField;

    private TransportEventType dischargeTransportEventField;

    private PersonType[] driverPersonField;

    private TransportEventType dropoffTransportEventField;

    private TransportEventType estimatedArrivalTransportEventField;

    private EstimatedDeliveryDateType estimatedDeliveryDateField;

    private EstimatedDeliveryTimeType estimatedDeliveryTimeField;

    private TransportEventType estimatedDepartureTransportEventField;

    private PeriodType estimatedTransitPeriodField;

    private TransportEventType examinationTransportEventField;

    private TransportEventType exportationTransportEventField;

    private AllowanceChargeType[] freightAllowanceChargeField;

    private LocationType1 freightChargeLocationField;

    private IDType idField;

    private InstructionsType[] instructionsField;

    private LocationType1 loadingPortLocationField;

    private LoadingSequenceIDType loadingSequenceIDField;

    private TransportEventType loadingTransportEventField;

    private PersonType masterPersonField;

    private OnCarriageIndicatorType onCarriageIndicatorField;

    private TransportEventType optionalTakeoverTransportEventField;

    private PersonType[] passengerPersonField;

    private PassengerQuantityType passengerQuantityField;

    private TransportEventType plannedArrivalTransportEventField;

    private TransportEventType plannedDepartureTransportEventField;

    private TransportEventType[] plannedWaypointTransportEventField;

    private PreCarriageIndicatorType preCarriageIndicatorField;

    private TransportEventType receiptTransportEventField;

    private PersonType reportingPersonField;

    private TransportEventType requestedArrivalTransportEventField;

    private TransportEventType requestedDepartureTransportEventField;

    private TransportEventType[] requestedWaypointTransportEventField;

    private RequiredDeliveryDateType requiredDeliveryDateField;

    private RequiredDeliveryTimeType requiredDeliveryTimeField;

    private PersonType securityOfficerPersonField;

    private PersonType shipsSurgeonPersonField;

    private TransportEventType storageTransportEventField;

    private SuccessiveSequenceIDType successiveSequenceIDField;

    private TransportEventType takeoverTransportEventField;

    private PartyType terminalOperatorPartyField;

    private TransitDirectionCodeType transitDirectionCodeField;

    private PeriodType transitPeriodField;

    private TransportEventType[] transportEventField;

    private TransportMeansType transportMeansField;

    private TransportMeansTypeCodeType transportMeansTypeCodeField;

    private TransportModeCodeType transportModeCodeField;

    private LocationType1 transshipPortLocationField;

    private LocationType1 unloadingPortLocationField;

    private TransportEventType warehousingTransportEventField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportModeCodeType TransportModeCode
    {
        get => transportModeCodeField;
        set => transportModeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportMeansTypeCodeType TransportMeansTypeCode
    {
        get => transportMeansTypeCodeField;
        set => transportMeansTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransitDirectionCodeType TransitDirectionCode
    {
        get => transitDirectionCodeField;
        set => transitDirectionCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreCarriageIndicatorType PreCarriageIndicator
    {
        get => preCarriageIndicatorField;
        set => preCarriageIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OnCarriageIndicatorType OnCarriageIndicator
    {
        get => onCarriageIndicatorField;
        set => onCarriageIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedDeliveryDateType EstimatedDeliveryDate
    {
        get => estimatedDeliveryDateField;
        set => estimatedDeliveryDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedDeliveryTimeType EstimatedDeliveryTime
    {
        get => estimatedDeliveryTimeField;
        set => estimatedDeliveryTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequiredDeliveryDateType RequiredDeliveryDate
    {
        get => requiredDeliveryDateField;
        set => requiredDeliveryDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequiredDeliveryTimeType RequiredDeliveryTime
    {
        get => requiredDeliveryTimeField;
        set => requiredDeliveryTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LoadingSequenceIDType LoadingSequenceID
    {
        get => loadingSequenceIDField;
        set => loadingSequenceIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SuccessiveSequenceIDType SuccessiveSequenceID
    {
        get => successiveSequenceIDField;
        set => successiveSequenceIDField = value;
    }

    /// <remarks />
    [XmlElement("Instructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstructionsType[] Instructions
    {
        get => instructionsField;
        set => instructionsField = value;
    }

    /// <remarks />
    [XmlElement("DemurrageInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DemurrageInstructionsType[] DemurrageInstructions
    {
        get => demurrageInstructionsField;
        set => demurrageInstructionsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CrewQuantityType CrewQuantity
    {
        get => crewQuantityField;
        set => crewQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PassengerQuantityType PassengerQuantity
    {
        get => passengerQuantityField;
        set => passengerQuantityField = value;
    }

    /// <remarks />
    public PeriodType TransitPeriod
    {
        get => transitPeriodField;
        set => transitPeriodField = value;
    }

    /// <remarks />
    [XmlElement("CarrierParty")]
    public PartyType[] CarrierParty
    {
        get => carrierPartyField;
        set => carrierPartyField = value;
    }

    /// <remarks />
    public TransportMeansType TransportMeans
    {
        get => transportMeansField;
        set => transportMeansField = value;
    }

    /// <remarks />
    public LocationType1 LoadingPortLocation
    {
        get => loadingPortLocationField;
        set => loadingPortLocationField = value;
    }

    /// <remarks />
    public LocationType1 UnloadingPortLocation
    {
        get => unloadingPortLocationField;
        set => unloadingPortLocationField = value;
    }

    /// <remarks />
    public LocationType1 TransshipPortLocation
    {
        get => transshipPortLocationField;
        set => transshipPortLocationField = value;
    }

    /// <remarks />
    public TransportEventType LoadingTransportEvent
    {
        get => loadingTransportEventField;
        set => loadingTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType ExaminationTransportEvent
    {
        get => examinationTransportEventField;
        set => examinationTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType AvailabilityTransportEvent
    {
        get => availabilityTransportEventField;
        set => availabilityTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType ExportationTransportEvent
    {
        get => exportationTransportEventField;
        set => exportationTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType DischargeTransportEvent
    {
        get => dischargeTransportEventField;
        set => dischargeTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType WarehousingTransportEvent
    {
        get => warehousingTransportEventField;
        set => warehousingTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType TakeoverTransportEvent
    {
        get => takeoverTransportEventField;
        set => takeoverTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType OptionalTakeoverTransportEvent
    {
        get => optionalTakeoverTransportEventField;
        set => optionalTakeoverTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType DropoffTransportEvent
    {
        get => dropoffTransportEventField;
        set => dropoffTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType ActualPickupTransportEvent
    {
        get => actualPickupTransportEventField;
        set => actualPickupTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType DeliveryTransportEvent
    {
        get => deliveryTransportEventField;
        set => deliveryTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType ReceiptTransportEvent
    {
        get => receiptTransportEventField;
        set => receiptTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType StorageTransportEvent
    {
        get => storageTransportEventField;
        set => storageTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType AcceptanceTransportEvent
    {
        get => acceptanceTransportEventField;
        set => acceptanceTransportEventField = value;
    }

    /// <remarks />
    public PartyType TerminalOperatorParty
    {
        get => terminalOperatorPartyField;
        set => terminalOperatorPartyField = value;
    }

    /// <remarks />
    public PartyType CustomsAgentParty
    {
        get => customsAgentPartyField;
        set => customsAgentPartyField = value;
    }

    /// <remarks />
    public PeriodType EstimatedTransitPeriod
    {
        get => estimatedTransitPeriodField;
        set => estimatedTransitPeriodField = value;
    }

    /// <remarks />
    [XmlElement("FreightAllowanceCharge")]
    public AllowanceChargeType[] FreightAllowanceCharge
    {
        get => freightAllowanceChargeField;
        set => freightAllowanceChargeField = value;
    }

    /// <remarks />
    public LocationType1 FreightChargeLocation
    {
        get => freightChargeLocationField;
        set => freightChargeLocationField = value;
    }

    /// <remarks />
    [XmlElement("DetentionTransportEvent")]
    public TransportEventType[] DetentionTransportEvent
    {
        get => detentionTransportEventField;
        set => detentionTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType RequestedDepartureTransportEvent
    {
        get => requestedDepartureTransportEventField;
        set => requestedDepartureTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType RequestedArrivalTransportEvent
    {
        get => requestedArrivalTransportEventField;
        set => requestedArrivalTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("RequestedWaypointTransportEvent")]
    public TransportEventType[] RequestedWaypointTransportEvent
    {
        get => requestedWaypointTransportEventField;
        set => requestedWaypointTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType PlannedDepartureTransportEvent
    {
        get => plannedDepartureTransportEventField;
        set => plannedDepartureTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType PlannedArrivalTransportEvent
    {
        get => plannedArrivalTransportEventField;
        set => plannedArrivalTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("PlannedWaypointTransportEvent")]
    public TransportEventType[] PlannedWaypointTransportEvent
    {
        get => plannedWaypointTransportEventField;
        set => plannedWaypointTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType ActualDepartureTransportEvent
    {
        get => actualDepartureTransportEventField;
        set => actualDepartureTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType ActualWaypointTransportEvent
    {
        get => actualWaypointTransportEventField;
        set => actualWaypointTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType ActualArrivalTransportEvent
    {
        get => actualArrivalTransportEventField;
        set => actualArrivalTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("TransportEvent")]
    public TransportEventType[] TransportEvent
    {
        get => transportEventField;
        set => transportEventField = value;
    }

    /// <remarks />
    public TransportEventType EstimatedDepartureTransportEvent
    {
        get => estimatedDepartureTransportEventField;
        set => estimatedDepartureTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType EstimatedArrivalTransportEvent
    {
        get => estimatedArrivalTransportEventField;
        set => estimatedArrivalTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("PassengerPerson")]
    public PersonType[] PassengerPerson
    {
        get => passengerPersonField;
        set => passengerPersonField = value;
    }

    /// <remarks />
    [XmlElement("DriverPerson")]
    public PersonType[] DriverPerson
    {
        get => driverPersonField;
        set => driverPersonField = value;
    }

    /// <remarks />
    public PersonType ReportingPerson
    {
        get => reportingPersonField;
        set => reportingPersonField = value;
    }

    /// <remarks />
    [XmlElement("CrewMemberPerson")]
    public PersonType[] CrewMemberPerson
    {
        get => crewMemberPersonField;
        set => crewMemberPersonField = value;
    }

    /// <remarks />
    public PersonType SecurityOfficerPerson
    {
        get => securityOfficerPersonField;
        set => securityOfficerPersonField = value;
    }

    /// <remarks />
    public PersonType MasterPerson
    {
        get => masterPersonField;
        set => masterPersonField = value;
    }

    /// <remarks />
    public PersonType ShipsSurgeonPerson
    {
        get => shipsSurgeonPersonField;
        set => shipsSurgeonPersonField = value;
    }
}