using Silk.NET.Input;

namespace Frank.Libraries.Gaming.Engines.SilkySmooth;

public class KeyboardEventHandlers : KeyValuePairCollection<Key, Action>
{
    public void AddAction(Key key, Action action) => Add(new KeyValuePair<Key, Action>(key, action));

    public IEnumerable<Action> GetActions(Key key) => this.Where(x => x.Key == key).Select(x => x.Value);
}