namespace Frank.Libraries.Ubl.Validation.Internals;

internal class XsdFiles
{
    private const string Root = "xsd";
    private const string Sbdh = "sdbh";
    private const string Maindoc = "maindoc";
    private const string Common = "common";

    private readonly IEnumerable<string> _xsdNames;

    public XsdFiles()
    {
        _xsdNames = typeof(XsdFiles).Assembly.GetManifestResourceNames(Root);
        MaindocXsds = GetXsdNames(Root, Maindoc);
        SbdhXsds = GetXsdNames(Root, Sbdh);
        CommonXsds = GetXsdNames(Root, Common);
        AllXsds = GetXsdNames(Root);
    }

    public IEnumerable<string> MaindocXsds { get; }

    public IEnumerable<string> SbdhXsds { get; }

    public IEnumerable<string> CommonXsds { get; }

    public IEnumerable<string> AllXsds { get; }

    private IEnumerable<string> GetXsdNames(string rootFolder, string? subFolder = null) =>
        string.IsNullOrWhiteSpace(subFolder)
            ? _xsdNames.Where(x => x.Contains(rootFolder, StringComparison.Ordinal))
            : _xsdNames.Where(x =>
                                  x.Contains(rootFolder, StringComparison.Ordinal) && x.Contains(subFolder, StringComparison.Ordinal));
}