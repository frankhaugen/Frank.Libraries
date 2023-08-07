namespace Frank.Libraries.CodeGeneration.Extensions;

public static class ParameterInfoExtensions
{
    public static void RemoveAt(this ParameterInfo[] source, int index)
    {
        var list = source.ToList();
        list.RemoveAt(index);
        source = list.ToArray();
    }
}