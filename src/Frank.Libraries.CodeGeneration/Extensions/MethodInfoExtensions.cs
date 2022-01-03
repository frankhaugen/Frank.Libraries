using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Frank.Libraries.CodeGeneration.Extensions;

public static class MethodInfoExtensions
{
    public static bool IsAsync(this MethodInfo method)
    {
        Type attType = typeof(AsyncStateMachineAttribute);
        var attrib = method.GetCustomAttribute(attType);
        return (attrib != null);
    }
}