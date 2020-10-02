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

        private IDType idField;

        private QuantityType2 quantityField;

        private MinimumQuantityType minimumQuantityField;

        private MaximumQuantityType maximumQuantityField;

        private ActualDeliveryDateType actualDeliveryDateField;

        private ActualDeliveryTimeType actualDeliveryTimeField;

        private LatestDeliveryDateType latestDeliveryDateField;

        private LatestDeliveryTimeType latestDeliveryTimeField;

        private ReleaseIDType releaseIDField;

        private TrackingIDType trackingIDField;

        private AddressType deliveryAddressField;

        private LocationType1 deliveryLocationField;

        private LocationType1 alternativeDeliveryLocationField;

        private PeriodType requestedDeliveryPeriodField;

        private PeriodType promisedDeliveryPeriodField;

        private PeriodType estimatedDeliveryPeriodField;

        private PartyType carrierPartyField;

        private PartyType deliveryPartyField;

        private PartyType[] notifyPartyField;

        private DespatchType despatchField;

        private DeliveryTermsType[] deliveryTermsField;

        private DeliveryUnitType minimumDeliveryUnitField;

        private DeliveryUnitType maximumDeliveryUnitField;

        private ShipmentType shipmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return this.minimumQuantityField;
            }
            set
            {
                this.minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return this.maximumQuantityField;
            }
            set
            {
                this.maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDeliveryDateType ActualDeliveryDate
        {
            get
            {
                return this.actualDeliveryDateField;
            }
            set
            {
                this.actualDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDeliveryTimeType ActualDeliveryTime
        {
            get
            {
                return this.actualDeliveryTimeField;
            }
            set
            {
                this.actualDeliveryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestDeliveryDateType LatestDeliveryDate
        {
            get
            {
                return this.latestDeliveryDateField;
            }
            set
            {
                this.latestDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestDeliveryTimeType LatestDeliveryTime
        {
            get
            {
                return this.latestDeliveryTimeField;
            }
            set
            {
                this.latestDeliveryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReleaseIDType ReleaseID
        {
            get
            {
                return this.releaseIDField;
            }
            set
            {
                this.releaseIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TrackingIDType TrackingID
        {
            get
            {
                return this.trackingIDField;
            }
            set
            {
                this.trackingIDField = value;
            }
        }

        /// <remarks/>
        public AddressType DeliveryAddress
        {
            get
            {
                return this.deliveryAddressField;
            }
            set
            {
                this.deliveryAddressField = value;
            }
        }

        /// <remarks/>
        public LocationType1 DeliveryLocation
        {
            get
            {
                return this.deliveryLocationField;
            }
            set
            {
                this.deliveryLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 AlternativeDeliveryLocation
        {
            get
            {
                return this.alternativeDeliveryLocationField;
            }
            set
            {
                this.alternativeDeliveryLocationField = value;
            }
        }

        /// <remarks/>
        public PeriodType RequestedDeliveryPeriod
        {
            get
            {
                return this.requestedDeliveryPeriodField;
            }
            set
            {
                this.requestedDeliveryPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType PromisedDeliveryPeriod
        {
            get
            {
                return this.promisedDeliveryPeriodField;
            }
            set
            {
                this.promisedDeliveryPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType EstimatedDeliveryPeriod
        {
            get
            {
                return this.estimatedDeliveryPeriodField;
            }
            set
            {
                this.estimatedDeliveryPeriodField = value;
            }
        }

        /// <remarks/>
        public PartyType CarrierParty
        {
            get
            {
                return this.carrierPartyField;
            }
            set
            {
                this.carrierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType DeliveryParty
        {
            get
            {
                return this.deliveryPartyField;
            }
            set
            {
                this.deliveryPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
        public PartyType[] NotifyParty
        {
            get
            {
                return this.notifyPartyField;
            }
            set
            {
                this.notifyPartyField = value;
            }
        }

        /// <remarks/>
        public DespatchType Despatch
        {
            get
            {
                return this.despatchField;
            }
            set
            {
                this.despatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms")]
        public DeliveryTermsType[] DeliveryTerms
        {
            get
            {
                return this.deliveryTermsField;
            }
            set
            {
                this.deliveryTermsField = value;
            }
        }

        /// <remarks/>
        public DeliveryUnitType MinimumDeliveryUnit
        {
            get
            {
                return this.minimumDeliveryUnitField;
            }
            set
            {
                this.minimumDeliveryUnitField = value;
            }
        }

        /// <remarks/>
        public DeliveryUnitType MaximumDeliveryUnit
        {
            get
            {
                return this.maximumDeliveryUnitField;
            }
            set
            {
                this.maximumDeliveryUnitField = value;
            }
        }

        /// <remarks/>
        public ShipmentType Shipment
        {
            get
            {
                return this.shipmentField;
            }
            set
            {
                this.shipmentField = value;
            }
        }
    }
}