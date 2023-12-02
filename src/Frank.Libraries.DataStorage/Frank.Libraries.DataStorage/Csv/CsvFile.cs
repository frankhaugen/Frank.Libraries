namespace Frank.Libraries.DataStorage.Csv;

public class CsvFile
{
    private readonly FileInfo _file;
    private readonly ReaderWriterLockSlim _lock = new();

    public CsvFile(FileInfo file)
    {
        _file = file ?? throw new ArgumentNullException(nameof(file));
        if (!_file.Exists)
        {
            _file.Directory?.Create();
            _file.Create()
                 .Close();
        }
    }

    public int Count()
    {
        _lock.EnterReadLock();
        try
        {
            return ReadFromFile()
                .Count();
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }

    public bool DeleteLine(string line)
    {
        _lock.EnterWriteLock();
        try
        {
            var lines = ReadFromFile()
                .ToList();
            var index = lines.IndexOf(line);
            if (index == -1)
            {
                return false;
            }

            lines.RemoveAt(index);
            WriteToFile(lines);
            return true;
        }
        finally
        {
            _lock.ExitWriteLock();
        }
    }

    public IEnumerable<string> ReadAllLines()
    {
        _lock.EnterReadLock();
        try
        {
            return ReadFromFile();
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }

    public bool Contains(string line)
    {
        _lock.EnterReadLock();
        try
        {
            return ReadFromFile()
                .Contains(line);
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }

    public void DeleteAllLines()
    {
        _lock.EnterWriteLock();
        try
        {
            WriteToFile(new List<string>());
        }
        finally
        {
            _lock.ExitWriteLock();
        }
    }

    public void AppendLine(string line)
    {
        _lock.EnterWriteLock();
        try
        {
            AppendToFile(new List<string> { line });
        }
        finally
        {
            _lock.ExitWriteLock();
        }
    }

    public string? LineStartsWith(string startsWith)
    {
        _lock.EnterReadLock();
        try
        {
            return ReadFromFile()
                .FirstOrDefault(l => l.StartsWith(startsWith));
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }


    // Read all lines from file
    private IEnumerable<string> ReadFromFile()
    {
        using var streamReader = _file.OpenText();
        while (!streamReader.EndOfStream)
        {
            yield return streamReader.ReadLine();
        }
    }

    // Write all lines to a new file
    private void WriteToFile(IEnumerable<string> lines)
    {
        using var streamWriter = _file.CreateText();
        foreach (var line in lines)
        {
            streamWriter.WriteLine(line);
        }
    }

    // Append all lines to the end of the current file
    private void AppendToFile(IEnumerable<string> lines)
    {
        using var streamWriter = _file.AppendText();
        foreach (var line in lines)
        {
            streamWriter.WriteLine(line);
        }
    }
}