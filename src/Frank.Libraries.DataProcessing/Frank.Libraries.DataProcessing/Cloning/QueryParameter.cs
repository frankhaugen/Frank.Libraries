namespace Frank.Libraries.DataProcessing.Cloning;

public record QueryParameter(string Name, string? Value) : INameValuePair<string, string?>;