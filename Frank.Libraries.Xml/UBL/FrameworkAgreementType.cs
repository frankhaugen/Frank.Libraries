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
    [XmlRoot("FrameworkAgreement", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class FrameworkAgreementType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpectedOperatorQuantityType ExpectedOperatorQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumOperatorQuantityType MaximumOperatorQuantity;
    
        /// <remarks/>
        [XmlElement("Justification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public JustificationType[] Justification;
    
        /// <remarks/>
        [XmlElement("Frequency", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FrequencyType[] Frequency;
    
        /// <remarks/>
        public PeriodType DurationPeriod;
    
        /// <remarks/>
        [XmlElement("SubsequentProcessTenderRequirement")]
        public TenderRequirementType[] SubsequentProcessTenderRequirement;
    }
}