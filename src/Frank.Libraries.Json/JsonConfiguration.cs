using System.IO;

namespace Frank.Libraries.Json
{
    public class JsonConfiguration
    {
        public string Folder { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "Data");
    }
}
