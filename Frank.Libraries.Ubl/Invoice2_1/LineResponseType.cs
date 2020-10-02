namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("LineResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class LineResponseType
    {

        private LineReferenceType _lineReferenceField;

        private ResponseType[] _responseField;

        /// <remarks/>
        public LineReferenceType LineReference
        {
            get
            {
                return _lineReferenceField;
            }
            set
            {
                _lineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Response")]
        public ResponseType[] Response
        {
            get
            {
                return _responseField;
            }
            set
            {
                _responseField = value;
            }
        }
    }
}