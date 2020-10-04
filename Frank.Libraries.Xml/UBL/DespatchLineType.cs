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
    [XmlRoot("DespatchLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class DespatchLineType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUIDType UUID;
    
        /// <remarks/>
        [XmlElement("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineStatusCodeType LineStatusCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeliveredQuantityType DeliveredQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BackorderQuantityType BackorderQuantity;
    
        /// <remarks/>
        [XmlElement("BackorderReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BackorderReasonType[] BackorderReason;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OutstandingQuantityType OutstandingQuantity;
    
        /// <remarks/>
        [XmlElement("OutstandingReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OutstandingReasonType[] OutstandingReason;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OversupplyQuantityType OversupplyQuantity;
    
        /// <remarks/>
        [XmlElement("OrderLineReference")]
        public OrderLineReferenceType[] OrderLineReference;
    
        /// <remarks/>
        [XmlElement("DocumentReference")]
        public DocumentReferenceType[] DocumentReference;
    
        /// <remarks/>
        public ItemType Item;
    
        /// <remarks/>
        [XmlElement("Shipment")]
        public ShipmentType[] Shipment;
    }
}