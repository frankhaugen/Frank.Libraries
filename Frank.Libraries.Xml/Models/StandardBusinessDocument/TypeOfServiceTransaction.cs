using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.Models.StandardBusinessDocument
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace =
        "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public enum TypeOfServiceTransaction
    {

        /// <remarks/>
        RequestingServiceTransaction,

        /// <remarks/>
        RespondingServiceTransaction,
    }
}