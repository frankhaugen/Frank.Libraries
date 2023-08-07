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
[XmlRoot("AdditionalQualifyingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class QualifyingPartyType
{
    private BusinessClassificationEvidenceIDType businessClassificationEvidenceIDField;

    private ClassificationSchemeType businessClassificationSchemeField;

    private BusinessIdentityEvidenceIDType businessIdentityEvidenceIDField;

    private CompletedTaskType[] completedTaskField;

    private DeclarationType[] declarationField;

    private EconomicOperatorRoleType economicOperatorRoleField;

    private EmployeeQuantityType employeeQuantityField;

    private CapabilityType[] financialCapabilityField;

    private OperatingYearsQuantityType operatingYearsQuantityField;

    private ParticipationPercentType participationPercentField;

    private PartyType partyField;

    private PersonalSituationType[] personalSituationField;

    private CapabilityType[] technicalCapabilityField;

    private TendererRoleCodeType tendererRoleCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ParticipationPercentType ParticipationPercent
    {
        get => participationPercentField;
        set => participationPercentField = value;
    }

    /// <remarks />
    [XmlElement("PersonalSituation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PersonalSituationType[] PersonalSituation
    {
        get => personalSituationField;
        set => personalSituationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OperatingYearsQuantityType OperatingYearsQuantity
    {
        get => operatingYearsQuantityField;
        set => operatingYearsQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EmployeeQuantityType EmployeeQuantity
    {
        get => employeeQuantityField;
        set => employeeQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BusinessClassificationEvidenceIDType BusinessClassificationEvidenceID
    {
        get => businessClassificationEvidenceIDField;
        set => businessClassificationEvidenceIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BusinessIdentityEvidenceIDType BusinessIdentityEvidenceID
    {
        get => businessIdentityEvidenceIDField;
        set => businessIdentityEvidenceIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TendererRoleCodeType TendererRoleCode
    {
        get => tendererRoleCodeField;
        set => tendererRoleCodeField = value;
    }

    /// <remarks />
    public ClassificationSchemeType BusinessClassificationScheme
    {
        get => businessClassificationSchemeField;
        set => businessClassificationSchemeField = value;
    }

    /// <remarks />
    [XmlElement("TechnicalCapability")]
    public CapabilityType[] TechnicalCapability
    {
        get => technicalCapabilityField;
        set => technicalCapabilityField = value;
    }

    /// <remarks />
    [XmlElement("FinancialCapability")]
    public CapabilityType[] FinancialCapability
    {
        get => financialCapabilityField;
        set => financialCapabilityField = value;
    }

    /// <remarks />
    [XmlElement("CompletedTask")]
    public CompletedTaskType[] CompletedTask
    {
        get => completedTaskField;
        set => completedTaskField = value;
    }

    /// <remarks />
    [XmlElement("Declaration")]
    public DeclarationType[] Declaration
    {
        get => declarationField;
        set => declarationField = value;
    }

    /// <remarks />
    public PartyType Party
    {
        get => partyField;
        set => partyField = value;
    }

    /// <remarks />
    public EconomicOperatorRoleType EconomicOperatorRole
    {
        get => economicOperatorRoleField;
        set => economicOperatorRoleField = value;
    }
}