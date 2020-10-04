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
    [XmlRoot("CertificateOfOriginApplication", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class CertificateOfOriginApplicationType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceIDType ReferenceID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CertificateTypeType CertificateType;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ApplicationStatusCodeType ApplicationStatusCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OriginalJobIDType OriginalJobID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousJobIDType PreviousJobID;
    
        /// <remarks/>
        [XmlElement("Remarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks;
    
        /// <remarks/>
        public ShipmentType Shipment;
    
        /// <remarks/>
        [XmlElement("EndorserParty")]
        public EndorserPartyType[] EndorserParty;
    
        /// <remarks/>
        public PartyType PreparationParty;
    
        /// <remarks/>
        public PartyType IssuerParty;
    
        /// <remarks/>
        public PartyType ExporterParty;
    
        /// <remarks/>
        public PartyType ImporterParty;
    
        /// <remarks/>
        public CountryType IssuingCountry;
    
        /// <remarks/>
        [XmlElement("DocumentDistribution")]
        public DocumentDistributionType[] DocumentDistribution;
    
        /// <remarks/>
        [XmlElement("SupportingDocumentReference")]
        public DocumentReferenceType[] SupportingDocumentReference;
    
        /// <remarks/>
        [XmlElement("Signature")]
        public SignatureType[] Signature;
    }
}