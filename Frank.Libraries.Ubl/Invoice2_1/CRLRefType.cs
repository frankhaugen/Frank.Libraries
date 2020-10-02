namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CrlRefType
    {

        private DigestAlgAndValueType _digestAlgAndValueField;

        private CrlIdentifierType _cRlIdentifierField;

        /// <remarks/>
        public DigestAlgAndValueType DigestAlgAndValue
        {
            get
            {
                return _digestAlgAndValueField;
            }
            set
            {
                _digestAlgAndValueField = value;
            }
        }

        /// <remarks/>
        public CrlIdentifierType CrlIdentifier
        {
            get
            {
                return _cRlIdentifierField;
            }
            set
            {
                _cRlIdentifierField = value;
            }
        }
    }
}