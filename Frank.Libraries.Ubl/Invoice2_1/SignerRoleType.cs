namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SignerRole", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class SignerRoleType
    {

        private AnyType[] _claimedRolesField;

        private EncapsulatedPkiDataType[] _certifiedRolesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ClaimedRole", IsNullable = false)]
        public AnyType[] ClaimedRoles
        {
            get
            {
                return _claimedRolesField;
            }
            set
            {
                _claimedRolesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CertifiedRole", IsNullable = false)]
        public EncapsulatedPkiDataType[] CertifiedRoles
        {
            get
            {
                return _certifiedRolesField;
            }
            set
            {
                _certifiedRolesField = value;
            }
        }
    }
}