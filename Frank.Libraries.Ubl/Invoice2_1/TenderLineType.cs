namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("SubTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TenderLineType
    {

        private IdType _idField;

        private NoteType[] _noteField;

        private QuantityType2 _quantityField;

        private LineExtensionAmountType _lineExtensionAmountField;

        private TotalTaxAmountType _totalTaxAmountField;

        private OrderableUnitType _orderableUnitField;

        private ContentUnitQuantityType _contentUnitQuantityField;

        private OrderQuantityIncrementNumericType _orderQuantityIncrementNumericField;

        private MinimumOrderQuantityType _minimumOrderQuantityField;

        private MaximumOrderQuantityType _maximumOrderQuantityField;

        private WarrantyInformationType[] _warrantyInformationField;

        private PackLevelCodeType _packLevelCodeField;

        private DocumentReferenceType[] _documentReferenceField;

        private ItemType _itemField;

        private ItemLocationQuantityType[] _offeredItemLocationQuantityField;

        private RelatedItemType[] _replacementRelatedItemField;

        private PartyType _warrantyPartyField;

        private PeriodType _warrantyValidityPeriodField;

        private TenderLineType[] _subTenderLineField;

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
        public QuantityType2 Quantity
        {
            get
            {
                return _quantityField;
            }
            set
            {
                _quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmountType LineExtensionAmount
        {
            get
            {
                return _lineExtensionAmountField;
            }
            set
            {
                _lineExtensionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalTaxAmountType TotalTaxAmount
        {
            get
            {
                return _totalTaxAmountField;
            }
            set
            {
                _totalTaxAmountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OfferedItemLocationQuantity")]
        public ItemLocationQuantityType[] OfferedItemLocationQuantity
        {
            get
            {
                return _offeredItemLocationQuantityField;
            }
            set
            {
                _offeredItemLocationQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SubTenderLine")]
        public TenderLineType[] SubTenderLine
        {
            get
            {
                return _subTenderLineField;
            }
            set
            {
                _subTenderLineField = value;
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