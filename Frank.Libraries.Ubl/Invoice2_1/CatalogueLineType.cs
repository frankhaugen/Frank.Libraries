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

        private IdType _idField;

        private ActionCodeType _actionCodeField;

        private LifeCycleStatusCodeType _lifeCycleStatusCodeField;

        private ContractSubdivisionType _contractSubdivisionField;

        private NoteType[] _noteField;

        private OrderableIndicatorType _orderableIndicatorField;

        private OrderableUnitType _orderableUnitField;

        private ContentUnitQuantityType _contentUnitQuantityField;

        private OrderQuantityIncrementNumericType _orderQuantityIncrementNumericField;

        private MinimumOrderQuantityType _minimumOrderQuantityField;

        private MaximumOrderQuantityType _maximumOrderQuantityField;

        private WarrantyInformationType[] _warrantyInformationField;

        private PackLevelCodeType _packLevelCodeField;

        private CustomerPartyType _contractorCustomerPartyField;

        private SupplierPartyType _sellerSupplierPartyField;

        private PartyType _warrantyPartyField;

        private PeriodType _warrantyValidityPeriodField;

        private PeriodType _lineValidityPeriodField;

        private ItemComparisonType[] _itemComparisonField;

        private RelatedItemType[] _componentRelatedItemField;

        private RelatedItemType[] _accessoryRelatedItemField;

        private RelatedItemType[] _requiredRelatedItemField;

        private RelatedItemType[] _replacementRelatedItemField;

        private RelatedItemType[] _complementaryRelatedItemField;

        private RelatedItemType[] _replacedRelatedItemField;

        private ItemLocationQuantityType[] _requiredItemLocationQuantityField;

        private DocumentReferenceType[] _documentReferenceField;

        private ItemType _itemField;

        private ItemPropertyType[] _keywordItemPropertyField;

        private LineReferenceType _callForTendersLineReferenceField;

        private DocumentReferenceType _callForTendersDocumentReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdType Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActionCodeType ActionCode
        {
            get
            {
                return _actionCodeField;
            }
            set
            {
                _actionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LifeCycleStatusCodeType LifeCycleStatusCode
        {
            get
            {
                return _lifeCycleStatusCodeField;
            }
            set
            {
                _lifeCycleStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractSubdivisionType ContractSubdivision
        {
            get
            {
                return _contractSubdivisionField;
            }
            set
            {
                _contractSubdivisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return _noteField;
            }
            set
            {
                _noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderableIndicatorType OrderableIndicator
        {
            get
            {
                return _orderableIndicatorField;
            }
            set
            {
                _orderableIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderableUnitType OrderableUnit
        {
            get
            {
                return _orderableUnitField;
            }
            set
            {
                _orderableUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContentUnitQuantityType ContentUnitQuantity
        {
            get
            {
                return _contentUnitQuantityField;
            }
            set
            {
                _contentUnitQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderQuantityIncrementNumericType OrderQuantityIncrementNumeric
        {
            get
            {
                return _orderQuantityIncrementNumericField;
            }
            set
            {
                _orderQuantityIncrementNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumOrderQuantityType MinimumOrderQuantity
        {
            get
            {
                return _minimumOrderQuantityField;
            }
            set
            {
                _minimumOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumOrderQuantityType MaximumOrderQuantity
        {
            get
            {
                return _maximumOrderQuantityField;
            }
            set
            {
                _maximumOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WarrantyInformationType[] WarrantyInformation
        {
            get
            {
                return _warrantyInformationField;
            }
            set
            {
                _warrantyInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackLevelCodeType PackLevelCode
        {
            get
            {
                return _packLevelCodeField;
            }
            set
            {
                _packLevelCodeField = value;
            }
        }

        /// <remarks/>
        public CustomerPartyType ContractorCustomerParty
        {
            get
            {
                return _contractorCustomerPartyField;
            }
            set
            {
                _contractorCustomerPartyField = value;
            }
        }

        /// <remarks/>
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return _sellerSupplierPartyField;
            }
            set
            {
                _sellerSupplierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType WarrantyParty
        {
            get
            {
                return _warrantyPartyField;
            }
            set
            {
                _warrantyPartyField = value;
            }
        }

        /// <remarks/>
        public PeriodType WarrantyValidityPeriod
        {
            get
            {
                return _warrantyValidityPeriodField;
            }
            set
            {
                _warrantyValidityPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType LineValidityPeriod
        {
            get
            {
                return _lineValidityPeriodField;
            }
            set
            {
                _lineValidityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemComparison")]
        public ItemComparisonType[] ItemComparison
        {
            get
            {
                return _itemComparisonField;
            }
            set
            {
                _itemComparisonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComponentRelatedItem")]
        public RelatedItemType[] ComponentRelatedItem
        {
            get
            {
                return _componentRelatedItemField;
            }
            set
            {
                _componentRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccessoryRelatedItem")]
        public RelatedItemType[] AccessoryRelatedItem
        {
            get
            {
                return _accessoryRelatedItemField;
            }
            set
            {
                _accessoryRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredRelatedItem")]
        public RelatedItemType[] RequiredRelatedItem
        {
            get
            {
                return _requiredRelatedItemField;
            }
            set
            {
                _requiredRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReplacementRelatedItem")]
        public RelatedItemType[] ReplacementRelatedItem
        {
            get
            {
                return _replacementRelatedItemField;
            }
            set
            {
                _replacementRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComplementaryRelatedItem")]
        public RelatedItemType[] ComplementaryRelatedItem
        {
            get
            {
                return _complementaryRelatedItemField;
            }
            set
            {
                _complementaryRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReplacedRelatedItem")]
        public RelatedItemType[] ReplacedRelatedItem
        {
            get
            {
                return _replacedRelatedItemField;
            }
            set
            {
                _replacedRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity")]
        public ItemLocationQuantityType[] RequiredItemLocationQuantity
        {
            get
            {
                return _requiredItemLocationQuantityField;
            }
            set
            {
                _requiredItemLocationQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return _documentReferenceField;
            }
            set
            {
                _documentReferenceField = value;
            }
        }

        /// <remarks/>
        public ItemType Item
        {
            get
            {
                return _itemField;
            }
            set
            {
                _itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KeywordItemProperty")]
        public ItemPropertyType[] KeywordItemProperty
        {
            get
            {
                return _keywordItemPropertyField;
            }
            set
            {
                _keywordItemPropertyField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType CallForTendersLineReference
        {
            get
            {
                return _callForTendersLineReferenceField;
            }
            set
            {
                _callForTendersLineReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType CallForTendersDocumentReference
        {
            get
            {
                return _callForTendersDocumentReferenceField;
            }
            set
            {
                _callForTendersDocumentReferenceField = value;
            }
        }
    }
}