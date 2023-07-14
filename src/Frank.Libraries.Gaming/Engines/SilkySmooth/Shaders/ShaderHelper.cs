using Silk.NET.OpenGL;

namespace Frank.Libraries.Gaming.Engines.SilkySmooth.Shaders;

public static class ShaderHelper
{
    public static uint LoadShader(GL gl, IShaderSource vertexShaderSource, IShaderSource fragmentShaderSource)
    {
        var vertexShader = gl.CreateShader(ShaderType.VertexShader);
        gl.ShaderSource(vertexShader, vertexShaderSource.SourceCode);
        gl.CompileShader(vertexShader);

        var fragmentShader = gl.CreateShader(ShaderType.FragmentShader);
        gl.ShaderSource(fragmentShader, fragmentShaderSource.SourceCode);
        gl.CompileShader(fragmentShader);

        var shaderProgram = gl.CreateProgram();
        gl.AttachShader(shaderProgram, vertexShader);
        gl.AttachShader(shaderProgram, fragmentShader);
        gl.LinkProgram(shaderProgram);

        gl.DeleteShader(vertexShader);
        gl.DeleteShader(fragmentShader);

        return shaderProgram;
    }

    public static void DeleteShader(GL gl, uint shaderProgram)
    {
        gl.DeleteProgram(shaderProgram);
    }
}