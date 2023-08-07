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
[XmlRoot("MeterReading", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class MeterReadingType
{
    private DeliveredQuantityType deliveredQuantityField;

    private IDType idField;

    private LatestMeterQuantityType latestMeterQuantityField;

    private LatestMeterReadingDateType latestMeterReadingDateField;

    private LatestMeterReadingMethodCodeType latestMeterReadingMethodCodeField;

    private LatestMeterReadingMethodType latestMeterReadingMethodField;

    private MeterReadingCommentsType[] meterReadingCommentsField;

    private MeterReadingTypeType meterReadingType1Field;

    private MeterReadingTypeCodeType meterReadingTypeCodeField;

    private PreviousMeterQuantityType previousMeterQuantityField;

    private PreviousMeterReadingDateType previousMeterReadingDateField;

    private PreviousMeterReadingMethodCodeType previousMeterReadingMethodCodeField;

    private PreviousMeterReadingMethodType previousMeterReadingMethodField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement("MeterReadingType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MeterReadingTypeType MeterReadingType1
    {
        get => meterReadingType1Field;
        set => meterReadingType1Field = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MeterReadingTypeCodeType MeterReadingTypeCode
    {
        get => meterReadingTypeCodeField;
        set => meterReadingTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreviousMeterReadingDateType PreviousMeterReadingDate
    {
        get => previousMeterReadingDateField;
        set => previousMeterReadingDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreviousMeterQuantityType PreviousMeterQuantity
    {
        get => previousMeterQuantityField;
        set => previousMeterQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestMeterReadingDateType LatestMeterReadingDate
    {
        get => latestMeterReadingDateField;
        set => latestMeterReadingDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestMeterQuantityType LatestMeterQuantity
    {
        get => latestMeterQuantityField;
        set => latestMeterQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreviousMeterReadingMethodType PreviousMeterReadingMethod
    {
        get => previousMeterReadingMethodField;
        set => previousMeterReadingMethodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreviousMeterReadingMethodCodeType PreviousMeterReadingMethodCode
    {
        get => previousMeterReadingMethodCodeField;
        set => previousMeterReadingMethodCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestMeterReadingMethodType LatestMeterReadingMethod
    {
        get => latestMeterReadingMethodField;
        set => latestMeterReadingMethodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestMeterReadingMethodCodeType LatestMeterReadingMethodCode
    {
        get => latestMeterReadingMethodCodeField;
        set => latestMeterReadingMethodCodeField = value;
    }

    /// <remarks />
    [XmlElement("MeterReadingComments", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MeterReadingCommentsType[] MeterReadingComments
    {
        get => meterReadingCommentsField;
        set => meterReadingCommentsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeliveredQuantityType DeliveredQuantity
    {
        get => deliveredQuantityField;
        set => deliveredQuantityField = value;
    }
}