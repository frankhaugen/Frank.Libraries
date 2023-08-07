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
[XmlRoot("ChildConsignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ConsignmentType
{
    private AnimalFoodIndicatorType animalFoodIndicatorField;

    private PartyType billOfLadingHolderPartyField;

    private BrokerAssignedIDType brokerAssignedIDField;

    private BulkCargoIndicatorType bulkCargoIndicatorField;

    private CarrierAssignedIDType carrierAssignedIDField;

    private PartyType carrierPartyField;

    private CarrierServiceInstructionsType[] carrierServiceInstructionsField;

    private ChargeableWeightMeasureType chargeableWeightMeasureField;

    private ConsignmentType[] childConsignmentField;

    private ChildConsignmentQuantityType childConsignmentQuantityField;

    private PaymentTermsType collectPaymentTermsField;

    private ConsigneeAssignedIDType consigneeAssignedIDField;

    private PartyType consigneePartyField;

    private ConsignmentQuantityType consignmentQuantityField;

    private ConsignorAssignedIDType consignorAssignedIDField;

    private PartyType consignorPartyField;

    private ConsolidatableIndicatorType consolidatableIndicatorField;

    private ShipmentType[] consolidatedShipmentField;

    private ContainerizedIndicatorType containerizedIndicatorField;

    private ContractedCarrierAssignedIDType contractedCarrierAssignedIDField;

    private CustomsClearanceServiceInstructionsType[] customsClearanceServiceInstructionsField;

    private CustomsDeclarationType[] customsDeclarationField;

    private DeclaredCustomsValueAmountType declaredCustomsValueAmountField;

    private DeclaredForCarriageValueAmountType declaredForCarriageValueAmountField;

    private DeclaredStatisticsValueAmountType declaredStatisticsValueAmountField;

    private DeliveryInstructionsType[] deliveryInstructionsField;

    private DeliveryTermsType deliveryTermsField;

    private PaymentTermsType disbursementPaymentTermsField;

    private PartyType exporterPartyField;

    private AllowanceChargeType[] extraAllowanceChargeField;

    private PartyType finalDeliveryPartyField;

    private TransportationServiceType finalDeliveryTransportationServiceField;

    private CountryType finalDestinationCountryField;

    private LocationType1 firstArrivalPortLocationField;

    private ForwarderServiceInstructionsType[] forwarderServiceInstructionsField;

    private FreeOnBoardValueAmountType freeOnBoardValueAmountField;

    private AllowanceChargeType[] freightAllowanceChargeField;

    private FreightForwarderAssignedIDType freightForwarderAssignedIDField;

    private PartyType freightForwarderPartyField;

    private GeneralCargoIndicatorType generalCargoIndicatorField;

    private GrossVolumeMeasureType grossVolumeMeasureField;

    private GrossWeightMeasureType grossWeightMeasureField;

    private HandlingCodeType handlingCodeField;

    private HandlingInstructionsType[] handlingInstructionsField;

    private HaulageInstructionsType[] haulageInstructionsField;

    private PartyType hazardousItemNotificationPartyField;

    private HazardousRiskIndicatorType hazardousRiskIndicatorField;

    private HumanFoodIndicatorType humanFoodIndicatorField;

    private IDType idField;

    private PartyType importerPartyField;

    private InformationType[] informationField;

    private PartyType insurancePartyField;

    private InsurancePremiumAmountType insurancePremiumAmountField;

    private InsuranceValueAmountType insuranceValueAmountField;

    private LocationType1 lastExitPortLocationField;

    private LivestockIndicatorType livestockIndicatorField;

    private LoadingLengthMeasureType loadingLengthMeasureField;

    private LoadingSequenceIDType loadingSequenceIDField;

    private PartyType logisticsOperatorPartyField;

    private ShipmentStageType[] mainCarriageShipmentStageField;

    private PartyType mortgageHolderPartyField;

    private NetNetWeightMeasureType netNetWeightMeasureField;

    private NetVolumeMeasureType netVolumeMeasureField;

    private NetWeightMeasureType netWeightMeasureField;

    private PartyType notifyPartyField;

    private ShipmentStageType[] onCarriageShipmentStageField;

    private CountryType originalDepartureCountryField;

    private PartyType originalDespatchPartyField;

    private TransportationServiceType originalDespatchTransportationServiceField;

    private PaymentTermsType paymentTermsField;

    private PerformingCarrierAssignedIDType performingCarrierAssignedIDField;

    private PartyType performingCarrierPartyField;

    private TransportEventType plannedDeliveryTransportEventField;

    private TransportEventType plannedPickupTransportEventField;

    private ShipmentStageType[] preCarriageShipmentStageField;

    private PaymentTermsType prepaidPaymentTermsField;

    private RemarksType[] remarksField;

    private TransportEventType requestedDeliveryTransportEventField;

    private TransportEventType requestedPickupTransportEventField;

    private SequenceIDType sequenceIDField;

    private ShippingPriorityLevelCodeType shippingPriorityLevelCodeField;

    private SpecialInstructionsType[] specialInstructionsField;

    private SpecialSecurityIndicatorType specialSecurityIndicatorField;

    private SpecialServiceInstructionsType[] specialServiceInstructionsField;

    private SplitConsignmentIndicatorType splitConsignmentIndicatorField;

    private StatusType[] statusField;

    private PartyType substituteCarrierPartyField;

    private SummaryDescriptionType[] summaryDescriptionField;

    private TariffCodeType tariffCodeField;

    private TariffDescriptionType[] tariffDescriptionField;

    private ThirdPartyPayerIndicatorType thirdPartyPayerIndicatorField;

    private TotalGoodsItemQuantityType totalGoodsItemQuantityField;

    private TotalInvoiceAmountType totalInvoiceAmountField;

    private TotalPackagesQuantityType totalPackagesQuantityField;

    private TotalTransportHandlingUnitQuantityType totalTransportHandlingUnitQuantityField;

    private CountryType[] transitCountryField;

    private PartyType transportAdvisorPartyField;

    private ContractType transportContractField;

    private TransportEventType[] transportEventField;

    private TransportHandlingUnitType[] transportHandlingUnitField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CarrierAssignedIDType CarrierAssignedID
    {
        get => carrierAssignedIDField;
        set => carrierAssignedIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsigneeAssignedIDType ConsigneeAssignedID
    {
        get => consigneeAssignedIDField;
        set => consigneeAssignedIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsignorAssignedIDType ConsignorAssignedID
    {
        get => consignorAssignedIDField;
        set => consignorAssignedIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FreightForwarderAssignedIDType FreightForwarderAssignedID
    {
        get => freightForwarderAssignedIDField;
        set => freightForwarderAssignedIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BrokerAssignedIDType BrokerAssignedID
    {
        get => brokerAssignedIDField;
        set => brokerAssignedIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractedCarrierAssignedIDType ContractedCarrierAssignedID
    {
        get => contractedCarrierAssignedIDField;
        set => contractedCarrierAssignedIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerformingCarrierAssignedIDType PerformingCarrierAssignedID
    {
        get => performingCarrierAssignedIDField;
        set => performingCarrierAssignedIDField = value;
    }

    /// <remarks />
    [XmlElement("SummaryDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SummaryDescriptionType[] SummaryDescription
    {
        get => summaryDescriptionField;
        set => summaryDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalInvoiceAmountType TotalInvoiceAmount
    {
        get => totalInvoiceAmountField;
        set => totalInvoiceAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
    {
        get => declaredCustomsValueAmountField;
        set => declaredCustomsValueAmountField = value;
    }

    /// <remarks />
    [XmlElement("TariffDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TariffDescriptionType[] TariffDescription
    {
        get => tariffDescriptionField;
        set => tariffDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TariffCodeType TariffCode
    {
        get => tariffCodeField;
        set => tariffCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InsurancePremiumAmountType InsurancePremiumAmount
    {
        get => insurancePremiumAmountField;
        set => insurancePremiumAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GrossWeightMeasureType GrossWeightMeasure
    {
        get => grossWeightMeasureField;
        set => grossWeightMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetWeightMeasureType NetWeightMeasure
    {
        get => netWeightMeasureField;
        set => netWeightMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetNetWeightMeasureType NetNetWeightMeasure
    {
        get => netNetWeightMeasureField;
        set => netNetWeightMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChargeableWeightMeasureType ChargeableWeightMeasure
    {
        get => chargeableWeightMeasureField;
        set => chargeableWeightMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GrossVolumeMeasureType GrossVolumeMeasure
    {
        get => grossVolumeMeasureField;
        set => grossVolumeMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetVolumeMeasureType NetVolumeMeasure
    {
        get => netVolumeMeasureField;
        set => netVolumeMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LoadingLengthMeasureType LoadingLengthMeasure
    {
        get => loadingLengthMeasureField;
        set => loadingLengthMeasureField = value;
    }

    /// <remarks />
    [XmlElement("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RemarksType[] Remarks
    {
        get => remarksField;
        set => remarksField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousRiskIndicatorType HazardousRiskIndicator
    {
        get => hazardousRiskIndicatorField;
        set => hazardousRiskIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AnimalFoodIndicatorType AnimalFoodIndicator
    {
        get => animalFoodIndicatorField;
        set => animalFoodIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HumanFoodIndicatorType HumanFoodIndicator
    {
        get => humanFoodIndicatorField;
        set => humanFoodIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LivestockIndicatorType LivestockIndicator
    {
        get => livestockIndicatorField;
        set => livestockIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BulkCargoIndicatorType BulkCargoIndicator
    {
        get => bulkCargoIndicatorField;
        set => bulkCargoIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContainerizedIndicatorType ContainerizedIndicator
    {
        get => containerizedIndicatorField;
        set => containerizedIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GeneralCargoIndicatorType GeneralCargoIndicator
    {
        get => generalCargoIndicatorField;
        set => generalCargoIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialSecurityIndicatorType SpecialSecurityIndicator
    {
        get => specialSecurityIndicatorField;
        set => specialSecurityIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ThirdPartyPayerIndicatorType ThirdPartyPayerIndicator
    {
        get => thirdPartyPayerIndicatorField;
        set => thirdPartyPayerIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("CarrierServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CarrierServiceInstructionsType[] CarrierServiceInstructions
    {
        get => carrierServiceInstructionsField;
        set => carrierServiceInstructionsField = value;
    }

    /// <remarks />
    [XmlElement("CustomsClearanceServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomsClearanceServiceInstructionsType[] CustomsClearanceServiceInstructions
    {
        get => customsClearanceServiceInstructionsField;
        set => customsClearanceServiceInstructionsField = value;
    }

    /// <remarks />
    [XmlElement("ForwarderServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ForwarderServiceInstructionsType[] ForwarderServiceInstructions
    {
        get => forwarderServiceInstructionsField;
        set => forwarderServiceInstructionsField = value;
    }

    /// <remarks />
    [XmlElement("SpecialServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialServiceInstructionsType[] SpecialServiceInstructions
    {
        get => specialServiceInstructionsField;
        set => specialServiceInstructionsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceIDType SequenceID
    {
        get => sequenceIDField;
        set => sequenceIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShippingPriorityLevelCodeType ShippingPriorityLevelCode
    {
        get => shippingPriorityLevelCodeField;
        set => shippingPriorityLevelCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingCodeType HandlingCode
    {
        get => handlingCodeField;
        set => handlingCodeField = value;
    }

    /// <remarks />
    [XmlElement("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingInstructionsType[] HandlingInstructions
    {
        get => handlingInstructionsField;
        set => handlingInstructionsField = value;
    }

    /// <remarks />
    [XmlElement("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InformationType[] Information
    {
        get => informationField;
        set => informationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalGoodsItemQuantityType TotalGoodsItemQuantity
    {
        get => totalGoodsItemQuantityField;
        set => totalGoodsItemQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity
    {
        get => totalTransportHandlingUnitQuantityField;
        set => totalTransportHandlingUnitQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InsuranceValueAmountType InsuranceValueAmount
    {
        get => insuranceValueAmountField;
        set => insuranceValueAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
    {
        get => declaredForCarriageValueAmountField;
        set => declaredForCarriageValueAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
    {
        get => declaredStatisticsValueAmountField;
        set => declaredStatisticsValueAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FreeOnBoardValueAmountType FreeOnBoardValueAmount
    {
        get => freeOnBoardValueAmountField;
        set => freeOnBoardValueAmountField = value;
    }

    /// <remarks />
    [XmlElement("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialInstructionsType[] SpecialInstructions
    {
        get => specialInstructionsField;
        set => specialInstructionsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SplitConsignmentIndicatorType SplitConsignmentIndicator
    {
        get => splitConsignmentIndicatorField;
        set => splitConsignmentIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeliveryInstructionsType[] DeliveryInstructions
    {
        get => deliveryInstructionsField;
        set => deliveryInstructionsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsignmentQuantityType ConsignmentQuantity
    {
        get => consignmentQuantityField;
        set => consignmentQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsolidatableIndicatorType ConsolidatableIndicator
    {
        get => consolidatableIndicatorField;
        set => consolidatableIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("HaulageInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HaulageInstructionsType[] HaulageInstructions
    {
        get => haulageInstructionsField;
        set => haulageInstructionsField = value;
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
    public ChildConsignmentQuantityType ChildConsignmentQuantity
    {
        get => childConsignmentQuantityField;
        set => childConsignmentQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalPackagesQuantityType TotalPackagesQuantity
    {
        get => totalPackagesQuantityField;
        set => totalPackagesQuantityField = value;
    }

    /// <remarks />
    [XmlElement("ConsolidatedShipment")]
    public ShipmentType[] ConsolidatedShipment
    {
        get => consolidatedShipmentField;
        set => consolidatedShipmentField = value;
    }

    /// <remarks />
    [XmlElement("CustomsDeclaration")]
    public CustomsDeclarationType[] CustomsDeclaration
    {
        get => customsDeclarationField;
        set => customsDeclarationField = value;
    }

    /// <remarks />
    public TransportEventType RequestedPickupTransportEvent
    {
        get => requestedPickupTransportEventField;
        set => requestedPickupTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType RequestedDeliveryTransportEvent
    {
        get => requestedDeliveryTransportEventField;
        set => requestedDeliveryTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType PlannedPickupTransportEvent
    {
        get => plannedPickupTransportEventField;
        set => plannedPickupTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType PlannedDeliveryTransportEvent
    {
        get => plannedDeliveryTransportEventField;
        set => plannedDeliveryTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("Status")]
    public StatusType[] Status
    {
        get => statusField;
        set => statusField = value;
    }

    /// <remarks />
    [XmlElement("ChildConsignment")]
    public ConsignmentType[] ChildConsignment
    {
        get => childConsignmentField;
        set => childConsignmentField = value;
    }

    /// <remarks />
    public PartyType ConsigneeParty
    {
        get => consigneePartyField;
        set => consigneePartyField = value;
    }

    /// <remarks />
    public PartyType ExporterParty
    {
        get => exporterPartyField;
        set => exporterPartyField = value;
    }

    /// <remarks />
    public PartyType ConsignorParty
    {
        get => consignorPartyField;
        set => consignorPartyField = value;
    }

    /// <remarks />
    public PartyType ImporterParty
    {
        get => importerPartyField;
        set => importerPartyField = value;
    }

    /// <remarks />
    public PartyType CarrierParty
    {
        get => carrierPartyField;
        set => carrierPartyField = value;
    }

    /// <remarks />
    public PartyType FreightForwarderParty
    {
        get => freightForwarderPartyField;
        set => freightForwarderPartyField = value;
    }

    /// <remarks />
    public PartyType NotifyParty
    {
        get => notifyPartyField;
        set => notifyPartyField = value;
    }

    /// <remarks />
    public PartyType OriginalDespatchParty
    {
        get => originalDespatchPartyField;
        set => originalDespatchPartyField = value;
    }

    /// <remarks />
    public PartyType FinalDeliveryParty
    {
        get => finalDeliveryPartyField;
        set => finalDeliveryPartyField = value;
    }

    /// <remarks />
    public PartyType PerformingCarrierParty
    {
        get => performingCarrierPartyField;
        set => performingCarrierPartyField = value;
    }

    /// <remarks />
    public PartyType SubstituteCarrierParty
    {
        get => substituteCarrierPartyField;
        set => substituteCarrierPartyField = value;
    }

    /// <remarks />
    public PartyType LogisticsOperatorParty
    {
        get => logisticsOperatorPartyField;
        set => logisticsOperatorPartyField = value;
    }

    /// <remarks />
    public PartyType TransportAdvisorParty
    {
        get => transportAdvisorPartyField;
        set => transportAdvisorPartyField = value;
    }

    /// <remarks />
    public PartyType HazardousItemNotificationParty
    {
        get => hazardousItemNotificationPartyField;
        set => hazardousItemNotificationPartyField = value;
    }

    /// <remarks />
    public PartyType InsuranceParty
    {
        get => insurancePartyField;
        set => insurancePartyField = value;
    }

    /// <remarks />
    public PartyType MortgageHolderParty
    {
        get => mortgageHolderPartyField;
        set => mortgageHolderPartyField = value;
    }

    /// <remarks />
    public PartyType BillOfLadingHolderParty
    {
        get => billOfLadingHolderPartyField;
        set => billOfLadingHolderPartyField = value;
    }

    /// <remarks />
    public CountryType OriginalDepartureCountry
    {
        get => originalDepartureCountryField;
        set => originalDepartureCountryField = value;
    }

    /// <remarks />
    public CountryType FinalDestinationCountry
    {
        get => finalDestinationCountryField;
        set => finalDestinationCountryField = value;
    }

    /// <remarks />
    [XmlElement("TransitCountry")]
    public CountryType[] TransitCountry
    {
        get => transitCountryField;
        set => transitCountryField = value;
    }

    /// <remarks />
    public ContractType TransportContract
    {
        get => transportContractField;
        set => transportContractField = value;
    }

    /// <remarks />
    [XmlElement("TransportEvent")]
    public TransportEventType[] TransportEvent
    {
        get => transportEventField;
        set => transportEventField = value;
    }

    /// <remarks />
    public TransportationServiceType OriginalDespatchTransportationService
    {
        get => originalDespatchTransportationServiceField;
        set => originalDespatchTransportationServiceField = value;
    }

    /// <remarks />
    public TransportationServiceType FinalDeliveryTransportationService
    {
        get => finalDeliveryTransportationServiceField;
        set => finalDeliveryTransportationServiceField = value;
    }

    /// <remarks />
    public DeliveryTermsType DeliveryTerms
    {
        get => deliveryTermsField;
        set => deliveryTermsField = value;
    }

    /// <remarks />
    public PaymentTermsType PaymentTerms
    {
        get => paymentTermsField;
        set => paymentTermsField = value;
    }

    /// <remarks />
    public PaymentTermsType CollectPaymentTerms
    {
        get => collectPaymentTermsField;
        set => collectPaymentTermsField = value;
    }

    /// <remarks />
    public PaymentTermsType DisbursementPaymentTerms
    {
        get => disbursementPaymentTermsField;
        set => disbursementPaymentTermsField = value;
    }

    /// <remarks />
    public PaymentTermsType PrepaidPaymentTerms
    {
        get => prepaidPaymentTermsField;
        set => prepaidPaymentTermsField = value;
    }

    /// <remarks />
    [XmlElement("FreightAllowanceCharge")]
    public AllowanceChargeType[] FreightAllowanceCharge
    {
        get => freightAllowanceChargeField;
        set => freightAllowanceChargeField = value;
    }

    /// <remarks />
    [XmlElement("ExtraAllowanceCharge")]
    public AllowanceChargeType[] ExtraAllowanceCharge
    {
        get => extraAllowanceChargeField;
        set => extraAllowanceChargeField = value;
    }

    /// <remarks />
    [XmlElement("MainCarriageShipmentStage")]
    public ShipmentStageType[] MainCarriageShipmentStage
    {
        get => mainCarriageShipmentStageField;
        set => mainCarriageShipmentStageField = value;
    }

    /// <remarks />
    [XmlElement("PreCarriageShipmentStage")]
    public ShipmentStageType[] PreCarriageShipmentStage
    {
        get => preCarriageShipmentStageField;
        set => preCarriageShipmentStageField = value;
    }

    /// <remarks />
    [XmlElement("OnCarriageShipmentStage")]
    public ShipmentStageType[] OnCarriageShipmentStage
    {
        get => onCarriageShipmentStageField;
        set => onCarriageShipmentStageField = value;
    }

    /// <remarks />
    [XmlElement("TransportHandlingUnit")]
    public TransportHandlingUnitType[] TransportHandlingUnit
    {
        get => transportHandlingUnitField;
        set => transportHandlingUnitField = value;
    }

    /// <remarks />
    public LocationType1 FirstArrivalPortLocation
    {
        get => firstArrivalPortLocationField;
        set => firstArrivalPortLocationField = value;
    }

    /// <remarks />
    public LocationType1 LastExitPortLocation
    {
        get => lastExitPortLocationField;
        set => lastExitPortLocationField = value;
    }
}