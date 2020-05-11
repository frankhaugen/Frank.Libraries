using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Extensions.Xml
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace =
        "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public partial class ManifestItem
    {

        private string _mimeTypeQualifierCodeField;

        private string _uniformResourceIdentifierField;

        private string _descriptionField;

        private string _languageCodeField;

        /// <remarks/>
        public string MimeTypeQualifierCode
        {
            get => _mimeTypeQualifierCodeField;
            set => _mimeTypeQualifierCodeField = value;
        }

        /// <remarks/>
        [XmlElement(DataType = "anyURI")]
        public string UniformResourceIdentifier
        {
            get => _uniformResourceIdentifierField;
            set => _uniformResourceIdentifierField = value;
        }

        /// <remarks/>
        public string Description
        {
            get => _descriptionField;
            set => _descriptionField = value;
        }

        /// <remarks/>
        public string LanguageCode
        {
            get => _languageCodeField;
            set => _languageCodeField = value;
        }
    }
}