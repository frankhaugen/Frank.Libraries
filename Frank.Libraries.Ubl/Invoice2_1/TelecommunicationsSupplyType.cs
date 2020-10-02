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

        private TelecommunicationsSupplyTypeType _telecommunicationsSupplyType1Field;

        private TelecommunicationsSupplyTypeCodeType _telecommunicationsSupplyTypeCodeField;

        private PrivacyCodeType _privacyCodeField;

        private DescriptionType[] _descriptionField;

        private TotalAmountType _totalAmountField;

        private TelecommunicationsSupplyLineType[] _telecommunicationsSupplyLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupplyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TelecommunicationsSupplyTypeType TelecommunicationsSupplyType1
        {
            get
            {
                return _telecommunicationsSupplyType1Field;
            }
            set
            {
                _telecommunicationsSupplyType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TelecommunicationsSupplyTypeCodeType TelecommunicationsSupplyTypeCode
        {
            get
            {
                return _telecommunicationsSupplyTypeCodeField;
            }
            set
            {
                _telecommunicationsSupplyTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrivacyCodeType PrivacyCode
        {
            get
            {
                return _privacyCodeField;
            }
            set
            {
                _privacyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalAmountType TotalAmount
        {
            get
            {
                return _totalAmountField;
            }
            set
            {
                _totalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupplyLine")]
        public TelecommunicationsSupplyLineType[] TelecommunicationsSupplyLine
        {
            get
            {
                return _telecommunicationsSupplyLineField;
            }
            set
            {
                _telecommunicationsSupplyLineField = value;
            }
        }
    }
}