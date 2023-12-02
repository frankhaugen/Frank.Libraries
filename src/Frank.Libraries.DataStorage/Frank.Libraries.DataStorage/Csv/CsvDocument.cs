using System.Collections;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.DataStorage.Csv;

public class CsvDocument<T> : ICollection<T> where T : class, IKeyed, new()
{
    private const char Separator = ';';
    private const char NewLine = '\n';

    private readonly CsvFile _file;
    private readonly IOptions<CsvConnection> _options;

    public CsvDocument(IOptions<CsvConnection> options)
    {
        _options = options;
        _file = new CsvFile(new FileInfo(Path.Combine(_options.Value.CsvDataFolder, $"{typeof(T).Name}.csv")));
    }

    public IEnumerator<T> GetEnumerator() => _file.ReadAllLines()
                                                  .Select(ParseLine)
                                                  .GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(T item)
    {
        if (item.Id == Guid.Empty)
        {
            item.Id = Guid.NewGuid();
        }
        else if (Contains(item))
        {
            throw new Exception($"Item with id {item.Id} already exists");
        }

        var line = FormatLine(item);
        _file.AppendLine(line);
    }

    public void Clear() => _file.DeleteAllLines();

    public bool Contains(T item) => _file.Contains(FormatLine(item));

    public void CopyTo(T[] array, int arrayIndex) => _file.ReadAllLines()
                                                          .Select(ParseLine)
                                                          .ToArray()
                                                          .CopyTo(array, arrayIndex);

    public bool Remove(T item) => _file.DeleteLine(FormatLine(item));

    public int Count => _file.Count();
    public bool IsReadOnly => false;

    private T ParseLine(string line)
    {
        var item = Activator.CreateInstance<T>();
        var values = line.Split(Separator);
        var properties = typeof(T).GetProperties();

        for (var i = 0; i < values.Length; i++)
        {
            var value = values[i];

            if (properties[i].PropertyType == typeof(DateTime))
            {
                var dateTime = DateTime.Parse(value);
                properties[i]
                    .SetValue(item, dateTime);
                continue;
            }

            if (properties[i].PropertyType == typeof(DateTimeOffset))
            {
                var dateTimeOffset = DateTimeOffset.Parse(value);
                properties[i]
                    .SetValue(item, dateTimeOffset);
                continue;
            }

            if (properties[i].PropertyType == typeof(TimeSpan))
            {
                var timeSpan = TimeSpan.Parse(value);
                properties[i]
                    .SetValue(item, timeSpan);
                continue;
            }

            if (properties[i].PropertyType == typeof(bool))
            {
                var boolean = bool.Parse(value);
                properties[i]
                    .SetValue(item, boolean);
                continue;
            }

            if (properties[i].PropertyType == typeof(Guid))
            {
                var guid = Guid.Parse(value);
                properties[i]
                    .SetValue(item, guid);
                continue;
            }

            if (properties[i].PropertyType == typeof(int))
            {
                var integer = int.Parse(value);
                properties[i]
                    .SetValue(item, integer);
                continue;
            }

            if (properties[i].PropertyType == typeof(long))
            {
                var longValue = long.Parse(value);
                properties[i]
                    .SetValue(item, longValue);
                continue;
            }

            if (properties[i].PropertyType == typeof(float))
            {
                var floatValue = float.Parse(value);
                properties[i]
                    .SetValue(item, floatValue);
                continue;
            }

            if (properties[i].PropertyType == typeof(double))
            {
                var doubleValue = double.Parse(value);
                properties[i]
                    .SetValue(item, doubleValue);
                continue;
            }

            if (properties[i].PropertyType == typeof(decimal))
            {
                var decimalValue = decimal.Parse(value);
                properties[i]
                    .SetValue(item, decimalValue);
                continue;
            }

            if (properties[i].PropertyType == typeof(string))
            {
                properties[i]
                    .SetValue(item, value);
                continue;
            }

            if (properties[i].PropertyType == typeof(char))
            {
                var charValue = char.Parse(value);
                properties[i]
                    .SetValue(item, charValue);
                continue;
            }

            var convertedValue = Convert.ChangeType(values[i], properties[i].PropertyType);
            properties[i]
                .SetValue(item, convertedValue);
        }

        return item;
    }

    private string FormatLine(T item)
    {
        var properties = typeof(T).GetProperties();
        var values = properties.Select(p =>
        {
            var value = p.GetValue(item)
                         ?.ToString()
                        ?? "";
            return value.Replace(NewLine.ToString(), " ")
                        .Replace(Separator.ToString(), ",");
        });

        return string.Join(Separator.ToString(), values);
    }

    public T Update(T entity)
    {
        var existingEntity = _file.LineStartsWith(entity.Id.ToString());
        if (string.IsNullOrWhiteSpace(existingEntity))
        {
            return entity;
        }

        _file.DeleteLine(existingEntity);
        _file.AppendLine(FormatLine(entity));

        return entity;
    }

    public T GetById(Guid id)
    {
        var line = _file.LineStartsWith(id.ToString());
        if (string.IsNullOrWhiteSpace(line))
        {
            return null;
        }

        return ParseLine(line);
    }

    public void Delete(Guid id)
    {
        var line = _file.LineStartsWith(id.ToString());
        if (string.IsNullOrWhiteSpace(line))
        {
            return;
        }

        _file.DeleteLine(line);
    }
}