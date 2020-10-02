namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class SignedPropertiesType
    {

        private SignedSignaturePropertiesType signedSignaturePropertiesField;

        private SignedDataObjectPropertiesType signedDataObjectPropertiesField;

        private string idField;

        /// <remarks/>
        public SignedSignaturePropertiesType SignedSignatureProperties
        {
            get
            {
                return signedSignaturePropertiesField;
            }
            set
            {
                signedSignaturePropertiesField = value;
            }
        }

        /// <remarks/>
        public SignedDataObjectPropertiesType SignedDataObjectProperties
        {
            get
            {
                return signedDataObjectPropertiesField;
            }
            set
            {
                signedDataObjectPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }
}