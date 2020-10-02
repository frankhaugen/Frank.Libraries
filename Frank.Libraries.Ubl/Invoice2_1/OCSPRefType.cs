namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OcspRefType
    {

        private OcspIdentifierType _oCspIdentifierField;

        private DigestAlgAndValueType _digestAlgAndValueField;

        /// <remarks/>
        public OcspIdentifierType OcspIdentifier
        {
            get
            {
                return _oCspIdentifierField;
            }
            set
            {
                _oCspIdentifierField = value;
            }
        }

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
    }
}