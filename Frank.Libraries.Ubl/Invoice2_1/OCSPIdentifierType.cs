namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OcspIdentifierType
    {

        private ResponderIdType _responderIdField;

        private System.DateTime _producedAtField;

        private string _uRiField;

        /// <remarks/>
        public ResponderIdType ResponderId
        {
            get
            {
                return _responderIdField;
            }
            set
            {
                _responderIdField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ProducedAt
        {
            get
            {
                return _producedAtField;
            }
            set
            {
                _producedAtField = value;
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