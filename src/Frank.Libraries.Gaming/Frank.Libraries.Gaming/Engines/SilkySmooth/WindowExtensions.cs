using Silk.NET.Input;
using Silk.NET.Windowing;

namespace Frank.Libraries.Gaming.Engines.SilkySmooth;

public static class WindowExtensions
{
    public static InputHandler CreateInputHandler(this IWindow window)
    {
        var input = window.CreateInput();
        var inputHandler = new InputHandler(input);
        return inputHandler;
    }
}