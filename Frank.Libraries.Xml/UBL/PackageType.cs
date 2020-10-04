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
    [XmlRoot("ActualPackage", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class PackageType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReturnableMaterialIndicatorType ReturnableMaterialIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackageLevelCodeType PackageLevelCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackagingTypeCodeType PackagingTypeCode;
    
        /// <remarks/>
        [XmlElement("PackingMaterial", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackingMaterialType[] PackingMaterial;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TraceIDType TraceID;
    
        /// <remarks/>
        [XmlElement("ContainedPackage")]
        public PackageType[] ContainedPackage;
    
        /// <remarks/>
        public TransportEquipmentType ContainingTransportEquipment;
    
        /// <remarks/>
        [XmlElement("GoodsItem")]
        public GoodsItemType[] GoodsItem;
    
        /// <remarks/>
        [XmlElement("MeasurementDimension")]
        public DimensionType[] MeasurementDimension;
    
        /// <remarks/>
        [XmlElement("DeliveryUnit")]
        public DeliveryUnitType[] DeliveryUnit;
    
        /// <remarks/>
        public DeliveryType Delivery;
    
        /// <remarks/>
        public PickupType Pickup;
    
        /// <remarks/>
        public DespatchType Despatch;
    }
}