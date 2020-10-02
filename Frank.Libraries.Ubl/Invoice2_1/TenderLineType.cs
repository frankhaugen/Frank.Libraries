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

        private IDType idField;

        private NoteType[] noteField;

        private QuantityType2 quantityField;

        private LineExtensionAmountType lineExtensionAmountField;

        private TotalTaxAmountType totalTaxAmountField;

        private OrderableUnitType orderableUnitField;

        private ContentUnitQuantityType contentUnitQuantityField;

        private OrderQuantityIncrementNumericType orderQuantityIncrementNumericField;

        private MinimumOrderQuantityType minimumOrderQuantityField;

        private MaximumOrderQuantityType maximumOrderQuantityField;

        private WarrantyInformationType[] warrantyInformationField;

        private PackLevelCodeType packLevelCodeField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType itemField;

        private ItemLocationQuantityType[] offeredItemLocationQuantityField;

        private RelatedItemType[] replacementRelatedItemField;

        private PartyType warrantyPartyField;

        private PeriodType warrantyValidityPeriodField;

        private TenderLineType[] subTenderLineField;

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
        public QuantityType2 Quantity
        {
            get
            {
                return quantityField;
            }
            set
            {
                quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmountType LineExtensionAmount
        {
            get
            {
                return lineExtensionAmountField;
            }
            set
            {
                lineExtensionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalTaxAmountType TotalTaxAmount
        {
            get
            {
                return totalTaxAmountField;
            }
            set
            {
                totalTaxAmountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OfferedItemLocationQuantity")]
        public ItemLocationQuantityType[] OfferedItemLocationQuantity
        {
            get
            {
                return offeredItemLocationQuantityField;
            }
            set
            {
                offeredItemLocationQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SubTenderLine")]
        public TenderLineType[] SubTenderLine
        {
            get
            {
                return subTenderLineField;
            }
            set
            {
                subTenderLineField = value;
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