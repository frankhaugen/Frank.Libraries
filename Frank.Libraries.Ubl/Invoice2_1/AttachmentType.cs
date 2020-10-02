namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Attachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AttachmentType
    {

        private EmbeddedDocumentBinaryObjectType _embeddedDocumentBinaryObjectField;

        private ExternalReferenceType _externalReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EmbeddedDocumentBinaryObjectType EmbeddedDocumentBinaryObject
        {
            get
            {
                return _embeddedDocumentBinaryObjectField;
            }
            set
            {
                _embeddedDocumentBinaryObjectField = value;
            }
        }

        /// <remarks/>
        public ExternalReferenceType ExternalReference
        {
            get
            {
                return _externalReferenceField;
            }
            set
            {
                _externalReferenceField = value;
            }
        }
    }
}