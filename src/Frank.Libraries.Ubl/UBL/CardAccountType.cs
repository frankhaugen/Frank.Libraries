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
[XmlRoot("CardAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class CardAccountType
{
    private CardChipCodeType cardChipCodeField;

    private CardTypeCodeType cardTypeCodeField;

    private ChipApplicationIDType chipApplicationIDField;

    private CV2IDType cV2IDField;

    private ExpiryDateType expiryDateField;

    private HolderNameType holderNameField;

    private IssueNumberIDType issueNumberIDField;

    private IssuerIDType issuerIDField;

    private NetworkIDType networkIDField;

    private PrimaryAccountNumberIDType primaryAccountNumberIDField;

    private ValidityStartDateType validityStartDateField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrimaryAccountNumberIDType PrimaryAccountNumberID
    {
        get => primaryAccountNumberIDField;
        set => primaryAccountNumberIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetworkIDType NetworkID
    {
        get => networkIDField;
        set => networkIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CardTypeCodeType CardTypeCode
    {
        get => cardTypeCodeField;
        set => cardTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValidityStartDateType ValidityStartDate
    {
        get => validityStartDateField;
        set => validityStartDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpiryDateType ExpiryDate
    {
        get => expiryDateField;
        set => expiryDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssuerIDType IssuerID
    {
        get => issuerIDField;
        set => issuerIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueNumberIDType IssueNumberID
    {
        get => issueNumberIDField;
        set => issueNumberIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CV2IDType CV2ID
    {
        get => cV2IDField;
        set => cV2IDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CardChipCodeType CardChipCode
    {
        get => cardChipCodeField;
        set => cardChipCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChipApplicationIDType ChipApplicationID
    {
        get => chipApplicationIDField;
        set => chipApplicationIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HolderNameType HolderName
    {
        get => holderNameField;
        set => holderNameField = value;
    }
}