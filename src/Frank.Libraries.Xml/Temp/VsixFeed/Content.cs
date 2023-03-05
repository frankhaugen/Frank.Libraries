using System.Xml.Serialization;

namespace Frank.Libraries.Xml.Temp.VsixFeed;

[XmlRoot(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
public class Content
{
    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

    [XmlAttribute(AttributeName = "src")] public string Src { get; set; }
}