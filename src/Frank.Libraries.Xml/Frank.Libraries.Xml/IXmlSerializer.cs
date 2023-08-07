namespace Frank.Libraries.Xml;

public interface IXmlSerializer
{
    string Serialize<T>(T obj) where T : class;

    T? Deserialize<T>(string xml) where T : class;
}