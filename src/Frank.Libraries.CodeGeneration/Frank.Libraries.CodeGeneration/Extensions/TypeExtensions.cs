namespace Frank.Libraries.CodeGeneration.Extensions;

public static class TypeExtensions
{
    public static bool HasBaseType(this Type type) => type.BaseType != null;

    public static bool IsStatic(this Type type) => type is { IsAbstract: true, IsSealed: true };

    public static TypeVariant GetTypeVariant(this Type type)
    {
        var typeAttributes = type.Attributes;

        if (typeAttributes.HasFlag(TypeAttributes.Abstract & TypeAttributes.Sealed))
            return TypeVariant.Static;
        if (typeAttributes.HasFlag(TypeAttributes.ExplicitLayout))
            return TypeVariant.Static;
        if (typeAttributes.HasFlag(TypeAttributes.Class))
            return TypeVariant.Class;
        return TypeVariant.Virtual;
    }

    public static IEnumerable<string> GetReferencedNamespaces(this Type type)
    {
        var types = new List<Type>();

        types.AddRange(type.GetConstructors().SelectMany(x => x.GetParameters().Select(y => y.ParameterType)));
        types.AddRange(type.GetProperties().Select(x => x.PropertyType));
        types.AddRange(type.GetFields().Select(x => x.FieldType));
        types.AddRange(type.GetMethods().SelectMany(x => x.GetParameters().Select(y => y.ParameterType)));
        types.AddRange(type.GetMethods().Select(x => x.ReturnType));

        return types.Select(x => x.Namespace).Where(x => !string.IsNullOrWhiteSpace(x)).Distinct();
    }

    public static string GetFriendlyName(this Type type, bool fullyQualified = false)
    {
        var typeName = fullyQualified
            ? type.GetFullNameSansTypeParameters().Replace("+", ".")
            : type.Name;

        if (type.IsGenericType)
        {
            var genericArgumentIds = type.GetGenericArguments()
                                         .Select(t => GetFriendlyName(t, fullyQualified))
                                         .ToArray();

            return new StringBuilder(typeName)
                   .Replace(string.Format("`{0}", genericArgumentIds.Count()), string.Empty)
                   .Append(string.Format("<{0}>", string.Join(",", genericArgumentIds).TrimEnd(',')))
                   .ToString();
        }

        return typeName;
    }

    /// <summary>
    /// Returns a nice name for a class especially for generics by including angle-brackets
    /// </summary>
    /// <param name="type"></param>
    /// <param name="fullyQualified"></param>
    /// <returns></returns>
    public static string FriendlyName(this Type type, bool fullyQualified = false)
    {
        var typeName = fullyQualified
            ? type.GetFullNameSansTypeParameters().Replace("+", ".")
            : type.Name;

        if (type.IsGenericType)
        {
            var genericArgumentIds = type.GetGenericArguments()
                                         .Select(t => FriendlyName(t, fullyQualified))
                                         .ToArray();

            return new StringBuilder(typeName)
                   .Replace(string.Format("`{0}", genericArgumentIds.Count()), string.Empty)
                   .Append(string.Format("<{0}>", string.Join(",", genericArgumentIds).TrimEnd(',')))
                   .ToString();
        }

        return typeName;
    }

    public static string GetFullNameSansTypeParameters(this Type type)
    {
        var fullName = type.FullName;
        if (string.IsNullOrEmpty(fullName))
            fullName = type.Name;
        var chopIndex = fullName.IndexOf("[[");
        return (chopIndex == -1) ? fullName : fullName.Substring(0, chopIndex);
    }
}