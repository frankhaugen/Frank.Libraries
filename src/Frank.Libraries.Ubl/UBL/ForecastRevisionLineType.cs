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
[XmlRoot("ForecastRevisionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ForecastRevisionLineType
{
    private AdjustmentReasonCodeType adjustmentReasonCodeField;

    private DescriptionType[] descriptionField;

    private PeriodType forecastPeriodField;

    private IDType idField;

    private NoteType[] noteField;

    private RevisedForecastLineIDType revisedForecastLineIDField;

    private SalesItemType salesItemField;

    private SourceForecastIssueDateType sourceForecastIssueDateField;

    private SourceForecastIssueTimeType sourceForecastIssueTimeField;

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
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RevisedForecastLineIDType RevisedForecastLineID
    {
        get => revisedForecastLineIDField;
        set => revisedForecastLineIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SourceForecastIssueDateType SourceForecastIssueDate
    {
        get => sourceForecastIssueDateField;
        set => sourceForecastIssueDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SourceForecastIssueTimeType SourceForecastIssueTime
    {
        get => sourceForecastIssueTimeField;
        set => sourceForecastIssueTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdjustmentReasonCodeType AdjustmentReasonCode
    {
        get => adjustmentReasonCodeField;
        set => adjustmentReasonCodeField = value;
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