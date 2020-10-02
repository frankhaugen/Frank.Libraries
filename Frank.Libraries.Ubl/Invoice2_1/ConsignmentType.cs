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

        private IdType _idField;

        private CarrierAssignedIdType _carrierAssignedIdField;

        private ConsigneeAssignedIdType _consigneeAssignedIdField;

        private ConsignorAssignedIdType _consignorAssignedIdField;

        private FreightForwarderAssignedIdType _freightForwarderAssignedIdField;

        private BrokerAssignedIdType _brokerAssignedIdField;

        private ContractedCarrierAssignedIdType _contractedCarrierAssignedIdField;

        private PerformingCarrierAssignedIdType _performingCarrierAssignedIdField;

        private SummaryDescriptionType[] _summaryDescriptionField;

        private TotalInvoiceAmountType _totalInvoiceAmountField;

        private DeclaredCustomsValueAmountType _declaredCustomsValueAmountField;

        private TariffDescriptionType[] _tariffDescriptionField;

        private TariffCodeType _tariffCodeField;

        private InsurancePremiumAmountType _insurancePremiumAmountField;

        private GrossWeightMeasureType _grossWeightMeasureField;

        private NetWeightMeasureType _netWeightMeasureField;

        private NetNetWeightMeasureType _netNetWeightMeasureField;

        private ChargeableWeightMeasureType _chargeableWeightMeasureField;

        private GrossVolumeMeasureType _grossVolumeMeasureField;

        private NetVolumeMeasureType _netVolumeMeasureField;

        private LoadingLengthMeasureType _loadingLengthMeasureField;

        private RemarksType[] _remarksField;

        private HazardousRiskIndicatorType _hazardousRiskIndicatorField;

        private AnimalFoodIndicatorType _animalFoodIndicatorField;

        private HumanFoodIndicatorType _humanFoodIndicatorField;

        private LivestockIndicatorType _livestockIndicatorField;

        private BulkCargoIndicatorType _bulkCargoIndicatorField;

        private ContainerizedIndicatorType _containerizedIndicatorField;

        private GeneralCargoIndicatorType _generalCargoIndicatorField;

        private SpecialSecurityIndicatorType _specialSecurityIndicatorField;

        private ThirdPartyPayerIndicatorType _thirdPartyPayerIndicatorField;

        private CarrierServiceInstructionsType[] _carrierServiceInstructionsField;

        private CustomsClearanceServiceInstructionsType[] _customsClearanceServiceInstructionsField;

        private ForwarderServiceInstructionsType[] _forwarderServiceInstructionsField;

        private SpecialServiceInstructionsType[] _specialServiceInstructionsField;

        private SequenceIdType _sequenceIdField;

        private ShippingPriorityLevelCodeType _shippingPriorityLevelCodeField;

        private HandlingCodeType _handlingCodeField;

        private HandlingInstructionsType[] _handlingInstructionsField;

        private InformationType[] _informationField;

        private TotalGoodsItemQuantityType _totalGoodsItemQuantityField;

        private TotalTransportHandlingUnitQuantityType _totalTransportHandlingUnitQuantityField;

        private InsuranceValueAmountType _insuranceValueAmountField;

        private DeclaredForCarriageValueAmountType _declaredForCarriageValueAmountField;

        private DeclaredStatisticsValueAmountType _declaredStatisticsValueAmountField;

        private FreeOnBoardValueAmountType _freeOnBoardValueAmountField;

        private SpecialInstructionsType[] _specialInstructionsField;

        private SplitConsignmentIndicatorType _splitConsignmentIndicatorField;

        private DeliveryInstructionsType[] _deliveryInstructionsField;

        private ConsignmentQuantityType _consignmentQuantityField;

        private ConsolidatableIndicatorType _consolidatableIndicatorField;

        private HaulageInstructionsType[] _haulageInstructionsField;

        private LoadingSequenceIdType _loadingSequenceIdField;

        private ChildConsignmentQuantityType _childConsignmentQuantityField;

        private TotalPackagesQuantityType _totalPackagesQuantityField;

        private ShipmentType[] _consolidatedShipmentField;

        private CustomsDeclarationType[] _customsDeclarationField;

        private TransportEventType _requestedPickupTransportEventField;

        private TransportEventType _requestedDeliveryTransportEventField;

        private TransportEventType _plannedPickupTransportEventField;

        private TransportEventType _plannedDeliveryTransportEventField;

        private StatusType[] _statusField;

        private ConsignmentType[] _childConsignmentField;

        private PartyType _consigneePartyField;

        private PartyType _exporterPartyField;

        private PartyType _consignorPartyField;

        private PartyType _importerPartyField;

        private PartyType _carrierPartyField;

        private PartyType _freightForwarderPartyField;

        private PartyType _notifyPartyField;

        private PartyType _originalDespatchPartyField;

        private PartyType _finalDeliveryPartyField;

        private PartyType _performingCarrierPartyField;

        private PartyType _substituteCarrierPartyField;

        private PartyType _logisticsOperatorPartyField;

        private PartyType _transportAdvisorPartyField;

        private PartyType _hazardousItemNotificationPartyField;

        private PartyType _insurancePartyField;

        private PartyType _mortgageHolderPartyField;

        private PartyType _billOfLadingHolderPartyField;

        private CountryType _originalDepartureCountryField;

        private CountryType _finalDestinationCountryField;

        private CountryType[] _transitCountryField;

        private ContractType _transportContractField;

        private TransportEventType[] _transportEventField;

        private TransportationServiceType _originalDespatchTransportationServiceField;

        private TransportationServiceType _finalDeliveryTransportationServiceField;

        private DeliveryTermsType _deliveryTermsField;

        private PaymentTermsType _paymentTermsField;

        private PaymentTermsType _collectPaymentTermsField;

        private PaymentTermsType _disbursementPaymentTermsField;

        private PaymentTermsType _prepaidPaymentTermsField;

        private AllowanceChargeType[] _freightAllowanceChargeField;

        private AllowanceChargeType[] _extraAllowanceChargeField;

        private ShipmentStageType[] _mainCarriageShipmentStageField;

        private ShipmentStageType[] _preCarriageShipmentStageField;

        private ShipmentStageType[] _onCarriageShipmentStageField;

        private TransportHandlingUnitType[] _transportHandlingUnitField;

        private LocationType1 _firstArrivalPortLocationField;

        private LocationType1 _lastExitPortLocationField;

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
        public CarrierAssignedIdType CarrierAssignedId
        {
            get
            {
                return _carrierAssignedIdField;
            }
            set
            {
                _carrierAssignedIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsigneeAssignedIdType ConsigneeAssignedId
        {
            get
            {
                return _consigneeAssignedIdField;
            }
            set
            {
                _consigneeAssignedIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsignorAssignedIdType ConsignorAssignedId
        {
            get
            {
                return _consignorAssignedIdField;
            }
            set
            {
                _consignorAssignedIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreightForwarderAssignedIdType FreightForwarderAssignedId
        {
            get
            {
                return _freightForwarderAssignedIdField;
            }
            set
            {
                _freightForwarderAssignedIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BrokerAssignedIdType BrokerAssignedId
        {
            get
            {
                return _brokerAssignedIdField;
            }
            set
            {
                _brokerAssignedIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractedCarrierAssignedIdType ContractedCarrierAssignedId
        {
            get
            {
                return _contractedCarrierAssignedIdField;
            }
            set
            {
                _contractedCarrierAssignedIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PerformingCarrierAssignedIdType PerformingCarrierAssignedId
        {
            get
            {
                return _performingCarrierAssignedIdField;
            }
            set
            {
                _performingCarrierAssignedIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SummaryDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SummaryDescriptionType[] SummaryDescription
        {
            get
            {
                return _summaryDescriptionField;
            }
            set
            {
                _summaryDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalInvoiceAmountType TotalInvoiceAmount
        {
            get
            {
                return _totalInvoiceAmountField;
            }
            set
            {
                _totalInvoiceAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
        {
            get
            {
                return _declaredCustomsValueAmountField;
            }
            set
            {
                _declaredCustomsValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TariffDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TariffDescriptionType[] TariffDescription
        {
            get
            {
                return _tariffDescriptionField;
            }
            set
            {
                _tariffDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TariffCodeType TariffCode
        {
            get
            {
                return _tariffCodeField;
            }
            set
            {
                _tariffCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InsurancePremiumAmountType InsurancePremiumAmount
        {
            get
            {
                return _insurancePremiumAmountField;
            }
            set
            {
                _insurancePremiumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossWeightMeasureType GrossWeightMeasure
        {
            get
            {
                return _grossWeightMeasureField;
            }
            set
            {
                _grossWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetWeightMeasureType NetWeightMeasure
        {
            get
            {
                return _netWeightMeasureField;
            }
            set
            {
                _netWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetNetWeightMeasureType NetNetWeightMeasure
        {
            get
            {
                return _netNetWeightMeasureField;
            }
            set
            {
                _netNetWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChargeableWeightMeasureType ChargeableWeightMeasure
        {
            get
            {
                return _chargeableWeightMeasureField;
            }
            set
            {
                _chargeableWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossVolumeMeasureType GrossVolumeMeasure
        {
            get
            {
                return _grossVolumeMeasureField;
            }
            set
            {
                _grossVolumeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetVolumeMeasureType NetVolumeMeasure
        {
            get
            {
                return _netVolumeMeasureField;
            }
            set
            {
                _netVolumeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LoadingLengthMeasureType LoadingLengthMeasure
        {
            get
            {
                return _loadingLengthMeasureField;
            }
            set
            {
                _loadingLengthMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks
        {
            get
            {
                return _remarksField;
            }
            set
            {
                _remarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return _hazardousRiskIndicatorField;
            }
            set
            {
                _hazardousRiskIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AnimalFoodIndicatorType AnimalFoodIndicator
        {
            get
            {
                return _animalFoodIndicatorField;
            }
            set
            {
                _animalFoodIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HumanFoodIndicatorType HumanFoodIndicator
        {
            get
            {
                return _humanFoodIndicatorField;
            }
            set
            {
                _humanFoodIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LivestockIndicatorType LivestockIndicator
        {
            get
            {
                return _livestockIndicatorField;
            }
            set
            {
                _livestockIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BulkCargoIndicatorType BulkCargoIndicator
        {
            get
            {
                return _bulkCargoIndicatorField;
            }
            set
            {
                _bulkCargoIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContainerizedIndicatorType ContainerizedIndicator
        {
            get
            {
                return _containerizedIndicatorField;
            }
            set
            {
                _containerizedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GeneralCargoIndicatorType GeneralCargoIndicator
        {
            get
            {
                return _generalCargoIndicatorField;
            }
            set
            {
                _generalCargoIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialSecurityIndicatorType SpecialSecurityIndicator
        {
            get
            {
                return _specialSecurityIndicatorField;
            }
            set
            {
                _specialSecurityIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ThirdPartyPayerIndicatorType ThirdPartyPayerIndicator
        {
            get
            {
                return _thirdPartyPayerIndicatorField;
            }
            set
            {
                _thirdPartyPayerIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarrierServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CarrierServiceInstructionsType[] CarrierServiceInstructions
        {
            get
            {
                return _carrierServiceInstructionsField;
            }
            set
            {
                _carrierServiceInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomsClearanceServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomsClearanceServiceInstructionsType[] CustomsClearanceServiceInstructions
        {
            get
            {
                return _customsClearanceServiceInstructionsField;
            }
            set
            {
                _customsClearanceServiceInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForwarderServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ForwarderServiceInstructionsType[] ForwarderServiceInstructions
        {
            get
            {
                return _forwarderServiceInstructionsField;
            }
            set
            {
                _forwarderServiceInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialServiceInstructionsType[] SpecialServiceInstructions
        {
            get
            {
                return _specialServiceInstructionsField;
            }
            set
            {
                _specialServiceInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceIdType SequenceId
        {
            get
            {
                return _sequenceIdField;
            }
            set
            {
                _sequenceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShippingPriorityLevelCodeType ShippingPriorityLevelCode
        {
            get
            {
                return _shippingPriorityLevelCodeField;
            }
            set
            {
                _shippingPriorityLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingCodeType HandlingCode
        {
            get
            {
                return _handlingCodeField;
            }
            set
            {
                _handlingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingInstructionsType[] HandlingInstructions
        {
            get
            {
                return _handlingInstructionsField;
            }
            set
            {
                _handlingInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InformationType[] Information
        {
            get
            {
                return _informationField;
            }
            set
            {
                _informationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity
        {
            get
            {
                return _totalGoodsItemQuantityField;
            }
            set
            {
                _totalGoodsItemQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity
        {
            get
            {
                return _totalTransportHandlingUnitQuantityField;
            }
            set
            {
                _totalTransportHandlingUnitQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InsuranceValueAmountType InsuranceValueAmount
        {
            get
            {
                return _insuranceValueAmountField;
            }
            set
            {
                _insuranceValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
        {
            get
            {
                return _declaredForCarriageValueAmountField;
            }
            set
            {
                _declaredForCarriageValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
        {
            get
            {
                return _declaredStatisticsValueAmountField;
            }
            set
            {
                _declaredStatisticsValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreeOnBoardValueAmountType FreeOnBoardValueAmount
        {
            get
            {
                return _freeOnBoardValueAmountField;
            }
            set
            {
                _freeOnBoardValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialInstructionsType[] SpecialInstructions
        {
            get
            {
                return _specialInstructionsField;
            }
            set
            {
                _specialInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SplitConsignmentIndicatorType SplitConsignmentIndicator
        {
            get
            {
                return _splitConsignmentIndicatorField;
            }
            set
            {
                _splitConsignmentIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeliveryInstructionsType[] DeliveryInstructions
        {
            get
            {
                return _deliveryInstructionsField;
            }
            set
            {
                _deliveryInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsignmentQuantityType ConsignmentQuantity
        {
            get
            {
                return _consignmentQuantityField;
            }
            set
            {
                _consignmentQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsolidatableIndicatorType ConsolidatableIndicator
        {
            get
            {
                return _consolidatableIndicatorField;
            }
            set
            {
                _consolidatableIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HaulageInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HaulageInstructionsType[] HaulageInstructions
        {
            get
            {
                return _haulageInstructionsField;
            }
            set
            {
                _haulageInstructionsField = value;
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
        public ChildConsignmentQuantityType ChildConsignmentQuantity
        {
            get
            {
                return _childConsignmentQuantityField;
            }
            set
            {
                _childConsignmentQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalPackagesQuantityType TotalPackagesQuantity
        {
            get
            {
                return _totalPackagesQuantityField;
            }
            set
            {
                _totalPackagesQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsolidatedShipment")]
        public ShipmentType[] ConsolidatedShipment
        {
            get
            {
                return _consolidatedShipmentField;
            }
            set
            {
                _consolidatedShipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration")]
        public CustomsDeclarationType[] CustomsDeclaration
        {
            get
            {
                return _customsDeclarationField;
            }
            set
            {
                _customsDeclarationField = value;
            }
        }

        /// <remarks/>
        public TransportEventType RequestedPickupTransportEvent
        {
            get
            {
                return _requestedPickupTransportEventField;
            }
            set
            {
                _requestedPickupTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType RequestedDeliveryTransportEvent
        {
            get
            {
                return _requestedDeliveryTransportEventField;
            }
            set
            {
                _requestedDeliveryTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedPickupTransportEvent
        {
            get
            {
                return _plannedPickupTransportEventField;
            }
            set
            {
                _plannedPickupTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedDeliveryTransportEvent
        {
            get
            {
                return _plannedDeliveryTransportEventField;
            }
            set
            {
                _plannedDeliveryTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Status")]
        public StatusType[] Status
        {
            get
            {
                return _statusField;
            }
            set
            {
                _statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChildConsignment")]
        public ConsignmentType[] ChildConsignment
        {
            get
            {
                return _childConsignmentField;
            }
            set
            {
                _childConsignmentField = value;
            }
        }

        /// <remarks/>
        public PartyType ConsigneeParty
        {
            get
            {
                return _consigneePartyField;
            }
            set
            {
                _consigneePartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ExporterParty
        {
            get
            {
                return _exporterPartyField;
            }
            set
            {
                _exporterPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ConsignorParty
        {
            get
            {
                return _consignorPartyField;
            }
            set
            {
                _consignorPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ImporterParty
        {
            get
            {
                return _importerPartyField;
            }
            set
            {
                _importerPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType CarrierParty
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
        public PartyType FreightForwarderParty
        {
            get
            {
                return _freightForwarderPartyField;
            }
            set
            {
                _freightForwarderPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType NotifyParty
        {
            get
            {
                return _notifyPartyField;
            }
            set
            {
                _notifyPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType OriginalDespatchParty
        {
            get
            {
                return _originalDespatchPartyField;
            }
            set
            {
                _originalDespatchPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType FinalDeliveryParty
        {
            get
            {
                return _finalDeliveryPartyField;
            }
            set
            {
                _finalDeliveryPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType PerformingCarrierParty
        {
            get
            {
                return _performingCarrierPartyField;
            }
            set
            {
                _performingCarrierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType SubstituteCarrierParty
        {
            get
            {
                return _substituteCarrierPartyField;
            }
            set
            {
                _substituteCarrierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType LogisticsOperatorParty
        {
            get
            {
                return _logisticsOperatorPartyField;
            }
            set
            {
                _logisticsOperatorPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType TransportAdvisorParty
        {
            get
            {
                return _transportAdvisorPartyField;
            }
            set
            {
                _transportAdvisorPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType HazardousItemNotificationParty
        {
            get
            {
                return _hazardousItemNotificationPartyField;
            }
            set
            {
                _hazardousItemNotificationPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType InsuranceParty
        {
            get
            {
                return _insurancePartyField;
            }
            set
            {
                _insurancePartyField = value;
            }
        }

        /// <remarks/>
        public PartyType MortgageHolderParty
        {
            get
            {
                return _mortgageHolderPartyField;
            }
            set
            {
                _mortgageHolderPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType BillOfLadingHolderParty
        {
            get
            {
                return _billOfLadingHolderPartyField;
            }
            set
            {
                _billOfLadingHolderPartyField = value;
            }
        }

        /// <remarks/>
        public CountryType OriginalDepartureCountry
        {
            get
            {
                return _originalDepartureCountryField;
            }
            set
            {
                _originalDepartureCountryField = value;
            }
        }

        /// <remarks/>
        public CountryType FinalDestinationCountry
        {
            get
            {
                return _finalDestinationCountryField;
            }
            set
            {
                _finalDestinationCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransitCountry")]
        public CountryType[] TransitCountry
        {
            get
            {
                return _transitCountryField;
            }
            set
            {
                _transitCountryField = value;
            }
        }

        /// <remarks/>
        public ContractType TransportContract
        {
            get
            {
                return _transportContractField;
            }
            set
            {
                _transportContractField = value;
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
        public TransportationServiceType OriginalDespatchTransportationService
        {
            get
            {
                return _originalDespatchTransportationServiceField;
            }
            set
            {
                _originalDespatchTransportationServiceField = value;
            }
        }

        /// <remarks/>
        public TransportationServiceType FinalDeliveryTransportationService
        {
            get
            {
                return _finalDeliveryTransportationServiceField;
            }
            set
            {
                _finalDeliveryTransportationServiceField = value;
            }
        }

        /// <remarks/>
        public DeliveryTermsType DeliveryTerms
        {
            get
            {
                return _deliveryTermsField;
            }
            set
            {
                _deliveryTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType PaymentTerms
        {
            get
            {
                return _paymentTermsField;
            }
            set
            {
                _paymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType CollectPaymentTerms
        {
            get
            {
                return _collectPaymentTermsField;
            }
            set
            {
                _collectPaymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType DisbursementPaymentTerms
        {
            get
            {
                return _disbursementPaymentTermsField;
            }
            set
            {
                _disbursementPaymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType PrepaidPaymentTerms
        {
            get
            {
                return _prepaidPaymentTermsField;
            }
            set
            {
                _prepaidPaymentTermsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ExtraAllowanceCharge")]
        public AllowanceChargeType[] ExtraAllowanceCharge
        {
            get
            {
                return _extraAllowanceChargeField;
            }
            set
            {
                _extraAllowanceChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MainCarriageShipmentStage")]
        public ShipmentStageType[] MainCarriageShipmentStage
        {
            get
            {
                return _mainCarriageShipmentStageField;
            }
            set
            {
                _mainCarriageShipmentStageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PreCarriageShipmentStage")]
        public ShipmentStageType[] PreCarriageShipmentStage
        {
            get
            {
                return _preCarriageShipmentStageField;
            }
            set
            {
                _preCarriageShipmentStageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OnCarriageShipmentStage")]
        public ShipmentStageType[] OnCarriageShipmentStage
        {
            get
            {
                return _onCarriageShipmentStageField;
            }
            set
            {
                _onCarriageShipmentStageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit")]
        public TransportHandlingUnitType[] TransportHandlingUnit
        {
            get
            {
                return _transportHandlingUnitField;
            }
            set
            {
                _transportHandlingUnitField = value;
            }
        }

        /// <remarks/>
        public LocationType1 FirstArrivalPortLocation
        {
            get
            {
                return _firstArrivalPortLocationField;
            }
            set
            {
                _firstArrivalPortLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 LastExitPortLocation
        {
            get
            {
                return _lastExitPortLocationField;
            }
            set
            {
                _lastExitPortLocationField = value;
            }
        }
    }
}