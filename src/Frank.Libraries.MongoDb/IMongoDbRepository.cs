using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Frank.Libraries.MongoDb;

public interface IMongoDbRepository<TEntity> where TEntity : IMongoEntity, new()
{
    IQueryable<TEntity> AsQueryable();

    IEnumerable<TEntity> FilterBy(Expression<Func<TEntity, bool>> filterExpression);

    IEnumerable<TProjected> FilterBy<TProjected>(Expression<Func<TEntity, bool>> filterExpression, Expression<Func<TEntity, TProjected>> projectionExpression);

    TEntity FindOne(Expression<Func<TEntity, bool>> filterExpression);

    Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> filterExpression);

    TEntity FindById(ObjectId objectId);

    Task<TEntity> FindByIdAsync(ObjectId objectId);

    void InsertOne(TEntity document);

    Task InsertOneAsync(TEntity document);

    void InsertMany(ICollection<TEntity> documents);

    Task InsertManyAsync(ICollection<TEntity> documents);

    void ReplaceOne(TEntity document);

    Task ReplaceOneAsync(TEntity document);

    void DeleteOne(Expression<Func<TEntity, bool>> filterExpression);

    Task DeleteOneAsync(Expression<Func<TEntity, bool>> filterExpression);

    void DeleteById(ObjectId objectId);

    Task DeleteByIdAsync(ObjectId objectId);

    void DeleteMany(Expression<Func<TEntity, bool>> filterExpression);

    Task DeleteManyAsync(Expression<Func<TEntity, bool>> filterExpression);
}