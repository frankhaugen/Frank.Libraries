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
    [XmlRoot("PackagedTransportHandlingUnit", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TransportHandlingUnitType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportHandlingUnitTypeCodeType TransportHandlingUnitTypeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingCodeType HandlingCode;
    
        /// <remarks/>
        [XmlElement("HandlingInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingInstructionsType[] HandlingInstructions;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalPackageQuantityType TotalPackageQuantity;
    
        /// <remarks/>
        [XmlElement("DamageRemarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DamageRemarksType[] DamageRemarks;
    
        /// <remarks/>
        [XmlElement("ShippingMarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShippingMarksType[] ShippingMarks;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TraceIDType TraceID;
    
        /// <remarks/>
        [XmlElement("HandlingUnitDespatchLine")]
        public DespatchLineType[] HandlingUnitDespatchLine;
    
        /// <remarks/>
        [XmlElement("ActualPackage")]
        public PackageType[] ActualPackage;
    
        /// <remarks/>
        [XmlElement("ReceivedHandlingUnitReceiptLine")]
        public ReceiptLineType[] ReceivedHandlingUnitReceiptLine;
    
        /// <remarks/>
        [XmlElement("TransportEquipment")]
        public TransportEquipmentType[] TransportEquipment;
    
        /// <remarks/>
        [XmlElement("TransportMeans")]
        public TransportMeansType[] TransportMeans;
    
        /// <remarks/>
        [XmlElement("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit;
    
        /// <remarks/>
        [XmlElement("MeasurementDimension")]
        public DimensionType[] MeasurementDimension;
    
        /// <remarks/>
        public TemperatureType MinimumTemperature;
    
        /// <remarks/>
        public TemperatureType MaximumTemperature;
    
        /// <remarks/>
        [XmlElement("GoodsItem")]
        public GoodsItemType[] GoodsItem;
    
        /// <remarks/>
        public DimensionType FloorSpaceMeasurementDimension;
    
        /// <remarks/>
        public DimensionType PalletSpaceMeasurementDimension;
    
        /// <remarks/>
        [XmlElement("ShipmentDocumentReference")]
        public DocumentReferenceType[] ShipmentDocumentReference;
    
        /// <remarks/>
        [XmlElement("Status")]
        public StatusType[] Status;
    
        /// <remarks/>
        [XmlElement("CustomsDeclaration")]
        public CustomsDeclarationType[] CustomsDeclaration;
    
        /// <remarks/>
        [XmlElement("ReferencedShipment")]
        public ShipmentType[] ReferencedShipment;
    
        /// <remarks/>
        [XmlElement("Package")]
        public PackageType[] Package;
    }
}