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
[XmlRoot("RequestForTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class RequestForTenderLineType
{
    private PeriodType[] deliveryPeriodField;

    private DocumentReferenceType[] documentReferenceField;

    private EstimatedAmountType estimatedAmountField;

    private IDType idField;

    private ItemType itemField;

    private MaximumAmountType maximumAmountField;

    private MaximumQuantityType maximumQuantityField;

    private MinimumAmountType minimumAmountField;

    private MinimumQuantityType minimumQuantityField;

    private NoteType[] noteField;

    private QuantityType2 quantityField;

    private ItemLocationQuantityType[] requiredItemLocationQuantityField;

    private RequestForTenderLineType[] subRequestForTenderLineField;

    private TaxIncludedIndicatorType taxIncludedIndicatorField;

    private UUIDType uUIDField;

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
    public QuantityType2 Quantity
    {
        get => quantityField;
        set => quantityField = value;
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
    public TaxIncludedIndicatorType TaxIncludedIndicator
    {
        get => taxIncludedIndicatorField;
        set => taxIncludedIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumAmountType MinimumAmount
    {
        get => minimumAmountField;
        set => minimumAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumAmountType MaximumAmount
    {
        get => maximumAmountField;
        set => maximumAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedAmountType EstimatedAmount
    {
        get => estimatedAmountField;
        set => estimatedAmountField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("DeliveryPeriod")]
    public PeriodType[] DeliveryPeriod
    {
        get => deliveryPeriodField;
        set => deliveryPeriodField = value;
    }

    /// <remarks />
    [XmlElement("RequiredItemLocationQuantity")]
    public ItemLocationQuantityType[] RequiredItemLocationQuantity
    {
        get => requiredItemLocationQuantityField;
        set => requiredItemLocationQuantityField = value;
    }

    /// <remarks />
    public PeriodType WarrantyValidityPeriod
    {
        get => warrantyValidityPeriodField;
        set => warrantyValidityPeriodField = value;
    }

    /// <remarks />
    public ItemType Item
    {
        get => itemField;
        set => itemField = value;
    }

    /// <remarks />
    [XmlElement("SubRequestForTenderLine")]
    public RequestForTenderLineType[] SubRequestForTenderLine
    {
        get => subRequestForTenderLineField;
        set => subRequestForTenderLineField = value;
    }
}