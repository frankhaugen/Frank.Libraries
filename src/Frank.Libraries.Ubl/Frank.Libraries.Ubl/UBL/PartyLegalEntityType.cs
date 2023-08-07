using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("PartyLegalEntity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PartyLegalEntityType
{
    private CompanyIDType companyIDField;

    private CompanyLegalFormCodeType companyLegalFormCodeField;

    private CompanyLegalFormType companyLegalFormField;

    private CompanyLiquidationStatusCodeType companyLiquidationStatusCodeField;

    private CorporateRegistrationSchemeType corporateRegistrationSchemeField;

    private CorporateStockAmountType corporateStockAmountField;

    private FullyPaidSharesIndicatorType fullyPaidSharesIndicatorField;

    private PartyType headOfficePartyField;

    private AddressType registrationAddressField;

    private RegistrationDateType registrationDateField;

    private RegistrationExpirationDateType registrationExpirationDateField;

    private RegistrationNameType registrationNameField;

    private ShareholderPartyType[] shareholderPartyField;

    private SoleProprietorshipIndicatorType soleProprietorshipIndicatorField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RegistrationNameType RegistrationName
    {
        get => registrationNameField;
        set => registrationNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CompanyIDType CompanyID
    {
        get => companyIDField;
        set => companyIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RegistrationDateType RegistrationDate
    {
        get => registrationDateField;
        set => registrationDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RegistrationExpirationDateType RegistrationExpirationDate
    {
        get => registrationExpirationDateField;
        set => registrationExpirationDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CompanyLegalFormCodeType CompanyLegalFormCode
    {
        get => companyLegalFormCodeField;
        set => companyLegalFormCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CompanyLegalFormType CompanyLegalForm
    {
        get => companyLegalFormField;
        set => companyLegalFormField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SoleProprietorshipIndicatorType SoleProprietorshipIndicator
    {
        get => soleProprietorshipIndicatorField;
        set => soleProprietorshipIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CompanyLiquidationStatusCodeType CompanyLiquidationStatusCode
    {
        get => companyLiquidationStatusCodeField;
        set => companyLiquidationStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CorporateStockAmountType CorporateStockAmount
    {
        get => corporateStockAmountField;
        set => corporateStockAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FullyPaidSharesIndicatorType FullyPaidSharesIndicator
    {
        get => fullyPaidSharesIndicatorField;
        set => fullyPaidSharesIndicatorField = value;
    }

    /// <remarks />
    public AddressType RegistrationAddress
    {
        get => registrationAddressField;
        set => registrationAddressField = value;
    }

    /// <remarks />
    public CorporateRegistrationSchemeType CorporateRegistrationScheme
    {
        get => corporateRegistrationSchemeField;
        set => corporateRegistrationSchemeField = value;
    }

    /// <remarks />
    public PartyType HeadOfficeParty
    {
        get => headOfficePartyField;
        set => headOfficePartyField = value;
    }

    /// <remarks />
    [XmlElement("ShareholderParty")]
    public ShareholderPartyType[] ShareholderParty
    {
        get => shareholderPartyField;
        set => shareholderPartyField = value;
    }
}