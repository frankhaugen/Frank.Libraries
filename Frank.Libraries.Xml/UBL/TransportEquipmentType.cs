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
    [XmlRoot("AttachedTransportEquipment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TransportEquipmentType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement("ReferencedConsignmentID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferencedConsignmentIDType[] ReferencedConsignmentID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportEquipmentTypeCodeType TransportEquipmentTypeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProviderTypeCodeType ProviderTypeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OwnerTypeCodeType OwnerTypeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SizeTypeCodeType SizeTypeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DispositionCodeType DispositionCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FullnessIndicationCodeType FullnessIndicationCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RefrigerationOnIndicatorType RefrigerationOnIndicator;
    
        /// <remarks/>
        [XmlElement("Information", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InformationType[] Information;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReturnabilityIndicatorType ReturnabilityIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LegalStatusIndicatorType LegalStatusIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AirFlowPercentType AirFlowPercent;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HumidityPercentType HumidityPercent;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AnimalFoodApprovedIndicatorType AnimalFoodApprovedIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HumanFoodApprovedIndicatorType HumanFoodApprovedIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DangerousGoodsApprovedIndicatorType DangerousGoodsApprovedIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RefrigeratedIndicatorType RefrigeratedIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CharacteristicsType Characteristics;
    
        /// <remarks/>
        [XmlElement("DamageRemarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DamageRemarksType[] DamageRemarks;
    
        /// <remarks/>
        [XmlElement("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description;
    
        /// <remarks/>
        [XmlElement("SpecialTransportRequirements", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialTransportRequirementsType[] SpecialTransportRequirements;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossWeightMeasureType GrossWeightMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossVolumeMeasureType GrossVolumeMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TareWeightMeasureType TareWeightMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TrackingDeviceCodeType TrackingDeviceCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PowerIndicatorType PowerIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TraceIDType TraceID;
    
        /// <remarks/>
        [XmlElement("MeasurementDimension")]
        public DimensionType[] MeasurementDimension;
    
        /// <remarks/>
        [XmlElement("TransportEquipmentSeal")]
        public TransportEquipmentSealType[] TransportEquipmentSeal;
    
        /// <remarks/>
        public TemperatureType MinimumTemperature;
    
        /// <remarks/>
        public TemperatureType MaximumTemperature;
    
        /// <remarks/>
        public PartyType ProviderParty;
    
        /// <remarks/>
        public PartyType LoadingProofParty;
    
        /// <remarks/>
        public SupplierPartyType SupplierParty;
    
        /// <remarks/>
        public PartyType OwnerParty;
    
        /// <remarks/>
        public PartyType OperatingParty;
    
        /// <remarks/>
        public LocationType1 LoadingLocation;
    
        /// <remarks/>
        public LocationType1 UnloadingLocation;
    
        /// <remarks/>
        public LocationType1 StorageLocation;
    
        /// <remarks/>
        [XmlElement("PositioningTransportEvent")]
        public TransportEventType[] PositioningTransportEvent;
    
        /// <remarks/>
        [XmlElement("QuarantineTransportEvent")]
        public TransportEventType[] QuarantineTransportEvent;
    
        /// <remarks/>
        [XmlElement("DeliveryTransportEvent")]
        public TransportEventType[] DeliveryTransportEvent;
    
        /// <remarks/>
        [XmlElement("PickupTransportEvent")]
        public TransportEventType[] PickupTransportEvent;
    
        /// <remarks/>
        [XmlElement("HandlingTransportEvent")]
        public TransportEventType[] HandlingTransportEvent;
    
        /// <remarks/>
        [XmlElement("LoadingTransportEvent")]
        public TransportEventType[] LoadingTransportEvent;
    
        /// <remarks/>
        [XmlElement("TransportEvent")]
        public TransportEventType[] TransportEvent;
    
        /// <remarks/>
        public TransportMeansType ApplicableTransportMeans;
    
        /// <remarks/>
        [XmlElement("HaulageTradingTerms")]
        public TradingTermsType[] HaulageTradingTerms;
    
        /// <remarks/>
        [XmlElement("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit;
    
        /// <remarks/>
        [XmlElement("PackagedTransportHandlingUnit")]
        public TransportHandlingUnitType[] PackagedTransportHandlingUnit;
    
        /// <remarks/>
        [XmlElement("ServiceAllowanceCharge")]
        public AllowanceChargeType[] ServiceAllowanceCharge;
    
        /// <remarks/>
        [XmlElement("FreightAllowanceCharge")]
        public AllowanceChargeType[] FreightAllowanceCharge;
    
        /// <remarks/>
        [XmlElement("AttachedTransportEquipment")]
        public TransportEquipmentType[] AttachedTransportEquipment;
    
        /// <remarks/>
        public DeliveryType Delivery;
    
        /// <remarks/>
        public PickupType Pickup;
    
        /// <remarks/>
        public DespatchType Despatch;
    
        /// <remarks/>
        [XmlElement("ShipmentDocumentReference")]
        public DocumentReferenceType[] ShipmentDocumentReference;
    
        /// <remarks/>
        [XmlElement("ContainedInTransportEquipment")]
        public TransportEquipmentType[] ContainedInTransportEquipment;
    
        /// <remarks/>
        [XmlElement("Package")]
        public PackageType[] Package;
    
        /// <remarks/>
        [XmlElement("GoodsItem")]
        public GoodsItemType[] GoodsItem;
    }
}