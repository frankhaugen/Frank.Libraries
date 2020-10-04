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
    [XmlRoot("AwardingTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class AwardingTermsType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WeightingAlgorithmCodeType WeightingAlgorithmCode;
    
        /// <remarks/>
        [XmlElement("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description;
    
        /// <remarks/>
        [XmlElement("TechnicalCommitteeDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TechnicalCommitteeDescriptionType[] TechnicalCommitteeDescription;
    
        /// <remarks/>
        [XmlElement("LowTendersDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LowTendersDescriptionType[] LowTendersDescription;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrizeIndicatorType PrizeIndicator;
    
        /// <remarks/>
        [XmlElement("PrizeDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrizeDescriptionType[] PrizeDescription;
    
        /// <remarks/>
        [XmlElement("PaymentDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentDescriptionType[] PaymentDescription;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FollowupContractIndicatorType FollowupContractIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BindingOnBuyerIndicatorType BindingOnBuyerIndicator;
    
        /// <remarks/>
        [XmlElement("AwardingCriterion")]
        public AwardingCriterionType[] AwardingCriterion;
    
        /// <remarks/>
        [XmlElement("TechnicalCommitteePerson")]
        public PersonType[] TechnicalCommitteePerson;
    }
}