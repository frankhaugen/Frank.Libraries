namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("QualifyingProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class QualifyingPropertiesType
    {

        private SignedPropertiesType signedPropertiesField;

        private UnsignedPropertiesType unsignedPropertiesField;

        private string targetField;

        private string idField;

        /// <remarks/>
        public SignedPropertiesType SignedProperties
        {
            get
            {
                return signedPropertiesField;
            }
            set
            {
                signedPropertiesField = value;
            }
        }

        /// <remarks/>
        public UnsignedPropertiesType UnsignedProperties
        {
            get
            {
                return unsignedPropertiesField;
            }
            set
            {
                unsignedPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Target
        {
            get
            {
                return targetField;
            }
            set
            {
                targetField = value;
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