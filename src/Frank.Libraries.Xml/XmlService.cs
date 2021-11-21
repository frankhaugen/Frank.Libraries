using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace Frank.Libraries.Xml
{
    public class XmlService
    {
        private readonly List<(XmlSeverityType, string)> _messageList;

        public XmlService()
        {
            _messageList = new List<(XmlSeverityType, string)>();
        }

        public IEnumerable<(XmlSeverityType, string)> Validate(string xml, params string[] xsds)
        {
            using TextReader xmlReader = new StringReader(xml);

            var settings = new XmlReaderSettings(); //http://docs.oasis-open.org/ubl/os-UBL-2.1/xsdrt/

            foreach (var xsd in xsds)
            {
                using TextReader xsdReader = new StringReader(xsd);
                var schema = XmlSchema.Read(xsdReader, (sender, args) => { });
                settings.Schemas.Add(schema!);
            }

            settings.ValidationType = ValidationType.Schema;
            settings.ValidationEventHandler += (sender, args) => _messageList.Add((args.Severity, args.Message));

            //var reader = XmlReader.Create(xmlReader, settings);

            //while (reader.Read()) { }

            return _messageList;
        }
    }
}