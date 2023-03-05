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
[XmlRoot("FinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class FinancialAccountType
{
    private AccountFormatCodeType accountFormatCodeField;

    private AccountTypeCodeType accountTypeCodeField;

    private AliasNameType aliasNameField;

    private CountryType countryField;

    private CurrencyCodeType currencyCodeField;

    private BranchType financialInstitutionBranchField;

    private IDType idField;

    private NameType1 nameField;

    private PaymentNoteType[] paymentNoteField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AliasNameType AliasName
    {
        get => aliasNameField;
        set => aliasNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountTypeCodeType AccountTypeCode
    {
        get => accountTypeCodeField;
        set => accountTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountFormatCodeType AccountFormatCode
    {
        get => accountFormatCodeField;
        set => accountFormatCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CurrencyCodeType CurrencyCode
    {
        get => currencyCodeField;
        set => currencyCodeField = value;
    }

    /// <remarks />
    [XmlElement("PaymentNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentNoteType[] PaymentNote
    {
        get => paymentNoteField;
        set => paymentNoteField = value;
    }

    /// <remarks />
    public BranchType FinancialInstitutionBranch
    {
        get => financialInstitutionBranchField;
        set => financialInstitutionBranchField = value;
    }

    /// <remarks />
    public CountryType Country
    {
        get => countryField;
        set => countryField = value;
    }
}