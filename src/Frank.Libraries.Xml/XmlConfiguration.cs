using System.IO;

namespace Frank.Libraries.Xml;

public class XmlConfiguration
{
    public string Folder { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "Data");
}