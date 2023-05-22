namespace Frank.Libraries.IRC;

internal static class CollectionUtilities
{
    public static IDictionary<TValue, TKey> Invert<TKey, TValue>(this IDictionary<TKey, TValue> dictionary) => dictionary.ToDictionary(pair => pair.Value, pair => pair.Key);
}