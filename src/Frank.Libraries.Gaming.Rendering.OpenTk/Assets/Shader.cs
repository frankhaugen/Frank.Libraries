using OpenTK.Graphics.OpenGL;

namespace Frank.Libraries.Gaming.Rendering.OpenTk.Assets;

public readonly record struct ShaderInfo(string Path, ShaderType ShaderType, string Source);