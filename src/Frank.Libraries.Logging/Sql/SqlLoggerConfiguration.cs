using Frank.Libraries.Logging.Shared;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.Sql
{
    public class SqlLoggerConfiguration : LoggerConfigurationBase
    {
        public string ConnectionString { get; set; } = "Server=.\\SQLEXPRESS;Database=LoggingDatabase;Trusted_Connection=True;";
    }
}