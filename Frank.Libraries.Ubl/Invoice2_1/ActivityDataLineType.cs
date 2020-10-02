namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ActivityDataLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ActivityDataLineType
    {

        private IdType _idField;

        private SupplyChainActivityTypeCodeType _supplyChainActivityTypeCodeField;

        private CustomerPartyType _buyerCustomerPartyField;

        private SupplierPartyType _sellerSupplierPartyField;

        private PeriodType _activityPeriodField;

        private LocationType1 _activityOriginLocationField;

        private LocationType1 _activityFinalLocationField;

        private SalesItemType[] _salesItemField;

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
        public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode
        {
            get
            {
                return _supplyChainActivityTypeCodeField;
            }
            set
            {
                _supplyChainActivityTypeCodeField = value;
            }
        }

        /// <remarks/>
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                return _buyerCustomerPartyField;
            }
            set
            {
                _buyerCustomerPartyField = value;
            }
        }

        /// <remarks/>
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return _sellerSupplierPartyField;
            }
            set
            {
                _sellerSupplierPartyField = value;
            }
        }

        /// <remarks/>
        public PeriodType ActivityPeriod
        {
            get
            {
                return _activityPeriodField;
            }
            set
            {
                _activityPeriodField = value;
            }
        }

        /// <remarks/>
        public LocationType1 ActivityOriginLocation
        {
            get
            {
                return _activityOriginLocationField;
            }
            set
            {
                _activityOriginLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 ActivityFinalLocation
        {
            get
            {
                return _activityFinalLocationField;
            }
            set
            {
                _activityFinalLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesItem")]
        public SalesItemType[] SalesItem
        {
            get
            {
                return _salesItemField;
            }
            set
            {
                _salesItemField = value;
            }
        }
    }
}
