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

        private ConsumptionIDType consumptionIDField;

        private SpecificationTypeCodeType specificationTypeCodeField;

        private NoteType[] noteField;

        private TotalMeteredQuantityType totalMeteredQuantityField;

        private PartyType subscriberPartyField;

        private ConsumptionPointType utilityConsumptionPointField;

        private OnAccountPaymentType[] onAccountPaymentField;

        private ConsumptionType consumptionField;

        private SupplierConsumptionType[] supplierConsumptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionIDType ConsumptionID
        {
            get
            {
                return consumptionIDField;
            }
            set
            {
                consumptionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecificationTypeCodeType SpecificationTypeCode
        {
            get
            {
                return specificationTypeCodeField;
            }
            set
            {
                specificationTypeCodeField = value;
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
        public TotalMeteredQuantityType TotalMeteredQuantity
        {
            get
            {
                return totalMeteredQuantityField;
            }
            set
            {
                totalMeteredQuantityField = value;
            }
        }

        /// <remarks/>
        public PartyType SubscriberParty
        {
            get
            {
                return subscriberPartyField;
            }
            set
            {
                subscriberPartyField = value;
            }
        }

        /// <remarks/>
        public ConsumptionPointType UtilityConsumptionPoint
        {
            get
            {
                return utilityConsumptionPointField;
            }
            set
            {
                utilityConsumptionPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OnAccountPayment")]
        public OnAccountPaymentType[] OnAccountPayment
        {
            get
            {
                return onAccountPaymentField;
            }
            set
            {
                onAccountPaymentField = value;
            }
        }

        /// <remarks/>
        public ConsumptionType Consumption
        {
            get
            {
                return consumptionField;
            }
            set
            {
                consumptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplierConsumption")]
        public SupplierConsumptionType[] SupplierConsumption
        {
            get
            {
                return supplierConsumptionField;
            }
            set
            {
                supplierConsumptionField = value;
            }
        }
    }
}