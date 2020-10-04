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
    [XmlRoot("ChildConsignment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class ConsignmentType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CarrierAssignedIDType CarrierAssignedID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsigneeAssignedIDType ConsigneeAssignedID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsignorAssignedIDType ConsignorAssignedID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreightForwarderAssignedIDType FreightForwarderAssignedID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BrokerAssignedIDType BrokerAssignedID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractedCarrierAssignedIDType ContractedCarrierAssignedID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PerformingCarrierAssignedIDType PerformingCarrierAssignedID;
    
        /// <remarks/>
        [XmlElement("SummaryDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SummaryDescriptionType[] SummaryDescription;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalInvoiceAmountType TotalInvoiceAmount;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount;
    
        /// <remarks/>
        [XmlElement("TariffDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TariffDescriptionType[] TariffDescription;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TariffCodeType TariffCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InsurancePremiumAmountType InsurancePremiumAmount;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossWeightMeasureType GrossWeightMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetWeightMeasureType NetWeightMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetNetWeightMeasureType NetNetWeightMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChargeableWeightMeasureType ChargeableWeightMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossVolumeMeasureType GrossVolumeMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetVolumeMeasureType NetVolumeMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LoadingLengthMeasureType LoadingLengthMeasure;
    
        /// <remarks/>
        [XmlElement("Remarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AnimalFoodIndicatorType AnimalFoodIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HumanFoodIndicatorType HumanFoodIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LivestockIndicatorType LivestockIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BulkCargoIndicatorType BulkCargoIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContainerizedIndicatorType ContainerizedIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GeneralCargoIndicatorType GeneralCargoIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialSecurityIndicatorType SpecialSecurityIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ThirdPartyPayerIndicatorType ThirdPartyPayerIndicator;
    
        /// <remarks/>
        [XmlElement("CarrierServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CarrierServiceInstructionsType[] CarrierServiceInstructions;
    
        /// <remarks/>
        [XmlElement("CustomsClearanceServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomsClearanceServiceInstructionsType[] CustomsClearanceServiceInstructions;
    
        /// <remarks/>
        [XmlElement("ForwarderServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ForwarderServiceInstructionsType[] ForwarderServiceInstructions;
    
        /// <remarks/>
        [XmlElement("SpecialServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialServiceInstructionsType[] SpecialServiceInstructions;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceIDType SequenceID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShippingPriorityLevelCodeType ShippingPriorityLevelCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingCodeType HandlingCode;
    
        /// <remarks/>
        [XmlElement("HandlingInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingInstructionsType[] HandlingInstructions;
    
        /// <remarks/>
        [XmlElement("Information", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InformationType[] Information;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InsuranceValueAmountType InsuranceValueAmount;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreeOnBoardValueAmountType FreeOnBoardValueAmount;
    
        /// <remarks/>
        [XmlElement("SpecialInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialInstructionsType[] SpecialInstructions;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SplitConsignmentIndicatorType SplitConsignmentIndicator;
    
        /// <remarks/>
        [XmlElement("DeliveryInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeliveryInstructionsType[] DeliveryInstructions;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsignmentQuantityType ConsignmentQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsolidatableIndicatorType ConsolidatableIndicator;
    
        /// <remarks/>
        [XmlElement("HaulageInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HaulageInstructionsType[] HaulageInstructions;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LoadingSequenceIDType LoadingSequenceID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChildConsignmentQuantityType ChildConsignmentQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalPackagesQuantityType TotalPackagesQuantity;
    
        /// <remarks/>
        [XmlElement("ConsolidatedShipment")]
        public ShipmentType[] ConsolidatedShipment;
    
        /// <remarks/>
        [XmlElement("CustomsDeclaration")]
        public CustomsDeclarationType[] CustomsDeclaration;
    
        /// <remarks/>
        public TransportEventType RequestedPickupTransportEvent;
    
        /// <remarks/>
        public TransportEventType RequestedDeliveryTransportEvent;
    
        /// <remarks/>
        public TransportEventType PlannedPickupTransportEvent;
    
        /// <remarks/>
        public TransportEventType PlannedDeliveryTransportEvent;
    
        /// <remarks/>
        [XmlElement("Status")]
        public StatusType[] Status;
    
        /// <remarks/>
        [XmlElement("ChildConsignment")]
        public ConsignmentType[] ChildConsignment;
    
        /// <remarks/>
        public PartyType ConsigneeParty;
    
        /// <remarks/>
        public PartyType ExporterParty;
    
        /// <remarks/>
        public PartyType ConsignorParty;
    
        /// <remarks/>
        public PartyType ImporterParty;
    
        /// <remarks/>
        public PartyType CarrierParty;
    
        /// <remarks/>
        public PartyType FreightForwarderParty;
    
        /// <remarks/>
        public PartyType NotifyParty;
    
        /// <remarks/>
        public PartyType OriginalDespatchParty;
    
        /// <remarks/>
        public PartyType FinalDeliveryParty;
    
        /// <remarks/>
        public PartyType PerformingCarrierParty;
    
        /// <remarks/>
        public PartyType SubstituteCarrierParty;
    
        /// <remarks/>
        public PartyType LogisticsOperatorParty;
    
        /// <remarks/>
        public PartyType TransportAdvisorParty;
    
        /// <remarks/>
        public PartyType HazardousItemNotificationParty;
    
        /// <remarks/>
        public PartyType InsuranceParty;
    
        /// <remarks/>
        public PartyType MortgageHolderParty;
    
        /// <remarks/>
        public PartyType BillOfLadingHolderParty;
    
        /// <remarks/>
        public CountryType OriginalDepartureCountry;
    
        /// <remarks/>
        public CountryType FinalDestinationCountry;
    
        /// <remarks/>
        [XmlElement("TransitCountry")]
        public CountryType[] TransitCountry;
    
        /// <remarks/>
        public ContractType TransportContract;
    
        /// <remarks/>
        [XmlElement("TransportEvent")]
        public TransportEventType[] TransportEvent;
    
        /// <remarks/>
        public TransportationServiceType OriginalDespatchTransportationService;
    
        /// <remarks/>
        public TransportationServiceType FinalDeliveryTransportationService;
    
        /// <remarks/>
        public DeliveryTermsType DeliveryTerms;
    
        /// <remarks/>
        public PaymentTermsType PaymentTerms;
    
        /// <remarks/>
        public PaymentTermsType CollectPaymentTerms;
    
        /// <remarks/>
        public PaymentTermsType DisbursementPaymentTerms;
    
        /// <remarks/>
        public PaymentTermsType PrepaidPaymentTerms;
    
        /// <remarks/>
        [XmlElement("FreightAllowanceCharge")]
        public AllowanceChargeType[] FreightAllowanceCharge;
    
        /// <remarks/>
        [XmlElement("ExtraAllowanceCharge")]
        public AllowanceChargeType[] ExtraAllowanceCharge;
    
        /// <remarks/>
        [XmlElement("MainCarriageShipmentStage")]
        public ShipmentStageType[] MainCarriageShipmentStage;
    
        /// <remarks/>
        [XmlElement("PreCarriageShipmentStage")]
        public ShipmentStageType[] PreCarriageShipmentStage;
    
        /// <remarks/>
        [XmlElement("OnCarriageShipmentStage")]
        public ShipmentStageType[] OnCarriageShipmentStage;
    
        /// <remarks/>
        [XmlElement("TransportHandlingUnit")]
        public TransportHandlingUnitType[] TransportHandlingUnit;
    
        /// <remarks/>
        public LocationType1 FirstArrivalPortLocation;
    
        /// <remarks/>
        public LocationType1 LastExitPortLocation;
    }
}