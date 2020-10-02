namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class DocumentationReferencesType
    {

        private string[] documentationReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentationReference", DataType = "anyURI")]
        public string[] DocumentationReference
        {
            get
            {
                return documentationReferenceField;
            }
            set
            {
                documentationReferenceField = value;
            }
        }
    }
}