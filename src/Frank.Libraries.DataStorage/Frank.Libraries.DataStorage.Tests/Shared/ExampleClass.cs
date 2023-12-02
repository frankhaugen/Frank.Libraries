namespace Frank.Libraries.DataStorage.Tests.Shared;

public class ExampleClass : IKeyed
{
    public Guid Id { get; set; }
    public string SomeData { get; set; }
    public int Int { get; set; }
    public long Long { get; set; }
    public float Float { get; set; }
    public double Double { get; set; }
    public decimal Decimal { get; set; }
    public DateTime DateTime { get; set; }
    public DateTimeOffset DateTimeOffset { get; set; }
    public TimeSpan TimeSpan { get; set; }
    public bool Boolean { get; set; }
}