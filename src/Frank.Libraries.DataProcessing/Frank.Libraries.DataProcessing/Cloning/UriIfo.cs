namespace Frank.Libraries.DataProcessing.Cloning;

public class UriIfo : UriInfoBase
{
    public Headers Headers { get; } = new();
    public string? Content { get; set; }
    public string? Method { get; set; }
}