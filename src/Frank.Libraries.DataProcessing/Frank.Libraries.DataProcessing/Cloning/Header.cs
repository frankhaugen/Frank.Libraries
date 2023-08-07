namespace Frank.Libraries.DataProcessing.Cloning;

public record Header(string Key, string Value) : IKeyValuePair<string, string>;