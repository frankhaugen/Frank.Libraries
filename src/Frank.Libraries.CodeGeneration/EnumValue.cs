namespace Frank.Libraries.CodeGeneration.Generators;

public class EnumValue
{
    public EnumValue(string name, int? value = null)
    {
        Name = EnumNameGuards.EnumNameGuard(name);
        Value = value;
    }

    public string Name { get; }
    public int? Value { get; }
}