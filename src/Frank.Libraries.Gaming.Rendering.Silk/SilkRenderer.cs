using Frank.Libraries.Gaming.Primitives;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL;

namespace Frank.Libraries.Gaming.Rendering.Silk;

public class SilkRenderer : IRenderer
{
    private readonly GL _gl;

    public SilkRenderer()
    {
        _gl = GL.GetApi(new DefaultNativeContext("OpenGL"));
    }

    public void Render(Scene scene)
    {
        
    }

    public void Render(Scene scene, Action<string> callback) => throw new NotImplementedException();
}