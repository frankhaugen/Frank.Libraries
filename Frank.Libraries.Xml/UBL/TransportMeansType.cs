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
    [XmlRoot("ApplicableTransportMeans", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TransportMeansType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public JourneyIDType JourneyID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNationalityIDType RegistrationNationalityID;
    
        /// <remarks/>
        [XmlElement("RegistrationNationality", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNationalityType[] RegistrationNationality;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DirectionCodeType DirectionCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportMeansTypeCodeType TransportMeansTypeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TradeServiceCodeType TradeServiceCode;
    
        /// <remarks/>
        public StowageType Stowage;
    
        /// <remarks/>
        public AirTransportType AirTransport;
    
        /// <remarks/>
        public RoadTransportType RoadTransport;
    
        /// <remarks/>
        public RailTransportType RailTransport;
    
        /// <remarks/>
        public MaritimeTransportType MaritimeTransport;
    
        /// <remarks/>
        public PartyType OwnerParty;
    
        /// <remarks/>
        [XmlElement("MeasurementDimension")]
        public DimensionType[] MeasurementDimension;
    }
}