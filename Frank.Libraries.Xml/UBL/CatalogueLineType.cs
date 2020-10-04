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
    [XmlRoot("CatalogueLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class CatalogueLineType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActionCodeType ActionCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LifeCycleStatusCodeType LifeCycleStatusCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractSubdivisionType ContractSubdivision;
    
        /// <remarks/>
        [XmlElement("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderableIndicatorType OrderableIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderableUnitType OrderableUnit;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContentUnitQuantityType ContentUnitQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderQuantityIncrementNumericType OrderQuantityIncrementNumeric;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumOrderQuantityType MinimumOrderQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumOrderQuantityType MaximumOrderQuantity;
    
        /// <remarks/>
        [XmlElement("WarrantyInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WarrantyInformationType[] WarrantyInformation;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackLevelCodeType PackLevelCode;
    
        /// <remarks/>
        public CustomerPartyType ContractorCustomerParty;
    
        /// <remarks/>
        public SupplierPartyType SellerSupplierParty;
    
        /// <remarks/>
        public PartyType WarrantyParty;
    
        /// <remarks/>
        public PeriodType WarrantyValidityPeriod;
    
        /// <remarks/>
        public PeriodType LineValidityPeriod;
    
        /// <remarks/>
        [XmlElement("ItemComparison")]
        public ItemComparisonType[] ItemComparison;
    
        /// <remarks/>
        [XmlElement("ComponentRelatedItem")]
        public RelatedItemType[] ComponentRelatedItem;
    
        /// <remarks/>
        [XmlElement("AccessoryRelatedItem")]
        public RelatedItemType[] AccessoryRelatedItem;
    
        /// <remarks/>
        [XmlElement("RequiredRelatedItem")]
        public RelatedItemType[] RequiredRelatedItem;
    
        /// <remarks/>
        [XmlElement("ReplacementRelatedItem")]
        public RelatedItemType[] ReplacementRelatedItem;
    
        /// <remarks/>
        [XmlElement("ComplementaryRelatedItem")]
        public RelatedItemType[] ComplementaryRelatedItem;
    
        /// <remarks/>
        [XmlElement("ReplacedRelatedItem")]
        public RelatedItemType[] ReplacedRelatedItem;
    
        /// <remarks/>
        [XmlElement("RequiredItemLocationQuantity")]
        public ItemLocationQuantityType[] RequiredItemLocationQuantity;
    
        /// <remarks/>
        [XmlElement("DocumentReference")]
        public DocumentReferenceType[] DocumentReference;
    
        /// <remarks/>
        public ItemType Item;
    
        /// <remarks/>
        [XmlElement("KeywordItemProperty")]
        public ItemPropertyType[] KeywordItemProperty;
    
        /// <remarks/>
        public LineReferenceType CallForTendersLineReference;
    
        /// <remarks/>
        public DocumentReferenceType CallForTendersDocumentReference;
    }
}