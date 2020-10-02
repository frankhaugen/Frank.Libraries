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
                return idField;
            }
            set
            {
                idField = value;
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
        public ActualDeliveryDateType ActualDeliveryDate
        {
            get
            {
                return actualDeliveryDateField;
            }
            set
            {
                actualDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDeliveryTimeType ActualDeliveryTime
        {
            get
            {
                return actualDeliveryTimeField;
            }
            set
            {
                actualDeliveryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestDeliveryDateType LatestDeliveryDate
        {
            get
            {
                return latestDeliveryDateField;
            }
            set
            {
                latestDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestDeliveryTimeType LatestDeliveryTime
        {
            get
            {
                return latestDeliveryTimeField;
            }
            set
            {
                latestDeliveryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReleaseIDType ReleaseID
        {
            get
            {
                return releaseIDField;
            }
            set
            {
                releaseIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TrackingIDType TrackingID
        {
            get
            {
                return trackingIDField;
            }
            set
            {
                trackingIDField = value;
            }
        }

        /// <remarks/>
        public AddressType DeliveryAddress
        {
            get
            {
                return deliveryAddressField;
            }
            set
            {
                deliveryAddressField = value;
            }
        }

        /// <remarks/>
        public LocationType1 DeliveryLocation
        {
            get
            {
                return deliveryLocationField;
            }
            set
            {
                deliveryLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 AlternativeDeliveryLocation
        {
            get
            {
                return alternativeDeliveryLocationField;
            }
            set
            {
                alternativeDeliveryLocationField = value;
            }
        }

        /// <remarks/>
        public PeriodType RequestedDeliveryPeriod
        {
            get
            {
                return requestedDeliveryPeriodField;
            }
            set
            {
                requestedDeliveryPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType PromisedDeliveryPeriod
        {
            get
            {
                return promisedDeliveryPeriodField;
            }
            set
            {
                promisedDeliveryPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType EstimatedDeliveryPeriod
        {
            get
            {
                return estimatedDeliveryPeriodField;
            }
            set
            {
                estimatedDeliveryPeriodField = value;
            }
        }

        /// <remarks/>
        public PartyType CarrierParty
        {
            get
            {
                return carrierPartyField;
            }
            set
            {
                carrierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType DeliveryParty
        {
            get
            {
                return deliveryPartyField;
            }
            set
            {
                deliveryPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
        public PartyType[] NotifyParty
        {
            get
            {
                return notifyPartyField;
            }
            set
            {
                notifyPartyField = value;
            }
        }

        /// <remarks/>
        public DespatchType Despatch
        {
            get
            {
                return despatchField;
            }
            set
            {
                despatchField = value;
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
        public DeliveryUnitType MinimumDeliveryUnit
        {
            get
            {
                return minimumDeliveryUnitField;
            }
            set
            {
                minimumDeliveryUnitField = value;
            }
        }

        /// <remarks/>
        public DeliveryUnitType MaximumDeliveryUnit
        {
            get
            {
                return maximumDeliveryUnitField;
            }
            set
            {
                maximumDeliveryUnitField = value;
            }
        }

        /// <remarks/>
        public ShipmentType Shipment
        {
            get
            {
                return shipmentField;
            }
            set
            {
                shipmentField = value;
            }
        }
    }
}