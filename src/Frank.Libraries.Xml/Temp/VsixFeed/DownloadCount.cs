using System.Xml.Serialization;

namespace Frank.Libraries.Xml.Temp.VsixFeed;

[XmlRoot(ElementName="DownloadCount", Namespace="http://schemas.microsoft.com/developer/vsx-syndication-schema/2010")]
public class DownloadCount {
    [XmlAttribute(AttributeName="nil", Namespace="http://www.w3.org/2001/XMLSchema-instance")]
    public string Nil { get; set; }
}