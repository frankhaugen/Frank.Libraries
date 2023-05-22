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
[XmlRoot("ImmobilizedSecurity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ImmobilizedSecurityType
{
    private FaceValueAmountType faceValueAmountField;

    private ImmobilizationCertificateIDType immobilizationCertificateIDField;

    private IssueDateType issueDateField;

    private PartyType issuerPartyField;

    private MarketValueAmountType marketValueAmountField;

    private SecurityIDType securityIDField;

    private SharesNumberQuantityType sharesNumberQuantityField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ImmobilizationCertificateIDType ImmobilizationCertificateID
    {
        get => immobilizationCertificateIDField;
        set => immobilizationCertificateIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SecurityIDType SecurityID
    {
        get => securityIDField;
        set => securityIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueDateType IssueDate
    {
        get => issueDateField;
        set => issueDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FaceValueAmountType FaceValueAmount
    {
        get => faceValueAmountField;
        set => faceValueAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MarketValueAmountType MarketValueAmount
    {
        get => marketValueAmountField;
        set => marketValueAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SharesNumberQuantityType SharesNumberQuantity
    {
        get => sharesNumberQuantityField;
        set => sharesNumberQuantityField = value;
    }

    /// <remarks />
    public PartyType IssuerParty
    {
        get => issuerPartyField;
        set => issuerPartyField = value;
    }
}