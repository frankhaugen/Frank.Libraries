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

        private DescriptionType[] descriptionField;

        private PackQuantityType packQuantityField;

        private PackSizeNumericType packSizeNumericField;

        private CatalogueIndicatorType catalogueIndicatorField;

        private NameType1 nameField;

        private HazardousRiskIndicatorType hazardousRiskIndicatorField;

        private AdditionalInformationType[] additionalInformationField;

        private KeywordType[] keywordField;

        private BrandNameType[] brandNameField;

        private ModelNameType[] modelNameField;

        private ItemIdentificationType buyersItemIdentificationField;

        private ItemIdentificationType sellersItemIdentificationField;

        private ItemIdentificationType[] manufacturersItemIdentificationField;

        private ItemIdentificationType standardItemIdentificationField;

        private ItemIdentificationType catalogueItemIdentificationField;

        private ItemIdentificationType[] additionalItemIdentificationField;

        private DocumentReferenceType catalogueDocumentReferenceField;

        private DocumentReferenceType[] itemSpecificationDocumentReferenceField;

        private CountryType originCountryField;

        private CommodityClassificationType[] commodityClassificationField;

        private TransactionConditionsType[] transactionConditionsField;

        private HazardousItemType[] hazardousItemField;

        private TaxCategoryType[] classifiedTaxCategoryField;

        private ItemPropertyType[] additionalItemPropertyField;

        private PartyType[] manufacturerPartyField;

        private PartyType informationContentProviderPartyField;

        private AddressType[] originAddressField;

        private ItemInstanceType[] itemInstanceField;

        private CertificateType[] certificateField;

        private DimensionType[] dimensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackQuantityType PackQuantity
        {
            get
            {
                return packQuantityField;
            }
            set
            {
                packQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackSizeNumericType PackSizeNumeric
        {
            get
            {
                return packSizeNumericField;
            }
            set
            {
                packSizeNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CatalogueIndicatorType CatalogueIndicator
        {
            get
            {
                return catalogueIndicatorField;
            }
            set
            {
                catalogueIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return hazardousRiskIndicatorField;
            }
            set
            {
                hazardousRiskIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalInformationType[] AdditionalInformation
        {
            get
            {
                return additionalInformationField;
            }
            set
            {
                additionalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keyword", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public KeywordType[] Keyword
        {
            get
            {
                return keywordField;
            }
            set
            {
                keywordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BrandName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BrandNameType[] BrandName
        {
            get
            {
                return brandNameField;
            }
            set
            {
                brandNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ModelName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ModelNameType[] ModelName
        {
            get
            {
                return modelNameField;
            }
            set
            {
                modelNameField = value;
            }
        }

        /// <remarks/>
        public ItemIdentificationType BuyersItemIdentification
        {
            get
            {
                return buyersItemIdentificationField;
            }
            set
            {
                buyersItemIdentificationField = value;
            }
        }

        /// <remarks/>
        public ItemIdentificationType SellersItemIdentification
        {
            get
            {
                return sellersItemIdentificationField;
            }
            set
            {
                sellersItemIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturersItemIdentification")]
        public ItemIdentificationType[] ManufacturersItemIdentification
        {
            get
            {
                return manufacturersItemIdentificationField;
            }
            set
            {
                manufacturersItemIdentificationField = value;
            }
        }

        /// <remarks/>
        public ItemIdentificationType StandardItemIdentification
        {
            get
            {
                return standardItemIdentificationField;
            }
            set
            {
                standardItemIdentificationField = value;
            }
        }

        /// <remarks/>
        public ItemIdentificationType CatalogueItemIdentification
        {
            get
            {
                return catalogueItemIdentificationField;
            }
            set
            {
                catalogueItemIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemIdentification")]
        public ItemIdentificationType[] AdditionalItemIdentification
        {
            get
            {
                return additionalItemIdentificationField;
            }
            set
            {
                additionalItemIdentificationField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType CatalogueDocumentReference
        {
            get
            {
                return catalogueDocumentReferenceField;
            }
            set
            {
                catalogueDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemSpecificationDocumentReference")]
        public DocumentReferenceType[] ItemSpecificationDocumentReference
        {
            get
            {
                return itemSpecificationDocumentReferenceField;
            }
            set
            {
                itemSpecificationDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public CountryType OriginCountry
        {
            get
            {
                return originCountryField;
            }
            set
            {
                originCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommodityClassification")]
        public CommodityClassificationType[] CommodityClassification
        {
            get
            {
                return commodityClassificationField;
            }
            set
            {
                commodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransactionConditions")]
        public TransactionConditionsType[] TransactionConditions
        {
            get
            {
                return transactionConditionsField;
            }
            set
            {
                transactionConditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousItem")]
        public HazardousItemType[] HazardousItem
        {
            get
            {
                return hazardousItemField;
            }
            set
            {
                hazardousItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClassifiedTaxCategory")]
        public TaxCategoryType[] ClassifiedTaxCategory
        {
            get
            {
                return classifiedTaxCategoryField;
            }
            set
            {
                classifiedTaxCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty")]
        public ItemPropertyType[] AdditionalItemProperty
        {
            get
            {
                return additionalItemPropertyField;
            }
            set
            {
                additionalItemPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturerParty")]
        public PartyType[] ManufacturerParty
        {
            get
            {
                return manufacturerPartyField;
            }
            set
            {
                manufacturerPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType InformationContentProviderParty
        {
            get
            {
                return informationContentProviderPartyField;
            }
            set
            {
                informationContentProviderPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OriginAddress")]
        public AddressType[] OriginAddress
        {
            get
            {
                return originAddressField;
            }
            set
            {
                originAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemInstance")]
        public ItemInstanceType[] ItemInstance
        {
            get
            {
                return itemInstanceField;
            }
            set
            {
                itemInstanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Certificate")]
        public CertificateType[] Certificate
        {
            get
            {
                return certificateField;
            }
            set
            {
                certificateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dimension")]
        public DimensionType[] Dimension
        {
            get
            {
                return dimensionField;
            }
            set
            {
                dimensionField = value;
            }
        }
    }
}