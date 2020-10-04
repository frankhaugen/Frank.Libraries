using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRoot("Item", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class ItemType {
    
        /// <remarks/>
        [XmlElement("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackQuantityType PackQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackSizeNumericType PackSizeNumeric;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CatalogueIndicatorType CatalogueIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator;
    
        /// <remarks/>
        [XmlElement("AdditionalInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalInformationType[] AdditionalInformation;
    
        /// <remarks/>
        [XmlElement("Keyword", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public KeywordType[] Keyword;
    
        /// <remarks/>
        [XmlElement("BrandName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BrandNameType[] BrandName;
    
        /// <remarks/>
        [XmlElement("ModelName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ModelNameType[] ModelName;
    
        /// <remarks/>
        public ItemIdentificationType BuyersItemIdentification;
    
        /// <remarks/>
        public ItemIdentificationType SellersItemIdentification;
    
        /// <remarks/>
        [XmlElement("ManufacturersItemIdentification")]
        public ItemIdentificationType[] ManufacturersItemIdentification;
    
        /// <remarks/>
        public ItemIdentificationType StandardItemIdentification;
    
        /// <remarks/>
        public ItemIdentificationType CatalogueItemIdentification;
    
        /// <remarks/>
        [XmlElement("AdditionalItemIdentification")]
        public ItemIdentificationType[] AdditionalItemIdentification;
    
        /// <remarks/>
        public DocumentReferenceType CatalogueDocumentReference;
    
        /// <remarks/>
        [XmlElement("ItemSpecificationDocumentReference")]
        public DocumentReferenceType[] ItemSpecificationDocumentReference;
    
        /// <remarks/>
        public CountryType OriginCountry;
    
        /// <remarks/>
        [XmlElement("CommodityClassification")]
        public CommodityClassificationType[] CommodityClassification;
    
        /// <remarks/>
        [XmlElement("TransactionConditions")]
        public TransactionConditionsType[] TransactionConditions;
    
        /// <remarks/>
        [XmlElement("HazardousItem")]
        public HazardousItemType[] HazardousItem;
    
        /// <remarks/>
        [XmlElement("ClassifiedTaxCategory")]
        public TaxCategoryType[] ClassifiedTaxCategory;
    
        /// <remarks/>
        [XmlElement("AdditionalItemProperty")]
        public ItemPropertyType[] AdditionalItemProperty;
    
        /// <remarks/>
        [XmlElement("ManufacturerParty")]
        public PartyType[] ManufacturerParty;
    
        /// <remarks/>
        public PartyType InformationContentProviderParty;
    
        /// <remarks/>
        [XmlElement("OriginAddress")]
        public AddressType[] OriginAddress;
    
        /// <remarks/>
        [XmlElement("ItemInstance")]
        public ItemInstanceType[] ItemInstance;
    
        /// <remarks/>
        [XmlElement("Certificate")]
        public CertificateType[] Certificate;
    
        /// <remarks/>
        [XmlElement("Dimension")]
        public DimensionType[] Dimension;
    }
}