namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("SalesItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class SalesItemType
    {

        private QuantityType2 quantityField;

        private ActivityPropertyType[] activityPropertyField;

        private PriceType[] taxExclusivePriceField;

        private PriceType[] taxInclusivePriceField;

        private ItemType itemField;

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
        [System.Xml.Serialization.XmlElementAttribute("ActivityProperty")]
        public ActivityPropertyType[] ActivityProperty
        {
            get
            {
                return activityPropertyField;
            }
            set
            {
                activityPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxExclusivePrice")]
        public PriceType[] TaxExclusivePrice
        {
            get
            {
                return taxExclusivePriceField;
            }
            set
            {
                taxExclusivePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxInclusivePrice")]
        public PriceType[] TaxInclusivePrice
        {
            get
            {
                return taxInclusivePriceField;
            }
            set
            {
                taxInclusivePriceField = value;
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
    }
}