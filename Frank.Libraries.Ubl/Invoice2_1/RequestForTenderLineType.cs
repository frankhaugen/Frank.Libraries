namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("RequestForTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class RequestForTenderLineType
    {

        private IDType idField;

        private UUIDType uUIDField;

        private NoteType[] noteField;

        private QuantityType2 quantityField;

        private MinimumQuantityType minimumQuantityField;

        private MaximumQuantityType maximumQuantityField;

        private TaxIncludedIndicatorType taxIncludedIndicatorField;

        private MinimumAmountType minimumAmountField;

        private MaximumAmountType maximumAmountField;

        private EstimatedAmountType estimatedAmountField;

        private DocumentReferenceType[] documentReferenceField;

        private PeriodType[] deliveryPeriodField;

        private ItemLocationQuantityType[] requiredItemLocationQuantityField;

        private PeriodType warrantyValidityPeriodField;

        private ItemType itemField;

        private RequestForTenderLineType[] subRequestForTenderLineField;

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
        public UUIDType UUID
        {
            get
            {
                return uUIDField;
            }
            set
            {
                uUIDField = value;
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
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return minimumQuantityField;
            }
            set
            {
                minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return maximumQuantityField;
            }
            set
            {
                maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxIncludedIndicatorType TaxIncludedIndicator
        {
            get
            {
                return taxIncludedIndicatorField;
            }
            set
            {
                taxIncludedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumAmountType MinimumAmount
        {
            get
            {
                return minimumAmountField;
            }
            set
            {
                minimumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumAmountType MaximumAmount
        {
            get
            {
                return maximumAmountField;
            }
            set
            {
                maximumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedAmountType EstimatedAmount
        {
            get
            {
                return estimatedAmountField;
            }
            set
            {
                estimatedAmountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("DeliveryPeriod")]
        public PeriodType[] DeliveryPeriod
        {
            get
            {
                return deliveryPeriodField;
            }
            set
            {
                deliveryPeriodField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SubRequestForTenderLine")]
        public RequestForTenderLineType[] SubRequestForTenderLine
        {
            get
            {
                return subRequestForTenderLineField;
            }
            set
            {
                subRequestForTenderLineField = value;
            }
        }
    }
}