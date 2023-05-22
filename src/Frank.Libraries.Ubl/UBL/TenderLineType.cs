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
[XmlRoot("SubTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TenderLineType
{
    private DocumentReferenceType callForTendersDocumentReferenceField;

    private LineReferenceType callForTendersLineReferenceField;

    private ContentUnitQuantityType contentUnitQuantityField;

    private DocumentReferenceType[] documentReferenceField;

    private IDType idField;

    private ItemType itemField;

    private LineExtensionAmountType lineExtensionAmountField;

    private MaximumOrderQuantityType maximumOrderQuantityField;

    private MinimumOrderQuantityType minimumOrderQuantityField;

    private NoteType[] noteField;

    private ItemLocationQuantityType[] offeredItemLocationQuantityField;

    private OrderableUnitType orderableUnitField;

    private OrderQuantityIncrementNumericType orderQuantityIncrementNumericField;

    private PackLevelCodeType packLevelCodeField;

    private QuantityType2 quantityField;

    private RelatedItemType[] replacementRelatedItemField;

    private TenderLineType[] subTenderLineField;

    private TotalTaxAmountType totalTaxAmountField;

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
    public OrderableUnitType OrderableUnit
    {
        get => orderableUnitField;
        set => orderableUnitField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContentUnitQuantityType ContentUnitQuantity
    {
        get => contentUnitQuantityField;
        set => contentUnitQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OrderQuantityIncrementNumericType OrderQuantityIncrementNumeric
    {
        get => orderQuantityIncrementNumericField;
        set => orderQuantityIncrementNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumOrderQuantityType MinimumOrderQuantity
    {
        get => minimumOrderQuantityField;
        set => minimumOrderQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumOrderQuantityType MaximumOrderQuantity
    {
        get => maximumOrderQuantityField;
        set => maximumOrderQuantityField = value;
    }

    /// <remarks />
    [XmlElement("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public WarrantyInformationType[] WarrantyInformation
    {
        get => warrantyInformationField;
        set => warrantyInformationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackLevelCodeType PackLevelCode
    {
        get => packLevelCodeField;
        set => packLevelCodeField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    public ItemType Item
    {
        get => itemField;
        set => itemField = value;
    }

    /// <remarks />
    [XmlElement("OfferedItemLocationQuantity")]
    public ItemLocationQuantityType[] OfferedItemLocationQuantity
    {
        get => offeredItemLocationQuantityField;
        set => offeredItemLocationQuantityField = value;
    }

    /// <remarks />
    [XmlElement("ReplacementRelatedItem")]
    public RelatedItemType[] ReplacementRelatedItem
    {
        get => replacementRelatedItemField;
        set => replacementRelatedItemField = value;
    }

    /// <remarks />
    public PartyType WarrantyParty
    {
        get => warrantyPartyField;
        set => warrantyPartyField = value;
    }

    /// <remarks />
    public PeriodType WarrantyValidityPeriod
    {
        get => warrantyValidityPeriodField;
        set => warrantyValidityPeriodField = value;
    }

    /// <remarks />
    [XmlElement("SubTenderLine")]
    public TenderLineType[] SubTenderLine
    {
        get => subTenderLineField;
        set => subTenderLineField = value;
    }

    /// <remarks />
    public LineReferenceType CallForTendersLineReference
    {
        get => callForTendersLineReferenceField;
        set => callForTendersLineReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType CallForTendersDocumentReference
    {
        get => callForTendersDocumentReferenceField;
        set => callForTendersDocumentReferenceField = value;
    }
}