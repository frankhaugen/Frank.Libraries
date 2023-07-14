using Microsoft.Xna.Framework.Input;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine;

public class KeyboardHandler
{
    private readonly Dictionary<Keys, Action> _keyActions = new Dictionary<Keys, Action>();

    public void RegisterKeyAction(Keys key, Action action)
    {
        _keyActions[key] = action;
    }

    public void HandleKeyInput()
    {
        var keyboardState = Keyboard.GetState();

        foreach (var keyActionPair in _keyActions)
        {
            if (keyboardState.IsKeyDown(keyActionPair.Key))
            {
                keyActionPair.Value.Invoke();
            }
        }
    }
}