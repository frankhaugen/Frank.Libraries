namespace Frank.Libraries.Gaming.Core.FileProviders;

public interface I3DFileProvider
{
    public Memory<byte> GetFile(string fileName);
}