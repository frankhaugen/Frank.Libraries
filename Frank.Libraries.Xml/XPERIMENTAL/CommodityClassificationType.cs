namespace Bilagos.DocumentProcessor.UBL.Document
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
                return this.natureCodeField;
            }
            set
            {
                this.natureCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CargoTypeCodeType CargoTypeCode
        {
            get
            {
                return this.cargoTypeCodeField;
            }
            set
            {
                this.cargoTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CommodityCodeType CommodityCode
        {
            get
            {
                return this.commodityCodeField;
            }
            set
            {
                this.commodityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ItemClassificationCodeType ItemClassificationCode
        {
            get
            {
                return this.itemClassificationCodeField;
            }
            set
            {
                this.itemClassificationCodeField = value;
            }
        }
    }
}