using System.Xml.Serialization;

namespace Frank.Libraries.Xml.Temp.VsixFeed;

[XmlRoot(ElementName="Vsix", Namespace="http://schemas.microsoft.com/developer/vsx-syndication-schema/2010")]
public class Vsix {
    [XmlElement(ElementName="Id", Namespace="http://schemas.microsoft.com/developer/vsx-syndication-schema/2010")]
    public string Id { get; set; }
    [XmlElement(ElementName="Version", Namespace="http://schemas.microsoft.com/developer/vsx-syndication-schema/2010")]
    public string Version { get; set; }
    [XmlElement(ElementName="References", Namespace="http://schemas.microsoft.com/developer/vsx-syndication-schema/2010")]
    public string References { get; set; }
    [XmlElement(ElementName="Rating", Namespace="http://schemas.microsoft.com/developer/vsx-syndication-schema/2010")]
    public Rating Rating { get; set; }
    [XmlElement(ElementName="RatingCount", Namespace="http://schemas.microsoft.com/developer/vsx-syndication-schema/2010")]
    public RatingCount RatingCount { get; set; }
    [XmlElement(ElementName="DownloadCount", Namespace="http://schemas.microsoft.com/developer/vsx-syndication-schema/2010")]
    public DownloadCount DownloadCount { get; set; }
    [XmlAttribute(AttributeName="xsi", Namespace="http://www.w3.org/2000/xmlns/")]
    public string Xsi { get; set; }
    [XmlAttribute(AttributeName="xsd", Namespace="http://www.w3.org/2000/xmlns/")]
    public string Xsd { get; set; }
    [XmlAttribute(AttributeName="xmlns")]
    public string Xmlns { get; set; }
    [XmlElement(ElementName="PackedExtensionIDs", Namespace="http://schemas.microsoft.com/developer/vsx-syndication-schema/2010")]
    public string PackedExtensionIDs { get; set; }
}