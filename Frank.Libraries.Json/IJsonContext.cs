using System;
using System.Collections.Generic;
using System.Linq;

namespace Frank.Libraries.Json
{
    public interface IJsonContext<TEntity> where TEntity : JsonEntity
    {
        IEnumerable<TEntity> GetCollection();
        IQueryable<TEntity> GetQueryable();
        TEntity GetById(Guid id);
        void Delete(Guid id);
        void Add(TEntity item);
        void Add(List<TEntity> items);
        bool SaveChanges();
        void DiscardChanges();
    }
}