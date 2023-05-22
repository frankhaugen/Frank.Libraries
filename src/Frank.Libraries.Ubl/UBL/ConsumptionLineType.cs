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
[XmlRoot("ConsumptionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ConsumptionLineType
{
    private AllowanceChargeType[] allowanceChargeField;

    private DeliveryType[] deliveryField;

    private IDType idField;

    private InvoicedQuantityType invoicedQuantityField;

    private LineExtensionAmountType lineExtensionAmountField;

    private ParentDocumentLineReferenceIDType parentDocumentLineReferenceIDField;

    private PeriodType periodField;

    private PriceType priceField;

    private TaxTotalType[] taxTotalField;

    private UnstructuredPriceType unstructuredPriceField;

    private UtilityItemType utilityItemField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ParentDocumentLineReferenceIDType ParentDocumentLineReferenceID
    {
        get => parentDocumentLineReferenceIDField;
        set => parentDocumentLineReferenceIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InvoicedQuantityType InvoicedQuantity
    {
        get => invoicedQuantityField;
        set => invoicedQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineExtensionAmountType LineExtensionAmount
    {
        get => lineExtensionAmountField;
        set => lineExtensionAmountField = value;
    }

    /// <remarks />
    public PeriodType Period
    {
        get => periodField;
        set => periodField = value;
    }

    /// <remarks />
    [XmlElement("Delivery")]
    public DeliveryType[] Delivery
    {
        get => deliveryField;
        set => deliveryField = value;
    }

    /// <remarks />
    [XmlElement("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge
    {
        get => allowanceChargeField;
        set => allowanceChargeField = value;
    }

    /// <remarks />
    [XmlElement("TaxTotal")]
    public TaxTotalType[] TaxTotal
    {
        get => taxTotalField;
        set => taxTotalField = value;
    }

    /// <remarks />
    public UtilityItemType UtilityItem
    {
        get => utilityItemField;
        set => utilityItemField = value;
    }

    /// <remarks />
    public PriceType Price
    {
        get => priceField;
        set => priceField = value;
    }

    /// <remarks />
    public UnstructuredPriceType UnstructuredPrice
    {
        get => unstructuredPriceField;
        set => unstructuredPriceField = value;
    }
}