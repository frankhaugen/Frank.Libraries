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

        private IDType idField;

        private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

        private CustomerPartyType buyerCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private PeriodType activityPeriodField;

        private LocationType1 activityOriginLocationField;

        private LocationType1 activityFinalLocationField;

        private SalesItemType[] salesItemField;

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
        public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode
        {
            get
            {
                return supplyChainActivityTypeCodeField;
            }
            set
            {
                supplyChainActivityTypeCodeField = value;
            }
        }

        /// <remarks/>
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                return buyerCustomerPartyField;
            }
            set
            {
                buyerCustomerPartyField = value;
            }
        }

        /// <remarks/>
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return sellerSupplierPartyField;
            }
            set
            {
                sellerSupplierPartyField = value;
            }
        }

        /// <remarks/>
        public PeriodType ActivityPeriod
        {
            get
            {
                return activityPeriodField;
            }
            set
            {
                activityPeriodField = value;
            }
        }

        /// <remarks/>
        public LocationType1 ActivityOriginLocation
        {
            get
            {
                return activityOriginLocationField;
            }
            set
            {
                activityOriginLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 ActivityFinalLocation
        {
            get
            {
                return activityFinalLocationField;
            }
            set
            {
                activityFinalLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesItem")]
        public SalesItemType[] SalesItem
        {
            get
            {
                return salesItemField;
            }
            set
            {
                salesItemField = value;
            }
        }
    }
}
