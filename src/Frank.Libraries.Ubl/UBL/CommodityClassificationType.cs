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
[XmlRoot("AdditionalCommodityClassification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class CommodityClassificationType
{
    private CargoTypeCodeType cargoTypeCodeField;

    private CommodityCodeType commodityCodeField;

    private ItemClassificationCodeType itemClassificationCodeField;

    private NatureCodeType natureCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NatureCodeType NatureCode
    {
        get => natureCodeField;
        set => natureCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CargoTypeCodeType CargoTypeCode
    {
        get => cargoTypeCodeField;
        set => cargoTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CommodityCodeType CommodityCode
    {
        get => commodityCodeField;
        set => commodityCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ItemClassificationCodeType ItemClassificationCode
    {
        get => itemClassificationCodeField;
        set => itemClassificationCodeField = value;
    }
}