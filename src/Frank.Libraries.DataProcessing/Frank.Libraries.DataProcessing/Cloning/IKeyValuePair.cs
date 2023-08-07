namespace Frank.Libraries.DataProcessing.Cloning;

public interface IKeyValuePair<out TKey, out TValue>
{
    TKey Key { get; }
    TValue Value { get; }
}