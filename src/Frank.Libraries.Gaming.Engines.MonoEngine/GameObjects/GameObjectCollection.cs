using System.Collections;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;

public class GameObjectCollection : IEnumerable<GameObject>
{
    private readonly List<GameObject> _gameObjects = new();

    public IEnumerator<GameObject> GetEnumerator() => _gameObjects.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public GameObject this[int i] => _gameObjects[i];

    public int Length => _gameObjects.Count;

    public void Add(GameObject gameObject) => _gameObjects.Add(gameObject);

    public void Remove(GameObject gameObject) => _gameObjects.Remove(gameObject);

    public void RemoveAt(int index) => _gameObjects.RemoveAt(index);

    public void Clear() => _gameObjects.Clear();

    public void AddRange(IEnumerable<GameObject> gameObjects) => _gameObjects.AddRange(gameObjects);

    public void Insert(int index, GameObject gameObject) => _gameObjects.Insert(index, gameObject);
}