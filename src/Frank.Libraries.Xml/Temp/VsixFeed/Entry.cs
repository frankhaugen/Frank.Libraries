using System.Collections.Generic;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.Temp.VsixFeed;

[XmlRoot(ElementName = "entry", Namespace = "http://www.w3.org/2005/Atom")]
public class Entry
{
    [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
    public string Id { get; set; }

    [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
    public Title Title { get; set; }

    [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
    public List<Link> Link { get; set; }

    [XmlElement(ElementName = "summary", Namespace = "http://www.w3.org/2005/Atom")]
    public Summary Summary { get; set; }

    [XmlElement(ElementName = "published", Namespace = "http://www.w3.org/2005/Atom")]
    public string Published { get; set; }

    [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
    public string Updated { get; set; }

    [XmlElement(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
    public Author Author { get; set; }

    [XmlElement(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
    public Content Content { get; set; }

    [XmlElement(ElementName = "Vsix", Namespace = "http://schemas.microsoft.com/developer/vsx-syndication-schema/2010")]
    public Vsix Vsix { get; set; }
}