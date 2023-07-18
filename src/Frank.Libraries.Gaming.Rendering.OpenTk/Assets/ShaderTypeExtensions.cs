using OpenTK.Graphics.OpenGL;

namespace Frank.Libraries.Gaming.Rendering.OpenTk.Assets;

public static class ShaderTypeExtensions
{
    public static ShaderTypeExtension ToShaderTypeExtension(this ShaderType shaderType) =>
        shaderType switch
        {
            ShaderType.VertexShader         => ShaderTypeExtension.Vert,
            ShaderType.FragmentShader       => ShaderTypeExtension.Frag,
            ShaderType.GeometryShader       => throw new ArgumentOutOfRangeException(nameof(shaderType), shaderType, null),
            ShaderType.TessEvaluationShader => throw new ArgumentOutOfRangeException(nameof(shaderType), shaderType, null),
            ShaderType.TessControlShader    => throw new ArgumentOutOfRangeException(nameof(shaderType), shaderType, null),
            ShaderType.ComputeShader        => throw new ArgumentOutOfRangeException(nameof(shaderType), shaderType, null),
            _                               => throw new ArgumentOutOfRangeException(nameof(shaderType), shaderType, null)
        };

    public static string GetExtension(this ShaderType shaderType) => shaderType.ToShaderTypeExtension().GetExtension();
}