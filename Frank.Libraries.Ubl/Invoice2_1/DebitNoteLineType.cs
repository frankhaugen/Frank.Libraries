namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("DebitNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DebitNoteLineType
    {

        private IdType _idField;

        private UuidType _uUidField;

        private NoteType[] _noteField;

        private DebitedQuantityType _debitedQuantityField;

        private LineExtensionAmountType _lineExtensionAmountField;

        private TaxPointDateType _taxPointDateField;

        private AccountingCostCodeType _accountingCostCodeField;

        private AccountingCostType _accountingCostField;

        private PaymentPurposeCodeType _paymentPurposeCodeField;

        private ResponseType[] _discrepancyResponseField;

        private LineReferenceType[] _despatchLineReferenceField;

        private LineReferenceType[] _receiptLineReferenceField;

        private BillingReferenceType[] _billingReferenceField;

        private DocumentReferenceType[] _documentReferenceField;

        private PricingReferenceType _pricingReferenceField;

        private DeliveryType[] _deliveryField;

        private TaxTotalType[] _taxTotalField;

        private AllowanceChargeType[] _allowanceChargeField;

        private ItemType _itemField;

        private PriceType _priceField;

        private DebitNoteLineType[] _subDebitNoteLineField;

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
        public UuidType Uuid
        {
            get
            {
                return _uUidField;
            }
            set
            {
                _uUidField = value;
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
        public DebitedQuantityType DebitedQuantity
        {
            get
            {
                return _debitedQuantityField;
            }
            set
            {
                _debitedQuantityField = value;
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
        public TaxPointDateType TaxPointDate
        {
            get
            {
                return _taxPointDateField;
            }
            set
            {
                _taxPointDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostCodeType AccountingCostCode
        {
            get
            {
                return _accountingCostCodeField;
            }
            set
            {
                _accountingCostCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostType AccountingCost
        {
            get
            {
                return _accountingCostField;
            }
            set
            {
                _accountingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentPurposeCodeType PaymentPurposeCode
        {
            get
            {
                return _paymentPurposeCodeField;
            }
            set
            {
                _paymentPurposeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse")]
        public ResponseType[] DiscrepancyResponse
        {
            get
            {
                return _discrepancyResponseField;
            }
            set
            {
                _discrepancyResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference")]
        public LineReferenceType[] DespatchLineReference
        {
            get
            {
                return _despatchLineReferenceField;
            }
            set
            {
                _despatchLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptLineReference")]
        public LineReferenceType[] ReceiptLineReference
        {
            get
            {
                return _receiptLineReferenceField;
            }
            set
            {
                _receiptLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
        public BillingReferenceType[] BillingReference
        {
            get
            {
                return _billingReferenceField;
            }
            set
            {
                _billingReferenceField = value;
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
        public PricingReferenceType PricingReference
        {
            get
            {
                return _pricingReferenceField;
            }
            set
            {
                _pricingReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Delivery")]
        public DeliveryType[] Delivery
        {
            get
            {
                return _deliveryField;
            }
            set
            {
                _deliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return _taxTotalField;
            }
            set
            {
                _taxTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return _allowanceChargeField;
            }
            set
            {
                _allowanceChargeField = value;
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
        public PriceType Price
        {
            get
            {
                return _priceField;
            }
            set
            {
                _priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubDebitNoteLine")]
        public DebitNoteLineType[] SubDebitNoteLine
        {
            get
            {
                return _subDebitNoteLineField;
            }
            set
            {
                _subDebitNoteLineField = value;
            }
        }
    }
}