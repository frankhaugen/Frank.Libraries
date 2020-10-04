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
    [XmlRoot("AdditionalTransportationService", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TransportationServiceType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportServiceCodeType TransportServiceCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TariffClassCodeType TariffClassCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriorityType Priority;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreightRateClassCodeType FreightRateClassCode;
    
        /// <remarks/>
        [XmlElement("TransportationServiceDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportationServiceDescriptionType[] TransportationServiceDescription;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportationServiceDetailsURIType TransportationServiceDetailsURI;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NominationDateType NominationDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NominationTimeType NominationTime;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceNumericType SequenceNumeric;
    
        /// <remarks/>
        [XmlElement("TransportEquipment")]
        public TransportEquipmentType[] TransportEquipment;
    
        /// <remarks/>
        [XmlElement("SupportedTransportEquipment")]
        public TransportEquipmentType[] SupportedTransportEquipment;
    
        /// <remarks/>
        [XmlElement("UnsupportedTransportEquipment")]
        public TransportEquipmentType[] UnsupportedTransportEquipment;
    
        /// <remarks/>
        [XmlElement("CommodityClassification")]
        public CommodityClassificationType[] CommodityClassification;
    
        /// <remarks/>
        [XmlElement("SupportedCommodityClassification")]
        public CommodityClassificationType[] SupportedCommodityClassification;
    
        /// <remarks/>
        [XmlElement("UnsupportedCommodityClassification")]
        public CommodityClassificationType[] UnsupportedCommodityClassification;
    
        /// <remarks/>
        public DimensionType TotalCapacityDimension;
    
        /// <remarks/>
        [XmlElement("ShipmentStage")]
        public ShipmentStageType[] ShipmentStage;
    
        /// <remarks/>
        [XmlElement("TransportEvent")]
        public TransportEventType[] TransportEvent;
    
        /// <remarks/>
        public PartyType ResponsibleTransportServiceProviderParty;
    
        /// <remarks/>
        [XmlElement("EnvironmentalEmission")]
        public EnvironmentalEmissionType[] EnvironmentalEmission;
    
        /// <remarks/>
        public PeriodType EstimatedDurationPeriod;
    
        /// <remarks/>
        [XmlElement("ScheduledServiceFrequency")]
        public ServiceFrequencyType[] ScheduledServiceFrequency;
    }
}