using System.Collections;

namespace Frank.Libraries.Gaming.Engines.SilkySmooth;

public abstract class KeyValuePairCollection<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>
{
    private readonly ICollection<KeyValuePair<TKey, TValue>> _collection;

    protected KeyValuePairCollection(ICollection<KeyValuePair<TKey, TValue>> collection) => _collection = collection;

    protected KeyValuePairCollection() => _collection = new List<KeyValuePair<TKey, TValue>>();

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => _collection.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(KeyValuePair<TKey, TValue> item) => _collection.Add(item);

    public void Clear() => _collection.Clear();

    public bool Contains(KeyValuePair<TKey, TValue> item) => _collection.Contains(item);

    public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) => _collection.CopyTo(array, arrayIndex);

    public bool Remove(KeyValuePair<TKey, TValue> item) => _collection.Remove(item);

    public int Count => _collection.Count;

    public bool IsReadOnly => _collection.IsReadOnly;
}