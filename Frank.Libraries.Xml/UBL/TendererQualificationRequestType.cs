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
    [XmlRoot("TendererQualificationRequest", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TendererQualificationRequestType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalFormCodeType CompanyLegalFormCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalFormType CompanyLegalForm;
    
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
        [XmlElement("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description;
    
        /// <remarks/>
        [XmlElement("RequiredBusinessClassificationScheme")]
        public ClassificationSchemeType[] RequiredBusinessClassificationScheme;
    
        /// <remarks/>
        [XmlElement("TechnicalEvaluationCriterion")]
        public EvaluationCriterionType[] TechnicalEvaluationCriterion;
    
        /// <remarks/>
        [XmlElement("FinancialEvaluationCriterion")]
        public EvaluationCriterionType[] FinancialEvaluationCriterion;
    
        /// <remarks/>
        [XmlElement("SpecificTendererRequirement")]
        public TendererRequirementType[] SpecificTendererRequirement;
    
        /// <remarks/>
        [XmlElement("EconomicOperatorRole")]
        public EconomicOperatorRoleType[] EconomicOperatorRole;
    }
}