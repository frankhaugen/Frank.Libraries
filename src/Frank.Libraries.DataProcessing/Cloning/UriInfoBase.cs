namespace Frank.Libraries.DataProcessing.Cloning;

public class UriInfoBase
{
    public PathSegments PathSegments { get; } = new();
    public QueryParameters QueryParameters { get; } = new();
    public HostAddress HostAddress { get; set; }

    public override string ToString() => $"{HostAddress}{PathSegments}{QueryParameters}";
}