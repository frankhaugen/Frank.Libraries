//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.444.0.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Cefact.Namespaces.StandardBusinessDocumentHeader
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.444.0")]
    [Serializable()]
    [XmlType("ContactInformation", Namespace="http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ContactInformation
    {
        
        [Required()]
        [XmlElement("Contact")]
        public string Contact { get; set; }
        
        [XmlElement("EmailAddress")]
        public string EmailAddress { get; set; }
        
        [XmlElement("FaxNumber")]
        public string FaxNumber { get; set; }
        
        [XmlElement("TelephoneNumber")]
        public string TelephoneNumber { get; set; }
        
        [XmlElement("ContactTypeIdentifier")]
        public string ContactTypeIdentifier { get; set; }
    }
}