namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemType
    {

        private DescriptionType[] _descriptionField;

        private PackQuantityType _packQuantityField;

        private PackSizeNumericType _packSizeNumericField;

        private CatalogueIndicatorType _catalogueIndicatorField;

        private NameType1 _nameField;

        private HazardousRiskIndicatorType _hazardousRiskIndicatorField;

        private AdditionalInformationType[] _additionalInformationField;

        private KeywordType[] _keywordField;

        private BrandNameType[] _brandNameField;

        private ModelNameType[] _modelNameField;

        private ItemIdentificationType _buyersItemIdentificationField;

        private ItemIdentificationType _sellersItemIdentificationField;

        private ItemIdentificationType[] _manufacturersItemIdentificationField;

        private ItemIdentificationType _standardItemIdentificationField;

        private ItemIdentificationType _catalogueItemIdentificationField;

        private ItemIdentificationType[] _additionalItemIdentificationField;

        private DocumentReferenceType _catalogueDocumentReferenceField;

        private DocumentReferenceType[] _itemSpecificationDocumentReferenceField;

        private CountryType _originCountryField;

        private CommodityClassificationType[] _commodityClassificationField;

        private TransactionConditionsType[] _transactionConditionsField;

        private HazardousItemType[] _hazardousItemField;

        private TaxCategoryType[] _classifiedTaxCategoryField;

        private ItemPropertyType[] _additionalItemPropertyField;

        private PartyType[] _manufacturerPartyField;

        private PartyType _informationContentProviderPartyField;

        private AddressType[] _originAddressField;

        private ItemInstanceType[] _itemInstanceField;

        private CertificateType[] _certificateField;

        private DimensionType[] _dimensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackQuantityType PackQuantity
        {
            get
            {
                return _packQuantityField;
            }
            set
            {
                _packQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackSizeNumericType PackSizeNumeric
        {
            get
            {
                return _packSizeNumericField;
            }
            set
            {
                _packSizeNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CatalogueIndicatorType CatalogueIndicator
        {
            get
            {
                return _catalogueIndicatorField;
            }
            set
            {
                _catalogueIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name
        {
            get
            {
                return _nameField;
            }
            set
            {
                _nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return _hazardousRiskIndicatorField;
            }
            set
            {
                _hazardousRiskIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalInformationType[] AdditionalInformation
        {
            get
            {
                return _additionalInformationField;
            }
            set
            {
                _additionalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keyword", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public KeywordType[] Keyword
        {
            get
            {
                return _keywordField;
            }
            set
            {
                _keywordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BrandName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BrandNameType[] BrandName
        {
            get
            {
                return _brandNameField;
            }
            set
            {
                _brandNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ModelName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ModelNameType[] ModelName
        {
            get
            {
                return _modelNameField;
            }
            set
            {
                _modelNameField = value;
            }
        }

        /// <remarks/>
        public ItemIdentificationType BuyersItemIdentification
        {
            get
            {
                return _buyersItemIdentificationField;
            }
            set
            {
                _buyersItemIdentificationField = value;
            }
        }

        /// <remarks/>
        public ItemIdentificationType SellersItemIdentification
        {
            get
            {
                return _sellersItemIdentificationField;
            }
            set
            {
                _sellersItemIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturersItemIdentification")]
        public ItemIdentificationType[] ManufacturersItemIdentification
        {
            get
            {
                return _manufacturersItemIdentificationField;
            }
            set
            {
                _manufacturersItemIdentificationField = value;
            }
        }

        /// <remarks/>
        public ItemIdentificationType StandardItemIdentification
        {
            get
            {
                return _standardItemIdentificationField;
            }
            set
            {
                _standardItemIdentificationField = value;
            }
        }

        /// <remarks/>
        public ItemIdentificationType CatalogueItemIdentification
        {
            get
            {
                return _catalogueItemIdentificationField;
            }
            set
            {
                _catalogueItemIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemIdentification")]
        public ItemIdentificationType[] AdditionalItemIdentification
        {
            get
            {
                return _additionalItemIdentificationField;
            }
            set
            {
                _additionalItemIdentificationField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType CatalogueDocumentReference
        {
            get
            {
                return _catalogueDocumentReferenceField;
            }
            set
            {
                _catalogueDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemSpecificationDocumentReference")]
        public DocumentReferenceType[] ItemSpecificationDocumentReference
        {
            get
            {
                return _itemSpecificationDocumentReferenceField;
            }
            set
            {
                _itemSpecificationDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public CountryType OriginCountry
        {
            get
            {
                return _originCountryField;
            }
            set
            {
                _originCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommodityClassification")]
        public CommodityClassificationType[] CommodityClassification
        {
            get
            {
                return _commodityClassificationField;
            }
            set
            {
                _commodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransactionConditions")]
        public TransactionConditionsType[] TransactionConditions
        {
            get
            {
                return _transactionConditionsField;
            }
            set
            {
                _transactionConditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousItem")]
        public HazardousItemType[] HazardousItem
        {
            get
            {
                return _hazardousItemField;
            }
            set
            {
                _hazardousItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClassifiedTaxCategory")]
        public TaxCategoryType[] ClassifiedTaxCategory
        {
            get
            {
                return _classifiedTaxCategoryField;
            }
            set
            {
                _classifiedTaxCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty")]
        public ItemPropertyType[] AdditionalItemProperty
        {
            get
            {
                return _additionalItemPropertyField;
            }
            set
            {
                _additionalItemPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturerParty")]
        public PartyType[] ManufacturerParty
        {
            get
            {
                return _manufacturerPartyField;
            }
            set
            {
                _manufacturerPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType InformationContentProviderParty
        {
            get
            {
                return _informationContentProviderPartyField;
            }
            set
            {
                _informationContentProviderPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OriginAddress")]
        public AddressType[] OriginAddress
        {
            get
            {
                return _originAddressField;
            }
            set
            {
                _originAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemInstance")]
        public ItemInstanceType[] ItemInstance
        {
            get
            {
                return _itemInstanceField;
            }
            set
            {
                _itemInstanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Certificate")]
        public CertificateType[] Certificate
        {
            get
            {
                return _certificateField;
            }
            set
            {
                _certificateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dimension")]
        public DimensionType[] Dimension
        {
            get
            {
                return _dimensionField;
            }
            set
            {
                _dimensionField = value;
            }
        }
    }
}