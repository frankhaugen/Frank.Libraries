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
[XmlRoot("AuctionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class AuctionTermsType
{
    private AuctionConstraintIndicatorType auctionConstraintIndicatorField;

    private AuctionURIType auctionURIField;

    private ConditionsDescriptionType[] conditionsDescriptionField;

    private DescriptionType[] descriptionField;

    private ElectronicDeviceDescriptionType[] electronicDeviceDescriptionField;

    private JustificationDescriptionType[] justificationDescriptionField;

    private ProcessDescriptionType[] processDescriptionField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AuctionConstraintIndicatorType AuctionConstraintIndicator
    {
        get => auctionConstraintIndicatorField;
        set => auctionConstraintIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("JustificationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public JustificationDescriptionType[] JustificationDescription
    {
        get => justificationDescriptionField;
        set => justificationDescriptionField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("ProcessDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProcessDescriptionType[] ProcessDescription
    {
        get => processDescriptionField;
        set => processDescriptionField = value;
    }

    /// <remarks />
    [XmlElement("ConditionsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConditionsDescriptionType[] ConditionsDescription
    {
        get => conditionsDescriptionField;
        set => conditionsDescriptionField = value;
    }

    /// <remarks />
    [XmlElement("ElectronicDeviceDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ElectronicDeviceDescriptionType[] ElectronicDeviceDescription
    {
        get => electronicDeviceDescriptionField;
        set => electronicDeviceDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AuctionURIType AuctionURI
    {
        get => auctionURIField;
        set => auctionURIField = value;
    }
}