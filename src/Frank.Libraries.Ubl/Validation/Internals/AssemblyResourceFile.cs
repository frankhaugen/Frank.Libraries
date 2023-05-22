namespace Frank.Libraries.Ubl.Validation.Internals;

public readonly struct AssemblyResourceFile
{
    public AssemblyResourceFile(string name, Stream stream)
    {
        Name = name;
        Stream = stream;
    }

    public string Name { get; }

    public Stream Stream { get; }
}