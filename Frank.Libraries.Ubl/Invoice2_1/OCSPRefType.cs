namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OCSPRefType
    {

        private OCSPIdentifierType oCSPIdentifierField;

        private DigestAlgAndValueType digestAlgAndValueField;

        /// <remarks/>
        public OCSPIdentifierType OCSPIdentifier
        {
            get
            {
                return oCSPIdentifierField;
            }
            set
            {
                oCSPIdentifierField = value;
            }
        }

        /// <remarks/>
        public DigestAlgAndValueType DigestAlgAndValue
        {
            get
            {
                return digestAlgAndValueField;
            }
            set
            {
                digestAlgAndValueField = value;
            }
        }
    }
}