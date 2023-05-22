namespace Frank.Libraries.Xml;

public interface IXmlContext<TEntity> where TEntity : XmlEntity, new()
{
    IEnumerable<TEntity> GetCollection();
    void Add(TEntity entity);
    void Add(List<TEntity> entities);
    TEntity GetById(Guid id);
    void Update(Guid id, TEntity entity);
    void Delete(Guid id);
    bool SaveChanges();
    void DiscardChanges();
}