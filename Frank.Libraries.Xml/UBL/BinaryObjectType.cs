using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [XmlInclude(typeof(VideoType))]
    [XmlInclude(typeof(SoundType))]
    [XmlInclude(typeof(PictureType))]
    [XmlInclude(typeof(GraphicType))]
    [XmlInclude(typeof(BinaryObjectType1))]
    [XmlInclude(typeof(EmbeddedDocumentBinaryObjectType))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class BinaryObjectType {
    
        /// <remarks/>
        [XmlAttribute]
        public string format;
    
        /// <remarks/>
        [XmlAttribute(DataType="normalizedString")]
        public string mimeCode;
    
        /// <remarks/>
        [XmlAttribute(DataType="normalizedString")]
        public string encodingCode;
    
        /// <remarks/>
        [XmlAttribute(DataType="normalizedString")]
        public string characterSetCode;
    
        /// <remarks/>
        [XmlAttribute(DataType="anyURI")]
        public string uri;
    
        /// <remarks/>
        [XmlAttribute]
        public string filename;
    
        /// <remarks/>
        [XmlText(DataType="base64Binary")]
        public byte[] Value;
    }
}