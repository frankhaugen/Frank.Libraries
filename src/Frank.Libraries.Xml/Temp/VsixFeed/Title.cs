using System.Xml.Serialization;

namespace Frank.Libraries.Xml.Temp.VsixFeed;

[XmlRoot(ElementName="title", Namespace="http://www.w3.org/2005/Atom")]
public class Title {
    [XmlAttribute(AttributeName="type")]
    public string Type { get; set; }
    [XmlText]
    public string Text { get; set; }
}