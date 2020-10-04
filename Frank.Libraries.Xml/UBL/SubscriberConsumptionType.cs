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
    [XmlRoot("SubscriberConsumption", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class SubscriberConsumptionType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionIDType ConsumptionID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecificationTypeCodeType SpecificationTypeCode;
    
        /// <remarks/>
        [XmlElement("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalMeteredQuantityType TotalMeteredQuantity;
    
        /// <remarks/>
        public PartyType SubscriberParty;
    
        /// <remarks/>
        public ConsumptionPointType UtilityConsumptionPoint;
    
        /// <remarks/>
        [XmlElement("OnAccountPayment")]
        public OnAccountPaymentType[] OnAccountPayment;
    
        /// <remarks/>
        public ConsumptionType Consumption;
    
        /// <remarks/>
        [XmlElement("SupplierConsumption")]
        public SupplierConsumptionType[] SupplierConsumption;
    }
}