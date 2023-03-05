using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("AttachedTransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TransportEquipmentType
{
    private AirFlowPercentType airFlowPercentField;

    private AnimalFoodApprovedIndicatorType animalFoodApprovedIndicatorField;

    private TransportMeansType applicableTransportMeansField;

    private TransportEquipmentType[] attachedTransportEquipmentField;

    private CharacteristicsType characteristicsField;

    private TransportEquipmentType[] containedInTransportEquipmentField;

    private DamageRemarksType[] damageRemarksField;

    private DangerousGoodsApprovedIndicatorType dangerousGoodsApprovedIndicatorField;

    private DeliveryType deliveryField;

    private TransportEventType[] deliveryTransportEventField;

    private DescriptionType[] descriptionField;

    private DespatchType despatchField;

    private DispositionCodeType dispositionCodeField;

    private AllowanceChargeType[] freightAllowanceChargeField;

    private FullnessIndicationCodeType fullnessIndicationCodeField;

    private GoodsItemType[] goodsItemField;

    private GrossVolumeMeasureType grossVolumeMeasureField;

    private GrossWeightMeasureType grossWeightMeasureField;

    private TransportEventType[] handlingTransportEventField;

    private TradingTermsType[] haulageTradingTermsField;

    private HazardousGoodsTransitType[] hazardousGoodsTransitField;

    private HumanFoodApprovedIndicatorType humanFoodApprovedIndicatorField;

    private HumidityPercentType humidityPercentField;

    private IDType idField;

    private InformationType[] informationField;

    private LegalStatusIndicatorType legalStatusIndicatorField;

    private LocationType1 loadingLocationField;

    private PartyType loadingProofPartyField;

    private TransportEventType[] loadingTransportEventField;

    private TemperatureType maximumTemperatureField;

    private DimensionType[] measurementDimensionField;

    private TemperatureType minimumTemperatureField;

    private PartyType operatingPartyField;

    private PartyType ownerPartyField;

    private OwnerTypeCodeType ownerTypeCodeField;

    private TransportHandlingUnitType[] packagedTransportHandlingUnitField;

    private PackageType[] packageField;

    private PickupType pickupField;

    private TransportEventType[] pickupTransportEventField;

    private TransportEventType[] positioningTransportEventField;

    private PowerIndicatorType powerIndicatorField;

    private PartyType providerPartyField;

    private ProviderTypeCodeType providerTypeCodeField;

    private TransportEventType[] quarantineTransportEventField;

    private ReferencedConsignmentIDType[] referencedConsignmentIDField;

    private RefrigeratedIndicatorType refrigeratedIndicatorField;

    private RefrigerationOnIndicatorType refrigerationOnIndicatorField;

    private ReturnabilityIndicatorType returnabilityIndicatorField;

    private AllowanceChargeType[] serviceAllowanceChargeField;

    private DocumentReferenceType[] shipmentDocumentReferenceField;

    private SizeTypeCodeType sizeTypeCodeField;

    private SpecialTransportRequirementsType[] specialTransportRequirementsField;

    private LocationType1 storageLocationField;

    private SupplierPartyType supplierPartyField;

    private TareWeightMeasureType tareWeightMeasureField;

    private TraceIDType traceIDField;

    private TrackingDeviceCodeType trackingDeviceCodeField;

    private TransportEquipmentSealType[] transportEquipmentSealField;

    private TransportEquipmentTypeCodeType transportEquipmentTypeCodeField;

    private TransportEventType[] transportEventField;

    private LocationType1 unloadingLocationField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement("ReferencedConsignmentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferencedConsignmentIDType[] ReferencedConsignmentID
    {
        get => referencedConsignmentIDField;
        set => referencedConsignmentIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportEquipmentTypeCodeType TransportEquipmentTypeCode
    {
        get => transportEquipmentTypeCodeField;
        set => transportEquipmentTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProviderTypeCodeType ProviderTypeCode
    {
        get => providerTypeCodeField;
        set => providerTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OwnerTypeCodeType OwnerTypeCode
    {
        get => ownerTypeCodeField;
        set => ownerTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SizeTypeCodeType SizeTypeCode
    {
        get => sizeTypeCodeField;
        set => sizeTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DispositionCodeType DispositionCode
    {
        get => dispositionCodeField;
        set => dispositionCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FullnessIndicationCodeType FullnessIndicationCode
    {
        get => fullnessIndicationCodeField;
        set => fullnessIndicationCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RefrigerationOnIndicatorType RefrigerationOnIndicator
    {
        get => refrigerationOnIndicatorField;
        set => refrigerationOnIndicatorField = value;
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
    public ReturnabilityIndicatorType ReturnabilityIndicator
    {
        get => returnabilityIndicatorField;
        set => returnabilityIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LegalStatusIndicatorType LegalStatusIndicator
    {
        get => legalStatusIndicatorField;
        set => legalStatusIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AirFlowPercentType AirFlowPercent
    {
        get => airFlowPercentField;
        set => airFlowPercentField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HumidityPercentType HumidityPercent
    {
        get => humidityPercentField;
        set => humidityPercentField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AnimalFoodApprovedIndicatorType AnimalFoodApprovedIndicator
    {
        get => animalFoodApprovedIndicatorField;
        set => animalFoodApprovedIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HumanFoodApprovedIndicatorType HumanFoodApprovedIndicator
    {
        get => humanFoodApprovedIndicatorField;
        set => humanFoodApprovedIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DangerousGoodsApprovedIndicatorType DangerousGoodsApprovedIndicator
    {
        get => dangerousGoodsApprovedIndicatorField;
        set => dangerousGoodsApprovedIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RefrigeratedIndicatorType RefrigeratedIndicator
    {
        get => refrigeratedIndicatorField;
        set => refrigeratedIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CharacteristicsType Characteristics
    {
        get => characteristicsField;
        set => characteristicsField = value;
    }

    /// <remarks />
    [XmlElement("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DamageRemarksType[] DamageRemarks
    {
        get => damageRemarksField;
        set => damageRemarksField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("SpecialTransportRequirements", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialTransportRequirementsType[] SpecialTransportRequirements
    {
        get => specialTransportRequirementsField;
        set => specialTransportRequirementsField = value;
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
    public GrossVolumeMeasureType GrossVolumeMeasure
    {
        get => grossVolumeMeasureField;
        set => grossVolumeMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TareWeightMeasureType TareWeightMeasure
    {
        get => tareWeightMeasureField;
        set => tareWeightMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TrackingDeviceCodeType TrackingDeviceCode
    {
        get => trackingDeviceCodeField;
        set => trackingDeviceCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PowerIndicatorType PowerIndicator
    {
        get => powerIndicatorField;
        set => powerIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TraceIDType TraceID
    {
        get => traceIDField;
        set => traceIDField = value;
    }

    /// <remarks />
    [XmlElement("MeasurementDimension")]
    public DimensionType[] MeasurementDimension
    {
        get => measurementDimensionField;
        set => measurementDimensionField = value;
    }

    /// <remarks />
    [XmlElement("TransportEquipmentSeal")]
    public TransportEquipmentSealType[] TransportEquipmentSeal
    {
        get => transportEquipmentSealField;
        set => transportEquipmentSealField = value;
    }

    /// <remarks />
    public TemperatureType MinimumTemperature
    {
        get => minimumTemperatureField;
        set => minimumTemperatureField = value;
    }

    /// <remarks />
    public TemperatureType MaximumTemperature
    {
        get => maximumTemperatureField;
        set => maximumTemperatureField = value;
    }

    /// <remarks />
    public PartyType ProviderParty
    {
        get => providerPartyField;
        set => providerPartyField = value;
    }

    /// <remarks />
    public PartyType LoadingProofParty
    {
        get => loadingProofPartyField;
        set => loadingProofPartyField = value;
    }

    /// <remarks />
    public SupplierPartyType SupplierParty
    {
        get => supplierPartyField;
        set => supplierPartyField = value;
    }

    /// <remarks />
    public PartyType OwnerParty
    {
        get => ownerPartyField;
        set => ownerPartyField = value;
    }

    /// <remarks />
    public PartyType OperatingParty
    {
        get => operatingPartyField;
        set => operatingPartyField = value;
    }

    /// <remarks />
    public LocationType1 LoadingLocation
    {
        get => loadingLocationField;
        set => loadingLocationField = value;
    }

    /// <remarks />
    public LocationType1 UnloadingLocation
    {
        get => unloadingLocationField;
        set => unloadingLocationField = value;
    }

    /// <remarks />
    public LocationType1 StorageLocation
    {
        get => storageLocationField;
        set => storageLocationField = value;
    }

    /// <remarks />
    [XmlElement("PositioningTransportEvent")]
    public TransportEventType[] PositioningTransportEvent
    {
        get => positioningTransportEventField;
        set => positioningTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("QuarantineTransportEvent")]
    public TransportEventType[] QuarantineTransportEvent
    {
        get => quarantineTransportEventField;
        set => quarantineTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("DeliveryTransportEvent")]
    public TransportEventType[] DeliveryTransportEvent
    {
        get => deliveryTransportEventField;
        set => deliveryTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("PickupTransportEvent")]
    public TransportEventType[] PickupTransportEvent
    {
        get => pickupTransportEventField;
        set => pickupTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("HandlingTransportEvent")]
    public TransportEventType[] HandlingTransportEvent
    {
        get => handlingTransportEventField;
        set => handlingTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("LoadingTransportEvent")]
    public TransportEventType[] LoadingTransportEvent
    {
        get => loadingTransportEventField;
        set => loadingTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("TransportEvent")]
    public TransportEventType[] TransportEvent
    {
        get => transportEventField;
        set => transportEventField = value;
    }

    /// <remarks />
    public TransportMeansType ApplicableTransportMeans
    {
        get => applicableTransportMeansField;
        set => applicableTransportMeansField = value;
    }

    /// <remarks />
    [XmlElement("HaulageTradingTerms")]
    public TradingTermsType[] HaulageTradingTerms
    {
        get => haulageTradingTermsField;
        set => haulageTradingTermsField = value;
    }

    /// <remarks />
    [XmlElement("HazardousGoodsTransit")]
    public HazardousGoodsTransitType[] HazardousGoodsTransit
    {
        get => hazardousGoodsTransitField;
        set => hazardousGoodsTransitField = value;
    }

    /// <remarks />
    [XmlElement("PackagedTransportHandlingUnit")]
    public TransportHandlingUnitType[] PackagedTransportHandlingUnit
    {
        get => packagedTransportHandlingUnitField;
        set => packagedTransportHandlingUnitField = value;
    }

    /// <remarks />
    [XmlElement("ServiceAllowanceCharge")]
    public AllowanceChargeType[] ServiceAllowanceCharge
    {
        get => serviceAllowanceChargeField;
        set => serviceAllowanceChargeField = value;
    }

    /// <remarks />
    [XmlElement("FreightAllowanceCharge")]
    public AllowanceChargeType[] FreightAllowanceCharge
    {
        get => freightAllowanceChargeField;
        set => freightAllowanceChargeField = value;
    }

    /// <remarks />
    [XmlElement("AttachedTransportEquipment")]
    public TransportEquipmentType[] AttachedTransportEquipment
    {
        get => attachedTransportEquipmentField;
        set => attachedTransportEquipmentField = value;
    }

    /// <remarks />
    public DeliveryType Delivery
    {
        get => deliveryField;
        set => deliveryField = value;
    }

    /// <remarks />
    public PickupType Pickup
    {
        get => pickupField;
        set => pickupField = value;
    }

    /// <remarks />
    public DespatchType Despatch
    {
        get => despatchField;
        set => despatchField = value;
    }

    /// <remarks />
    [XmlElement("ShipmentDocumentReference")]
    public DocumentReferenceType[] ShipmentDocumentReference
    {
        get => shipmentDocumentReferenceField;
        set => shipmentDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("ContainedInTransportEquipment")]
    public TransportEquipmentType[] ContainedInTransportEquipment
    {
        get => containedInTransportEquipmentField;
        set => containedInTransportEquipmentField = value;
    }

    /// <remarks />
    [XmlElement("Package")]
    public PackageType[] Package
    {
        get => packageField;
        set => packageField = value;
    }

    /// <remarks />
    [XmlElement("GoodsItem")]
    public GoodsItemType[] GoodsItem
    {
        get => goodsItemField;
        set => goodsItemField = value;
    }
}