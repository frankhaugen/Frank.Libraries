﻿namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CRLRefType
    {

        private DigestAlgAndValueType digestAlgAndValueField;

        private CRLIdentifierType cRLIdentifierField;

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

        /// <remarks/>
        public CRLIdentifierType CRLIdentifier
        {
            get
            {
                return cRLIdentifierField;
            }
            set
            {
                cRLIdentifierField = value;
            }
        }
    }
}