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
    [XmlRoot("AdditionalInformationParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class PartyType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkCareIndicatorType MarkCareIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkAttentionIndicatorType MarkAttentionIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WebsiteURIType WebsiteURI;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LogoReferenceIDType LogoReferenceID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EndpointIDType EndpointID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndustryClassificationCodeType IndustryClassificationCode;
    
        /// <remarks/>
        [XmlElement("PartyIdentification")]
        public PartyIdentificationType[] PartyIdentification;
    
        /// <remarks/>
        [XmlElement("PartyName")]
        public PartyNameType[] PartyName;
    
        /// <remarks/>
        public LanguageType Language;
    
        /// <remarks/>
        public AddressType PostalAddress;
    
        /// <remarks/>
        public LocationType1 PhysicalLocation;
    
        /// <remarks/>
        [XmlElement("PartyTaxScheme")]
        public PartyTaxSchemeType[] PartyTaxScheme;
    
        /// <remarks/>
        [XmlElement("PartyLegalEntity")]
        public PartyLegalEntityType[] PartyLegalEntity;
    
        /// <remarks/>
        public ContactType Contact;
    
        /// <remarks/>
        [XmlElement("Person")]
        public PersonType[] Person;
    
        /// <remarks/>
        public PartyType AgentParty;
    
        /// <remarks/>
        [XmlElement("ServiceProviderParty")]
        public ServiceProviderPartyType[] ServiceProviderParty;
    
        /// <remarks/>
        [XmlElement("PowerOfAttorney")]
        public PowerOfAttorneyType[] PowerOfAttorney;
    
        /// <remarks/>
        public FinancialAccountType FinancialAccount;
    }
}