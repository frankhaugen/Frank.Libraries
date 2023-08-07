using System.Xml;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.Internals;

internal static class InternalSerializer
{
    private static System.Xml.Serialization.XmlSerializer GetSerializer<T>() where T : class => new(typeof(T));

    public static T? Deserialize<T>(string xml) where T : class
    {
        var serializer = GetSerializer<T>();
        using var stringReader = new StringReader(xml);
        using var xmlReader = XmlReader.Create(stringReader);
        var documentObject = serializer.Deserialize(xmlReader);
        if (documentObject is T instance)
            return instance;

        return default;
    }

    public static string Serialize<T>(T obj) where T : class
    {
        if (obj == null)
            throw new ArgumentNullException(nameof(obj));

        var serializer = GetSerializer<T>();
        using var stringWriter = new StringWriter();
        using var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true, IndentChars = "    " });

        var namespaces = new XmlSerializerNamespaces();
        namespaces.Add("ns", typeof(T).Namespace);

        serializer.Serialize(xmlWriter, obj, namespaces);
        return stringWriter.ToString();
    }
}