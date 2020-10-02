namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ContractualDelivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DeliveryType
    {

        private IdType _idField;

        private QuantityType2 _quantityField;

        private MinimumQuantityType _minimumQuantityField;

        private MaximumQuantityType _maximumQuantityField;

        private ActualDeliveryDateType _actualDeliveryDateField;

        private ActualDeliveryTimeType _actualDeliveryTimeField;

        private LatestDeliveryDateType _latestDeliveryDateField;

        private LatestDeliveryTimeType _latestDeliveryTimeField;

        private ReleaseIdType _releaseIdField;

        private TrackingIdType _trackingIdField;

        private AddressType _deliveryAddressField;

        private LocationType1 _deliveryLocationField;

        private LocationType1 _alternativeDeliveryLocationField;

        private PeriodType _requestedDeliveryPeriodField;

        private PeriodType _promisedDeliveryPeriodField;

        private PeriodType _estimatedDeliveryPeriodField;

        private PartyType _carrierPartyField;

        private PartyType _deliveryPartyField;

        private PartyType[] _notifyPartyField;

        private DespatchType _despatchField;

        private DeliveryTermsType[] _deliveryTermsField;

        private DeliveryUnitType _minimumDeliveryUnitField;

        private DeliveryUnitType _maximumDeliveryUnitField;

        private ShipmentType _shipmentField;

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
        public ActualDeliveryDateType ActualDeliveryDate
        {
            get
            {
                return _actualDeliveryDateField;
            }
            set
            {
                _actualDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDeliveryTimeType ActualDeliveryTime
        {
            get
            {
                return _actualDeliveryTimeField;
            }
            set
            {
                _actualDeliveryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestDeliveryDateType LatestDeliveryDate
        {
            get
            {
                return _latestDeliveryDateField;
            }
            set
            {
                _latestDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestDeliveryTimeType LatestDeliveryTime
        {
            get
            {
                return _latestDeliveryTimeField;
            }
            set
            {
                _latestDeliveryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReleaseIdType ReleaseId
        {
            get
            {
                return _releaseIdField;
            }
            set
            {
                _releaseIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TrackingIdType TrackingId
        {
            get
            {
                return _trackingIdField;
            }
            set
            {
                _trackingIdField = value;
            }
        }

        /// <remarks/>
        public AddressType DeliveryAddress
        {
            get
            {
                return _deliveryAddressField;
            }
            set
            {
                _deliveryAddressField = value;
            }
        }

        /// <remarks/>
        public LocationType1 DeliveryLocation
        {
            get
            {
                return _deliveryLocationField;
            }
            set
            {
                _deliveryLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 AlternativeDeliveryLocation
        {
            get
            {
                return _alternativeDeliveryLocationField;
            }
            set
            {
                _alternativeDeliveryLocationField = value;
            }
        }

        /// <remarks/>
        public PeriodType RequestedDeliveryPeriod
        {
            get
            {
                return _requestedDeliveryPeriodField;
            }
            set
            {
                _requestedDeliveryPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType PromisedDeliveryPeriod
        {
            get
            {
                return _promisedDeliveryPeriodField;
            }
            set
            {
                _promisedDeliveryPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType EstimatedDeliveryPeriod
        {
            get
            {
                return _estimatedDeliveryPeriodField;
            }
            set
            {
                _estimatedDeliveryPeriodField = value;
            }
        }

        /// <remarks/>
        public PartyType CarrierParty
        {
            get
            {
                return _carrierPartyField;
            }
            set
            {
                _carrierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType DeliveryParty
        {
            get
            {
                return _deliveryPartyField;
            }
            set
            {
                _deliveryPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
        public PartyType[] NotifyParty
        {
            get
            {
                return _notifyPartyField;
            }
            set
            {
                _notifyPartyField = value;
            }
        }

        /// <remarks/>
        public DespatchType Despatch
        {
            get
            {
                return _despatchField;
            }
            set
            {
                _despatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms")]
        public DeliveryTermsType[] DeliveryTerms
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
        public DeliveryUnitType MinimumDeliveryUnit
        {
            get
            {
                return _minimumDeliveryUnitField;
            }
            set
            {
                _minimumDeliveryUnitField = value;
            }
        }

        /// <remarks/>
        public DeliveryUnitType MaximumDeliveryUnit
        {
            get
            {
                return _maximumDeliveryUnitField;
            }
            set
            {
                _maximumDeliveryUnitField = value;
            }
        }

        /// <remarks/>
        public ShipmentType Shipment
        {
            get
            {
                return _shipmentField;
            }
            set
            {
                _shipmentField = value;
            }
        }
    }
}