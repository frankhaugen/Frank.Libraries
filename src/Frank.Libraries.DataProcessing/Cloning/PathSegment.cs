namespace Frank.Libraries.DataProcessing.Cloning;

public record PathSegment(int Key, string Value) : IKeyValuePair<int, string>;