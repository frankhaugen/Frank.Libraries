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
    [XmlRoot("EventLineItem", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class EventLineItemType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineNumberNumericType LineNumberNumeric;
    
        /// <remarks/>
        public LocationType1 ParticipatingLocationsLocation;
    
        /// <remarks/>
        [XmlElement("RetailPlannedImpact")]
        public RetailPlannedImpactType[] RetailPlannedImpact;
    
        /// <remarks/>
        public ItemType SupplyItem;
    }
}