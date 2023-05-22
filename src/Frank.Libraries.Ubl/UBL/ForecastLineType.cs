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
[XmlRoot("ForecastLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ForecastLineType
{
    private PeriodType forecastPeriodField;

    private ForecastTypeCodeType forecastTypeCodeField;

    private FrozenDocumentIndicatorType frozenDocumentIndicatorField;

    private IDType idField;

    private NoteType[] noteField;

    private SalesItemType salesItemField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FrozenDocumentIndicatorType FrozenDocumentIndicator
    {
        get => frozenDocumentIndicatorField;
        set => frozenDocumentIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ForecastTypeCodeType ForecastTypeCode
    {
        get => forecastTypeCodeField;
        set => forecastTypeCodeField = value;
    }

    /// <remarks />
    public PeriodType ForecastPeriod
    {
        get => forecastPeriodField;
        set => forecastPeriodField = value;
    }

    /// <remarks />
    public SalesItemType SalesItem
    {
        get => salesItemField;
        set => salesItemField = value;
    }
}