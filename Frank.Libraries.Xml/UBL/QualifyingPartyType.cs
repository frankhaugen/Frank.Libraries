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
    [XmlRoot("AdditionalQualifyingParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class QualifyingPartyType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ParticipationPercentType ParticipationPercent;
    
        /// <remarks/>
        [XmlElement("PersonalSituation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PersonalSituationType[] PersonalSituation;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OperatingYearsQuantityType OperatingYearsQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EmployeeQuantityType EmployeeQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BusinessClassificationEvidenceIDType BusinessClassificationEvidenceID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BusinessIdentityEvidenceIDType BusinessIdentityEvidenceID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TendererRoleCodeType TendererRoleCode;
    
        /// <remarks/>
        public ClassificationSchemeType BusinessClassificationScheme;
    
        /// <remarks/>
        [XmlElement("TechnicalCapability")]
        public CapabilityType[] TechnicalCapability;
    
        /// <remarks/>
        [XmlElement("FinancialCapability")]
        public CapabilityType[] FinancialCapability;
    
        /// <remarks/>
        [XmlElement("CompletedTask")]
        public CompletedTaskType[] CompletedTask;
    
        /// <remarks/>
        [XmlElement("Declaration")]
        public DeclarationType[] Declaration;
    
        /// <remarks/>
        public PartyType Party;
    
        /// <remarks/>
        public EconomicOperatorRoleType EconomicOperatorRole;
    }
}