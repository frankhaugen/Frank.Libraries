namespace Frank.Extensions.MongoDb
{
    public class MongoDbConfigurationBase
    {
        public string DatabaseName { get; set; } = null!;
        public string ConnectionString { get; set; } = null!;
    }
}