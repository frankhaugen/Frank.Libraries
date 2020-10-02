namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CreditNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CreditNoteLineType
    {

        private IDType idField;

        private UUIDType uUIDField;

        private NoteType[] noteField;

        private CreditedQuantityType creditedQuantityField;

        private LineExtensionAmountType lineExtensionAmountField;

        private TaxPointDateType taxPointDateField;

        private AccountingCostCodeType accountingCostCodeField;

        private AccountingCostType accountingCostField;

        private PaymentPurposeCodeType paymentPurposeCodeField;

        private FreeOfChargeIndicatorType freeOfChargeIndicatorField;

        private PeriodType[] invoicePeriodField;

        private OrderLineReferenceType[] orderLineReferenceField;

        private ResponseType[] discrepancyResponseField;

        private LineReferenceType[] despatchLineReferenceField;

        private LineReferenceType[] receiptLineReferenceField;

        private BillingReferenceType[] billingReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private PricingReferenceType pricingReferenceField;

        private PartyType originatorPartyField;

        private DeliveryType[] deliveryField;

        private PaymentTermsType[] paymentTermsField;

        private TaxTotalType[] taxTotalField;

        private AllowanceChargeType[] allowanceChargeField;

        private ItemType itemField;

        private PriceType priceField;

        private DeliveryTermsType[] deliveryTermsField;

        private CreditNoteLineType[] subCreditNoteLineField;

        private PriceExtensionType itemPriceExtensionField;

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
        public CreditedQuantityType CreditedQuantity
        {
            get
            {
                return creditedQuantityField;
            }
            set
            {
                creditedQuantityField = value;
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
        public TaxPointDateType TaxPointDate
        {
            get
            {
                return taxPointDateField;
            }
            set
            {
                taxPointDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostCodeType AccountingCostCode
        {
            get
            {
                return accountingCostCodeField;
            }
            set
            {
                accountingCostCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostType AccountingCost
        {
            get
            {
                return accountingCostField;
            }
            set
            {
                accountingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentPurposeCodeType PaymentPurposeCode
        {
            get
            {
                return paymentPurposeCodeField;
            }
            set
            {
                paymentPurposeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreeOfChargeIndicatorType FreeOfChargeIndicator
        {
            get
            {
                return freeOfChargeIndicatorField;
            }
            set
            {
                freeOfChargeIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod")]
        public PeriodType[] InvoicePeriod
        {
            get
            {
                return invoicePeriodField;
            }
            set
            {
                invoicePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrderLineReference")]
        public OrderLineReferenceType[] OrderLineReference
        {
            get
            {
                return orderLineReferenceField;
            }
            set
            {
                orderLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse")]
        public ResponseType[] DiscrepancyResponse
        {
            get
            {
                return discrepancyResponseField;
            }
            set
            {
                discrepancyResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference")]
        public LineReferenceType[] DespatchLineReference
        {
            get
            {
                return despatchLineReferenceField;
            }
            set
            {
                despatchLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptLineReference")]
        public LineReferenceType[] ReceiptLineReference
        {
            get
            {
                return receiptLineReferenceField;
            }
            set
            {
                receiptLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
        public BillingReferenceType[] BillingReference
        {
            get
            {
                return billingReferenceField;
            }
            set
            {
                billingReferenceField = value;
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
        public PricingReferenceType PricingReference
        {
            get
            {
                return pricingReferenceField;
            }
            set
            {
                pricingReferenceField = value;
            }
        }

        /// <remarks/>
        public PartyType OriginatorParty
        {
            get
            {
                return originatorPartyField;
            }
            set
            {
                originatorPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Delivery")]
        public DeliveryType[] Delivery
        {
            get
            {
                return deliveryField;
            }
            set
            {
                deliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return paymentTermsField;
            }
            set
            {
                paymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return taxTotalField;
            }
            set
            {
                taxTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return allowanceChargeField;
            }
            set
            {
                allowanceChargeField = value;
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
        public PriceType Price
        {
            get
            {
                return priceField;
            }
            set
            {
                priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms")]
        public DeliveryTermsType[] DeliveryTerms
        {
            get
            {
                return deliveryTermsField;
            }
            set
            {
                deliveryTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubCreditNoteLine")]
        public CreditNoteLineType[] SubCreditNoteLine
        {
            get
            {
                return subCreditNoteLineField;
            }
            set
            {
                subCreditNoteLineField = value;
            }
        }

        /// <remarks/>
        public PriceExtensionType ItemPriceExtension
        {
            get
            {
                return itemPriceExtensionField;
            }
            set
            {
                itemPriceExtensionField = value;
            }
        }
    }
}