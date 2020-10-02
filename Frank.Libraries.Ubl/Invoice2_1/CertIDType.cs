namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CertIdType
    {

        private DigestAlgAndValueType _certDigestField;

        private X509IssuerSerialType _issuerSerialField;

        private string _uRiField;

        /// <remarks/>
        public DigestAlgAndValueType CertDigest
        {
            get
            {
                return _certDigestField;
            }
            set
            {
                _certDigestField = value;
            }
        }

        /// <remarks/>
        public X509IssuerSerialType IssuerSerial
        {
            get
            {
                return _issuerSerialField;
            }
            set
            {
                _issuerSerialField = value;
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