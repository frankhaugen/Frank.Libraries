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
[XmlRoot("DocumentDistribution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class DocumentDistributionType
{
    private MaximumCopiesNumericType maximumCopiesNumericField;

    private PartyType partyField;

    private PrintQualifierType printQualifierField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrintQualifierType PrintQualifier
    {
        get => printQualifierField;
        set => printQualifierField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumCopiesNumericType MaximumCopiesNumeric
    {
        get => maximumCopiesNumericField;
        set => maximumCopiesNumericField = value;
    }

    /// <remarks />
    public PartyType Party
    {
        get => partyField;
        set => partyField = value;
    }
}