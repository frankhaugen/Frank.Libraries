namespace Frank.Libraries.Gaming.Core.FileProviders;

public class ManifestFileProvider : I3DFileProvider
{
    public Memory<byte> GetFile(string fileName)
    {
        var assembly = GetType().Assembly;
        var manifestResourceNames = assembly.GetManifestResourceNames();
        var existingResourceName = manifestResourceNames.FirstOrDefault(x => x.EndsWith("teapot.obj", StringComparison.InvariantCultureIgnoreCase));
        using var existingResource = assembly.GetManifestResourceStream(existingResourceName!);
        var memoryStream = new MemoryStream();
        existingResource!.CopyTo(memoryStream);
        var bytes = memoryStream.ToArray();
        return bytes;
    }
}