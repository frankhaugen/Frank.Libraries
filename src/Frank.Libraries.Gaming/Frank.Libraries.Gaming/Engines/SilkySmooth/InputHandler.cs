using Silk.NET.Input;

namespace Frank.Libraries.Gaming.Engines.SilkySmooth;

public class InputHandler
{
    private readonly KeyboardEventHandlers _keyDownActions = new();
    private readonly KeyboardEventHandlers _keyUpActions = new();

    public InputHandler(IInputContext input)
    {
        foreach (var keyboard in input.Keyboards)
        {
            keyboard.KeyDown += KeyDown;
            keyboard.KeyUp += KeyUp;
        }
    }

    private void KeyDown(IKeyboard keyboard, Key key, int arg3)
    {
        var actions = _keyDownActions.GetActions(key);
        foreach (var action in actions)
        {
            action.Invoke();
        }
    }

    private void KeyUp(IKeyboard keyboard, Key key, int arg3)
    {
        var actions = _keyUpActions.GetActions(key);
        foreach (var action in actions)
        {
            action.Invoke();
        }
    }

    public void AddKeyDownAction(Key key, Action action) => _keyDownActions.AddAction(key, action);

    public void AddKeyUpAction(Key key, Action action) => _keyUpActions.AddAction(key, action);
}