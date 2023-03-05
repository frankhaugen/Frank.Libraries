using System;
using System.Collections.Generic;

namespace Frank.Libraries.Rest;

public class InvariantStringComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y) => string.Equals(x, y, StringComparison.InvariantCultureIgnoreCase);

    public int GetHashCode(string obj) => obj.GetHashCode();
}