namespace Frank.Libraries.MongoDb
{
    public abstract class MongoConfiguration
    {
        public string? DatabaseName { get; set; }
        public string? ConnectionString { get; set; }
    }
}
