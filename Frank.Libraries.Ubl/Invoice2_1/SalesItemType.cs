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

        private QuantityType2 _quantityField;

        private ActivityPropertyType[] _activityPropertyField;

        private PriceType[] _taxExclusivePriceField;

        private PriceType[] _taxInclusivePriceField;

        private ItemType _itemField;

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
        [System.Xml.Serialization.XmlElementAttribute("ActivityProperty")]
        public ActivityPropertyType[] ActivityProperty
        {
            get
            {
                return _activityPropertyField;
            }
            set
            {
                _activityPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxExclusivePrice")]
        public PriceType[] TaxExclusivePrice
        {
            get
            {
                return _taxExclusivePriceField;
            }
            set
            {
                _taxExclusivePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxInclusivePrice")]
        public PriceType[] TaxInclusivePrice
        {
            get
            {
                return _taxInclusivePriceField;
            }
            set
            {
                _taxInclusivePriceField = value;
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
    }
}