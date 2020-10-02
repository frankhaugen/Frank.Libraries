namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CrlIdentifierType
    {

        private string _issuerField;

        private System.DateTime _issueTimeField;

        private string _numberField;

        private string _uRiField;

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return _issuerField;
            }
            set
            {
                _issuerField = value;
            }
        }

        /// <remarks/>
        public System.DateTime IssueTime
        {
            get
            {
                return _issueTimeField;
            }
            set
            {
                _issueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Number
        {
            get
            {
                return _numberField;
            }
            set
            {
                _numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Uri
        {
            get
            {
                return _uRiField;
            }
            set
            {
                _uRiField = value;
            }
        }
    }
}