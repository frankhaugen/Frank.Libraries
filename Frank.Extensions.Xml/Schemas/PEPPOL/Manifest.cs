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
    public partial class Manifest
    {

        private string _numberOfItemsField;

        private ManifestItem[] _manifestItemField;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string NumberOfItems
        {
            get => _numberOfItemsField;
            set => _numberOfItemsField = value;
        }

        /// <remarks/>
        [XmlElement("ManifestItem")]
        public ManifestItem[] ManifestItem
        {
            get => _manifestItemField;
            set => _manifestItemField = value;
        }
    }
}