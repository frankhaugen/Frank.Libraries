namespace Frank.Libraries.MongoDb;

[AttributeUsage(AttributeTargets.Class)]
public sealed class CollectionName : Attribute
{
    public CollectionName(string name = null!) => Name = name;

    public string? Name { get; set; }
}