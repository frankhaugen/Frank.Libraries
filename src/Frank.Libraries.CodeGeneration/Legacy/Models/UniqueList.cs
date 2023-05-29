namespace Frank.Libraries.CodeGeneration.Models;

public class UniqueList<T> : List<T>
{
    public new void Add(T value)
    {
        if (Contains(value))
        {
            return;
        }

        base.Add(value);
    }

    public new void AddRange(IEnumerable<T> values)
    {
        foreach (var value in values)
        {
            Add(value);
        }
    }
}