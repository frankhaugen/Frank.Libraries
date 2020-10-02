namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OCSPIdentifierType
    {

        private ResponderIDType responderIDField;

        private System.DateTime producedAtField;

        private string uRIField;

        /// <remarks/>
        public ResponderIDType ResponderID
        {
            get
            {
                return responderIDField;
            }
            set
            {
                responderIDField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ProducedAt
        {
            get
            {
                return producedAtField;
            }
            set
            {
                producedAtField = value;
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