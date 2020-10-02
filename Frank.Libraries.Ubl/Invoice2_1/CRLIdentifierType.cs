namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CRLIdentifierType
    {

        private string issuerField;

        private System.DateTime issueTimeField;

        private string numberField;

        private string uRIField;

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return issuerField;
            }
            set
            {
                issuerField = value;
            }
        }

        /// <remarks/>
        public System.DateTime IssueTime
        {
            get
            {
                return issueTimeField;
            }
            set
            {
                issueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Number
        {
            get
            {
                return numberField;
            }
            set
            {
                numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return uRIField;
            }
            set
            {
                uRIField = value;
            }
        }
    }
}