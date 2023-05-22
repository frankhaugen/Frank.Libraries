namespace Frank.Libraries.Ubl.Validation.Internals;

internal class XsdManifest
{
    public XsdManifest()
    {
        var xsdFiles = new XsdFiles();
        var assembly = typeof(XsdManifest).Assembly;
        CommonXsdMetadata =
            xsdFiles.CommonXsds.ToDictionary(x => x, x => new XsdMetadata(assembly.GetManifestResourceFile(x)));
        MaindocXsdMetadata =
            xsdFiles.MaindocXsds.ToDictionary(x => x, x => new XsdMetadata(assembly.GetManifestResourceFile(x)));
        SbdhXsdMetadata =
            xsdFiles.SbdhXsds.ToDictionary(x => x, x => new XsdMetadata(assembly.GetManifestResourceFile(x)));
        XsdMetadata = xsdFiles.AllXsds.ToDictionary(x => x, x => new XsdMetadata(assembly.GetManifestResourceFile(x)));
    }

    public Dictionary<string, XsdMetadata> XsdMetadata { get; }

    public Dictionary<string, XsdMetadata> CommonXsdMetadata { get; }

    public Dictionary<string, XsdMetadata> MaindocXsdMetadata { get; }

    public Dictionary<string, XsdMetadata> SbdhXsdMetadata { get; }
}