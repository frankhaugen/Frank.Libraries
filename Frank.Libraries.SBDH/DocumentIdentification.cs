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
    [XmlType("DocumentIdentification", Namespace="http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class DocumentIdentification
    {
        
        [Required()]
        [XmlElement("Standard")]
        public string Standard { get; set; }
        
        [Required()]
        [XmlElement("TypeVersion")]
        public string TypeVersion { get; set; }
        
        [Required()]
        [XmlElement("InstanceIdentifier")]
        public string InstanceIdentifier { get; set; }
        
        [Required()]
        [XmlElement("Type")]
        public string Type { get; set; }
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("MultipleType")]
        public bool MultipleTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MultipleType-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MultipleType property is specified.</para>
        /// </summary>
        [XmlIgnore()]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool MultipleTypeValueSpecified { get; set; }
        
        [XmlIgnore()]
        public Nullable<bool> MultipleType
        {
            get
            {
                if (this.MultipleTypeValueSpecified)
                {
                    return this.MultipleTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MultipleTypeValue = value.GetValueOrDefault();
                this.MultipleTypeValueSpecified = value.HasValue;
            }
        }
        
        [Required()]
        [XmlElement("CreationDateAndTime", DataType="dateTime")]
        public DateTime CreationDateAndTime { get; set; }
    }
}