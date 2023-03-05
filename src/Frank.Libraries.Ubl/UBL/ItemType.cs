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
[XmlRoot("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ItemType
{
    private AdditionalInformationType[] additionalInformationField;

    private ItemIdentificationType[] additionalItemIdentificationField;

    private ItemPropertyType[] additionalItemPropertyField;

    private BrandNameType[] brandNameField;

    private ItemIdentificationType buyersItemIdentificationField;

    private DocumentReferenceType catalogueDocumentReferenceField;

    private CatalogueIndicatorType catalogueIndicatorField;

    private ItemIdentificationType catalogueItemIdentificationField;

    private CertificateType[] certificateField;

    private TaxCategoryType[] classifiedTaxCategoryField;

    private CommodityClassificationType[] commodityClassificationField;

    private DescriptionType[] descriptionField;

    private DimensionType[] dimensionField;

    private HazardousItemType[] hazardousItemField;

    private HazardousRiskIndicatorType hazardousRiskIndicatorField;

    private PartyType informationContentProviderPartyField;

    private ItemInstanceType[] itemInstanceField;

    private DocumentReferenceType[] itemSpecificationDocumentReferenceField;

    private KeywordType[] keywordField;

    private PartyType[] manufacturerPartyField;

    private ItemIdentificationType[] manufacturersItemIdentificationField;

    private ModelNameType[] modelNameField;

    private NameType1 nameField;

    private AddressType[] originAddressField;

    private CountryType originCountryField;

    private PackQuantityType packQuantityField;

    private PackSizeNumericType packSizeNumericField;

    private ItemIdentificationType sellersItemIdentificationField;

    private ItemIdentificationType standardItemIdentificationField;

    private TransactionConditionsType[] transactionConditionsField;

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackQuantityType PackQuantity
    {
        get => packQuantityField;
        set => packQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackSizeNumericType PackSizeNumeric
    {
        get => packSizeNumericField;
        set => packSizeNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CatalogueIndicatorType CatalogueIndicator
    {
        get => catalogueIndicatorField;
        set => catalogueIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousRiskIndicatorType HazardousRiskIndicator
    {
        get => hazardousRiskIndicatorField;
        set => hazardousRiskIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdditionalInformationType[] AdditionalInformation
    {
        get => additionalInformationField;
        set => additionalInformationField = value;
    }

    /// <remarks />
    [XmlElement("Keyword", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public KeywordType[] Keyword
    {
        get => keywordField;
        set => keywordField = value;
    }

    /// <remarks />
    [XmlElement("BrandName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BrandNameType[] BrandName
    {
        get => brandNameField;
        set => brandNameField = value;
    }

    /// <remarks />
    [XmlElement("ModelName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ModelNameType[] ModelName
    {
        get => modelNameField;
        set => modelNameField = value;
    }

    /// <remarks />
    public ItemIdentificationType BuyersItemIdentification
    {
        get => buyersItemIdentificationField;
        set => buyersItemIdentificationField = value;
    }

    /// <remarks />
    public ItemIdentificationType SellersItemIdentification
    {
        get => sellersItemIdentificationField;
        set => sellersItemIdentificationField = value;
    }

    /// <remarks />
    [XmlElement("ManufacturersItemIdentification")]
    public ItemIdentificationType[] ManufacturersItemIdentification
    {
        get => manufacturersItemIdentificationField;
        set => manufacturersItemIdentificationField = value;
    }

    /// <remarks />
    public ItemIdentificationType StandardItemIdentification
    {
        get => standardItemIdentificationField;
        set => standardItemIdentificationField = value;
    }

    /// <remarks />
    public ItemIdentificationType CatalogueItemIdentification
    {
        get => catalogueItemIdentificationField;
        set => catalogueItemIdentificationField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalItemIdentification")]
    public ItemIdentificationType[] AdditionalItemIdentification
    {
        get => additionalItemIdentificationField;
        set => additionalItemIdentificationField = value;
    }

    /// <remarks />
    public DocumentReferenceType CatalogueDocumentReference
    {
        get => catalogueDocumentReferenceField;
        set => catalogueDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("ItemSpecificationDocumentReference")]
    public DocumentReferenceType[] ItemSpecificationDocumentReference
    {
        get => itemSpecificationDocumentReferenceField;
        set => itemSpecificationDocumentReferenceField = value;
    }

    /// <remarks />
    public CountryType OriginCountry
    {
        get => originCountryField;
        set => originCountryField = value;
    }

    /// <remarks />
    [XmlElement("CommodityClassification")]
    public CommodityClassificationType[] CommodityClassification
    {
        get => commodityClassificationField;
        set => commodityClassificationField = value;
    }

    /// <remarks />
    [XmlElement("TransactionConditions")]
    public TransactionConditionsType[] TransactionConditions
    {
        get => transactionConditionsField;
        set => transactionConditionsField = value;
    }

    /// <remarks />
    [XmlElement("HazardousItem")]
    public HazardousItemType[] HazardousItem
    {
        get => hazardousItemField;
        set => hazardousItemField = value;
    }

    /// <remarks />
    [XmlElement("ClassifiedTaxCategory")]
    public TaxCategoryType[] ClassifiedTaxCategory
    {
        get => classifiedTaxCategoryField;
        set => classifiedTaxCategoryField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalItemProperty")]
    public ItemPropertyType[] AdditionalItemProperty
    {
        get => additionalItemPropertyField;
        set => additionalItemPropertyField = value;
    }

    /// <remarks />
    [XmlElement("ManufacturerParty")]
    public PartyType[] ManufacturerParty
    {
        get => manufacturerPartyField;
        set => manufacturerPartyField = value;
    }

    /// <remarks />
    public PartyType InformationContentProviderParty
    {
        get => informationContentProviderPartyField;
        set => informationContentProviderPartyField = value;
    }

    /// <remarks />
    [XmlElement("OriginAddress")]
    public AddressType[] OriginAddress
    {
        get => originAddressField;
        set => originAddressField = value;
    }

    /// <remarks />
    [XmlElement("ItemInstance")]
    public ItemInstanceType[] ItemInstance
    {
        get => itemInstanceField;
        set => itemInstanceField = value;
    }

    /// <remarks />
    [XmlElement("Certificate")]
    public CertificateType[] Certificate
    {
        get => certificateField;
        set => certificateField = value;
    }

    /// <remarks />
    [XmlElement("Dimension")]
    public DimensionType[] Dimension
    {
        get => dimensionField;
        set => dimensionField = value;
    }
}