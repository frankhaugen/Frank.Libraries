namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("SubscriberConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class SubscriberConsumptionType
    {

        private ConsumptionIdType _consumptionIdField;

        private SpecificationTypeCodeType _specificationTypeCodeField;

        private NoteType[] _noteField;

        private TotalMeteredQuantityType _totalMeteredQuantityField;

        private PartyType _subscriberPartyField;

        private ConsumptionPointType _utilityConsumptionPointField;

        private OnAccountPaymentType[] _onAccountPaymentField;

        private ConsumptionType _consumptionField;

        private SupplierConsumptionType[] _supplierConsumptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionIdType ConsumptionId
        {
            get
            {
                return _consumptionIdField;
            }
            set
            {
                _consumptionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecificationTypeCodeType SpecificationTypeCode
        {
            get
            {
                return _specificationTypeCodeField;
            }
            set
            {
                _specificationTypeCodeField = value;
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
        public TotalMeteredQuantityType TotalMeteredQuantity
        {
            get
            {
                return _totalMeteredQuantityField;
            }
            set
            {
                _totalMeteredQuantityField = value;
            }
        }

        /// <remarks/>
        public PartyType SubscriberParty
        {
            get
            {
                return _subscriberPartyField;
            }
            set
            {
                _subscriberPartyField = value;
            }
        }

        /// <remarks/>
        public ConsumptionPointType UtilityConsumptionPoint
        {
            get
            {
                return _utilityConsumptionPointField;
            }
            set
            {
                _utilityConsumptionPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OnAccountPayment")]
        public OnAccountPaymentType[] OnAccountPayment
        {
            get
            {
                return _onAccountPaymentField;
            }
            set
            {
                _onAccountPaymentField = value;
            }
        }

        /// <remarks/>
        public ConsumptionType Consumption
        {
            get
            {
                return _consumptionField;
            }
            set
            {
                _consumptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplierConsumption")]
        public SupplierConsumptionType[] SupplierConsumption
        {
            get
            {
                return _supplierConsumptionField;
            }
            set
            {
                _supplierConsumptionField = value;
            }
        }
    }
}