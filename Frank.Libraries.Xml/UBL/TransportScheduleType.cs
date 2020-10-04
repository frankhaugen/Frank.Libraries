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
    [XmlRoot("TransportSchedule", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TransportScheduleType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceNumericType SequenceNumeric;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceDateType ReferenceDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceTimeType ReferenceTime;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReliabilityPercentType ReliabilityPercent;
    
        /// <remarks/>
        [XmlElement("Remarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks;
    
        /// <remarks/>
        public LocationType1 StatusLocation;
    
        /// <remarks/>
        public TransportEventType ActualArrivalTransportEvent;
    
        /// <remarks/>
        public TransportEventType ActualDepartureTransportEvent;
    
        /// <remarks/>
        public TransportEventType EstimatedDepartureTransportEvent;
    
        /// <remarks/>
        public TransportEventType EstimatedArrivalTransportEvent;
    
        /// <remarks/>
        public TransportEventType PlannedDepartureTransportEvent;
    
        /// <remarks/>
        public TransportEventType PlannedArrivalTransportEvent;
    }
}