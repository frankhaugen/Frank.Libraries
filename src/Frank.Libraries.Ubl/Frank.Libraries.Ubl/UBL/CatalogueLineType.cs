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
[XmlRoot("CatalogueLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class CatalogueLineType
{
    private RelatedItemType[] accessoryRelatedItemField;

    private ActionCodeType actionCodeField;

    private DocumentReferenceType callForTendersDocumentReferenceField;

    private LineReferenceType callForTendersLineReferenceField;

    private RelatedItemType[] complementaryRelatedItemField;

    private RelatedItemType[] componentRelatedItemField;

    private ContentUnitQuantityType contentUnitQuantityField;

    private CustomerPartyType contractorCustomerPartyField;

    private ContractSubdivisionType contractSubdivisionField;

    private DocumentReferenceType[] documentReferenceField;

    private IDType idField;

    private ItemComparisonType[] itemComparisonField;

    private ItemType itemField;

    private ItemPropertyType[] keywordItemPropertyField;

    private LifeCycleStatusCodeType lifeCycleStatusCodeField;

    private PeriodType lineValidityPeriodField;

    private MaximumOrderQuantityType maximumOrderQuantityField;

    private MinimumOrderQuantityType minimumOrderQuantityField;

    private NoteType[] noteField;

    private OrderableIndicatorType orderableIndicatorField;

    private OrderableUnitType orderableUnitField;

    private OrderQuantityIncrementNumericType orderQuantityIncrementNumericField;

    private PackLevelCodeType packLevelCodeField;

    private RelatedItemType[] replacedRelatedItemField;

    private RelatedItemType[] replacementRelatedItemField;

    private ItemLocationQuantityType[] requiredItemLocationQuantityField;

    private RelatedItemType[] requiredRelatedItemField;

    private SupplierPartyType sellerSupplierPartyField;

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
    public ActionCodeType ActionCode
    {
        get => actionCodeField;
        set => actionCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LifeCycleStatusCodeType LifeCycleStatusCode
    {
        get => lifeCycleStatusCodeField;
        set => lifeCycleStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractSubdivisionType ContractSubdivision
    {
        get => contractSubdivisionField;
        set => contractSubdivisionField = value;
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
    public OrderableIndicatorType OrderableIndicator
    {
        get => orderableIndicatorField;
        set => orderableIndicatorField = value;
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
    public CustomerPartyType ContractorCustomerParty
    {
        get => contractorCustomerPartyField;
        set => contractorCustomerPartyField = value;
    }

    /// <remarks />
    public SupplierPartyType SellerSupplierParty
    {
        get => sellerSupplierPartyField;
        set => sellerSupplierPartyField = value;
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
    public PeriodType LineValidityPeriod
    {
        get => lineValidityPeriodField;
        set => lineValidityPeriodField = value;
    }

    /// <remarks />
    [XmlElement("ItemComparison")]
    public ItemComparisonType[] ItemComparison
    {
        get => itemComparisonField;
        set => itemComparisonField = value;
    }

    /// <remarks />
    [XmlElement("ComponentRelatedItem")]
    public RelatedItemType[] ComponentRelatedItem
    {
        get => componentRelatedItemField;
        set => componentRelatedItemField = value;
    }

    /// <remarks />
    [XmlElement("AccessoryRelatedItem")]
    public RelatedItemType[] AccessoryRelatedItem
    {
        get => accessoryRelatedItemField;
        set => accessoryRelatedItemField = value;
    }

    /// <remarks />
    [XmlElement("RequiredRelatedItem")]
    public RelatedItemType[] RequiredRelatedItem
    {
        get => requiredRelatedItemField;
        set => requiredRelatedItemField = value;
    }

    /// <remarks />
    [XmlElement("ReplacementRelatedItem")]
    public RelatedItemType[] ReplacementRelatedItem
    {
        get => replacementRelatedItemField;
        set => replacementRelatedItemField = value;
    }

    /// <remarks />
    [XmlElement("ComplementaryRelatedItem")]
    public RelatedItemType[] ComplementaryRelatedItem
    {
        get => complementaryRelatedItemField;
        set => complementaryRelatedItemField = value;
    }

    /// <remarks />
    [XmlElement("ReplacedRelatedItem")]
    public RelatedItemType[] ReplacedRelatedItem
    {
        get => replacedRelatedItemField;
        set => replacedRelatedItemField = value;
    }

    /// <remarks />
    [XmlElement("RequiredItemLocationQuantity")]
    public ItemLocationQuantityType[] RequiredItemLocationQuantity
    {
        get => requiredItemLocationQuantityField;
        set => requiredItemLocationQuantityField = value;
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
    [XmlElement("KeywordItemProperty")]
    public ItemPropertyType[] KeywordItemProperty
    {
        get => keywordItemPropertyField;
        set => keywordItemPropertyField = value;
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