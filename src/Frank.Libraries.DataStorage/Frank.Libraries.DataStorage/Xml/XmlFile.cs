using System.Data;

namespace Frank.Libraries.DataStorage.Xml;

public class XmlFile
{
    private readonly FileInfo _file;
    private readonly ReaderWriterLockSlim _lock = new(LockRecursionPolicy.SupportsRecursion);

    public XmlFile(FileInfo file)
    {
        _file = file;

    }

    private void CreateFile()
    {
        _lock.EnterWriteLock();
        try
        {
            WriteXml(new DataSet());
        }
        finally
        {
            _lock.ExitWriteLock();
        }
    }

    private void CreateDirectory()
    {
        _lock.EnterWriteLock();
        try
        {
            _file.Directory!.Create();
        }
        finally
        {
            _lock.ExitWriteLock();
        }
    }

    public void WriteXml(DataSet dataSet)
    {
        _lock.EnterWriteLock();
        try
        {
            dataSet.WriteXml(_file.FullName, XmlWriteMode.IgnoreSchema);
        }
        finally
        {
            _lock.ExitWriteLock();
        }
    }

    public DataSet ReadXml()
    {
        _lock.EnterReadLock();
        try
        {
            var dataSet = new DataSet();
            _file.Directory!.Create();
            if (!_file.Exists)
                dataSet.WriteXml(_file.FullName, XmlWriteMode.IgnoreSchema);

            dataSet.ReadXml(_file.FullName, XmlReadMode.IgnoreSchema);
            return dataSet;
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }
}