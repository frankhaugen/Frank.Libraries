namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ChildConsignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ConsignmentType
{

    private IDType idField;

    private CarrierAssignedIDType carrierAssignedIDField;

    private ConsigneeAssignedIDType consigneeAssignedIDField;

    private ConsignorAssignedIDType consignorAssignedIDField;

    private FreightForwarderAssignedIDType freightForwarderAssignedIDField;

    private BrokerAssignedIDType brokerAssignedIDField;

    private ContractedCarrierAssignedIDType contractedCarrierAssignedIDField;

    private PerformingCarrierAssignedIDType performingCarrierAssignedIDField;

    private SummaryDescriptionType[] summaryDescriptionField;

    private TotalInvoiceAmountType totalInvoiceAmountField;

    private DeclaredCustomsValueAmountType declaredCustomsValueAmountField;

    private TariffDescriptionType[] tariffDescriptionField;

    private TariffCodeType tariffCodeField;

    private InsurancePremiumAmountType insurancePremiumAmountField;

    private GrossWeightMeasureType grossWeightMeasureField;

    private NetWeightMeasureType netWeightMeasureField;

    private NetNetWeightMeasureType netNetWeightMeasureField;

    private ChargeableWeightMeasureType chargeableWeightMeasureField;

    private GrossVolumeMeasureType grossVolumeMeasureField;

    private NetVolumeMeasureType netVolumeMeasureField;

    private LoadingLengthMeasureType loadingLengthMeasureField;

    private RemarksType[] remarksField;

    private HazardousRiskIndicatorType hazardousRiskIndicatorField;

    private AnimalFoodIndicatorType animalFoodIndicatorField;

    private HumanFoodIndicatorType humanFoodIndicatorField;

    private LivestockIndicatorType livestockIndicatorField;

    private BulkCargoIndicatorType bulkCargoIndicatorField;

    private ContainerizedIndicatorType containerizedIndicatorField;

    private GeneralCargoIndicatorType generalCargoIndicatorField;

    private SpecialSecurityIndicatorType specialSecurityIndicatorField;

    private ThirdPartyPayerIndicatorType thirdPartyPayerIndicatorField;

    private CarrierServiceInstructionsType[] carrierServiceInstructionsField;

    private CustomsClearanceServiceInstructionsType[] customsClearanceServiceInstructionsField;

    private ForwarderServiceInstructionsType[] forwarderServiceInstructionsField;

    private SpecialServiceInstructionsType[] specialServiceInstructionsField;

    private SequenceIDType sequenceIDField;

    private ShippingPriorityLevelCodeType shippingPriorityLevelCodeField;

    private HandlingCodeType handlingCodeField;

    private HandlingInstructionsType[] handlingInstructionsField;

    private InformationType[] informationField;

    private TotalGoodsItemQuantityType totalGoodsItemQuantityField;

    private TotalTransportHandlingUnitQuantityType totalTransportHandlingUnitQuantityField;

    private InsuranceValueAmountType insuranceValueAmountField;

    private DeclaredForCarriageValueAmountType declaredForCarriageValueAmountField;

    private DeclaredStatisticsValueAmountType declaredStatisticsValueAmountField;

    private FreeOnBoardValueAmountType freeOnBoardValueAmountField;

    private SpecialInstructionsType[] specialInstructionsField;

    private SplitConsignmentIndicatorType splitConsignmentIndicatorField;

    private DeliveryInstructionsType[] deliveryInstructionsField;

    private ConsignmentQuantityType consignmentQuantityField;

    private ConsolidatableIndicatorType consolidatableIndicatorField;

    private HaulageInstructionsType[] haulageInstructionsField;

    private LoadingSequenceIDType loadingSequenceIDField;

    private ChildConsignmentQuantityType childConsignmentQuantityField;

    private TotalPackagesQuantityType totalPackagesQuantityField;

    private ShipmentType[] consolidatedShipmentField;

    private CustomsDeclarationType[] customsDeclarationField;

    private TransportEventType requestedPickupTransportEventField;

    private TransportEventType requestedDeliveryTransportEventField;

    private TransportEventType plannedPickupTransportEventField;

    private TransportEventType plannedDeliveryTransportEventField;

    private StatusType[] statusField;

    private ConsignmentType[] childConsignmentField;

    private PartyType consigneePartyField;

    private PartyType exporterPartyField;

    private PartyType consignorPartyField;

    private PartyType importerPartyField;

    private PartyType carrierPartyField;

    private PartyType freightForwarderPartyField;

    private PartyType notifyPartyField;

    private PartyType originalDespatchPartyField;

    private PartyType finalDeliveryPartyField;

    private PartyType performingCarrierPartyField;

    private PartyType substituteCarrierPartyField;

    private PartyType logisticsOperatorPartyField;

    private PartyType transportAdvisorPartyField;

    private PartyType hazardousItemNotificationPartyField;

    private PartyType insurancePartyField;

    private PartyType mortgageHolderPartyField;

    private PartyType billOfLadingHolderPartyField;

    private CountryType originalDepartureCountryField;

    private CountryType finalDestinationCountryField;

    private CountryType[] transitCountryField;

    private ContractType transportContractField;

    private TransportEventType[] transportEventField;

    private TransportationServiceType originalDespatchTransportationServiceField;

    private TransportationServiceType finalDeliveryTransportationServiceField;

    private DeliveryTermsType deliveryTermsField;

    private PaymentTermsType paymentTermsField;

    private PaymentTermsType collectPaymentTermsField;

    private PaymentTermsType disbursementPaymentTermsField;

    private PaymentTermsType prepaidPaymentTermsField;

    private AllowanceChargeType[] freightAllowanceChargeField;

    private AllowanceChargeType[] extraAllowanceChargeField;

    private ShipmentStageType[] mainCarriageShipmentStageField;

    private ShipmentStageType[] preCarriageShipmentStageField;

    private ShipmentStageType[] onCarriageShipmentStageField;

    private TransportHandlingUnitType[] transportHandlingUnitField;

    private LocationType1 firstArrivalPortLocationField;

    private LocationType1 lastExitPortLocationField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CarrierAssignedIDType CarrierAssignedID
    {
        get
        {
            return this.carrierAssignedIDField;
        }
        set
        {
            this.carrierAssignedIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsigneeAssignedIDType ConsigneeAssignedID
    {
        get
        {
            return this.consigneeAssignedIDField;
        }
        set
        {
            this.consigneeAssignedIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsignorAssignedIDType ConsignorAssignedID
    {
        get
        {
            return this.consignorAssignedIDField;
        }
        set
        {
            this.consignorAssignedIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FreightForwarderAssignedIDType FreightForwarderAssignedID
    {
        get
        {
            return this.freightForwarderAssignedIDField;
        }
        set
        {
            this.freightForwarderAssignedIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BrokerAssignedIDType BrokerAssignedID
    {
        get
        {
            return this.brokerAssignedIDField;
        }
        set
        {
            this.brokerAssignedIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractedCarrierAssignedIDType ContractedCarrierAssignedID
    {
        get
        {
            return this.contractedCarrierAssignedIDField;
        }
        set
        {
            this.contractedCarrierAssignedIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerformingCarrierAssignedIDType PerformingCarrierAssignedID
    {
        get
        {
            return this.performingCarrierAssignedIDField;
        }
        set
        {
            this.performingCarrierAssignedIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SummaryDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SummaryDescriptionType[] SummaryDescription
    {
        get
        {
            return this.summaryDescriptionField;
        }
        set
        {
            this.summaryDescriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalInvoiceAmountType TotalInvoiceAmount
    {
        get
        {
            return this.totalInvoiceAmountField;
        }
        set
        {
            this.totalInvoiceAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
    {
        get
        {
            return this.declaredCustomsValueAmountField;
        }
        set
        {
            this.declaredCustomsValueAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TariffDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TariffDescriptionType[] TariffDescription
    {
        get
        {
            return this.tariffDescriptionField;
        }
        set
        {
            this.tariffDescriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TariffCodeType TariffCode
    {
        get
        {
            return this.tariffCodeField;
        }
        set
        {
            this.tariffCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InsurancePremiumAmountType InsurancePremiumAmount
    {
        get
        {
            return this.insurancePremiumAmountField;
        }
        set
        {
            this.insurancePremiumAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GrossWeightMeasureType GrossWeightMeasure
    {
        get
        {
            return this.grossWeightMeasureField;
        }
        set
        {
            this.grossWeightMeasureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetWeightMeasureType NetWeightMeasure
    {
        get
        {
            return this.netWeightMeasureField;
        }
        set
        {
            this.netWeightMeasureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetNetWeightMeasureType NetNetWeightMeasure
    {
        get
        {
            return this.netNetWeightMeasureField;
        }
        set
        {
            this.netNetWeightMeasureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChargeableWeightMeasureType ChargeableWeightMeasure
    {
        get
        {
            return this.chargeableWeightMeasureField;
        }
        set
        {
            this.chargeableWeightMeasureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GrossVolumeMeasureType GrossVolumeMeasure
    {
        get
        {
            return this.grossVolumeMeasureField;
        }
        set
        {
            this.grossVolumeMeasureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetVolumeMeasureType NetVolumeMeasure
    {
        get
        {
            return this.netVolumeMeasureField;
        }
        set
        {
            this.netVolumeMeasureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LoadingLengthMeasureType LoadingLengthMeasure
    {
        get
        {
            return this.loadingLengthMeasureField;
        }
        set
        {
            this.loadingLengthMeasureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RemarksType[] Remarks
    {
        get
        {
            return this.remarksField;
        }
        set
        {
            this.remarksField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousRiskIndicatorType HazardousRiskIndicator
    {
        get
        {
            return this.hazardousRiskIndicatorField;
        }
        set
        {
            this.hazardousRiskIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AnimalFoodIndicatorType AnimalFoodIndicator
    {
        get
        {
            return this.animalFoodIndicatorField;
        }
        set
        {
            this.animalFoodIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HumanFoodIndicatorType HumanFoodIndicator
    {
        get
        {
            return this.humanFoodIndicatorField;
        }
        set
        {
            this.humanFoodIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LivestockIndicatorType LivestockIndicator
    {
        get
        {
            return this.livestockIndicatorField;
        }
        set
        {
            this.livestockIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BulkCargoIndicatorType BulkCargoIndicator
    {
        get
        {
            return this.bulkCargoIndicatorField;
        }
        set
        {
            this.bulkCargoIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContainerizedIndicatorType ContainerizedIndicator
    {
        get
        {
            return this.containerizedIndicatorField;
        }
        set
        {
            this.containerizedIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GeneralCargoIndicatorType GeneralCargoIndicator
    {
        get
        {
            return this.generalCargoIndicatorField;
        }
        set
        {
            this.generalCargoIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialSecurityIndicatorType SpecialSecurityIndicator
    {
        get
        {
            return this.specialSecurityIndicatorField;
        }
        set
        {
            this.specialSecurityIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ThirdPartyPayerIndicatorType ThirdPartyPayerIndicator
    {
        get
        {
            return this.thirdPartyPayerIndicatorField;
        }
        set
        {
            this.thirdPartyPayerIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CarrierServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CarrierServiceInstructionsType[] CarrierServiceInstructions
    {
        get
        {
            return this.carrierServiceInstructionsField;
        }
        set
        {
            this.carrierServiceInstructionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CustomsClearanceServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomsClearanceServiceInstructionsType[] CustomsClearanceServiceInstructions
    {
        get
        {
            return this.customsClearanceServiceInstructionsField;
        }
        set
        {
            this.customsClearanceServiceInstructionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ForwarderServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ForwarderServiceInstructionsType[] ForwarderServiceInstructions
    {
        get
        {
            return this.forwarderServiceInstructionsField;
        }
        set
        {
            this.forwarderServiceInstructionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SpecialServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialServiceInstructionsType[] SpecialServiceInstructions
    {
        get
        {
            return this.specialServiceInstructionsField;
        }
        set
        {
            this.specialServiceInstructionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceIDType SequenceID
    {
        get
        {
            return this.sequenceIDField;
        }
        set
        {
            this.sequenceIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShippingPriorityLevelCodeType ShippingPriorityLevelCode
    {
        get
        {
            return this.shippingPriorityLevelCodeField;
        }
        set
        {
            this.shippingPriorityLevelCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingCodeType HandlingCode
    {
        get
        {
            return this.handlingCodeField;
        }
        set
        {
            this.handlingCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingInstructionsType[] HandlingInstructions
    {
        get
        {
            return this.handlingInstructionsField;
        }
        set
        {
            this.handlingInstructionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InformationType[] Information
    {
        get
        {
            return this.informationField;
        }
        set
        {
            this.informationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalGoodsItemQuantityType TotalGoodsItemQuantity
    {
        get
        {
            return this.totalGoodsItemQuantityField;
        }
        set
        {
            this.totalGoodsItemQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity
    {
        get
        {
            return this.totalTransportHandlingUnitQuantityField;
        }
        set
        {
            this.totalTransportHandlingUnitQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InsuranceValueAmountType InsuranceValueAmount
    {
        get
        {
            return this.insuranceValueAmountField;
        }
        set
        {
            this.insuranceValueAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
    {
        get
        {
            return this.declaredForCarriageValueAmountField;
        }
        set
        {
            this.declaredForCarriageValueAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
    {
        get
        {
            return this.declaredStatisticsValueAmountField;
        }
        set
        {
            this.declaredStatisticsValueAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FreeOnBoardValueAmountType FreeOnBoardValueAmount
    {
        get
        {
            return this.freeOnBoardValueAmountField;
        }
        set
        {
            this.freeOnBoardValueAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialInstructionsType[] SpecialInstructions
    {
        get
        {
            return this.specialInstructionsField;
        }
        set
        {
            this.specialInstructionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SplitConsignmentIndicatorType SplitConsignmentIndicator
    {
        get
        {
            return this.splitConsignmentIndicatorField;
        }
        set
        {
            this.splitConsignmentIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeliveryInstructionsType[] DeliveryInstructions
    {
        get
        {
            return this.deliveryInstructionsField;
        }
        set
        {
            this.deliveryInstructionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsignmentQuantityType ConsignmentQuantity
    {
        get
        {
            return this.consignmentQuantityField;
        }
        set
        {
            this.consignmentQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsolidatableIndicatorType ConsolidatableIndicator
    {
        get
        {
            return this.consolidatableIndicatorField;
        }
        set
        {
            this.consolidatableIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HaulageInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HaulageInstructionsType[] HaulageInstructions
    {
        get
        {
            return this.haulageInstructionsField;
        }
        set
        {
            this.haulageInstructionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LoadingSequenceIDType LoadingSequenceID
    {
        get
        {
            return this.loadingSequenceIDField;
        }
        set
        {
            this.loadingSequenceIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChildConsignmentQuantityType ChildConsignmentQuantity
    {
        get
        {
            return this.childConsignmentQuantityField;
        }
        set
        {
            this.childConsignmentQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalPackagesQuantityType TotalPackagesQuantity
    {
        get
        {
            return this.totalPackagesQuantityField;
        }
        set
        {
            this.totalPackagesQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ConsolidatedShipment")]
    public ShipmentType[] ConsolidatedShipment
    {
        get
        {
            return this.consolidatedShipmentField;
        }
        set
        {
            this.consolidatedShipmentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration")]
    public CustomsDeclarationType[] CustomsDeclaration
    {
        get
        {
            return this.customsDeclarationField;
        }
        set
        {
            this.customsDeclarationField = value;
        }
    }

    /// <remarks/>
    public TransportEventType RequestedPickupTransportEvent
    {
        get
        {
            return this.requestedPickupTransportEventField;
        }
        set
        {
            this.requestedPickupTransportEventField = value;
        }
    }

    /// <remarks/>
    public TransportEventType RequestedDeliveryTransportEvent
    {
        get
        {
            return this.requestedDeliveryTransportEventField;
        }
        set
        {
            this.requestedDeliveryTransportEventField = value;
        }
    }

    /// <remarks/>
    public TransportEventType PlannedPickupTransportEvent
    {
        get
        {
            return this.plannedPickupTransportEventField;
        }
        set
        {
            this.plannedPickupTransportEventField = value;
        }
    }

    /// <remarks/>
    public TransportEventType PlannedDeliveryTransportEvent
    {
        get
        {
            return this.plannedDeliveryTransportEventField;
        }
        set
        {
            this.plannedDeliveryTransportEventField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Status")]
    public StatusType[] Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ChildConsignment")]
    public ConsignmentType[] ChildConsignment
    {
        get
        {
            return this.childConsignmentField;
        }
        set
        {
            this.childConsignmentField = value;
        }
    }

    /// <remarks/>
    public PartyType ConsigneeParty
    {
        get
        {
            return this.consigneePartyField;
        }
        set
        {
            this.consigneePartyField = value;
        }
    }

    /// <remarks/>
    public PartyType ExporterParty
    {
        get
        {
            return this.exporterPartyField;
        }
        set
        {
            this.exporterPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType ConsignorParty
    {
        get
        {
            return this.consignorPartyField;
        }
        set
        {
            this.consignorPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType ImporterParty
    {
        get
        {
            return this.importerPartyField;
        }
        set
        {
            this.importerPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType CarrierParty
    {
        get
        {
            return this.carrierPartyField;
        }
        set
        {
            this.carrierPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType FreightForwarderParty
    {
        get
        {
            return this.freightForwarderPartyField;
        }
        set
        {
            this.freightForwarderPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType NotifyParty
    {
        get
        {
            return this.notifyPartyField;
        }
        set
        {
            this.notifyPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType OriginalDespatchParty
    {
        get
        {
            return this.originalDespatchPartyField;
        }
        set
        {
            this.originalDespatchPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType FinalDeliveryParty
    {
        get
        {
            return this.finalDeliveryPartyField;
        }
        set
        {
            this.finalDeliveryPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType PerformingCarrierParty
    {
        get
        {
            return this.performingCarrierPartyField;
        }
        set
        {
            this.performingCarrierPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType SubstituteCarrierParty
    {
        get
        {
            return this.substituteCarrierPartyField;
        }
        set
        {
            this.substituteCarrierPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType LogisticsOperatorParty
    {
        get
        {
            return this.logisticsOperatorPartyField;
        }
        set
        {
            this.logisticsOperatorPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType TransportAdvisorParty
    {
        get
        {
            return this.transportAdvisorPartyField;
        }
        set
        {
            this.transportAdvisorPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType HazardousItemNotificationParty
    {
        get
        {
            return this.hazardousItemNotificationPartyField;
        }
        set
        {
            this.hazardousItemNotificationPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType InsuranceParty
    {
        get
        {
            return this.insurancePartyField;
        }
        set
        {
            this.insurancePartyField = value;
        }
    }

    /// <remarks/>
    public PartyType MortgageHolderParty
    {
        get
        {
            return this.mortgageHolderPartyField;
        }
        set
        {
            this.mortgageHolderPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType BillOfLadingHolderParty
    {
        get
        {
            return this.billOfLadingHolderPartyField;
        }
        set
        {
            this.billOfLadingHolderPartyField = value;
        }
    }

    /// <remarks/>
    public CountryType OriginalDepartureCountry
    {
        get
        {
            return this.originalDepartureCountryField;
        }
        set
        {
            this.originalDepartureCountryField = value;
        }
    }

    /// <remarks/>
    public CountryType FinalDestinationCountry
    {
        get
        {
            return this.finalDestinationCountryField;
        }
        set
        {
            this.finalDestinationCountryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransitCountry")]
    public CountryType[] TransitCountry
    {
        get
        {
            return this.transitCountryField;
        }
        set
        {
            this.transitCountryField = value;
        }
    }

    /// <remarks/>
    public ContractType TransportContract
    {
        get
        {
            return this.transportContractField;
        }
        set
        {
            this.transportContractField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
    public TransportEventType[] TransportEvent
    {
        get
        {
            return this.transportEventField;
        }
        set
        {
            this.transportEventField = value;
        }
    }

    /// <remarks/>
    public TransportationServiceType OriginalDespatchTransportationService
    {
        get
        {
            return this.originalDespatchTransportationServiceField;
        }
        set
        {
            this.originalDespatchTransportationServiceField = value;
        }
    }

    /// <remarks/>
    public TransportationServiceType FinalDeliveryTransportationService
    {
        get
        {
            return this.finalDeliveryTransportationServiceField;
        }
        set
        {
            this.finalDeliveryTransportationServiceField = value;
        }
    }

    /// <remarks/>
    public DeliveryTermsType DeliveryTerms
    {
        get
        {
            return this.deliveryTermsField;
        }
        set
        {
            this.deliveryTermsField = value;
        }
    }

    /// <remarks/>
    public PaymentTermsType PaymentTerms
    {
        get
        {
            return this.paymentTermsField;
        }
        set
        {
            this.paymentTermsField = value;
        }
    }

    /// <remarks/>
    public PaymentTermsType CollectPaymentTerms
    {
        get
        {
            return this.collectPaymentTermsField;
        }
        set
        {
            this.collectPaymentTermsField = value;
        }
    }

    /// <remarks/>
    public PaymentTermsType DisbursementPaymentTerms
    {
        get
        {
            return this.disbursementPaymentTermsField;
        }
        set
        {
            this.disbursementPaymentTermsField = value;
        }
    }

    /// <remarks/>
    public PaymentTermsType PrepaidPaymentTerms
    {
        get
        {
            return this.prepaidPaymentTermsField;
        }
        set
        {
            this.prepaidPaymentTermsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
    public AllowanceChargeType[] FreightAllowanceCharge
    {
        get
        {
            return this.freightAllowanceChargeField;
        }
        set
        {
            this.freightAllowanceChargeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ExtraAllowanceCharge")]
    public AllowanceChargeType[] ExtraAllowanceCharge
    {
        get
        {
            return this.extraAllowanceChargeField;
        }
        set
        {
            this.extraAllowanceChargeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MainCarriageShipmentStage")]
    public ShipmentStageType[] MainCarriageShipmentStage
    {
        get
        {
            return this.mainCarriageShipmentStageField;
        }
        set
        {
            this.mainCarriageShipmentStageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PreCarriageShipmentStage")]
    public ShipmentStageType[] PreCarriageShipmentStage
    {
        get
        {
            return this.preCarriageShipmentStageField;
        }
        set
        {
            this.preCarriageShipmentStageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OnCarriageShipmentStage")]
    public ShipmentStageType[] OnCarriageShipmentStage
    {
        get
        {
            return this.onCarriageShipmentStageField;
        }
        set
        {
            this.onCarriageShipmentStageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit")]
    public TransportHandlingUnitType[] TransportHandlingUnit
    {
        get
        {
            return this.transportHandlingUnitField;
        }
        set
        {
            this.transportHandlingUnitField = value;
        }
    }

    /// <remarks/>
    public LocationType1 FirstArrivalPortLocation
    {
        get
        {
            return this.firstArrivalPortLocationField;
        }
        set
        {
            this.firstArrivalPortLocationField = value;
        }
    }

    /// <remarks/>
    public LocationType1 LastExitPortLocation
    {
        get
        {
            return this.lastExitPortLocationField;
        }
        set
        {
            this.lastExitPortLocationField = value;
        }
    }
}