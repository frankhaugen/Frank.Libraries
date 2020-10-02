namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Branch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class BranchType
    {

        private IdType _idField;

        private NameType1 _nameField;

        private FinancialInstitutionType _financialInstitutionField;

        private AddressType _addressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdType Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name
        {
            get
            {
                return _nameField;
            }
            set
            {
                _nameField = value;
            }
        }

        /// <remarks/>
        public FinancialInstitutionType FinancialInstitution
        {
            get
            {
                return _financialInstitutionField;
            }
            set
            {
                _financialInstitutionField = value;
            }
        }

        /// <remarks/>
        public AddressType Address
        {
            get
            {
                return _addressField;
            }
            set
            {
                _addressField = value;
            }
        }
    }
}