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
    [XmlRoot("TransportationSegment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TransportationSegmentType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceNumericType SequenceNumeric;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportExecutionPlanReferenceIDType TransportExecutionPlanReferenceID;
    
        /// <remarks/>
        public TransportationServiceType TransportationService;
    
        /// <remarks/>
        public PartyType TransportServiceProviderParty;
    
        /// <remarks/>
        public ConsignmentType ReferencedConsignment;
    
        /// <remarks/>
        [XmlElement("ShipmentStage")]
        public ShipmentStageType[] ShipmentStage;
    }
}