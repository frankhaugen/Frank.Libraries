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
    [XmlRoot("SalesItem", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class SalesItemType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity;
    
        /// <remarks/>
        [XmlElement("ActivityProperty")]
        public ActivityPropertyType[] ActivityProperty;
    
        /// <remarks/>
        [XmlElement("TaxExclusivePrice")]
        public PriceType[] TaxExclusivePrice;
    
        /// <remarks/>
        [XmlElement("TaxInclusivePrice")]
        public PriceType[] TaxInclusivePrice;
    
        /// <remarks/>
        public ItemType Item;
    }
}