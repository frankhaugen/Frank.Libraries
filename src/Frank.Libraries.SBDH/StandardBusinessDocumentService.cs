using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Frank.Libraries.SBDH
{
    /// <summary>
    /// Simple functions to interact with Standard Business Documents
    /// </summary>
    public class StandardBusinessDocumentService
    {
        /// <summary>
        /// Deserializes an XML-string into a <see cref="StandardBusinessDocument"/>
        /// </summary>
        /// <param name="xml">The XML string with valid schema</param>
        /// <returns>a StandardBusinessDocument</returns>
        public StandardBusinessDocument Deserialize(string xml)
        {
            _ = XElement.Parse(xml);
            var serializer = new XmlSerializer(typeof(StandardBusinessDocument));
            using var stringReader = new StringReader(xml);
            using var xmlReader = XmlReader.Create(stringReader);
            var document = (StandardBusinessDocument)serializer.Deserialize(xmlReader);
            return document;
        }

        /// <summary>
        /// Serializes a <see cref="StandardBusinessDocument"/> into an XML string
        /// </summary>
        /// <param name="document">The StandardBusinessDocument object</param>
        /// <returns>A valid XML string according to the correct schema</returns>
        public string Serialize(StandardBusinessDocument document)
        {
            var xmlSerializer = new XmlSerializer(typeof(StandardBusinessDocument));
            using var stringWriter = new StringWriter();
            xmlSerializer!.Serialize(stringWriter, document);
            return stringWriter!.ToString();
        }
    }
}