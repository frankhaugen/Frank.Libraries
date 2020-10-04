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
    [XmlRoot("ItemManagementProfile", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class ItemManagementProfileType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FrozenPeriodDaysNumericType FrozenPeriodDaysNumeric;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumInventoryQuantityType MinimumInventoryQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MultipleOrderQuantityType MultipleOrderQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderIntervalDaysNumericType OrderIntervalDaysNumeric;
    
        /// <remarks/>
        [XmlElement("ReplenishmentOwnerDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReplenishmentOwnerDescriptionType[] ReplenishmentOwnerDescription;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetServicePercentType TargetServicePercent;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetInventoryQuantityType TargetInventoryQuantity;
    
        /// <remarks/>
        public PeriodType EffectivePeriod;
    
        /// <remarks/>
        public ItemType Item;
    
        /// <remarks/>
        public ItemLocationQuantityType ItemLocationQuantity;
    }
}