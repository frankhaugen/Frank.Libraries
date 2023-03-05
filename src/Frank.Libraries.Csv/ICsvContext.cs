using System.Collections.Generic;
using System.IO;
using CsvHelper.Configuration;

namespace Frank.Libraries.Csv;

public interface ICsvContext
{
    bool HasHeader<T, TMap>(FileInfo file, string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = true) where TMap : ClassMap<T> where T : class, new();
    List<T> Read<T, TMap>(FileInfo file, string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = true) where TMap : ClassMap<T> where T : class, new();
    List<T> Read<T, TMap>(string text, string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = true) where TMap : ClassMap<T> where T : class, new();
    void Write<T, TMap>(FileInfo file, List<T> records, string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = true) where TMap : ClassMap<T> where T : class, new();
    void Append<T, TMap>(FileInfo file, List<T> records, string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = true) where TMap : ClassMap<T> where T : class, new();
    byte[] GetTemplate<T, TMap>(string delimiter = ";", string newLine = "\n", bool hasHeaderRecord = false) where TMap : ClassMap<T> where T : class, new();
}