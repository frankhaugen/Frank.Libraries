namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalCommodityClassification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CommodityClassificationType
    {

        private NatureCodeType natureCodeField;

        private CargoTypeCodeType cargoTypeCodeField;

        private CommodityCodeType commodityCodeField;

        private ItemClassificationCodeType itemClassificationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NatureCodeType NatureCode
        {
            get
            {
                return natureCodeField;
            }
            set
            {
                natureCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CargoTypeCodeType CargoTypeCode
        {
            get
            {
                return cargoTypeCodeField;
            }
            set
            {
                cargoTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CommodityCodeType CommodityCode
        {
            get
            {
                return commodityCodeField;
            }
            set
            {
                commodityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ItemClassificationCodeType ItemClassificationCode
        {
            get
            {
                return itemClassificationCodeField;
            }
            set
            {
                itemClassificationCodeField = value;
            }
        }
    }
}