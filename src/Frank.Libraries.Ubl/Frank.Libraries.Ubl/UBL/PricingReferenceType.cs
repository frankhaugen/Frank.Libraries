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
[XmlRoot("PricingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PricingReferenceType
{
    private PriceType[] alternativeConditionPriceField;

    private ItemLocationQuantityType originalItemLocationQuantityField;

    /// <remarks />
    public ItemLocationQuantityType OriginalItemLocationQuantity
    {
        get => originalItemLocationQuantityField;
        set => originalItemLocationQuantityField = value;
    }

    /// <remarks />
    [XmlElement("AlternativeConditionPrice")]
    public PriceType[] AlternativeConditionPrice
    {
        get => alternativeConditionPriceField;
        set => alternativeConditionPriceField = value;
    }
}