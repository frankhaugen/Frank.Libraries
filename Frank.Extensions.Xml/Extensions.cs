using System;
using System.IO;
using System.Xml.Serialization;

namespace Frank.Extensions.Xml
{
    public static class Extensions
    {
        // THIS: (C): https://stackoverflow.com/questions/2434534/serialize-an-object-to-string
        /// <summary>
        /// A helper to serialize an object to a string containing XML data of the object.
        /// </summary>
        /// <typeparam name="T">An object to serialize to a XML data string.</typeparam>
        /// <param name="toSerialize">A helper method for any type of object to be serialized to a XML data string.</param>
        /// <returns>A string containing XML data of the object.</returns>
        public static string SerializeObjectToXml<T>(this T toSerialize)
        {
            // create an instance of a XmlSerializer class with the typeof(T)..
            var xmlSerializer = new XmlSerializer(toSerialize.GetType());

            // using is necessary with classes which implement the IDisposable interface..
            using (var stringWriter = new StringWriter())
            {
                // serialize a class to a StringWriter class instance..
                xmlSerializer.Serialize(stringWriter, toSerialize); // a base class of the StringWriter instance is TextWriter..
                return stringWriter.ToString(); // return the value..
            }
        }

        // THIS: (C): VPKSoft, 2018, https://www.vpksoft.net
        /// <summary>
        /// Deserializes an object which is saved to an XML data string. If the object has no instance a new object will be constructed if possible.
        /// <note type="note">An exception will occur if a null reference is called an no valid constructor of the class is available.</note>
        /// </summary>
        /// <typeparam name="T">An object to deserialize from a XML data string.</typeparam>
        /// <param name="xmlData">A string containing a serialized XML data do deserialize.</param>
        /// <returns>An object which is deserialized from the XML data string.</returns>
        public static T DeserializeObjectFromXml<T>(this string xmlData) where T : class, new()
        {
            // if a null instance of an object called this try to create a "default" instance for it with typeof(T),
            // this will throw an exception no useful constructor is found..
            var voidInstance = Activator.CreateInstance(typeof(T));

            // create an instance of a XmlSerializer class with the typeof(T)..
            var xmlSerializer = new XmlSerializer(voidInstance.GetType());

            // construct a StringReader class instance of the given xmlData parameter to be deserialized by the XmlSerializer class instance..
            using (var stringReader = new StringReader(xmlData))
            {
                // return the "new" object deserialized via the XmlSerializer class instance..
                return (T)xmlSerializer.Deserialize(stringReader);
            }
        }

        // THIS: (C): VPKSoft, 2018, https://www.vpksoft.net
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
                // if a null instance of an object called this try to create a "default" instance for it with typeof(T),
                // this will throw an exception no useful constructor is found..
                var voidInstance = Activator.CreateInstance(typeof(T));

                // create an instance of a XmlSerializer class with the typeof(T)..
                var xmlSerializer = new XmlSerializer(voidInstance.GetType());

                // construct a StringReader class instance of the given xmlData parameter to be deserialized by the XmlSerializer class instance..
                using (var stringReader = new StringReader(xmlData))
                {
                    // return the "new" object deserialized via the XmlSerializer class instance..
                    value = (T)xmlSerializer.Deserialize(stringReader);
                }

                return true;
            }
            catch
            {
                value = null;
                return false;
            }
        }
    }
}