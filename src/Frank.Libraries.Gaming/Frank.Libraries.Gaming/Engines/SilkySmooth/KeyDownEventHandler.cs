using Silk.NET.Input;

namespace Frank.Libraries.Gaming.Engines.SilkySmooth;

public class KeyDownEventHandler
{
    public KeyDownEventHandler(Key key, Action action)
    {
        Key = key;
        Action = action;
    }

    private KeyDownEventHandler()
    {
    }

    public Key Key { get; }

    public Action Action { get; }

    public void Handle()
    {
        Action.Invoke();
    }
}