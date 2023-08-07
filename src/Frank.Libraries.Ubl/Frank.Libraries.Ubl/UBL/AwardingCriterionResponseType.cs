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
[XmlRoot("AwardingCriterionResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class AwardingCriterionResponseType
{
    private AmountType2 amountField;

    private AwardingCriterionDescriptionType[] awardingCriterionDescriptionField;

    private AwardingCriterionIDType awardingCriterionIDField;

    private DescriptionType[] descriptionField;

    private IDType idField;

    private QuantityType2 quantityField;

    private AwardingCriterionResponseType[] subordinateAwardingCriterionResponseField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AwardingCriterionIDType AwardingCriterionID
    {
        get => awardingCriterionIDField;
        set => awardingCriterionIDField = value;
    }

    /// <remarks />
    [XmlElement("AwardingCriterionDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AwardingCriterionDescriptionType[] AwardingCriterionDescription
    {
        get => awardingCriterionDescriptionField;
        set => awardingCriterionDescriptionField = value;
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
    public QuantityType2 Quantity
    {
        get => quantityField;
        set => quantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AmountType2 Amount
    {
        get => amountField;
        set => amountField = value;
    }

    /// <remarks />
    [XmlElement("SubordinateAwardingCriterionResponse")]
    public AwardingCriterionResponseType[] SubordinateAwardingCriterionResponse
    {
        get => subordinateAwardingCriterionResponseField;
        set => subordinateAwardingCriterionResponseField = value;
    }
}