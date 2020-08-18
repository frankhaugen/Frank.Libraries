using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.Models.StandardBusinessDocument
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    [XmlRoot(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader", IsNullable = false)]
    public class CorrelationInformation
    {
        private DateTime _requestingDocumentCreationDateTimeField;

        private bool _requestingDocumentCreationDateTimeFieldSpecified;

        private string _requestingDocumentInstanceIdentifierField;

        private DateTime _expectedResponseDateTimeField;

        private bool _expectedResponseDateTimeFieldSpecified;

        /// <remarks/>
        public DateTime RequestingDocumentCreationDateTime
        {
            get => _requestingDocumentCreationDateTimeField;
            set => _requestingDocumentCreationDateTimeField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool RequestingDocumentCreationDateTimeSpecified
        {
            get => _requestingDocumentCreationDateTimeFieldSpecified;
            set => _requestingDocumentCreationDateTimeFieldSpecified = value;
        }

        /// <remarks/>
        public string RequestingDocumentInstanceIdentifier
        {
            get => _requestingDocumentInstanceIdentifierField;
            set => _requestingDocumentInstanceIdentifierField = value;
        }

        /// <remarks/>
        public DateTime ExpectedResponseDateTime
        {
            get => _expectedResponseDateTimeField;
            set => _expectedResponseDateTimeField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ExpectedResponseDateTimeSpecified
        {
            get => _expectedResponseDateTimeFieldSpecified;
            set => _expectedResponseDateTimeFieldSpecified = value;
        }
    }
}