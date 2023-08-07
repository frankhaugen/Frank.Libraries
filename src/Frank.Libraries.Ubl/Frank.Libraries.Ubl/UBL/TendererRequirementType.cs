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
[XmlRoot("SpecificTendererRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TendererRequirementType
{
    private DescriptionType[] descriptionField;

    private LegalReferenceType legalReferenceField;

    private NameType1[] nameField;

    private EvidenceType[] suggestedEvidenceField;

    private TendererRequirementTypeCodeType tendererRequirementTypeCodeField;

    /// <remarks />
    [XmlElement("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1[] Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TendererRequirementTypeCodeType TendererRequirementTypeCode
    {
        get => tendererRequirementTypeCodeField;
        set => tendererRequirementTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LegalReferenceType LegalReference
    {
        get => legalReferenceField;
        set => legalReferenceField = value;
    }

    /// <remarks />
    [XmlElement("SuggestedEvidence")]
    public EvidenceType[] SuggestedEvidence
    {
        get => suggestedEvidenceField;
        set => suggestedEvidenceField = value;
    }
}