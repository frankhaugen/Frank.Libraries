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
    [XmlRoot("AcceptanceTransportEvent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TransportEventType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentificationIDType IdentificationID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OccurrenceDateType OccurrenceDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OccurrenceTimeType OccurrenceTime;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportEventTypeCodeType TransportEventTypeCode;
    
        /// <remarks/>
        [XmlElement("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompletionIndicatorType CompletionIndicator;
    
        /// <remarks/>
        public ShipmentType ReportedShipment;
    
        /// <remarks/>
        [XmlElement("CurrentStatus")]
        public StatusType[] CurrentStatus;
    
        /// <remarks/>
        [XmlElement("Contact")]
        public ContactType[] Contact;
    
        /// <remarks/>
        public LocationType1 Location;
    
        /// <remarks/>
        public SignatureType Signature;
    
        /// <remarks/>
        [XmlElement("Period")]
        public PeriodType[] Period;
    }
}