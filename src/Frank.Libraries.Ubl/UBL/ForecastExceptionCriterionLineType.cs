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
[XmlRoot("ForecastExceptionCriterionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ForecastExceptionCriterionLineType
{
    private ComparisonDataSourceCodeType comparisonDataSourceCodeField;

    private DataSourceCodeType dataSourceCodeField;

    private ForecastPurposeCodeType forecastPurposeCodeField;

    private ForecastTypeCodeType forecastTypeCodeField;

    private TimeDeltaDaysQuantityType timeDeltaDaysQuantityField;

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
    public ComparisonDataSourceCodeType ComparisonDataSourceCode
    {
        get => comparisonDataSourceCodeField;
        set => comparisonDataSourceCodeField = value;
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
    public TimeDeltaDaysQuantityType TimeDeltaDaysQuantity
    {
        get => timeDeltaDaysQuantityField;
        set => timeDeltaDaysQuantityField = value;
    }
}