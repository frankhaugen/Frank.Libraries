namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
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
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CarrierAssignedIDType CarrierAssignedID
        {
            get
            {
                return carrierAssignedIDField;
            }
            set
            {
                carrierAssignedIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsigneeAssignedIDType ConsigneeAssignedID
        {
            get
            {
                return consigneeAssignedIDField;
            }
            set
            {
                consigneeAssignedIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsignorAssignedIDType ConsignorAssignedID
        {
            get
            {
                return consignorAssignedIDField;
            }
            set
            {
                consignorAssignedIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreightForwarderAssignedIDType FreightForwarderAssignedID
        {
            get
            {
                return freightForwarderAssignedIDField;
            }
            set
            {
                freightForwarderAssignedIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BrokerAssignedIDType BrokerAssignedID
        {
            get
            {
                return brokerAssignedIDField;
            }
            set
            {
                brokerAssignedIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractedCarrierAssignedIDType ContractedCarrierAssignedID
        {
            get
            {
                return contractedCarrierAssignedIDField;
            }
            set
            {
                contractedCarrierAssignedIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PerformingCarrierAssignedIDType PerformingCarrierAssignedID
        {
            get
            {
                return performingCarrierAssignedIDField;
            }
            set
            {
                performingCarrierAssignedIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SummaryDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SummaryDescriptionType[] SummaryDescription
        {
            get
            {
                return summaryDescriptionField;
            }
            set
            {
                summaryDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalInvoiceAmountType TotalInvoiceAmount
        {
            get
            {
                return totalInvoiceAmountField;
            }
            set
            {
                totalInvoiceAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
        {
            get
            {
                return declaredCustomsValueAmountField;
            }
            set
            {
                declaredCustomsValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TariffDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TariffDescriptionType[] TariffDescription
        {
            get
            {
                return tariffDescriptionField;
            }
            set
            {
                tariffDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TariffCodeType TariffCode
        {
            get
            {
                return tariffCodeField;
            }
            set
            {
                tariffCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InsurancePremiumAmountType InsurancePremiumAmount
        {
            get
            {
                return insurancePremiumAmountField;
            }
            set
            {
                insurancePremiumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossWeightMeasureType GrossWeightMeasure
        {
            get
            {
                return grossWeightMeasureField;
            }
            set
            {
                grossWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetWeightMeasureType NetWeightMeasure
        {
            get
            {
                return netWeightMeasureField;
            }
            set
            {
                netWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetNetWeightMeasureType NetNetWeightMeasure
        {
            get
            {
                return netNetWeightMeasureField;
            }
            set
            {
                netNetWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChargeableWeightMeasureType ChargeableWeightMeasure
        {
            get
            {
                return chargeableWeightMeasureField;
            }
            set
            {
                chargeableWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossVolumeMeasureType GrossVolumeMeasure
        {
            get
            {
                return grossVolumeMeasureField;
            }
            set
            {
                grossVolumeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetVolumeMeasureType NetVolumeMeasure
        {
            get
            {
                return netVolumeMeasureField;
            }
            set
            {
                netVolumeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LoadingLengthMeasureType LoadingLengthMeasure
        {
            get
            {
                return loadingLengthMeasureField;
            }
            set
            {
                loadingLengthMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks
        {
            get
            {
                return remarksField;
            }
            set
            {
                remarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return hazardousRiskIndicatorField;
            }
            set
            {
                hazardousRiskIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AnimalFoodIndicatorType AnimalFoodIndicator
        {
            get
            {
                return animalFoodIndicatorField;
            }
            set
            {
                animalFoodIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HumanFoodIndicatorType HumanFoodIndicator
        {
            get
            {
                return humanFoodIndicatorField;
            }
            set
            {
                humanFoodIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LivestockIndicatorType LivestockIndicator
        {
            get
            {
                return livestockIndicatorField;
            }
            set
            {
                livestockIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BulkCargoIndicatorType BulkCargoIndicator
        {
            get
            {
                return bulkCargoIndicatorField;
            }
            set
            {
                bulkCargoIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContainerizedIndicatorType ContainerizedIndicator
        {
            get
            {
                return containerizedIndicatorField;
            }
            set
            {
                containerizedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GeneralCargoIndicatorType GeneralCargoIndicator
        {
            get
            {
                return generalCargoIndicatorField;
            }
            set
            {
                generalCargoIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialSecurityIndicatorType SpecialSecurityIndicator
        {
            get
            {
                return specialSecurityIndicatorField;
            }
            set
            {
                specialSecurityIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ThirdPartyPayerIndicatorType ThirdPartyPayerIndicator
        {
            get
            {
                return thirdPartyPayerIndicatorField;
            }
            set
            {
                thirdPartyPayerIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarrierServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CarrierServiceInstructionsType[] CarrierServiceInstructions
        {
            get
            {
                return carrierServiceInstructionsField;
            }
            set
            {
                carrierServiceInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomsClearanceServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomsClearanceServiceInstructionsType[] CustomsClearanceServiceInstructions
        {
            get
            {
                return customsClearanceServiceInstructionsField;
            }
            set
            {
                customsClearanceServiceInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForwarderServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ForwarderServiceInstructionsType[] ForwarderServiceInstructions
        {
            get
            {
                return forwarderServiceInstructionsField;
            }
            set
            {
                forwarderServiceInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialServiceInstructionsType[] SpecialServiceInstructions
        {
            get
            {
                return specialServiceInstructionsField;
            }
            set
            {
                specialServiceInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceIDType SequenceID
        {
            get
            {
                return sequenceIDField;
            }
            set
            {
                sequenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShippingPriorityLevelCodeType ShippingPriorityLevelCode
        {
            get
            {
                return shippingPriorityLevelCodeField;
            }
            set
            {
                shippingPriorityLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingCodeType HandlingCode
        {
            get
            {
                return handlingCodeField;
            }
            set
            {
                handlingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingInstructionsType[] HandlingInstructions
        {
            get
            {
                return handlingInstructionsField;
            }
            set
            {
                handlingInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InformationType[] Information
        {
            get
            {
                return informationField;
            }
            set
            {
                informationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity
        {
            get
            {
                return totalGoodsItemQuantityField;
            }
            set
            {
                totalGoodsItemQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity
        {
            get
            {
                return totalTransportHandlingUnitQuantityField;
            }
            set
            {
                totalTransportHandlingUnitQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InsuranceValueAmountType InsuranceValueAmount
        {
            get
            {
                return insuranceValueAmountField;
            }
            set
            {
                insuranceValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
        {
            get
            {
                return declaredForCarriageValueAmountField;
            }
            set
            {
                declaredForCarriageValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
        {
            get
            {
                return declaredStatisticsValueAmountField;
            }
            set
            {
                declaredStatisticsValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreeOnBoardValueAmountType FreeOnBoardValueAmount
        {
            get
            {
                return freeOnBoardValueAmountField;
            }
            set
            {
                freeOnBoardValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialInstructionsType[] SpecialInstructions
        {
            get
            {
                return specialInstructionsField;
            }
            set
            {
                specialInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SplitConsignmentIndicatorType SplitConsignmentIndicator
        {
            get
            {
                return splitConsignmentIndicatorField;
            }
            set
            {
                splitConsignmentIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeliveryInstructionsType[] DeliveryInstructions
        {
            get
            {
                return deliveryInstructionsField;
            }
            set
            {
                deliveryInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsignmentQuantityType ConsignmentQuantity
        {
            get
            {
                return consignmentQuantityField;
            }
            set
            {
                consignmentQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsolidatableIndicatorType ConsolidatableIndicator
        {
            get
            {
                return consolidatableIndicatorField;
            }
            set
            {
                consolidatableIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HaulageInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HaulageInstructionsType[] HaulageInstructions
        {
            get
            {
                return haulageInstructionsField;
            }
            set
            {
                haulageInstructionsField = value;
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
        public ChildConsignmentQuantityType ChildConsignmentQuantity
        {
            get
            {
                return childConsignmentQuantityField;
            }
            set
            {
                childConsignmentQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalPackagesQuantityType TotalPackagesQuantity
        {
            get
            {
                return totalPackagesQuantityField;
            }
            set
            {
                totalPackagesQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsolidatedShipment")]
        public ShipmentType[] ConsolidatedShipment
        {
            get
            {
                return consolidatedShipmentField;
            }
            set
            {
                consolidatedShipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration")]
        public CustomsDeclarationType[] CustomsDeclaration
        {
            get
            {
                return customsDeclarationField;
            }
            set
            {
                customsDeclarationField = value;
            }
        }

        /// <remarks/>
        public TransportEventType RequestedPickupTransportEvent
        {
            get
            {
                return requestedPickupTransportEventField;
            }
            set
            {
                requestedPickupTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType RequestedDeliveryTransportEvent
        {
            get
            {
                return requestedDeliveryTransportEventField;
            }
            set
            {
                requestedDeliveryTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedPickupTransportEvent
        {
            get
            {
                return plannedPickupTransportEventField;
            }
            set
            {
                plannedPickupTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedDeliveryTransportEvent
        {
            get
            {
                return plannedDeliveryTransportEventField;
            }
            set
            {
                plannedDeliveryTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Status")]
        public StatusType[] Status
        {
            get
            {
                return statusField;
            }
            set
            {
                statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChildConsignment")]
        public ConsignmentType[] ChildConsignment
        {
            get
            {
                return childConsignmentField;
            }
            set
            {
                childConsignmentField = value;
            }
        }

        /// <remarks/>
        public PartyType ConsigneeParty
        {
            get
            {
                return consigneePartyField;
            }
            set
            {
                consigneePartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ExporterParty
        {
            get
            {
                return exporterPartyField;
            }
            set
            {
                exporterPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ConsignorParty
        {
            get
            {
                return consignorPartyField;
            }
            set
            {
                consignorPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ImporterParty
        {
            get
            {
                return importerPartyField;
            }
            set
            {
                importerPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType CarrierParty
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
        public PartyType FreightForwarderParty
        {
            get
            {
                return freightForwarderPartyField;
            }
            set
            {
                freightForwarderPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType NotifyParty
        {
            get
            {
                return notifyPartyField;
            }
            set
            {
                notifyPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType OriginalDespatchParty
        {
            get
            {
                return originalDespatchPartyField;
            }
            set
            {
                originalDespatchPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType FinalDeliveryParty
        {
            get
            {
                return finalDeliveryPartyField;
            }
            set
            {
                finalDeliveryPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType PerformingCarrierParty
        {
            get
            {
                return performingCarrierPartyField;
            }
            set
            {
                performingCarrierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType SubstituteCarrierParty
        {
            get
            {
                return substituteCarrierPartyField;
            }
            set
            {
                substituteCarrierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType LogisticsOperatorParty
        {
            get
            {
                return logisticsOperatorPartyField;
            }
            set
            {
                logisticsOperatorPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType TransportAdvisorParty
        {
            get
            {
                return transportAdvisorPartyField;
            }
            set
            {
                transportAdvisorPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType HazardousItemNotificationParty
        {
            get
            {
                return hazardousItemNotificationPartyField;
            }
            set
            {
                hazardousItemNotificationPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType InsuranceParty
        {
            get
            {
                return insurancePartyField;
            }
            set
            {
                insurancePartyField = value;
            }
        }

        /// <remarks/>
        public PartyType MortgageHolderParty
        {
            get
            {
                return mortgageHolderPartyField;
            }
            set
            {
                mortgageHolderPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType BillOfLadingHolderParty
        {
            get
            {
                return billOfLadingHolderPartyField;
            }
            set
            {
                billOfLadingHolderPartyField = value;
            }
        }

        /// <remarks/>
        public CountryType OriginalDepartureCountry
        {
            get
            {
                return originalDepartureCountryField;
            }
            set
            {
                originalDepartureCountryField = value;
            }
        }

        /// <remarks/>
        public CountryType FinalDestinationCountry
        {
            get
            {
                return finalDestinationCountryField;
            }
            set
            {
                finalDestinationCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransitCountry")]
        public CountryType[] TransitCountry
        {
            get
            {
                return transitCountryField;
            }
            set
            {
                transitCountryField = value;
            }
        }

        /// <remarks/>
        public ContractType TransportContract
        {
            get
            {
                return transportContractField;
            }
            set
            {
                transportContractField = value;
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
        public TransportationServiceType OriginalDespatchTransportationService
        {
            get
            {
                return originalDespatchTransportationServiceField;
            }
            set
            {
                originalDespatchTransportationServiceField = value;
            }
        }

        /// <remarks/>
        public TransportationServiceType FinalDeliveryTransportationService
        {
            get
            {
                return finalDeliveryTransportationServiceField;
            }
            set
            {
                finalDeliveryTransportationServiceField = value;
            }
        }

        /// <remarks/>
        public DeliveryTermsType DeliveryTerms
        {
            get
            {
                return deliveryTermsField;
            }
            set
            {
                deliveryTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType PaymentTerms
        {
            get
            {
                return paymentTermsField;
            }
            set
            {
                paymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType CollectPaymentTerms
        {
            get
            {
                return collectPaymentTermsField;
            }
            set
            {
                collectPaymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType DisbursementPaymentTerms
        {
            get
            {
                return disbursementPaymentTermsField;
            }
            set
            {
                disbursementPaymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType PrepaidPaymentTerms
        {
            get
            {
                return prepaidPaymentTermsField;
            }
            set
            {
                prepaidPaymentTermsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ExtraAllowanceCharge")]
        public AllowanceChargeType[] ExtraAllowanceCharge
        {
            get
            {
                return extraAllowanceChargeField;
            }
            set
            {
                extraAllowanceChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MainCarriageShipmentStage")]
        public ShipmentStageType[] MainCarriageShipmentStage
        {
            get
            {
                return mainCarriageShipmentStageField;
            }
            set
            {
                mainCarriageShipmentStageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PreCarriageShipmentStage")]
        public ShipmentStageType[] PreCarriageShipmentStage
        {
            get
            {
                return preCarriageShipmentStageField;
            }
            set
            {
                preCarriageShipmentStageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OnCarriageShipmentStage")]
        public ShipmentStageType[] OnCarriageShipmentStage
        {
            get
            {
                return onCarriageShipmentStageField;
            }
            set
            {
                onCarriageShipmentStageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit")]
        public TransportHandlingUnitType[] TransportHandlingUnit
        {
            get
            {
                return transportHandlingUnitField;
            }
            set
            {
                transportHandlingUnitField = value;
            }
        }

        /// <remarks/>
        public LocationType1 FirstArrivalPortLocation
        {
            get
            {
                return firstArrivalPortLocationField;
            }
            set
            {
                firstArrivalPortLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 LastExitPortLocation
        {
            get
            {
                return lastExitPortLocationField;
            }
            set
            {
                lastExitPortLocationField = value;
            }
        }
    }
}