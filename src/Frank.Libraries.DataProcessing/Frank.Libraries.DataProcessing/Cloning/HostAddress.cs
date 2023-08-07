namespace Frank.Libraries.DataProcessing.Cloning;

public record HostAddress(HttpScheme Scheme = HttpScheme.Http, string HostName = "localhost", int Port = 80);