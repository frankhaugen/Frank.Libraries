namespace Frank.Libraries.AzureStorage.FileShare;

public abstract class FileShareReference
{
    public FileShareReference(string name, string directoryPath)
    {
        Filename = name;
        DirectoryPath = directoryPath;

        FileShareReferenceGuards.EnsureValid(name);
        FileShareReferenceGuards.ValidateDirectoryName(directoryPath);
    }

    public string Filename { get; }
    public string DirectoryPath { get; }
}