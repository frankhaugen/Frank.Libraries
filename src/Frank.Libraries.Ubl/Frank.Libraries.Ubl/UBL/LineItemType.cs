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
[XmlRoot("AlternativeLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class LineItemType
{
    private AccountingCostCodeType accountingCostCodeField;

    private AccountingCostType accountingCostField;

    private AllowanceChargeType[] allowanceChargeField;

    private BackOrderAllowedIndicatorType backOrderAllowedIndicatorField;

    private DeliveryType[] deliveryField;

    private DeliveryTermsType deliveryTermsField;

    private IDType idField;

    private InspectionMethodCodeType inspectionMethodCodeField;

    private ItemType itemField;

    private PriceExtensionType itemPriceExtensionField;

    private LineExtensionAmountType lineExtensionAmountField;

    private LineReferenceType[] lineReferenceField;

    private LineStatusCodeType lineStatusCodeField;

    private MaximumBackorderQuantityType maximumBackorderQuantityField;

    private MaximumQuantityType maximumQuantityField;

    private MinimumBackorderQuantityType minimumBackorderQuantityField;

    private MinimumQuantityType minimumQuantityField;

    private NoteType[] noteField;

    private OrderedShipmentType[] orderedShipmentField;

    private PartyType originatorPartyField;

    private PartialDeliveryIndicatorType partialDeliveryIndicatorField;

    private PriceType priceField;

    private PricingReferenceType pricingReferenceField;

    private QuantityType2 quantityField;

    private SalesOrderIDType salesOrderIDField;

    private LineItemType[] subLineItemField;

    private TaxTotalType[] taxTotalField;

    private TotalTaxAmountType totalTaxAmountField;

    private UUIDType uUIDField;

    private WarrantyInformationType[] warrantyInformationField;

    private PartyType warrantyPartyField;

    private PeriodType warrantyValidityPeriodField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SalesOrderIDType SalesOrderID
    {
        get => salesOrderIDField;
        set => salesOrderIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get => uUIDField;
        set => uUIDField = value;
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
    public LineStatusCodeType LineStatusCode
    {
        get => lineStatusCodeField;
        set => lineStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity
    {
        get => quantityField;
        set => quantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineExtensionAmountType LineExtensionAmount
    {
        get => lineExtensionAmountField;
        set => lineExtensionAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalTaxAmountType TotalTaxAmount
    {
        get => totalTaxAmountField;
        set => totalTaxAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumQuantityType MinimumQuantity
    {
        get => minimumQuantityField;
        set => minimumQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumQuantityType MaximumQuantity
    {
        get => maximumQuantityField;
        set => maximumQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumBackorderQuantityType MinimumBackorderQuantity
    {
        get => minimumBackorderQuantityField;
        set => minimumBackorderQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumBackorderQuantityType MaximumBackorderQuantity
    {
        get => maximumBackorderQuantityField;
        set => maximumBackorderQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InspectionMethodCodeType InspectionMethodCode
    {
        get => inspectionMethodCodeField;
        set => inspectionMethodCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PartialDeliveryIndicatorType PartialDeliveryIndicator
    {
        get => partialDeliveryIndicatorField;
        set => partialDeliveryIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BackOrderAllowedIndicatorType BackOrderAllowedIndicator
    {
        get => backOrderAllowedIndicatorField;
        set => backOrderAllowedIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostCodeType AccountingCostCode
    {
        get => accountingCostCodeField;
        set => accountingCostCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostType AccountingCost
    {
        get => accountingCostField;
        set => accountingCostField = value;
    }

    /// <remarks />
    [XmlElement("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public WarrantyInformationType[] WarrantyInformation
    {
        get => warrantyInformationField;
        set => warrantyInformationField = value;
    }

    /// <remarks />
    [XmlElement("Delivery")]
    public DeliveryType[] Delivery
    {
        get => deliveryField;
        set => deliveryField = value;
    }

    /// <remarks />
    public DeliveryTermsType DeliveryTerms
    {
        get => deliveryTermsField;
        set => deliveryTermsField = value;
    }

    /// <remarks />
    public PartyType OriginatorParty
    {
        get => originatorPartyField;
        set => originatorPartyField = value;
    }

    /// <remarks />
    [XmlElement("OrderedShipment")]
    public OrderedShipmentType[] OrderedShipment
    {
        get => orderedShipmentField;
        set => orderedShipmentField = value;
    }

    /// <remarks />
    public PricingReferenceType PricingReference
    {
        get => pricingReferenceField;
        set => pricingReferenceField = value;
    }

    /// <remarks />
    [XmlElement("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge
    {
        get => allowanceChargeField;
        set => allowanceChargeField = value;
    }

    /// <remarks />
    public PriceType Price
    {
        get => priceField;
        set => priceField = value;
    }

    /// <remarks />
    public ItemType Item
    {
        get => itemField;
        set => itemField = value;
    }

    /// <remarks />
    [XmlElement("SubLineItem")]
    public LineItemType[] SubLineItem
    {
        get => subLineItemField;
        set => subLineItemField = value;
    }

    /// <remarks />
    public PeriodType WarrantyValidityPeriod
    {
        get => warrantyValidityPeriodField;
        set => warrantyValidityPeriodField = value;
    }

    /// <remarks />
    public PartyType WarrantyParty
    {
        get => warrantyPartyField;
        set => warrantyPartyField = value;
    }

    /// <remarks />
    [XmlElement("TaxTotal")]
    public TaxTotalType[] TaxTotal
    {
        get => taxTotalField;
        set => taxTotalField = value;
    }

    /// <remarks />
    public PriceExtensionType ItemPriceExtension
    {
        get => itemPriceExtensionField;
        set => itemPriceExtensionField = value;
    }

    /// <remarks />
    [XmlElement("LineReference")]
    public LineReferenceType[] LineReference
    {
        get => lineReferenceField;
        set => lineReferenceField = value;
    }
}