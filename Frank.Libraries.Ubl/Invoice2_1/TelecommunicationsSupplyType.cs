namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TelecommunicationsSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TelecommunicationsSupplyType
    {

        private TelecommunicationsSupplyTypeType telecommunicationsSupplyType1Field;

        private TelecommunicationsSupplyTypeCodeType telecommunicationsSupplyTypeCodeField;

        private PrivacyCodeType privacyCodeField;

        private DescriptionType[] descriptionField;

        private TotalAmountType totalAmountField;

        private TelecommunicationsSupplyLineType[] telecommunicationsSupplyLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupplyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TelecommunicationsSupplyTypeType TelecommunicationsSupplyType1
        {
            get
            {
                return telecommunicationsSupplyType1Field;
            }
            set
            {
                telecommunicationsSupplyType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TelecommunicationsSupplyTypeCodeType TelecommunicationsSupplyTypeCode
        {
            get
            {
                return telecommunicationsSupplyTypeCodeField;
            }
            set
            {
                telecommunicationsSupplyTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrivacyCodeType PrivacyCode
        {
            get
            {
                return privacyCodeField;
            }
            set
            {
                privacyCodeField = value;
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
        public TotalAmountType TotalAmount
        {
            get
            {
                return totalAmountField;
            }
            set
            {
                totalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupplyLine")]
        public TelecommunicationsSupplyLineType[] TelecommunicationsSupplyLine
        {
            get
            {
                return telecommunicationsSupplyLineField;
            }
            set
            {
                telecommunicationsSupplyLineField = value;
            }
        }
    }
}