using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace Frank.Libraries.Csv
{
    public class CsvContext : ICsvContext
    {
        public bool HasHeader<T, TMap>(FileInfo file, string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = true) where TMap : ClassMap<T> where T : class, new()
        {
            try
            {
                using var reader = new StreamReader(file.OpenRead());
                using var csv = new CsvReader(reader, GetBaseConfiguration(delimiter, newLine, hasHeaderRecord));
                csv.Context.RegisterClassMap<TMap>();
                csv.Read();
                csv.ReadHeader();
                csv.ValidateHeader<T>();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<T> Read<T, TMap>(FileInfo file, string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = true) where TMap : ClassMap<T> where T : class, new()
        {
            using var reader = new StreamReader(file.OpenRead());
            using var csv = new CsvReader(reader, GetBaseConfiguration(delimiter, newLine, hasHeaderRecord));
            var options = new TypeConverterOptions { Formats = new[] { "yyyy-MM-ddTHH:mm:ss:fff" } };
            csv.Context.TypeConverterOptionsCache.AddOptions<DateTime>(options);
            csv.Context.TypeConverterOptionsCache.AddOptions<DateTime?>(options);
            csv.Context.RegisterClassMap<TMap>();
            return csv.GetRecords<T>()
                      .ToList();
        }

        public List<T> Read<T, TMap>(string text, string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = true) where TMap : ClassMap<T> where T : class, new()
        {
            using var reader = new StringReader(text);
            using var csv = new CsvReader(reader, GetBaseConfiguration(delimiter, newLine, hasHeaderRecord));
            var options = new TypeConverterOptions { Formats = new[] { "yyyy-MM-ddTHH:mm:ss:fff" } };
            csv.Context.TypeConverterOptionsCache.AddOptions<DateTime>(options);
            csv.Context.TypeConverterOptionsCache.AddOptions<DateTime?>(options);
            csv.Context.RegisterClassMap<TMap>();
            return csv.GetRecords<T>()
                      .ToList();
        }

        public void Write<T, TMap>(FileInfo file, List<T> records, string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = true) where TMap : ClassMap<T> where T : class, new()
        {
            using var fileStream = new MemoryStream();
            using var writer = new StreamWriter(fileStream);
            using var csv = new CsvWriter(writer, GetBaseConfiguration(delimiter, newLine, hasHeaderRecord));
            var options = new TypeConverterOptions { Formats = new[] { "yyyy-MM-ddTHH:mm:ss:fff" } };
            csv.Context.TypeConverterOptionsCache.AddOptions<DateTime>(options);
            csv.Context.TypeConverterOptionsCache.AddOptions<DateTime?>(options);
            csv.Context.RegisterClassMap<TMap>();
            csv.WriteHeader<T>();
            csv.WriteRecords(records);
            csv.Flush();
            File.WriteAllBytes(file.FullName, fileStream.ToArray());
        }

        public void Append<T, TMap>(FileInfo file, List<T> records, string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = true) where TMap : ClassMap<T> where T : class, new()
        {
            using var stream = File.Open(file.FullName, FileMode.Append);
            using var writer = new StreamWriter(stream);
            using var csv = new CsvWriter(writer, GetBaseConfiguration(delimiter, newLine, hasHeaderRecord));
            var options = new TypeConverterOptions { Formats = new[] { "yyyy-MM-ddTHH:mm:ss:fff" } };
            csv.Context.TypeConverterOptionsCache.AddOptions<DateTime>(options);
            csv.Context.TypeConverterOptionsCache.AddOptions<DateTime?>(options);
            csv.Context.RegisterClassMap<TMap>();
            csv.WriteRecords(records);
        }

        public byte[] GetTemplate<T, TMap>(string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = false) where TMap : ClassMap<T> where T : class, new()
        {
            using var fileStream = new MemoryStream();
            using var writer = new StreamWriter(fileStream);
            using var csv = new CsvWriter(writer, GetBaseConfiguration(delimiter, newLine, hasHeaderRecord));
            var options = new TypeConverterOptions { Formats = new[] { "yyyy-MM-ddTHH:mm:ss:fff" } };
            csv.Context.TypeConverterOptionsCache.AddOptions<DateTime>(options);
            csv.Context.TypeConverterOptionsCache.AddOptions<DateTime?>(options);
            csv.Context.RegisterClassMap<TMap>();
            csv.WriteHeader<T>();
            csv.NextRecord();
            csv.WriteRecords(new List<T>() { });
            csv.Flush();
            return fileStream.ToArray();
        }

        private static CsvConfiguration GetBaseConfiguration(string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = true) => new(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = hasHeaderRecord,
            Delimiter = delimiter,
            NewLine = newLine,
            IgnoreBlankLines = true,
            Encoding = Encoding.UTF8
        };
    }
}