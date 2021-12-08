using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml
{
    public static class XmlExtensions
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="xElement"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool TrySerializeToXml(this string xml, out XElement? xElement)
        {
            try
            {
                xElement = XElement.Parse(xml);
                return true;
            }
            catch
            {
                xElement = null;
                return false;
            }
        }

        /// <summary>
        /// A helper to serialize an object to a string containing XML data of the object.
        /// </summary>
        /// <typeparam name="T">An object to serialize to a XML data string.</typeparam>
        /// <param name="toSerialize">A helper method for any type of object to be serialized to a XML data string.</param>
        /// <returns>A string containing XML data of the object.</returns>
        public static string SerializeObjectToXml<T>(this T toSerialize) where T : class, new()
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using var stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, toSerialize);
            return stringWriter!.ToString();
        }

        /// <summary>
        /// Deserializes an object which is saved to an XML data string. If the object has no instance a new object will be constructed if possible.
        /// <note type="note">An exception will occur if a null reference is called an no valid constructor of the class is available.</note>
        /// </summary>
        /// <typeparam name="T">An object to deserialize from a XML data string.</typeparam>
        /// <param name="xmlData">A string containing a serialized XML data do deserialize.</param>
        /// <returns>An object which is deserialized from the XML data string.</returns>
        public static T? DeserializeObjectFromXml<T>(this string xmlData) where T : class, new()
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using var stringReader = new StringReader(xmlData);
            return (T)xmlSerializer.Deserialize(stringReader)!;
        }

        /// <summary>
        /// Tries to deserializes an object which is saved to an XML data string. If the object has no instance a new object will be constructed if possible.
        /// <note type="note">An exception will occur if a null reference is called an no valid constructor of the class is available.</note>
        /// </summary>
        /// <typeparam name="T">An object to deserialize from a XML data string.</typeparam>
        /// <param name="xmlData">A string containing a serialized XML data do deserialize.</param>
        /// <param name="value"></param>
        /// <returns>An object which is deserialized from the XML data string.</returns>
        public static bool TryDeserializeObjectFromXml<T>(this string xmlData, out T value) where T : class, new()
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                using var stringReader = new StringReader(xmlData);
                value = ((T)xmlSerializer.Deserialize(stringReader)!)!;
                return true;
            }
            catch
            {
                value = null!;
                return false;
            }
        }
    }
}