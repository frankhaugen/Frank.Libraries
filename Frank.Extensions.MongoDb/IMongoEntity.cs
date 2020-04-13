using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Frank.Extensions.MongoDb
{
    public interface IMongoEntity
    {
        [BsonId]
        public ObjectId _Id { get; set; }
    }
}
