using System.Xml.Serialization;

namespace Frank.Libraries.Xml.Temp.VsixFeed;

[XmlRoot(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
public class Link
{
    [XmlAttribute(AttributeName = "rel")] public string Rel { get; set; }

    [XmlAttribute(AttributeName = "href")] public string Href { get; set; }
}