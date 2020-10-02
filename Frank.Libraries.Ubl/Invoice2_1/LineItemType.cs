namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AlternativeLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class LineItemType
    {

        private IDType idField;

        private SalesOrderIDType salesOrderIDField;

        private UUIDType uUIDField;

        private NoteType[] noteField;

        private LineStatusCodeType lineStatusCodeField;

        private QuantityType2 quantityField;

        private LineExtensionAmountType lineExtensionAmountField;

        private TotalTaxAmountType totalTaxAmountField;

        private MinimumQuantityType minimumQuantityField;

        private MaximumQuantityType maximumQuantityField;

        private MinimumBackorderQuantityType minimumBackorderQuantityField;

        private MaximumBackorderQuantityType maximumBackorderQuantityField;

        private InspectionMethodCodeType inspectionMethodCodeField;

        private PartialDeliveryIndicatorType partialDeliveryIndicatorField;

        private BackOrderAllowedIndicatorType backOrderAllowedIndicatorField;

        private AccountingCostCodeType accountingCostCodeField;

        private AccountingCostType accountingCostField;

        private WarrantyInformationType[] warrantyInformationField;

        private DeliveryType[] deliveryField;

        private DeliveryTermsType deliveryTermsField;

        private PartyType originatorPartyField;

        private OrderedShipmentType[] orderedShipmentField;

        private PricingReferenceType pricingReferenceField;

        private AllowanceChargeType[] allowanceChargeField;

        private PriceType priceField;

        private ItemType itemField;

        private LineItemType[] subLineItemField;

        private PeriodType warrantyValidityPeriodField;

        private PartyType warrantyPartyField;

        private TaxTotalType[] taxTotalField;

        private PriceExtensionType itemPriceExtensionField;

        private LineReferenceType[] lineReferenceField;

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
        public SalesOrderIDType SalesOrderID
        {
            get
            {
                return salesOrderIDField;
            }
            set
            {
                salesOrderIDField = value;
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
        public LineStatusCodeType LineStatusCode
        {
            get
            {
                return lineStatusCodeField;
            }
            set
            {
                lineStatusCodeField = value;
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
        public MinimumBackorderQuantityType MinimumBackorderQuantity
        {
            get
            {
                return minimumBackorderQuantityField;
            }
            set
            {
                minimumBackorderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumBackorderQuantityType MaximumBackorderQuantity
        {
            get
            {
                return maximumBackorderQuantityField;
            }
            set
            {
                maximumBackorderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InspectionMethodCodeType InspectionMethodCode
        {
            get
            {
                return inspectionMethodCodeField;
            }
            set
            {
                inspectionMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PartialDeliveryIndicatorType PartialDeliveryIndicator
        {
            get
            {
                return partialDeliveryIndicatorField;
            }
            set
            {
                partialDeliveryIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BackOrderAllowedIndicatorType BackOrderAllowedIndicator
        {
            get
            {
                return backOrderAllowedIndicatorField;
            }
            set
            {
                backOrderAllowedIndicatorField = value;
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
        public DeliveryTermsType DeliveryTerms
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
        [System.Xml.Serialization.XmlElementAttribute("OrderedShipment")]
        public OrderedShipmentType[] OrderedShipment
        {
            get
            {
                return orderedShipmentField;
            }
            set
            {
                orderedShipmentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SubLineItem")]
        public LineItemType[] SubLineItem
        {
            get
            {
                return subLineItemField;
            }
            set
            {
                subLineItemField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LineReference")]
        public LineReferenceType[] LineReference
        {
            get
            {
                return lineReferenceField;
            }
            set
            {
                lineReferenceField = value;
            }
        }
    }
}