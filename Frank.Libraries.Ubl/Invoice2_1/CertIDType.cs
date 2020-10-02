namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CertIDType
    {

        private DigestAlgAndValueType certDigestField;

        private X509IssuerSerialType issuerSerialField;

        private string uRIField;

        /// <remarks/>
        public DigestAlgAndValueType CertDigest
        {
            get
            {
                return certDigestField;
            }
            set
            {
                certDigestField = value;
            }
        }

        /// <remarks/>
        public X509IssuerSerialType IssuerSerial
        {
            get
            {
                return issuerSerialField;
            }
            set
            {
                issuerSerialField = value;
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