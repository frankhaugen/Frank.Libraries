namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SigningCertificate", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class CertIdListType
    {

        private CertIdType[] _certField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cert")]
        public CertIdType[] Cert
        {
            get
            {
                return _certField;
            }
            set
            {
                _certField = value;
            }
        }
    }
}