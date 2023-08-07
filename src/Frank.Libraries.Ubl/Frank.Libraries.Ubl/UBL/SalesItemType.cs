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
[XmlRoot("SalesItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class SalesItemType
{
    private ActivityPropertyType[] activityPropertyField;

    private ItemType itemField;

    private QuantityType2 quantityField;

    private PriceType[] taxExclusivePriceField;

    private PriceType[] taxInclusivePriceField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity
    {
        get => quantityField;
        set => quantityField = value;
    }

    /// <remarks />
    [XmlElement("ActivityProperty")]
    public ActivityPropertyType[] ActivityProperty
    {
        get => activityPropertyField;
        set => activityPropertyField = value;
    }

    /// <remarks />
    [XmlElement("TaxExclusivePrice")]
    public PriceType[] TaxExclusivePrice
    {
        get => taxExclusivePriceField;
        set => taxExclusivePriceField = value;
    }

    /// <remarks />
    [XmlElement("TaxInclusivePrice")]
    public PriceType[] TaxInclusivePrice
    {
        get => taxInclusivePriceField;
        set => taxInclusivePriceField = value;
    }

    /// <remarks />
    public ItemType Item
    {
        get => itemField;
        set => itemField = value;
    }
}