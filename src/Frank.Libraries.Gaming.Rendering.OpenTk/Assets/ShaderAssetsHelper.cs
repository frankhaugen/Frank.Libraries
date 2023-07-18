using System.Reflection;
using System.Text;
using OpenTK.Graphics.OpenGL;

namespace Frank.Libraries.Gaming.Rendering.OpenTk.Assets;

public static class ShaderAssetsHelper
{
    public static ShaderProgramInfo GetShaderProgramInfo(string name)
    {
        var vertexShader = GetShaderInfo(name, ShaderType.VertexShader);
        var fragmentShader = GetShaderInfo(name, ShaderType.FragmentShader);
        var shaderProgram = new ShaderProgramInfo(vertexShader, fragmentShader);
        return shaderProgram;
    }

    private static ShaderInfo GetShaderInfo(string name, ShaderType shaderType)
    {
        var assembly = typeof(Shader).Assembly;
        var resourceName = GetResourceName(assembly, name, shaderType.ToShaderTypeExtension());
        if (resourceName is null) throw new Exception($"Resource {name} not found in assembly {assembly.FullName}");
        var bytes = GetResource(assembly, resourceName);
        var source = Encoding.UTF8.GetString(bytes.ToArray());
        var shaderInfo = new ShaderInfo(resourceName, shaderType, source);
        return shaderInfo;
    }

    private static string? GetResourceName(Assembly assembly, string name, ShaderTypeExtension extension)
    {
        var manifestResourceNames = assembly.GetManifestResourceNames();
        var fileName = $"{name}.{extension.GetExtension()}";
        var existingResourceName = manifestResourceNames.FirstOrDefault(x => x.EndsWith(fileName, StringComparison.InvariantCultureIgnoreCase));
        return existingResourceName;
    }

    private static Memory<byte> GetResource(Assembly assembly, string resourceName)
    {
        using var existingResource = assembly.GetManifestResourceStream(resourceName);
        var memoryStream = new MemoryStream();
        existingResource!.CopyTo(memoryStream);
        var bytes = memoryStream.ToArray();
        return bytes;
    }
}