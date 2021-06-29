using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace Frank.Libraries.Csv
{
    public class CsvService<TEntity, TMap> where TEntity : class, new() where TMap : ClassMap<TEntity>
    {
        public CsvOptions Options { get; }

        public string TemplateName() => $"{typeof(TEntity).Name} Template.csv";

        public CsvService(CsvOptions? options = null)
        {
            Options = options ?? new CsvOptions();
        }

        public IEnumerable<TEntity> GetEnumerable(string csvString)
        {
            var output = new List<TEntity>();

            using var reader = new StringReader(csvString);
            using var csv = new CsvReader(reader, GetCsvConfiguration());

            var records = csv.GetRecords<TEntity>();
            output.AddRange(records);

            return output;
        }

        public byte[] GetTemplate(string delimiter = ";")
        {
            var fileStream = new MemoryStream();
            using (var writer = new StreamWriter(fileStream))
            using (var csv = new CsvWriter(writer, GetCsvConfiguration()))
            {
                csv.WriteRecords(new List<TEntity>());
            }

            return fileStream.ToArray();
        }

        public CsvConfiguration GetCsvConfiguration() => new(CultureInfo.InvariantCulture)
        { Delimiter = Options.Delimiter, HasHeaderRecord = Options.HasHeaders };
    }
}