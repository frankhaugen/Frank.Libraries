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
    [XmlRoot("HazardousItem", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class HazardousItemType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PlacardNotationType PlacardNotation;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PlacardEndorsementType PlacardEndorsement;
    
        /// <remarks/>
        [XmlElement("AdditionalInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalInformationType[] AdditionalInformation;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UNDGCodeType UNDGCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EmergencyProceduresCodeType EmergencyProceduresCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MedicalFirstAidGuideCodeType MedicalFirstAidGuideCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TechnicalNameType TechnicalName;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CategoryNameType CategoryName;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousCategoryCodeType HazardousCategoryCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UpperOrangeHazardPlacardIDType UpperOrangeHazardPlacardID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LowerOrangeHazardPlacardIDType LowerOrangeHazardPlacardID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkingIDType MarkingID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardClassIDType HazardClassID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetWeightMeasureType NetWeightMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetVolumeMeasureType NetVolumeMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity;
    
        /// <remarks/>
        public PartyType ContactParty;
    
        /// <remarks/>
        [XmlElement("SecondaryHazard")]
        public SecondaryHazardType[] SecondaryHazard;
    
        /// <remarks/>
        [XmlElement("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit;
    
        /// <remarks/>
        public TemperatureType EmergencyTemperature;
    
        /// <remarks/>
        public TemperatureType FlashpointTemperature;
    
        /// <remarks/>
        [XmlElement("AdditionalTemperature")]
        public TemperatureType[] AdditionalTemperature;
    }
}