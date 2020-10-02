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

        private IDType idField;

        private ReferencedConsignmentIDType[] referencedConsignmentIDField;

        private TransportEquipmentTypeCodeType transportEquipmentTypeCodeField;

        private ProviderTypeCodeType providerTypeCodeField;

        private OwnerTypeCodeType ownerTypeCodeField;

        private SizeTypeCodeType sizeTypeCodeField;

        private DispositionCodeType dispositionCodeField;

        private FullnessIndicationCodeType fullnessIndicationCodeField;

        private RefrigerationOnIndicatorType refrigerationOnIndicatorField;

        private InformationType[] informationField;

        private ReturnabilityIndicatorType returnabilityIndicatorField;

        private LegalStatusIndicatorType legalStatusIndicatorField;

        private AirFlowPercentType airFlowPercentField;

        private HumidityPercentType humidityPercentField;

        private AnimalFoodApprovedIndicatorType animalFoodApprovedIndicatorField;

        private HumanFoodApprovedIndicatorType humanFoodApprovedIndicatorField;

        private DangerousGoodsApprovedIndicatorType dangerousGoodsApprovedIndicatorField;

        private RefrigeratedIndicatorType refrigeratedIndicatorField;

        private CharacteristicsType characteristicsField;

        private DamageRemarksType[] damageRemarksField;

        private DescriptionType[] descriptionField;

        private SpecialTransportRequirementsType[] specialTransportRequirementsField;

        private GrossWeightMeasureType grossWeightMeasureField;

        private GrossVolumeMeasureType grossVolumeMeasureField;

        private TareWeightMeasureType tareWeightMeasureField;

        private TrackingDeviceCodeType trackingDeviceCodeField;

        private PowerIndicatorType powerIndicatorField;

        private TraceIDType traceIDField;

        private DimensionType[] measurementDimensionField;

        private TransportEquipmentSealType[] transportEquipmentSealField;

        private TemperatureType minimumTemperatureField;

        private TemperatureType maximumTemperatureField;

        private PartyType providerPartyField;

        private PartyType loadingProofPartyField;

        private SupplierPartyType supplierPartyField;

        private PartyType ownerPartyField;

        private PartyType operatingPartyField;

        private LocationType1 loadingLocationField;

        private LocationType1 unloadingLocationField;

        private LocationType1 storageLocationField;

        private TransportEventType[] positioningTransportEventField;

        private TransportEventType[] quarantineTransportEventField;

        private TransportEventType[] deliveryTransportEventField;

        private TransportEventType[] pickupTransportEventField;

        private TransportEventType[] handlingTransportEventField;

        private TransportEventType[] loadingTransportEventField;

        private TransportEventType[] transportEventField;

        private TransportMeansType applicableTransportMeansField;

        private TradingTermsType[] haulageTradingTermsField;

        private HazardousGoodsTransitType[] hazardousGoodsTransitField;

        private TransportHandlingUnitType[] packagedTransportHandlingUnitField;

        private AllowanceChargeType[] serviceAllowanceChargeField;

        private AllowanceChargeType[] freightAllowanceChargeField;

        private TransportEquipmentType[] attachedTransportEquipmentField;

        private DeliveryType deliveryField;

        private PickupType pickupField;

        private DespatchType despatchField;

        private DocumentReferenceType[] shipmentDocumentReferenceField;

        private TransportEquipmentType[] containedInTransportEquipmentField;

        private PackageType[] packageField;

        private GoodsItemType[] goodsItemField;

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
        [System.Xml.Serialization.XmlElementAttribute("ReferencedConsignmentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferencedConsignmentIDType[] ReferencedConsignmentID
        {
            get
            {
                return referencedConsignmentIDField;
            }
            set
            {
                referencedConsignmentIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportEquipmentTypeCodeType TransportEquipmentTypeCode
        {
            get
            {
                return transportEquipmentTypeCodeField;
            }
            set
            {
                transportEquipmentTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProviderTypeCodeType ProviderTypeCode
        {
            get
            {
                return providerTypeCodeField;
            }
            set
            {
                providerTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OwnerTypeCodeType OwnerTypeCode
        {
            get
            {
                return ownerTypeCodeField;
            }
            set
            {
                ownerTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SizeTypeCodeType SizeTypeCode
        {
            get
            {
                return sizeTypeCodeField;
            }
            set
            {
                sizeTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DispositionCodeType DispositionCode
        {
            get
            {
                return dispositionCodeField;
            }
            set
            {
                dispositionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FullnessIndicationCodeType FullnessIndicationCode
        {
            get
            {
                return fullnessIndicationCodeField;
            }
            set
            {
                fullnessIndicationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RefrigerationOnIndicatorType RefrigerationOnIndicator
        {
            get
            {
                return refrigerationOnIndicatorField;
            }
            set
            {
                refrigerationOnIndicatorField = value;
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
        public ReturnabilityIndicatorType ReturnabilityIndicator
        {
            get
            {
                return returnabilityIndicatorField;
            }
            set
            {
                returnabilityIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LegalStatusIndicatorType LegalStatusIndicator
        {
            get
            {
                return legalStatusIndicatorField;
            }
            set
            {
                legalStatusIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AirFlowPercentType AirFlowPercent
        {
            get
            {
                return airFlowPercentField;
            }
            set
            {
                airFlowPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HumidityPercentType HumidityPercent
        {
            get
            {
                return humidityPercentField;
            }
            set
            {
                humidityPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AnimalFoodApprovedIndicatorType AnimalFoodApprovedIndicator
        {
            get
            {
                return animalFoodApprovedIndicatorField;
            }
            set
            {
                animalFoodApprovedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HumanFoodApprovedIndicatorType HumanFoodApprovedIndicator
        {
            get
            {
                return humanFoodApprovedIndicatorField;
            }
            set
            {
                humanFoodApprovedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DangerousGoodsApprovedIndicatorType DangerousGoodsApprovedIndicator
        {
            get
            {
                return dangerousGoodsApprovedIndicatorField;
            }
            set
            {
                dangerousGoodsApprovedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RefrigeratedIndicatorType RefrigeratedIndicator
        {
            get
            {
                return refrigeratedIndicatorField;
            }
            set
            {
                refrigeratedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CharacteristicsType Characteristics
        {
            get
            {
                return characteristicsField;
            }
            set
            {
                characteristicsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DamageRemarksType[] DamageRemarks
        {
            get
            {
                return damageRemarksField;
            }
            set
            {
                damageRemarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialTransportRequirements", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialTransportRequirementsType[] SpecialTransportRequirements
        {
            get
            {
                return specialTransportRequirementsField;
            }
            set
            {
                specialTransportRequirementsField = value;
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
        public TareWeightMeasureType TareWeightMeasure
        {
            get
            {
                return tareWeightMeasureField;
            }
            set
            {
                tareWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TrackingDeviceCodeType TrackingDeviceCode
        {
            get
            {
                return trackingDeviceCodeField;
            }
            set
            {
                trackingDeviceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PowerIndicatorType PowerIndicator
        {
            get
            {
                return powerIndicatorField;
            }
            set
            {
                powerIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TraceIDType TraceID
        {
            get
            {
                return traceIDField;
            }
            set
            {
                traceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return measurementDimensionField;
            }
            set
            {
                measurementDimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipmentSeal")]
        public TransportEquipmentSealType[] TransportEquipmentSeal
        {
            get
            {
                return transportEquipmentSealField;
            }
            set
            {
                transportEquipmentSealField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MinimumTemperature
        {
            get
            {
                return minimumTemperatureField;
            }
            set
            {
                minimumTemperatureField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MaximumTemperature
        {
            get
            {
                return maximumTemperatureField;
            }
            set
            {
                maximumTemperatureField = value;
            }
        }

        /// <remarks/>
        public PartyType ProviderParty
        {
            get
            {
                return providerPartyField;
            }
            set
            {
                providerPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType LoadingProofParty
        {
            get
            {
                return loadingProofPartyField;
            }
            set
            {
                loadingProofPartyField = value;
            }
        }

        /// <remarks/>
        public SupplierPartyType SupplierParty
        {
            get
            {
                return supplierPartyField;
            }
            set
            {
                supplierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType OwnerParty
        {
            get
            {
                return ownerPartyField;
            }
            set
            {
                ownerPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType OperatingParty
        {
            get
            {
                return operatingPartyField;
            }
            set
            {
                operatingPartyField = value;
            }
        }

        /// <remarks/>
        public LocationType1 LoadingLocation
        {
            get
            {
                return loadingLocationField;
            }
            set
            {
                loadingLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 UnloadingLocation
        {
            get
            {
                return unloadingLocationField;
            }
            set
            {
                unloadingLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 StorageLocation
        {
            get
            {
                return storageLocationField;
            }
            set
            {
                storageLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PositioningTransportEvent")]
        public TransportEventType[] PositioningTransportEvent
        {
            get
            {
                return positioningTransportEventField;
            }
            set
            {
                positioningTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QuarantineTransportEvent")]
        public TransportEventType[] QuarantineTransportEvent
        {
            get
            {
                return quarantineTransportEventField;
            }
            set
            {
                quarantineTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTransportEvent")]
        public TransportEventType[] DeliveryTransportEvent
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
        [System.Xml.Serialization.XmlElementAttribute("PickupTransportEvent")]
        public TransportEventType[] PickupTransportEvent
        {
            get
            {
                return pickupTransportEventField;
            }
            set
            {
                pickupTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HandlingTransportEvent")]
        public TransportEventType[] HandlingTransportEvent
        {
            get
            {
                return handlingTransportEventField;
            }
            set
            {
                handlingTransportEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoadingTransportEvent")]
        public TransportEventType[] LoadingTransportEvent
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
        public TransportMeansType ApplicableTransportMeans
        {
            get
            {
                return applicableTransportMeansField;
            }
            set
            {
                applicableTransportMeansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HaulageTradingTerms")]
        public TradingTermsType[] HaulageTradingTerms
        {
            get
            {
                return haulageTradingTermsField;
            }
            set
            {
                haulageTradingTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit
        {
            get
            {
                return hazardousGoodsTransitField;
            }
            set
            {
                hazardousGoodsTransitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PackagedTransportHandlingUnit")]
        public TransportHandlingUnitType[] PackagedTransportHandlingUnit
        {
            get
            {
                return packagedTransportHandlingUnitField;
            }
            set
            {
                packagedTransportHandlingUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceAllowanceCharge")]
        public AllowanceChargeType[] ServiceAllowanceCharge
        {
            get
            {
                return serviceAllowanceChargeField;
            }
            set
            {
                serviceAllowanceChargeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AttachedTransportEquipment")]
        public TransportEquipmentType[] AttachedTransportEquipment
        {
            get
            {
                return attachedTransportEquipmentField;
            }
            set
            {
                attachedTransportEquipmentField = value;
            }
        }

        /// <remarks/>
        public DeliveryType Delivery
        {
            get
            {
                return deliveryField;
            }
            set
            {
                deliveryField = value;
            }
        }

        /// <remarks/>
        public PickupType Pickup
        {
            get
            {
                return pickupField;
            }
            set
            {
                pickupField = value;
            }
        }

        /// <remarks/>
        public DespatchType Despatch
        {
            get
            {
                return despatchField;
            }
            set
            {
                despatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference")]
        public DocumentReferenceType[] ShipmentDocumentReference
        {
            get
            {
                return shipmentDocumentReferenceField;
            }
            set
            {
                shipmentDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContainedInTransportEquipment")]
        public TransportEquipmentType[] ContainedInTransportEquipment
        {
            get
            {
                return containedInTransportEquipmentField;
            }
            set
            {
                containedInTransportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Package")]
        public PackageType[] Package
        {
            get
            {
                return packageField;
            }
            set
            {
                packageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
        public GoodsItemType[] GoodsItem
        {
            get
            {
                return goodsItemField;
            }
            set
            {
                goodsItemField = value;
            }
        }
    }
}