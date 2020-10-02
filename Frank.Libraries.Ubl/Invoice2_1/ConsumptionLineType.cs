namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ConsumptionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ConsumptionLineType
    {

        private IdType _idField;

        private ParentDocumentLineReferenceIdType _parentDocumentLineReferenceIdField;

        private InvoicedQuantityType _invoicedQuantityField;

        private LineExtensionAmountType _lineExtensionAmountField;

        private PeriodType _periodField;

        private DeliveryType[] _deliveryField;

        private AllowanceChargeType[] _allowanceChargeField;

        private TaxTotalType[] _taxTotalField;

        private UtilityItemType _utilityItemField;

        private PriceType _priceField;

        private UnstructuredPriceType _unstructuredPriceField;

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
        public ParentDocumentLineReferenceIdType ParentDocumentLineReferenceId
        {
            get
            {
                return _parentDocumentLineReferenceIdField;
            }
            set
            {
                _parentDocumentLineReferenceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InvoicedQuantityType InvoicedQuantity
        {
            get
            {
                return _invoicedQuantityField;
            }
            set
            {
                _invoicedQuantityField = value;
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
        public PeriodType Period
        {
            get
            {
                return _periodField;
            }
            set
            {
                _periodField = value;
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
        public UtilityItemType UtilityItem
        {
            get
            {
                return _utilityItemField;
            }
            set
            {
                _utilityItemField = value;
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
        public UnstructuredPriceType UnstructuredPrice
        {
            get
            {
                return _unstructuredPriceField;
            }
            set
            {
                _unstructuredPriceField = value;
            }
        }
    }
}