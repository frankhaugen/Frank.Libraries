namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AlternativeLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class LineItemType
{

    private IDType idField;

    private SalesOrderIDType salesOrderIDField;

    private UUIDType uUIDField;

    private NoteType[] noteField;

    private LineStatusCodeType lineStatusCodeField;

    private QuantityType2 quantityField;

    private LineExtensionAmountType lineExtensionAmountField;

    private TotalTaxAmountType totalTaxAmountField;

    private MinimumQuantityType minimumQuantityField;

    private MaximumQuantityType maximumQuantityField;

    private MinimumBackorderQuantityType minimumBackorderQuantityField;

    private MaximumBackorderQuantityType maximumBackorderQuantityField;

    private InspectionMethodCodeType inspectionMethodCodeField;

    private PartialDeliveryIndicatorType partialDeliveryIndicatorField;

    private BackOrderAllowedIndicatorType backOrderAllowedIndicatorField;

    private AccountingCostCodeType accountingCostCodeField;

    private AccountingCostType accountingCostField;

    private WarrantyInformationType[] warrantyInformationField;

    private DeliveryType[] deliveryField;

    private DeliveryTermsType deliveryTermsField;

    private PartyType originatorPartyField;

    private OrderedShipmentType[] orderedShipmentField;

    private PricingReferenceType pricingReferenceField;

    private AllowanceChargeType[] allowanceChargeField;

    private PriceType priceField;

    private ItemType itemField;

    private LineItemType[] subLineItemField;

    private PeriodType warrantyValidityPeriodField;

    private PartyType warrantyPartyField;

    private TaxTotalType[] taxTotalField;

    private PriceExtensionType itemPriceExtensionField;

    private LineReferenceType[] lineReferenceField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SalesOrderIDType SalesOrderID
    {
        get
        {
            return this.salesOrderIDField;
        }
        set
        {
            this.salesOrderIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get
        {
            return this.uUIDField;
        }
        set
        {
            this.uUIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineStatusCodeType LineStatusCode
    {
        get
        {
            return this.lineStatusCodeField;
        }
        set
        {
            this.lineStatusCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineExtensionAmountType LineExtensionAmount
    {
        get
        {
            return this.lineExtensionAmountField;
        }
        set
        {
            this.lineExtensionAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalTaxAmountType TotalTaxAmount
    {
        get
        {
            return this.totalTaxAmountField;
        }
        set
        {
            this.totalTaxAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumQuantityType MinimumQuantity
    {
        get
        {
            return this.minimumQuantityField;
        }
        set
        {
            this.minimumQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumQuantityType MaximumQuantity
    {
        get
        {
            return this.maximumQuantityField;
        }
        set
        {
            this.maximumQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumBackorderQuantityType MinimumBackorderQuantity
    {
        get
        {
            return this.minimumBackorderQuantityField;
        }
        set
        {
            this.minimumBackorderQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumBackorderQuantityType MaximumBackorderQuantity
    {
        get
        {
            return this.maximumBackorderQuantityField;
        }
        set
        {
            this.maximumBackorderQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InspectionMethodCodeType InspectionMethodCode
    {
        get
        {
            return this.inspectionMethodCodeField;
        }
        set
        {
            this.inspectionMethodCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PartialDeliveryIndicatorType PartialDeliveryIndicator
    {
        get
        {
            return this.partialDeliveryIndicatorField;
        }
        set
        {
            this.partialDeliveryIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BackOrderAllowedIndicatorType BackOrderAllowedIndicator
    {
        get
        {
            return this.backOrderAllowedIndicatorField;
        }
        set
        {
            this.backOrderAllowedIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostCodeType AccountingCostCode
    {
        get
        {
            return this.accountingCostCodeField;
        }
        set
        {
            this.accountingCostCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostType AccountingCost
    {
        get
        {
            return this.accountingCostField;
        }
        set
        {
            this.accountingCostField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public WarrantyInformationType[] WarrantyInformation
    {
        get
        {
            return this.warrantyInformationField;
        }
        set
        {
            this.warrantyInformationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Delivery")]
    public DeliveryType[] Delivery
    {
        get
        {
            return this.deliveryField;
        }
        set
        {
            this.deliveryField = value;
        }
    }

    /// <remarks/>
    public DeliveryTermsType DeliveryTerms
    {
        get
        {
            return this.deliveryTermsField;
        }
        set
        {
            this.deliveryTermsField = value;
        }
    }

    /// <remarks/>
    public PartyType OriginatorParty
    {
        get
        {
            return this.originatorPartyField;
        }
        set
        {
            this.originatorPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OrderedShipment")]
    public OrderedShipmentType[] OrderedShipment
    {
        get
        {
            return this.orderedShipmentField;
        }
        set
        {
            this.orderedShipmentField = value;
        }
    }

    /// <remarks/>
    public PricingReferenceType PricingReference
    {
        get
        {
            return this.pricingReferenceField;
        }
        set
        {
            this.pricingReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge
    {
        get
        {
            return this.allowanceChargeField;
        }
        set
        {
            this.allowanceChargeField = value;
        }
    }

    /// <remarks/>
    public PriceType Price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }

    /// <remarks/>
    public ItemType Item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubLineItem")]
    public LineItemType[] SubLineItem
    {
        get
        {
            return this.subLineItemField;
        }
        set
        {
            this.subLineItemField = value;
        }
    }

    /// <remarks/>
    public PeriodType WarrantyValidityPeriod
    {
        get
        {
            return this.warrantyValidityPeriodField;
        }
        set
        {
            this.warrantyValidityPeriodField = value;
        }
    }

    /// <remarks/>
    public PartyType WarrantyParty
    {
        get
        {
            return this.warrantyPartyField;
        }
        set
        {
            this.warrantyPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
    public TaxTotalType[] TaxTotal
    {
        get
        {
            return this.taxTotalField;
        }
        set
        {
            this.taxTotalField = value;
        }
    }

    /// <remarks/>
    public PriceExtensionType ItemPriceExtension
    {
        get
        {
            return this.itemPriceExtensionField;
        }
        set
        {
            this.itemPriceExtensionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LineReference")]
    public LineReferenceType[] LineReference
    {
        get
        {
            return this.lineReferenceField;
        }
        set
        {
            this.lineReferenceField = value;
        }
    }
}