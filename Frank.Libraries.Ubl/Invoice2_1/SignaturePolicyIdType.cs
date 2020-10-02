namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class SignaturePolicyIdType
    {

        private ObjectIdentifierType sigPolicyIdField;

        private TransformType[] transformsField;

        private DigestAlgAndValueType sigPolicyHashField;

        private AnyType[] sigPolicyQualifiersField;

        /// <remarks/>
        public ObjectIdentifierType SigPolicyId
        {
            get
            {
                return sigPolicyIdField;
            }
            set
            {
                sigPolicyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return transformsField;
            }
            set
            {
                transformsField = value;
            }
        }

        /// <remarks/>
        public DigestAlgAndValueType SigPolicyHash
        {
            get
            {
                return sigPolicyHashField;
            }
            set
            {
                sigPolicyHashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SigPolicyQualifier", IsNullable = false)]
        public AnyType[] SigPolicyQualifiers
        {
            get
            {
                return sigPolicyQualifiersField;
            }
            set
            {
                sigPolicyQualifiersField = value;
            }
        }
    }
}