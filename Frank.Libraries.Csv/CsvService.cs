using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Frank.Libraries.Csv
{
    public class CsvService<TEntity, TMap> where TEntity : class, new() where TMap : ClassMap<TEntity>
    {
        private readonly CsvConfiguration _options;

        public string TemplateName() => $"{typeof(TEntity).Name} Template.csv";

        public CsvService(CsvConfiguration options)
        {
            _options = options;
        }

        public IEnumerable<TEntity> GetEnumerable(string csvString)
        {
            var output = new List<TEntity>();

            using var reader = new StringReader(csvString);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Configuration.RegisterClassMap<TMap>();
            csv.Configuration.Delimiter = _options.Delimiter;
            csv.Configuration.HasHeaderRecord = _options.HasHeaders;

            var records = csv.GetRecords<TEntity>();
            output.AddRange(records);

            return output;
        }

        public byte[] GetTemplate(string delimiter = ";")
        {
            var fileStream = new MemoryStream();
            using (var writer = new StreamWriter(fileStream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = delimiter;
                csv.WriteRecords(new List<TEntity>());
            }

            return fileStream.ToArray();
        }
    }
}
