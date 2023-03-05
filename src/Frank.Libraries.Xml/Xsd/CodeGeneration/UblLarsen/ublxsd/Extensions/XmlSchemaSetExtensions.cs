using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Schema;

namespace ublxsd.Extensions;

public static class XmlSchemaSetExtensions
{
    public static void AddMaindocSchemas(this XmlSchemaSet @this, UblXsdSettings ublSettings)
    {
        var readerSettings = new XmlReaderSettings
        {
            ValidationType = ValidationType.Schema,
            DtdProcessing = DtdProcessing.Parse, // will crash without this
            NameTable = @this.NameTable
        };

        // ubl2.1: Have to preload this file to avoid parsing error due to missing DtdProcessing.Parse setting for implicit includes/imports 
        var preloadFilename = ublSettings.CommonDirectory.GetFiles("UBL-xmldsig-core-schema-*.xsd")
                                         .FirstOrDefault()
                                         ?.FullName;
        if (!string.IsNullOrEmpty(preloadFilename))
        {
            @this.AddSchemaFile(preloadFilename, readerSettings, ublSettings.XsdValidationEvent);
        }

        foreach (var xsdFile in ublSettings.MaindocDirectory.GetFiles("*.xsd"))
        {
            var schema = @this.AddSchemaFile(xsdFile.FullName, readerSettings, ublSettings.XsdValidationEvent);
        }
    }

    private static XmlSchema AddSchemaFile(this XmlSchemaSet @this, string filename, XmlReaderSettings settings, ValidationEventHandler validationEventHandler)
    {
        using (var reader = XmlReader.Create(filename, settings))
        {
            var schema = XmlSchema.Read(reader, validationEventHandler);
            return @this.Add(schema);
        }
    }

    // use to build XmlSerializerNamespaces for the serializer
    public static XmlQualifiedName[] GetNamespacePrefixes(this XmlSchemaSet @this)
    {
        var nsList = new List<XmlQualifiedName>();
        foreach (XmlSchema schema in @this.Schemas())
        {
            nsList.AddRange(schema.Namespaces.ToArray()
                                  .Where(ns => !string.IsNullOrEmpty(ns.Name)));
        }

        //return nsList.Distinct().ToArray();
        var comparer = new QNameComparer();
        nsList.Sort(comparer.Compare);
        return nsList.ToArray();
    }

    public static ICollection<XmlSchema> MaindocSchemas(this XmlSchemaSet @this) =>
        // TODO: Need a better way of separating maindocschemas from common ones imported/incuded explicitly.
        @this.Schemas()
             .Cast<XmlSchema>()
             .Where(s => s.SourceUri.Contains("maindoc") && s.TargetNamespace.StartsWith(Constants.oasisUblTargetNamespacePrefix))
             .ToList();
}

internal class QNameComparer : IComparer
{
    public int Compare(object o1, object o2)
    {
        var qn1 = (XmlQualifiedName)o1;
        var qn2 = (XmlQualifiedName)o2;
        var ns = string.Compare(qn1.Namespace, qn2.Namespace, StringComparison.Ordinal);
        if (ns == 0)
        {
            return string.Compare(qn1.Name, qn2.Name, StringComparison.Ordinal);
        }

        return ns;
    }
}