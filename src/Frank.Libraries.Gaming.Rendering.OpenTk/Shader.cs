using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

namespace Frank.Libraries.Gaming.Rendering.OpenTk;

public readonly struct Shader : IDisposable
{
    private readonly int _handle;

    public Shader(string vertexSource, string fragmentSource)
    {
        _handle = GL.CreateProgram();

        var vertexShader = LoadShader(ShaderType.VertexShader, vertexSource);
        var fragmentShader = LoadShader(ShaderType.FragmentShader, fragmentSource);

        GL.AttachShader(_handle, vertexShader);
        GL.AttachShader(_handle, fragmentShader);

        GL.LinkProgram(_handle);

        GL.DetachShader(_handle, vertexShader);
        GL.DetachShader(_handle, fragmentShader);
        GL.DeleteShader(vertexShader);
        GL.DeleteShader(fragmentShader);
    }
    
    public void SetMatrix4(string name, Matrix4 value)
    {
        var location = GL.GetUniformLocation(_handle, name);
        GL.UniformMatrix4(location, false, ref value);
    }

    public void Use() => GL.UseProgram(_handle);

    public void Dispose() => GL.DeleteProgram(_handle);

    private static int LoadShader(ShaderType type, string source)
    {
        var shader = GL.CreateShader(type);
        GL.ShaderSource(shader, source);
        GL.CompileShader(shader);

        GL.GetShader(shader, ShaderParameter.CompileStatus, out var code);
        if (code != (int)All.True)
        {
            throw new Exception($"Error occurred whilst compiling Shader({type}): {GL.GetShaderInfoLog(shader)}");
        }

        return shader;
    }
}