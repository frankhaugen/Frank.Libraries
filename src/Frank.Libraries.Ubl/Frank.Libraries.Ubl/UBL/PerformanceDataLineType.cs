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
[XmlRoot("PerformanceDataLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PerformanceDataLineType
{
    private IDType idField;

    private ItemType itemField;

    private NoteType[] noteField;

    private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

    private PerformanceValueQuantityType performanceValueQuantityField;

    private PeriodType periodField;

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
    public PerformanceValueQuantityType PerformanceValueQuantity
    {
        get => performanceValueQuantityField;
        set => performanceValueQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerformanceMetricTypeCodeType PerformanceMetricTypeCode
    {
        get => performanceMetricTypeCodeField;
        set => performanceMetricTypeCodeField = value;
    }

    /// <remarks />
    public PeriodType Period
    {
        get => periodField;
        set => periodField = value;
    }

    /// <remarks />
    public ItemType Item
    {
        get => itemField;
        set => itemField = value;
    }
}