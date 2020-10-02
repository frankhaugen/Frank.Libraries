namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class SignedSignaturePropertiesType
    {

        private System.DateTime _signingTimeField;

        private bool _signingTimeFieldSpecified;

        private CertIdType[] _signingCertificateField;

        private SignaturePolicyIdentifierType _signaturePolicyIdentifierField;

        private SignatureProductionPlaceType _signatureProductionPlaceField;

        private SignerRoleType _signerRoleField;

        private string _idField;

        /// <remarks/>
        public System.DateTime SigningTime
        {
            get
            {
                return _signingTimeField;
            }
            set
            {
                _signingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SigningTimeSpecified
        {
            get
            {
                return _signingTimeFieldSpecified;
            }
            set
            {
                _signingTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable = false)]
        public CertIdType[] SigningCertificate
        {
            get
            {
                return _signingCertificateField;
            }
            set
            {
                _signingCertificateField = value;
            }
        }

        /// <remarks/>
        public SignaturePolicyIdentifierType SignaturePolicyIdentifier
        {
            get
            {
                return _signaturePolicyIdentifierField;
            }
            set
            {
                _signaturePolicyIdentifierField = value;
            }
        }

        /// <remarks/>
        public SignatureProductionPlaceType SignatureProductionPlace
        {
            get
            {
                return _signatureProductionPlaceField;
            }
            set
            {
                _signatureProductionPlaceField = value;
            }
        }

        /// <remarks/>
        public SignerRoleType SignerRole
        {
            get
            {
                return _signerRoleField;
            }
            set
            {
                _signerRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }
    }
}