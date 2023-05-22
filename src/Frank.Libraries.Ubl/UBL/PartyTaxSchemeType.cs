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
[XmlRoot("PartyTaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PartyTaxSchemeType
{
    private CompanyIDType companyIDField;

    private ExemptionReasonCodeType exemptionReasonCodeField;

    private ExemptionReasonType[] exemptionReasonField;

    private AddressType registrationAddressField;

    private RegistrationNameType registrationNameField;

    private TaxLevelCodeType taxLevelCodeField;

    private TaxSchemeType taxSchemeField;

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
    public TaxLevelCodeType TaxLevelCode
    {
        get => taxLevelCodeField;
        set => taxLevelCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExemptionReasonCodeType ExemptionReasonCode
    {
        get => exemptionReasonCodeField;
        set => exemptionReasonCodeField = value;
    }

    /// <remarks />
    [XmlElement("ExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExemptionReasonType[] ExemptionReason
    {
        get => exemptionReasonField;
        set => exemptionReasonField = value;
    }

    /// <remarks />
    public AddressType RegistrationAddress
    {
        get => registrationAddressField;
        set => registrationAddressField = value;
    }

    /// <remarks />
    public TaxSchemeType TaxScheme
    {
        get => taxSchemeField;
        set => taxSchemeField = value;
    }
}