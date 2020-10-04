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
    [XmlRoot("TenderingProcess", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TenderingProcessType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OriginalContractingSystemIDType OriginalContractingSystemID;
    
        /// <remarks/>
        [XmlElement("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description;
    
        /// <remarks/>
        [XmlElement("NegotiationDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NegotiationDescriptionType[] NegotiationDescription;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProcedureCodeType ProcedureCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UrgencyCodeType UrgencyCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpenseCodeType ExpenseCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PartPresentationCodeType PartPresentationCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractingSystemCodeType ContractingSystemCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubmissionMethodCodeType SubmissionMethodCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CandidateReductionConstraintIndicatorType CandidateReductionConstraintIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GovernmentAgreementConstraintIndicatorType GovernmentAgreementConstraintIndicator;
    
        /// <remarks/>
        public PeriodType DocumentAvailabilityPeriod;
    
        /// <remarks/>
        public PeriodType TenderSubmissionDeadlinePeriod;
    
        /// <remarks/>
        public PeriodType InvitationSubmissionPeriod;
    
        /// <remarks/>
        public PeriodType ParticipationRequestReceptionPeriod;
    
        /// <remarks/>
        [XmlElement("NoticeDocumentReference")]
        public DocumentReferenceType[] NoticeDocumentReference;
    
        /// <remarks/>
        [XmlElement("AdditionalDocumentReference")]
        public DocumentReferenceType[] AdditionalDocumentReference;
    
        /// <remarks/>
        [XmlElement("ProcessJustification")]
        public ProcessJustificationType[] ProcessJustification;
    
        /// <remarks/>
        public EconomicOperatorShortListType EconomicOperatorShortList;
    
        /// <remarks/>
        [XmlElement("OpenTenderEvent")]
        public EventType[] OpenTenderEvent;
    
        /// <remarks/>
        public AuctionTermsType AuctionTerms;
    
        /// <remarks/>
        public FrameworkAgreementType FrameworkAgreement;
    }
}