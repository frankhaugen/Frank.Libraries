using System.Xml.Serialization;

namespace Frank.Libraries.Xml.Temp.VsixFeed;

[XmlRoot(ElementName = "RatingCount", Namespace = "http://schemas.microsoft.com/developer/vsx-syndication-schema/2010")]
public class RatingCount
{
    [XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string Nil { get; set; }
}