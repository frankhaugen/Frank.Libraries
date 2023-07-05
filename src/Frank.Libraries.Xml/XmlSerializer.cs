using Frank.Libraries.Xml.Internals;

namespace Frank.Libraries.Xml;

public class XmlSerializer : IXmlSerializer
{
    public string Serialize<T>(T obj) where T : class => InternalSerializer.Serialize(obj);

    public T? Deserialize<T>(string xml) where T : class => InternalSerializer.Deserialize<T>(xml);
}