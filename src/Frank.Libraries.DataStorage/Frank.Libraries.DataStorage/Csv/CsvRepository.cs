namespace Frank.Libraries.DataStorage.Csv;

public class CsvRepository<T> : IRepository<T> where T : class, IKeyed, new()
{
    private readonly CsvDocument<T> _csvDocument;

    public CsvRepository(CsvDocument<T> csvDocument) => _csvDocument = csvDocument;

    public IQueryable<T> GetAll() => _csvDocument.AsQueryable();

    public void Add(T entity) => _csvDocument.Add(entity);

    public void Update(T entity) => _csvDocument.Update(entity);

    public void Delete(Guid id) => _csvDocument.Delete(id);

    public T? GetById(Guid id) => _csvDocument.GetById(id);

    public void SaveChanges()
    {
    }
}