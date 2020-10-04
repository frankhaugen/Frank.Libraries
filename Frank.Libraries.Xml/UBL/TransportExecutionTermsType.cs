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
    [XmlRoot("TransportExecutionTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TransportExecutionTermsType {
    
        /// <remarks/>
        [XmlElement("TransportUserSpecialTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportUserSpecialTermsType[] TransportUserSpecialTerms;
    
        /// <remarks/>
        [XmlElement("TransportServiceProviderSpecialTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportServiceProviderSpecialTermsType[] TransportServiceProviderSpecialTerms;
    
        /// <remarks/>
        [XmlElement("ChangeConditions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChangeConditionsType[] ChangeConditions;
    
        /// <remarks/>
        [XmlElement("PaymentTerms")]
        public PaymentTermsType[] PaymentTerms;
    
        /// <remarks/>
        [XmlElement("DeliveryTerms")]
        public DeliveryTermsType[] DeliveryTerms;
    
        /// <remarks/>
        public PaymentTermsType BonusPaymentTerms;
    
        /// <remarks/>
        public PaymentTermsType CommissionPaymentTerms;
    
        /// <remarks/>
        public PaymentTermsType PenaltyPaymentTerms;
    
        /// <remarks/>
        [XmlElement("EnvironmentalEmission")]
        public EnvironmentalEmissionType[] EnvironmentalEmission;
    
        /// <remarks/>
        [XmlElement("NotificationRequirement")]
        public NotificationRequirementType[] NotificationRequirement;
    
        /// <remarks/>
        public PaymentTermsType ServiceChargePaymentTerms;
    }
}