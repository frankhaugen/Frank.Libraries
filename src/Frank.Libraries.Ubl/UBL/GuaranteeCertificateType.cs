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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GuaranteeCertificate-2")]
[XmlRoot("GuaranteeCertificate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GuaranteeCertificate-2", IsNullable = false)]
public class GuaranteeCertificateType
{
    private PeriodType applicablePeriodField;

    private RegulationType[] applicableRegulationField;

    private PartyType beneficiaryPartyField;

    private ConstitutionCodeType constitutionCodeField;

    private ContractFolderIDType contractFolderIDField;

    private CopyIndicatorType copyIndicatorField;

    private CustomizationIDType customizationIDField;

    private DocumentReferenceType[] guaranteeDocumentReferenceField;

    private GuaranteeTypeCodeType guaranteeTypeCodeField;

    private PartyType guarantorPartyField;

    private IDType idField;

    private ImmobilizedSecurityType[] immobilizedSecurityField;

    private PartyType interestedPartyField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private LiabilityAmountType liabilityAmountField;

    private NoteType[] noteField;

    private ProfileExecutionIDType profileExecutionIDField;

    private ProfileIDType profileIDField;

    private PurposeType[] purposeField;

    private SignatureType[] signatureField;

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private UUIDType uUIDField;

    /// <remarks />
    [XmlArray(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlArrayItem("UBLExtension", IsNullable = false)]
    public UBLExtensionType[] UBLExtensions
    {
        get => uBLExtensionsField;
        set => uBLExtensionsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UBLVersionIDType UBLVersionID
    {
        get => uBLVersionIDField;
        set => uBLVersionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomizationIDType CustomizationID
    {
        get => customizationIDField;
        set => customizationIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileIDType ProfileID
    {
        get => profileIDField;
        set => profileIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileExecutionIDType ProfileExecutionID
    {
        get => profileExecutionIDField;
        set => profileExecutionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CopyIndicatorType CopyIndicator
    {
        get => copyIndicatorField;
        set => copyIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get => uUIDField;
        set => uUIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractFolderIDType ContractFolderID
    {
        get => contractFolderIDField;
        set => contractFolderIDField = value;
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
    public IssueTimeType IssueTime
    {
        get => issueTimeField;
        set => issueTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GuaranteeTypeCodeType GuaranteeTypeCode
    {
        get => guaranteeTypeCodeField;
        set => guaranteeTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("Purpose", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PurposeType[] Purpose
    {
        get => purposeField;
        set => purposeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LiabilityAmountType LiabilityAmount
    {
        get => liabilityAmountField;
        set => liabilityAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConstitutionCodeType ConstitutionCode
    {
        get => constitutionCodeField;
        set => constitutionCodeField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType ApplicablePeriod
    {
        get => applicablePeriodField;
        set => applicablePeriodField = value;
    }

    /// <remarks />
    [XmlElement("ApplicableRegulation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public RegulationType[] ApplicableRegulation
    {
        get => applicableRegulationField;
        set => applicableRegulationField = value;
    }

    /// <remarks />
    [XmlElement("GuaranteeDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] GuaranteeDocumentReference
    {
        get => guaranteeDocumentReferenceField;
        set => guaranteeDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("ImmobilizedSecurity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ImmobilizedSecurityType[] ImmobilizedSecurity
    {
        get => immobilizedSecurityField;
        set => immobilizedSecurityField = value;
    }

    /// <remarks />
    [XmlElement("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SignatureType[] Signature
    {
        get => signatureField;
        set => signatureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType GuarantorParty
    {
        get => guarantorPartyField;
        set => guarantorPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType InterestedParty
    {
        get => interestedPartyField;
        set => interestedPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType BeneficiaryParty
    {
        get => beneficiaryPartyField;
        set => beneficiaryPartyField = value;
    }
}