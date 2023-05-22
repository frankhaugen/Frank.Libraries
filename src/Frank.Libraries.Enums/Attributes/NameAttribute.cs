namespace Frank.Libraries.Enums.Attributes;

/// <summary>
///     Attribute to store an alternative name
/// </summary>
public class NameAttribute : Attribute
{
    private readonly string _name;

    /// <inheritdoc />
    public NameAttribute(string name) => _name = name;

    /// <summary>
    /// </summary>
    /// <returns>
    ///     <see cref="string" />
    /// </returns>
    public string GetName() => _name;
}