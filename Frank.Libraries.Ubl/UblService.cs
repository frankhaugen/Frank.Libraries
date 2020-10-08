using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl
{
    /// <summary>
    /// A service to interact with UBLs in <c>this</c> library
    /// </summary>
    public class UblService
    {
        /// <summary>
        /// Get an Invoice back based on the XML
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public T DeserializeToInvoiceType<T>(string xml)
        {
            _ = XElement.Parse(xml);

            var serializer = new XmlSerializer(typeof(T));

            using var stringReader = new StringReader(xml);
            using var xmlReader = XmlReader.Create(stringReader);
            var document = (T)serializer.Deserialize(xmlReader);

            return document;
        }
    }
}
