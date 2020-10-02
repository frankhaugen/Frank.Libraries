namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Capability", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CapabilityType
    {

        private CapabilityTypeCodeType capabilityTypeCodeField;

        private DescriptionType[] descriptionField;

        private ValueAmountType valueAmountField;

        private ValueQuantityType valueQuantityField;

        private EvidenceSuppliedType[] evidenceSuppliedField;

        private PeriodType validityPeriodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CapabilityTypeCodeType CapabilityTypeCode
        {
            get
            {
                return capabilityTypeCodeField;
            }
            set
            {
                capabilityTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValueAmountType ValueAmount
        {
            get
            {
                return valueAmountField;
            }
            set
            {
                valueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValueQuantityType ValueQuantity
        {
            get
            {
                return valueQuantityField;
            }
            set
            {
                valueQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvidenceSupplied")]
        public EvidenceSuppliedType[] EvidenceSupplied
        {
            get
            {
                return evidenceSuppliedField;
            }
            set
            {
                evidenceSuppliedField = value;
            }
        }

        /// <remarks/>
        public PeriodType ValidityPeriod
        {
            get
            {
                return validityPeriodField;
            }
            set
            {
                validityPeriodField = value;
            }
        }
    }
}