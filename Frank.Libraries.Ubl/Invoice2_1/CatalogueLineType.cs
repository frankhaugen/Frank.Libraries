namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CatalogueLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CatalogueLineType
    {

        private IDType idField;

        private ActionCodeType actionCodeField;

        private LifeCycleStatusCodeType lifeCycleStatusCodeField;

        private ContractSubdivisionType contractSubdivisionField;

        private NoteType[] noteField;

        private OrderableIndicatorType orderableIndicatorField;

        private OrderableUnitType orderableUnitField;

        private ContentUnitQuantityType contentUnitQuantityField;

        private OrderQuantityIncrementNumericType orderQuantityIncrementNumericField;

        private MinimumOrderQuantityType minimumOrderQuantityField;

        private MaximumOrderQuantityType maximumOrderQuantityField;

        private WarrantyInformationType[] warrantyInformationField;

        private PackLevelCodeType packLevelCodeField;

        private CustomerPartyType contractorCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private PartyType warrantyPartyField;

        private PeriodType warrantyValidityPeriodField;

        private PeriodType lineValidityPeriodField;

        private ItemComparisonType[] itemComparisonField;

        private RelatedItemType[] componentRelatedItemField;

        private RelatedItemType[] accessoryRelatedItemField;

        private RelatedItemType[] requiredRelatedItemField;

        private RelatedItemType[] replacementRelatedItemField;

        private RelatedItemType[] complementaryRelatedItemField;

        private RelatedItemType[] replacedRelatedItemField;

        private ItemLocationQuantityType[] requiredItemLocationQuantityField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType itemField;

        private ItemPropertyType[] keywordItemPropertyField;

        private LineReferenceType callForTendersLineReferenceField;

        private DocumentReferenceType callForTendersDocumentReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActionCodeType ActionCode
        {
            get
            {
                return actionCodeField;
            }
            set
            {
                actionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LifeCycleStatusCodeType LifeCycleStatusCode
        {
            get
            {
                return lifeCycleStatusCodeField;
            }
            set
            {
                lifeCycleStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractSubdivisionType ContractSubdivision
        {
            get
            {
                return contractSubdivisionField;
            }
            set
            {
                contractSubdivisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return noteField;
            }
            set
            {
                noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderableIndicatorType OrderableIndicator
        {
            get
            {
                return orderableIndicatorField;
            }
            set
            {
                orderableIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderableUnitType OrderableUnit
        {
            get
            {
                return orderableUnitField;
            }
            set
            {
                orderableUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContentUnitQuantityType ContentUnitQuantity
        {
            get
            {
                return contentUnitQuantityField;
            }
            set
            {
                contentUnitQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderQuantityIncrementNumericType OrderQuantityIncrementNumeric
        {
            get
            {
                return orderQuantityIncrementNumericField;
            }
            set
            {
                orderQuantityIncrementNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumOrderQuantityType MinimumOrderQuantity
        {
            get
            {
                return minimumOrderQuantityField;
            }
            set
            {
                minimumOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumOrderQuantityType MaximumOrderQuantity
        {
            get
            {
                return maximumOrderQuantityField;
            }
            set
            {
                maximumOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WarrantyInformationType[] WarrantyInformation
        {
            get
            {
                return warrantyInformationField;
            }
            set
            {
                warrantyInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackLevelCodeType PackLevelCode
        {
            get
            {
                return packLevelCodeField;
            }
            set
            {
                packLevelCodeField = value;
            }
        }

        /// <remarks/>
        public CustomerPartyType ContractorCustomerParty
        {
            get
            {
                return contractorCustomerPartyField;
            }
            set
            {
                contractorCustomerPartyField = value;
            }
        }

        /// <remarks/>
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return sellerSupplierPartyField;
            }
            set
            {
                sellerSupplierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType WarrantyParty
        {
            get
            {
                return warrantyPartyField;
            }
            set
            {
                warrantyPartyField = value;
            }
        }

        /// <remarks/>
        public PeriodType WarrantyValidityPeriod
        {
            get
            {
                return warrantyValidityPeriodField;
            }
            set
            {
                warrantyValidityPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType LineValidityPeriod
        {
            get
            {
                return lineValidityPeriodField;
            }
            set
            {
                lineValidityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemComparison")]
        public ItemComparisonType[] ItemComparison
        {
            get
            {
                return itemComparisonField;
            }
            set
            {
                itemComparisonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComponentRelatedItem")]
        public RelatedItemType[] ComponentRelatedItem
        {
            get
            {
                return componentRelatedItemField;
            }
            set
            {
                componentRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccessoryRelatedItem")]
        public RelatedItemType[] AccessoryRelatedItem
        {
            get
            {
                return accessoryRelatedItemField;
            }
            set
            {
                accessoryRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredRelatedItem")]
        public RelatedItemType[] RequiredRelatedItem
        {
            get
            {
                return requiredRelatedItemField;
            }
            set
            {
                requiredRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReplacementRelatedItem")]
        public RelatedItemType[] ReplacementRelatedItem
        {
            get
            {
                return replacementRelatedItemField;
            }
            set
            {
                replacementRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComplementaryRelatedItem")]
        public RelatedItemType[] ComplementaryRelatedItem
        {
            get
            {
                return complementaryRelatedItemField;
            }
            set
            {
                complementaryRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReplacedRelatedItem")]
        public RelatedItemType[] ReplacedRelatedItem
        {
            get
            {
                return replacedRelatedItemField;
            }
            set
            {
                replacedRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity")]
        public ItemLocationQuantityType[] RequiredItemLocationQuantity
        {
            get
            {
                return requiredItemLocationQuantityField;
            }
            set
            {
                requiredItemLocationQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return documentReferenceField;
            }
            set
            {
                documentReferenceField = value;
            }
        }

        /// <remarks/>
        public ItemType Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KeywordItemProperty")]
        public ItemPropertyType[] KeywordItemProperty
        {
            get
            {
                return keywordItemPropertyField;
            }
            set
            {
                keywordItemPropertyField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType CallForTendersLineReference
        {
            get
            {
                return callForTendersLineReferenceField;
            }
            set
            {
                callForTendersLineReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType CallForTendersDocumentReference
        {
            get
            {
                return callForTendersDocumentReferenceField;
            }
            set
            {
                callForTendersDocumentReferenceField = value;
            }
        }
    }
}