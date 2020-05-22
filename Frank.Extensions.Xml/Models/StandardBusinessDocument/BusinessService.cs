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
    [XmlRoot(
        Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader", IsNullable = false)]
    public class BusinessService
    {
        private string _businessServiceNameField;

        private ServiceTransaction _serviceTransactionField;

        /// <remarks/>
        public string BusinessServiceName
        {
            get => _businessServiceNameField;
            set => _businessServiceNameField = value;
        }

        /// <remarks/>
        public ServiceTransaction ServiceTransaction
        {
            get => _serviceTransactionField;
            set => _serviceTransactionField = value;
        }
    }
}