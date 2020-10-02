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

        private IdType _idField;

        private SalesOrderIdType _salesOrderIdField;

        private UuidType _uUidField;

        private NoteType[] _noteField;

        private LineStatusCodeType _lineStatusCodeField;

        private QuantityType2 _quantityField;

        private LineExtensionAmountType _lineExtensionAmountField;

        private TotalTaxAmountType _totalTaxAmountField;

        private MinimumQuantityType _minimumQuantityField;

        private MaximumQuantityType _maximumQuantityField;

        private MinimumBackorderQuantityType _minimumBackorderQuantityField;

        private MaximumBackorderQuantityType _maximumBackorderQuantityField;

        private InspectionMethodCodeType _inspectionMethodCodeField;

        private PartialDeliveryIndicatorType _partialDeliveryIndicatorField;

        private BackOrderAllowedIndicatorType _backOrderAllowedIndicatorField;

        private AccountingCostCodeType _accountingCostCodeField;

        private AccountingCostType _accountingCostField;

        private WarrantyInformationType[] _warrantyInformationField;

        private DeliveryType[] _deliveryField;

        private DeliveryTermsType _deliveryTermsField;

        private PartyType _originatorPartyField;

        private OrderedShipmentType[] _orderedShipmentField;

        private PricingReferenceType _pricingReferenceField;

        private AllowanceChargeType[] _allowanceChargeField;

        private PriceType _priceField;

        private ItemType _itemField;

        private LineItemType[] _subLineItemField;

        private PeriodType _warrantyValidityPeriodField;

        private PartyType _warrantyPartyField;

        private TaxTotalType[] _taxTotalField;

        private PriceExtensionType _itemPriceExtensionField;

        private LineReferenceType[] _lineReferenceField;

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
        public SalesOrderIdType SalesOrderId
        {
            get
            {
                return _salesOrderIdField;
            }
            set
            {
                _salesOrderIdField = value;
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
        public LineStatusCodeType LineStatusCode
        {
            get
            {
                return _lineStatusCodeField;
            }
            set
            {
                _lineStatusCodeField = value;
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
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return _minimumQuantityField;
            }
            set
            {
                _minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return _maximumQuantityField;
            }
            set
            {
                _maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumBackorderQuantityType MinimumBackorderQuantity
        {
            get
            {
                return _minimumBackorderQuantityField;
            }
            set
            {
                _minimumBackorderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumBackorderQuantityType MaximumBackorderQuantity
        {
            get
            {
                return _maximumBackorderQuantityField;
            }
            set
            {
                _maximumBackorderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InspectionMethodCodeType InspectionMethodCode
        {
            get
            {
                return _inspectionMethodCodeField;
            }
            set
            {
                _inspectionMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PartialDeliveryIndicatorType PartialDeliveryIndicator
        {
            get
            {
                return _partialDeliveryIndicatorField;
            }
            set
            {
                _partialDeliveryIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BackOrderAllowedIndicatorType BackOrderAllowedIndicator
        {
            get
            {
                return _backOrderAllowedIndicatorField;
            }
            set
            {
                _backOrderAllowedIndicatorField = value;
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
        public DeliveryTermsType DeliveryTerms
        {
            get
            {
                return _deliveryTermsField;
            }
            set
            {
                _deliveryTermsField = value;
            }
        }

        /// <remarks/>
        public PartyType OriginatorParty
        {
            get
            {
                return _originatorPartyField;
            }
            set
            {
                _originatorPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrderedShipment")]
        public OrderedShipmentType[] OrderedShipment
        {
            get
            {
                return _orderedShipmentField;
            }
            set
            {
                _orderedShipmentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SubLineItem")]
        public LineItemType[] SubLineItem
        {
            get
            {
                return _subLineItemField;
            }
            set
            {
                _subLineItemField = value;
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
        public PriceExtensionType ItemPriceExtension
        {
            get
            {
                return _itemPriceExtensionField;
            }
            set
            {
                _itemPriceExtensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LineReference")]
        public LineReferenceType[] LineReference
        {
            get
            {
                return _lineReferenceField;
            }
            set
            {
                _lineReferenceField = value;
            }
        }
    }
}