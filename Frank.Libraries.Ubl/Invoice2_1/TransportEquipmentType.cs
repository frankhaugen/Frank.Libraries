namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AttachedTransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportEquipmentType
    {

        private IdType _idField;

        private ReferencedConsignmentIdType[] _referencedConsignmentIdField;

        private TransportEquipmentTypeCodeType _transportEquipmentTypeCodeField;

        private ProviderTypeCodeType _providerTypeCodeField;

        private OwnerTypeCodeType _ownerTypeCodeField;

        private SizeTypeCodeType _sizeTypeCodeField;

        private DispositionCodeType _dispositionCodeField;

        private FullnessIndicationCodeType _fullnessIndicationCodeField;

        private RefrigerationOnIndicatorType _refrigerationOnIndicatorField;

        private InformationType[] _informationField;

        private ReturnabilityIndicatorType _returnabilityIndicatorField;

        private LegalStatusIndicatorType _legalStatusIndicatorField;

        private AirFlowPercentType _airFlowPercentField;

        private HumidityPercentType _humidityPercentField;

        private AnimalFoodApprovedIndicatorType _animalFoodApprovedIndicatorField;

        private HumanFoodApprovedIndicatorType _humanFoodApprovedIndicatorField;

        private DangerousGoodsApprovedIndicatorType _dangerousGoodsApprovedIndicatorField;

        private RefrigeratedIndicatorType _refrigeratedIndicatorField;

        private CharacteristicsType _characteristicsField;

        private DamageRemarksType[] _damageRemarksField;

        private DescriptionType[] _descriptionField;

        private SpecialTransportRequirementsType[] _specialTransportRequirementsField;

        private GrossWeightMeasureType _grossWeightMeasureField;

        private GrossVolumeMeasureType _grossVolumeMeasureField;

        private TareWeightMeasureType _tareWeightMeasureField;

        private TrackingDeviceCodeType _trackingDeviceCodeField;

        private PowerIndicatorType _powerIndicatorField;

        private TraceIdType _traceIdField;

        private DimensionType[] _measurementDimensionField;

        private TransportEquipmentSealType[] _transportEquipmentSealField;

        private TemperatureType _minimumTemperatureField;

        private TemperatureType _maximumTemperatureField;

        private PartyType _providerPartyField;

        private PartyType _loadingProofPartyField;

        private SupplierPartyType _supplierPartyField;

        private PartyType _ownerPartyField;

        private PartyType _operatingPartyField;

        private LocationType1 _loadingLocationField;

        private LocationType1 _unloadingLocationField;

        private LocationType1 _storageLocationField;

        private TransportEventType[] _positioningTransportEventField;

        private TransportEventType[] _quarantineTransportEventField;

        private TransportEventType[] _deliveryTransportEventField;

        private TransportEventType[] _pickupTransportEventField;

        private TransportEventType[] _handlingTransportEventField;

        private TransportEventType[] _loadingTransportEventField;

        private TransportEventType[] _transportEventField;

        private TransportMeansType _applicableTransportMeansField;

        private TradingTermsType[] _haulageTradingTermsField;

        private HazardousGoodsTransitType[] _hazardousGoodsTransitField;

        private TransportHandlingUnitType[] _packagedTransportHandlingUnitField;

        private AllowanceChargeType[] _serviceAllowanceChargeField;

        private AllowanceChargeType[] _freightAllowanceChargeField;

        private TransportEquipmentType[] _attachedTransportEquipmentField;

        private DeliveryType _deliveryField;

        private PickupType _pickupField;

        private DespatchType _despatchField;

        private DocumentReferenceType[] _shipmentDocumentReferenceField;

        private TransportEquipmentType[] _containedInTransportEquipmentField;

        private PackageType[] _packageField;

        private GoodsItemType[] _goodsItemField;

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
        [System.Xml.Serialization.XmlElementAttribute("ReferencedConsignmentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferencedConsignmentIdType[] ReferencedConsignmentId
        {
            get
            {
                return _referencedConsignmentIdField;
            }
            set
            {
                _referencedConsignmentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportEquipmentTypeCodeType TransportEquipmentTypeCode
        {
            get
            {
                return _transportEquipmentTypeCodeField;
            }
            set
            {
                _transportEquipmentTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProviderTypeCodeType ProviderTypeCode
        {
            get
            {
                return _providerTypeCodeField;
            }
            set
            {
                _providerTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OwnerTypeCodeType OwnerTypeCode
        {
            get
            {
                return _ownerTypeCodeField;
            }
            set
            {
                _ownerTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SizeTypeCodeType SizeTypeCode
        {
            get
            {
                return _sizeTypeCodeField;
            }
            set
            {
                _sizeTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DispositionCodeType DispositionCode
        {
            get
            {
                return _dispositionCodeField;
            }
            set
            {
                _dispositionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FullnessIndicationCodeType FullnessIndicationCode
        {
            get
            {
                return _fullnessIndicationCodeField;
            }
            set
            {
                _fullnessIndicationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RefrigerationOnIndicatorType RefrigerationOnIndicator
        {
            get
            {
                return _refrigerationOnIndicatorField;
            }
            set
            {
                _refrigerationOnIndicatorField = value;
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
        public ReturnabilityIndicatorType ReturnabilityIndicator
        {
            get
            {
                return _returnabilityIndicatorField;
            }
            set
            {
                _returnabilityIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LegalStatusIndicatorType LegalStatusIndicator
        {
            get
            {
                return _legalStatusIndicatorField;
            }
            set
            {
                _legalStatusIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AirFlowPercentType AirFlowPercent
        {
            get
            {
                return _airFlowPercentField;
            }
            set
            {
                _airFlowPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HumidityPercentType HumidityPercent
        {
            get
            {
                return _humidityPercentField;
            }
            set
            {
                _humidityPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AnimalFoodApprovedIndicatorType AnimalFoodApprovedIndicator
        {
            get
            {
                return _animalFoodApprovedIndicatorField;
            }
            set
            {
                _animalFoodApprovedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HumanFoodApprovedIndicatorType HumanFoodApprovedIndicator
        {
            get
            {
                return _humanFoodApprovedIndicatorField;
            }
            set
            {
                _humanFoodApprovedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DangerousGoodsApprovedIndicatorType DangerousGoodsApprovedIndicator
        {
            get
            {
                return _dangerousGoodsApprovedIndicatorField;
            }
            set
            {
                _dangerousGoodsApprovedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RefrigeratedIndicatorType RefrigeratedIndicator
        {
            get
            {
                return _refrigeratedIndicatorField;
            }
            set
            {
                _refrigeratedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CharacteristicsType Characteristics
        {
            get
            {
                return _characteristicsField;
            }
            set
            {
                _characteristicsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DamageRemarksType[] DamageRemarks
        {
            get
            {
                return _damageRemarksField;
            }
            set
            {
                _damageRemarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialTransportRequirements", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialTransportRequirementsType[] SpecialTransportRequirements
        {
            get
            {
                return _specialTransportRequirementsField;
            }
            set
            {
                _specialTransportRequirementsField = value;
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
        public TareWeightMeasureType TareWeightMeasure
        {
            get
            {
                return _tareWeightMeasureField;
            }
            set
            {
                _tareWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TrackingDeviceCodeType TrackingDeviceCode
        {
            get
            {
                return _trackingDeviceCodeField;
            }
            set
            {
                _trackingDeviceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PowerIndicatorType PowerIndicator
        {
            get
            {
                return _powerIndicatorField;
            }
            set
            {
                _powerIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TraceIdType TraceId
        {
            get
            {
                return _traceIdField;
            }
            set
            {
                _traceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return _measurementDimensionField;
            }
            set
            {
                _measurementDimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipmentSeal")]
        public TransportEquipmentSealType[] TransportEquipmentSeal
        {
            get
            {
                return _transportEquipmentSealField;
            }
            set
            {
                _transportEquipmentSealField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MinimumTemperature
        {
            get
            {
                return _minimumTemperatureField;
            }
            set
            {
                _minimumTemperatureField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MaximumTemperature
        {
            get
            {
                return _maximumTemperatureField;
            }
            set
            {
                _maximumTemperatureField = value;
            }
        }

        /// <remarks/>
        public PartyType ProviderParty
        {
            get
            {
                return _providerPartyField;
            }
            set
            {
                _providerPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType LoadingProofParty
        {
            get
            {
                return _loadingProofPartyField;
            }
            set
            {
                _loadingProofPartyField = value;
            }
        }

        /// <remarks/>
        public SupplierPartyType SupplierParty
        {
            get
            {
                return _supplierPartyField;
            }
            set
            {
                _supplierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType OwnerParty
        {
            get
            {
                return _ownerPartyField;
            }
            set
            {
                _ownerPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType OperatingParty
        {
            get
            {
                return _operatingPartyField;
            }
            set
            {
                _operatingPartyField = value;
            }
        }

        /// <remarks/>
        public LocationType1 LoadingLocation
        {
            get
            {
                return _loadingLocationField;
            }
            set
            {
                _loadingLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 UnloadingLocation
        {
            get
            {
                return _unloadingLocationField;
            }
            set
            {
                _unloadingLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 StorageLocation
        {
            get
            {
                return _storageLocationField;
            }
            set
            {
                _storageLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PositioningTransportEvent")]
        public TransportEventType[] PositioningTransportEvent
        {
            get
            {
                return _positioningTransportEventField;
            }
            set
            {
                _positioningTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QuarantineTransportEvent")]
        public TransportEventType[] QuarantineTransportEvent
        {
            get
            {
                return _quarantineTransportEventField;
            }
            set
            {
                _quarantineTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTransportEvent")]
        public TransportEventType[] DeliveryTransportEvent
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
        [System.Xml.Serialization.XmlElementAttribute("PickupTransportEvent")]
        public TransportEventType[] PickupTransportEvent
        {
            get
            {
                return _pickupTransportEventField;
            }
            set
            {
                _pickupTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HandlingTransportEvent")]
        public TransportEventType[] HandlingTransportEvent
        {
            get
            {
                return _handlingTransportEventField;
            }
            set
            {
                _handlingTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoadingTransportEvent")]
        public TransportEventType[] LoadingTransportEvent
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
        public TransportMeansType ApplicableTransportMeans
        {
            get
            {
                return _applicableTransportMeansField;
            }
            set
            {
                _applicableTransportMeansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HaulageTradingTerms")]
        public TradingTermsType[] HaulageTradingTerms
        {
            get
            {
                return _haulageTradingTermsField;
            }
            set
            {
                _haulageTradingTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit
        {
            get
            {
                return _hazardousGoodsTransitField;
            }
            set
            {
                _hazardousGoodsTransitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PackagedTransportHandlingUnit")]
        public TransportHandlingUnitType[] PackagedTransportHandlingUnit
        {
            get
            {
                return _packagedTransportHandlingUnitField;
            }
            set
            {
                _packagedTransportHandlingUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceAllowanceCharge")]
        public AllowanceChargeType[] ServiceAllowanceCharge
        {
            get
            {
                return _serviceAllowanceChargeField;
            }
            set
            {
                _serviceAllowanceChargeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AttachedTransportEquipment")]
        public TransportEquipmentType[] AttachedTransportEquipment
        {
            get
            {
                return _attachedTransportEquipmentField;
            }
            set
            {
                _attachedTransportEquipmentField = value;
            }
        }

        /// <remarks/>
        public DeliveryType Delivery
        {
            get
            {
                return _deliveryField;
            }
            set
            {
                _deliveryField = value;
            }
        }

        /// <remarks/>
        public PickupType Pickup
        {
            get
            {
                return _pickupField;
            }
            set
            {
                _pickupField = value;
            }
        }

        /// <remarks/>
        public DespatchType Despatch
        {
            get
            {
                return _despatchField;
            }
            set
            {
                _despatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference")]
        public DocumentReferenceType[] ShipmentDocumentReference
        {
            get
            {
                return _shipmentDocumentReferenceField;
            }
            set
            {
                _shipmentDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContainedInTransportEquipment")]
        public TransportEquipmentType[] ContainedInTransportEquipment
        {
            get
            {
                return _containedInTransportEquipmentField;
            }
            set
            {
                _containedInTransportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Package")]
        public PackageType[] Package
        {
            get
            {
                return _packageField;
            }
            set
            {
                _packageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
        public GoodsItemType[] GoodsItem
        {
            get
            {
                return _goodsItemField;
            }
            set
            {
                _goodsItemField = value;
            }
        }
    }
}