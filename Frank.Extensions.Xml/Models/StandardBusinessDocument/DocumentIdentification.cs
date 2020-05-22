using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Extensions.Xml.Models.StandardBusinessDocument
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace =
        "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public class DocumentIdentification
    {
        private string _standardField;

        private string _typeVersionField;

        private string _instanceIdentifierField;

        private string _typeField;

        private bool _multipleTypeField;

        private bool _multipleTypeFieldSpecified;

        private DateTime _creationDateAndTimeField;

        /// <remarks/>
        public string Standard
        {
            get => _standardField;
            set => _standardField = value;
        }

        /// <remarks/>
        public string TypeVersion
        {
            get => _typeVersionField;
            set => _typeVersionField = value;
        }

        /// <remarks/>
        public string InstanceIdentifier
        {
            get => _instanceIdentifierField;
            set => _instanceIdentifierField = value;
        }

        /// <remarks/>
        public string Type
        {
            get => _typeField;
            set => _typeField = value;
        }

        /// <remarks/>
        public bool MultipleType
        {
            get => _multipleTypeField;
            set => _multipleTypeField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MultipleTypeSpecified
        {
            get => _multipleTypeFieldSpecified;
            set => _multipleTypeFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime CreationDateAndTime
        {
            get => _creationDateAndTimeField;
            set => _creationDateAndTimeField = value;
        }
    }
}