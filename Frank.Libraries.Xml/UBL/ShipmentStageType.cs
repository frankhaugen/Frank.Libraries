using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRoot("MainCarriageShipmentStage", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class ShipmentStageType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportModeCodeType TransportModeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportMeansTypeCodeType TransportMeansTypeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransitDirectionCodeType TransitDirectionCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreCarriageIndicatorType PreCarriageIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OnCarriageIndicatorType OnCarriageIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedDeliveryDateType EstimatedDeliveryDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedDeliveryTimeType EstimatedDeliveryTime;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredDeliveryDateType RequiredDeliveryDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredDeliveryTimeType RequiredDeliveryTime;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LoadingSequenceIDType LoadingSequenceID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SuccessiveSequenceIDType SuccessiveSequenceID;
    
        /// <remarks/>
        [XmlElement("Instructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InstructionsType[] Instructions;
    
        /// <remarks/>
        [XmlElement("DemurrageInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DemurrageInstructionsType[] DemurrageInstructions;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CrewQuantityType CrewQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PassengerQuantityType PassengerQuantity;
    
        /// <remarks/>
        public PeriodType TransitPeriod;
    
        /// <remarks/>
        [XmlElement("CarrierParty")]
        public PartyType[] CarrierParty;
    
        /// <remarks/>
        public TransportMeansType TransportMeans;
    
        /// <remarks/>
        public LocationType1 LoadingPortLocation;
    
        /// <remarks/>
        public LocationType1 UnloadingPortLocation;
    
        /// <remarks/>
        public LocationType1 TransshipPortLocation;
    
        /// <remarks/>
        public TransportEventType LoadingTransportEvent;
    
        /// <remarks/>
        public TransportEventType ExaminationTransportEvent;
    
        /// <remarks/>
        public TransportEventType AvailabilityTransportEvent;
    
        /// <remarks/>
        public TransportEventType ExportationTransportEvent;
    
        /// <remarks/>
        public TransportEventType DischargeTransportEvent;
    
        /// <remarks/>
        public TransportEventType WarehousingTransportEvent;
    
        /// <remarks/>
        public TransportEventType TakeoverTransportEvent;
    
        /// <remarks/>
        public TransportEventType OptionalTakeoverTransportEvent;
    
        /// <remarks/>
        public TransportEventType DropoffTransportEvent;
    
        /// <remarks/>
        public TransportEventType ActualPickupTransportEvent;
    
        /// <remarks/>
        public TransportEventType DeliveryTransportEvent;
    
        /// <remarks/>
        public TransportEventType ReceiptTransportEvent;
    
        /// <remarks/>
        public TransportEventType StorageTransportEvent;
    
        /// <remarks/>
        public TransportEventType AcceptanceTransportEvent;
    
        /// <remarks/>
        public PartyType TerminalOperatorParty;
    
        /// <remarks/>
        public PartyType CustomsAgentParty;
    
        /// <remarks/>
        public PeriodType EstimatedTransitPeriod;
    
        /// <remarks/>
        [XmlElement("FreightAllowanceCharge")]
        public AllowanceChargeType[] FreightAllowanceCharge;
    
        /// <remarks/>
        public LocationType1 FreightChargeLocation;
    
        /// <remarks/>
        [XmlElement("DetentionTransportEvent")]
        public TransportEventType[] DetentionTransportEvent;
    
        /// <remarks/>
        public TransportEventType RequestedDepartureTransportEvent;
    
        /// <remarks/>
        public TransportEventType RequestedArrivalTransportEvent;
    
        /// <remarks/>
        [XmlElement("RequestedWaypointTransportEvent")]
        public TransportEventType[] RequestedWaypointTransportEvent;
    
        /// <remarks/>
        public TransportEventType PlannedDepartureTransportEvent;
    
        /// <remarks/>
        public TransportEventType PlannedArrivalTransportEvent;
    
        /// <remarks/>
        [XmlElement("PlannedWaypointTransportEvent")]
        public TransportEventType[] PlannedWaypointTransportEvent;
    
        /// <remarks/>
        public TransportEventType ActualDepartureTransportEvent;
    
        /// <remarks/>
        public TransportEventType ActualWaypointTransportEvent;
    
        /// <remarks/>
        public TransportEventType ActualArrivalTransportEvent;
    
        /// <remarks/>
        [XmlElement("TransportEvent")]
        public TransportEventType[] TransportEvent;
    
        /// <remarks/>
        public TransportEventType EstimatedDepartureTransportEvent;
    
        /// <remarks/>
        public TransportEventType EstimatedArrivalTransportEvent;
    
        /// <remarks/>
        [XmlElement("PassengerPerson")]
        public PersonType[] PassengerPerson;
    
        /// <remarks/>
        [XmlElement("DriverPerson")]
        public PersonType[] DriverPerson;
    
        /// <remarks/>
        public PersonType ReportingPerson;
    
        /// <remarks/>
        [XmlElement("CrewMemberPerson")]
        public PersonType[] CrewMemberPerson;
    
        /// <remarks/>
        public PersonType SecurityOfficerPerson;
    
        /// <remarks/>
        public PersonType MasterPerson;
    
        /// <remarks/>
        public PersonType ShipsSurgeonPerson;
    }
}