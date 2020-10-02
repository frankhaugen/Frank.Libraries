namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.4.1#")]
    [System.Xml.Serialization.XmlRootAttribute("TimeStampValidationData", Namespace = "http://uri.etsi.org/01903/v1.4.1#", IsNullable = false)]
    public partial class ValidationDataType
    {

        private CertificateValuesType certificateValuesField;

        private RevocationValuesType revocationValuesField;

        private string idField;

        private string urField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public CertificateValuesType CertificateValues
        {
            get
            {
                return certificateValuesField;
            }
            set
            {
                certificateValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public RevocationValuesType RevocationValues
        {
            get
            {
                return revocationValuesField;
            }
            set
            {
                revocationValuesField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string UR
        {
            get
            {
                return urField;
            }
            set
            {
                urField = value;
            }
        }
    }
}