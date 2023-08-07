namespace Frank.Libraries.DataProcessing.Cloning;

public interface INameValuePair<out TKey, out TValue>
{
    TKey Name { get; }
    TValue Value { get; }
}