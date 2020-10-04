using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlRoot("UBLExtension", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable=false)]
    public class UBLExtensionType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name;
    
        /// <remarks/>
        public ExtensionAgencyIDType ExtensionAgencyID;
    
        /// <remarks/>
        public ExtensionAgencyNameType ExtensionAgencyName;
    
        /// <remarks/>
        public ExtensionVersionIDType ExtensionVersionID;
    
        /// <remarks/>
        public ExtensionAgencyURIType ExtensionAgencyURI;
    
        /// <remarks/>
        public ExtensionURIType ExtensionURI;
    
        /// <remarks/>
        public ExtensionReasonCodeType ExtensionReasonCode;
    
        /// <remarks/>
        public ExtensionReasonType ExtensionReason;
    
        /// <remarks/>
        public XmlElement ExtensionContent;
    }
}