using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("AdditionalInformationParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PartyType
{
    private PartyType agentPartyField;

    private ContactType contactField;

    private EndpointIDType endpointIDField;

    private FinancialAccountType financialAccountField;

    private IndustryClassificationCodeType industryClassificationCodeField;

    private LanguageType languageField;

    private LogoReferenceIDType logoReferenceIDField;

    private MarkAttentionIndicatorType markAttentionIndicatorField;

    private MarkCareIndicatorType markCareIndicatorField;

    private PartyIdentificationType[] partyIdentificationField;

    private PartyLegalEntityType[] partyLegalEntityField;

    private PartyNameType[] partyNameField;

    private PartyTaxSchemeType[] partyTaxSchemeField;

    private PersonType[] personField;

    private LocationType1 physicalLocationField;

    private AddressType postalAddressField;

    private PowerOfAttorneyType[] powerOfAttorneyField;

    private ServiceProviderPartyType[] serviceProviderPartyField;

    private WebsiteURIType websiteURIField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MarkCareIndicatorType MarkCareIndicator
    {
        get => markCareIndicatorField;
        set => markCareIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MarkAttentionIndicatorType MarkAttentionIndicator
    {
        get => markAttentionIndicatorField;
        set => markAttentionIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public WebsiteURIType WebsiteURI
    {
        get => websiteURIField;
        set => websiteURIField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LogoReferenceIDType LogoReferenceID
    {
        get => logoReferenceIDField;
        set => logoReferenceIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EndpointIDType EndpointID
    {
        get => endpointIDField;
        set => endpointIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IndustryClassificationCodeType IndustryClassificationCode
    {
        get => industryClassificationCodeField;
        set => industryClassificationCodeField = value;
    }

    /// <remarks />
    [XmlElement("PartyIdentification")]
    public PartyIdentificationType[] PartyIdentification
    {
        get => partyIdentificationField;
        set => partyIdentificationField = value;
    }

    /// <remarks />
    [XmlElement("PartyName")]
    public PartyNameType[] PartyName
    {
        get => partyNameField;
        set => partyNameField = value;
    }

    /// <remarks />
    public LanguageType Language
    {
        get => languageField;
        set => languageField = value;
    }

    /// <remarks />
    public AddressType PostalAddress
    {
        get => postalAddressField;
        set => postalAddressField = value;
    }

    /// <remarks />
    public LocationType1 PhysicalLocation
    {
        get => physicalLocationField;
        set => physicalLocationField = value;
    }

    /// <remarks />
    [XmlElement("PartyTaxScheme")]
    public PartyTaxSchemeType[] PartyTaxScheme
    {
        get => partyTaxSchemeField;
        set => partyTaxSchemeField = value;
    }

    /// <remarks />
    [XmlElement("PartyLegalEntity")]
    public PartyLegalEntityType[] PartyLegalEntity
    {
        get => partyLegalEntityField;
        set => partyLegalEntityField = value;
    }

    /// <remarks />
    public ContactType Contact
    {
        get => contactField;
        set => contactField = value;
    }

    /// <remarks />
    [XmlElement("Person")]
    public PersonType[] Person
    {
        get => personField;
        set => personField = value;
    }

    /// <remarks />
    public PartyType AgentParty
    {
        get => agentPartyField;
        set => agentPartyField = value;
    }

    /// <remarks />
    [XmlElement("ServiceProviderParty")]
    public ServiceProviderPartyType[] ServiceProviderParty
    {
        get => serviceProviderPartyField;
        set => serviceProviderPartyField = value;
    }

    /// <remarks />
    [XmlElement("PowerOfAttorney")]
    public PowerOfAttorneyType[] PowerOfAttorney
    {
        get => powerOfAttorneyField;
        set => powerOfAttorneyField = value;
    }

    /// <remarks />
    public FinancialAccountType FinancialAccount
    {
        get => financialAccountField;
        set => financialAccountField = value;
    }
}