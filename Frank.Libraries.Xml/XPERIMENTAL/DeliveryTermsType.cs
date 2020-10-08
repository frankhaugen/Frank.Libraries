namespace Bilagos.DocumentProcessor.UBL.Document
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DeliveryTermsType
    {

        private IDType idField;

        private SpecialTermsType[] specialTermsField;

        private LossRiskResponsibilityCodeType lossRiskResponsibilityCodeField;

        private LossRiskType[] lossRiskField;

        private AmountType2 amountField;

        private LocationType1 deliveryLocationField;

        private AllowanceChargeType allowanceChargeField;

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
        [System.Xml.Serialization.XmlElementAttribute("SpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialTermsType[] SpecialTerms
        {
            get
            {
                return this.specialTermsField;
            }
            set
            {
                this.specialTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LossRiskResponsibilityCodeType LossRiskResponsibilityCode
        {
            get
            {
                return this.lossRiskResponsibilityCodeField;
            }
            set
            {
                this.lossRiskResponsibilityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LossRisk", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LossRiskType[] LossRisk
        {
            get
            {
                return this.lossRiskField;
            }
            set
            {
                this.lossRiskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType2 Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
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
        public AllowanceChargeType AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
            }
        }
    }
}