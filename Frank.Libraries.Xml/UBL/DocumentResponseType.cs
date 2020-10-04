using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRoot("AdditionalDocumentResponse", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class DocumentResponseType {
    
        /// <remarks/>
        public ResponseType Response;
    
        /// <remarks/>
        [XmlElement("DocumentReference")]
        public DocumentReferenceType[] DocumentReference;
    
        /// <remarks/>
        public PartyType IssuerParty;
    
        /// <remarks/>
        public PartyType RecipientParty;
    
        /// <remarks/>
        [XmlElement("LineResponse")]
        public LineResponseType[] LineResponse;
    }
}