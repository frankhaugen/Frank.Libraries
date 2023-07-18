namespace Frank.Libraries.Gaming.Rendering.OpenTk.Assets;

public static class ShaderTypeExtensionExtensions
{
    public static string GetExtension(this ShaderTypeExtension shaderTypeExtension) => shaderTypeExtension.ToString().ToLower();
}