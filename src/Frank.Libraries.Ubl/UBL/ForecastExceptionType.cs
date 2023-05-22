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
[XmlRoot("ForecastException", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ForecastExceptionType
{
    private ComparisonDataCodeType comparisonDataCodeField;

    private ComparisonForecastIssueDateType comparisonForecastIssueDateField;

    private ComparisonForecastIssueTimeType comparisonForecastIssueTimeField;

    private DataSourceCodeType dataSourceCodeField;

    private ForecastPurposeCodeType forecastPurposeCodeField;

    private ForecastTypeCodeType forecastTypeCodeField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ForecastPurposeCodeType ForecastPurposeCode
    {
        get => forecastPurposeCodeField;
        set => forecastPurposeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ForecastTypeCodeType ForecastTypeCode
    {
        get => forecastTypeCodeField;
        set => forecastTypeCodeField = value;
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
    public DataSourceCodeType DataSourceCode
    {
        get => dataSourceCodeField;
        set => dataSourceCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ComparisonDataCodeType ComparisonDataCode
    {
        get => comparisonDataCodeField;
        set => comparisonDataCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ComparisonForecastIssueTimeType ComparisonForecastIssueTime
    {
        get => comparisonForecastIssueTimeField;
        set => comparisonForecastIssueTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ComparisonForecastIssueDateType ComparisonForecastIssueDate
    {
        get => comparisonForecastIssueDateField;
        set => comparisonForecastIssueDateField = value;
    }
}