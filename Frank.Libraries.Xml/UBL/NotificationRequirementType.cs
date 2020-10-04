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
    [XmlRoot("NotificationRequirement", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class NotificationRequirementType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NotificationTypeCodeType NotificationTypeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PostEventNotificationDurationMeasureType PostEventNotificationDurationMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreEventNotificationDurationMeasureType PreEventNotificationDurationMeasure;
    
        /// <remarks/>
        [XmlElement("NotifyParty")]
        public PartyType[] NotifyParty;
    
        /// <remarks/>
        [XmlElement("NotificationPeriod")]
        public PeriodType[] NotificationPeriod;
    
        /// <remarks/>
        [XmlElement("NotificationLocation")]
        public LocationType1[] NotificationLocation;
    }
}