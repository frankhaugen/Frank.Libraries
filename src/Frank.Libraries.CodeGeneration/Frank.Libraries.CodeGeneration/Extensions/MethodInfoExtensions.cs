namespace Frank.Libraries.CodeGeneration.Extensions;

public static class MethodInfoExtensions
{
    public static bool IsAsync(this MethodInfo methodInfo) => methodInfo.ReturnType == typeof(Task) || methodInfo.ReturnType.IsGenericType && methodInfo.ReturnType.GetGenericTypeDefinition() == typeof(Task<>);

    public static bool IsPropertyMethod(this MethodInfo methodInfo) => methodInfo.IsSpecialName && (methodInfo.Name.StartsWith("get_") || methodInfo.Name.StartsWith("set_"));

    public static bool IsBaseMethod(this MethodInfo methodInfo)
    {
        if (methodInfo.IsPrivate)
        {
            return true;
        }

        var type = methodInfo.DeclaringType;

        if (type?.BaseType != null && type.BaseType.GetMethods().Select(x => x.Name).Contains(methodInfo.Name))
        {
            return true;
        }

        // Check if the method is declared in the base class
        if (methodInfo.DeclaringType != null && methodInfo.DeclaringType != methodInfo.ReflectedType)
        {
            // Check if the method is not overridden in the derived class
            var baseMethodInfo = methodInfo.DeclaringType.GetMethod(methodInfo.Name, methodInfo.GetParameters().Select(p => p.ParameterType).ToArray());
            if (baseMethodInfo != null && baseMethodInfo.Equals(methodInfo))
            {
                return true;
            }
        }
        return false;
    }


    public static MethodVariant GetMethodVariant(this MethodInfo methodInfo)
    {
        if (methodInfo.IsDefined(typeof(ExtensionAttribute), false))
            return MethodVariant.Extension;
        if (methodInfo.IsStatic)
            return MethodVariant.Static;
        return MethodVariant.Instance;
    }

    public static TypeSyntax GetReturnStatement(this MethodInfo method)
    {
        var isAsync = method.IsAsync();
        var returnType = typeof(object);

        if (isAsync)
        {
            returnType = typeof(Task);
        }
        else
        {
            returnType = typeof(void);
        }

        return SyntaxFactory.ParseTypeName(returnType.Name);
    }
}